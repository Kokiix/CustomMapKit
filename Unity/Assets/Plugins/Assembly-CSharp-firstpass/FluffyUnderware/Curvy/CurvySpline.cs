using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FluffyUnderware.DevTools;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

namespace FluffyUnderware.Curvy
{
	[HelpURL("https://curvyeditor.com/doclink/curvyspline")]
	[AddComponentMenu("Curvy/Curvy Spline", 1)]
	[ExecuteInEditMode]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		public const string VERSION = "7.1.8";

		public const string APIVERSION = "710";

		public const string WEBROOT = "https://curvyeditor.com/";

		public const string DOCLINK = "https://curvyeditor.com/doclink/";

		[SerializeField]
		[HideInInspector]
		private List<CurvySplineSegment> ControlPoints;

		[HideInInspector]
		public bool ShowGizmos;

		[Section("General", true, false, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_general")]
		[Tooltip("Interpolation Method")]
		[SerializeField]
		[FormerlySerializedAs("Interpolation")]
		private CurvyInterpolation m_Interpolation;

		[Tooltip("Restrict Control Points to local X/Y axis")]
		[FieldAction("CBCheck2DPlanar", ActionAttribute.ActionEnum.Callback)]
		[SerializeField]
		private bool m_RestrictTo2D;

		[SerializeField]
		[FormerlySerializedAs("Closed")]
		private bool m_Closed;

		[FieldCondition("canHaveManualEndCP", Action = ActionAttribute.ActionEnum.Enable)]
		[Tooltip("Handle End Control Points automatically?")]
		[SerializeField]
		[FormerlySerializedAs("AutoEndTangents")]
		private bool m_AutoEndTangents;

		[Tooltip("Orientation Flow")]
		[SerializeField]
		[FormerlySerializedAs("Orientation")]
		private CurvyOrientation m_Orientation;

		[Section("Global Bezier Options", true, false, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_bezier")]
		[GroupCondition("m_Interpolation", CurvyInterpolation.Bezier, false)]
		[RangeEx(0f, 1f, "Default Distance %", "Handle length by distance to neighbours")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Section("Global TCB Options", true, false, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_tcb")]
		[GroupCondition("m_Interpolation", CurvyInterpolation.TCB, false)]
		[GroupAction("TCBOptionsGUI", ActionAttribute.ActionEnum.Callback, Position = ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[FormerlySerializedAs("Tension")]
		private float m_Tension;

		[SerializeField]
		[FormerlySerializedAs("Continuity")]
		private float m_Continuity;

		[SerializeField]
		[FormerlySerializedAs("Bias")]
		private float m_Bias;

		[Section("Advanced Settings", true, false, 100, HelpURL = "https://curvyeditor.com/doclink/curvyspline_advanced")]
		[FieldAction("ShowGizmoGUI", ActionAttribute.ActionEnum.Callback, Position = ActionAttribute.ActionPositionEnum.Above)]
		[Label("Color", "Gizmo color")]
		[SerializeField]
		private Color m_GizmoColor;

		[Label("Active Color", "Selected Gizmo color")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[RangeEx(1f, 100f, "", "")]
		[SerializeField]
		[FormerlySerializedAs("Granularity")]
		[Tooltip("Defines how densely the cached points are. When the value is 100, the number of cached points per world distance unit is equal to the spline's MaxPointsPerUnit")]
		private int m_CacheDensity;

		[SerializeField]
		[Tooltip("The maximum number of sampling points per world distance unit. Sampling is used in caching or shape extrusion for example")]
		private float m_MaxPointsPerUnit;

		[SerializeField]
		[Tooltip("Use a GameObject pool at runtime")]
		private bool m_UsePooling;

		[SerializeField]
		[Tooltip("Use threading where applicable. Threading is is currently not supported when targetting WebGL and Universal Windows Platform")]
		private bool m_UseThreading;

		[Tooltip("Refresh when Control Point position change?")]
		[SerializeField]
		[FormerlySerializedAs("AutoRefresh")]
		private bool m_CheckTransform;

		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Group("Events", Expanded = false, Sort = 1000, HelpURL = "https://curvyeditor.com/doclink/curvyspline_events")]
		[SortOrder(0)]
		[SerializeField]
		protected CurvySplineEvent m_OnRefresh;

		[Group("Events", Sort = 1000)]
		[SortOrder(1)]
		[SerializeField]
		protected CurvySplineEvent m_OnAfterControlPointChanges;

		[Group("Events", Sort = 1000)]
		[SortOrder(2)]
		[SerializeField]
		protected CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Group("Events", Sort = 1000)]
		[SortOrder(3)]
		[SerializeField]
		protected CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Group("Events", Sort = 1000)]
		[SortOrder(4)]
		[SerializeField]
		protected CurvyControlPointEvent m_OnBeforeControlPointDelete;

		private bool mIsInitialized;

		private bool isStarted;

		private bool sendOnRefreshEventNextUpdate;

		private readonly object controlPointsRelationshipCacheLock;

		private List<CurvySplineSegment> mSegments;

		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		private float length;

		private int mCacheSize;

		private Bounds? mBounds;

		private bool mDirtyCurve;

		private bool mDirtyOrientation;

		private HashSet<CurvySplineSegment> dirtyControlPointsMinimalSet;

		private List<CurvySplineSegment> dirtyCpsExtendedList;

		private bool allControlPointsAreDirty;

		private ThreadPoolWorker<CurvySplineSegment> mThreadWorker;

		private readonly CurvySplineEventArgs defaultSplineEventArgs;

		private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs;

		private readonly CurvyControlPointEventArgs defaultDeleteEventArgs;

		private float[] controlPointsDistances;

		private readonly Action<CurvySplineSegment> refreshCurveAction;

		private Vector3 lastProcessedPosition;

		private Quaternion lastProcessedRotation;

		private Vector3 lastProcessedScale;

		private bool globalCoordinatesChangedThisFrame;

		private bool isCpsRelationshipCacheValid;

		private CurvySplineSegment firstSegment;

		private CurvySplineSegment lastSegment;

		private CurvySplineSegment firstVisibleControlPoint;

		private CurvySplineSegment lastVisibleControlPoint;

		private const float MinimalMaxPointsPerUnit = 0.0001f;

		private static readonly string InvalidCPErrorMessage;

		private Transform cachedTransform;

		public CurvyInterpolation Interpolation
		{
			get
			{
				return default(CurvyInterpolation);
			}
			set
			{
			}
		}

		public bool RestrictTo2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float AutoHandleDistance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool Closed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutoEndTangents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CurvyOrientation Orientation
		{
			get
			{
				return default(CurvyOrientation);
			}
			set
			{
			}
		}

		public CurvyUpdateMethod UpdateIn
		{
			get
			{
				return default(CurvyUpdateMethod);
			}
			set
			{
			}
		}

		public Color GizmoColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color GizmoSelectionColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public int CacheDensity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float MaxPointsPerUnit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool UsePooling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseThreading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CheckTransform
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Tension
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Continuity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Bias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsInitialized => false;

		public Bounds Bounds => default(Bounds);

		public int Count => 0;

		public int ControlPointCount => 0;

		public int CacheSize => 0;

		public float Length => 0f;

		public bool Dirty => false;

		public CurvySplineSegment this[int idx] => null;

		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList => null;

		[CanBeNull]
		public CurvySplineSegment FirstVisibleControlPoint => null;

		[CanBeNull]
		public CurvySplineSegment LastVisibleControlPoint => null;

		public CurvySplineSegment FirstSegment => null;

		public CurvySplineSegment LastSegment => null;

		public bool GlobalCoordinatesChangedThisFrame => false;

		public Action<CurvySpline> OnGlobalCoordinatesChanged { get; set; }

		public CurvySplineEvent OnRefresh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvySplineEvent OnAfterControlPointChanges
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private List<CurvySplineSegment> Segments => null;

		public static CurvySpline Create()
		{
			return null;
		}

		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return 0;
		}

		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return 0f;
		}

		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[NotNull]
		public static CurvySplineSegment GetFollowUpHeadingControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headingDirection)
		{
			return null;
		}

		public Vector3 Interpolate(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangent(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangent(float tf, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangentFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangentByDistance(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangentByDistanceFast(float distance, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public void InterpolateAndGetTangent(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
			position = default(Vector3);
			tangent = default(Vector3);
		}

		public void InterpolateAndGetTangentFast(float tf, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
			position = default(Vector3);
			tangent = default(Vector3);
		}

		public Vector3 GetOrientationUpFast(float tf, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Quaternion GetOrientationFast(float tf, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Obsolete("Member not used by Curvy, will get remove. Copy it if you still need it")]
		public Vector3 InterpolateScale(float tf)
		{
			return default(Vector3);
		}

		public T GetMetadata<T>(float tf) where T : CurvyMetadataBase
		{
			return null;
		}

		public U GetInterpolatedMetadata<T, U>(float tf) where T : CurvyInterpolatableMetadataBase<U>
		{
			return default(U);
		}

		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return 0f;
		}

		public CurvySplineSegment TFToSegment(float tf, out float localF, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping)
		{
			localF = default(float);
			isOnSegmentStart = default(bool);
			isOnSegmentEnd = default(bool);
			return null;
		}

		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			localF = default(float);
			return null;
		}

		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			localF = default(float);
			return null;
		}

		public float SegmentToTF(CurvySplineSegment segment)
		{
			return 0f;
		}

		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return 0f;
		}

		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return 0f;
		}

		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			localDistance = default(float);
			return null;
		}

		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, out bool isOnSegmentStart, out bool isOnSegmentEnd, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			localDistance = default(float);
			isOnSegmentStart = default(bool);
			isOnSegmentEnd = default(bool);
			return null;
		}

		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return 0f;
		}

		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return 0f;
		}

		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return 0f;
		}

		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return 0f;
		}

		public CurvySplineSegment Add()
		{
			return null;
		}

		public CurvySplineSegment Add(Vector3 controlPointPosition, Space space)
		{
			return null;
		}

		public CurvySplineSegment[] Add(params Vector3[] controlPointsLocalPositions)
		{
			return null;
		}

		public CurvySplineSegment[] Add(Vector3[] controlPointsPositions, Space space)
		{
			return null;
		}

		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		public CurvySplineSegment InsertBefore([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		public CurvySplineSegment InsertAfter([CanBeNull] CurvySplineSegment controlPoint, Vector3 position, bool skipRefreshingAndEvents = false, Space space = Space.World)
		{
			return null;
		}

		public void Clear()
		{
		}

		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents, bool isUndoableDeletion)
		{
		}

		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		public Vector3[] GetApproximation(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		[Obsolete("Use GetApproximation instead")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true, Space space = Space.Self)
		{
			return null;
		}

		public Vector3[] GetApproximationT(Space space = Space.Self)
		{
			return null;
		}

		public Vector3[] GetApproximationUpVectors(Space space = Space.Self)
		{
			return null;
		}

		public float GetNearestPointTF(Vector3 localPosition)
		{
			return 0f;
		}

		public float GetNearestPointTF(Vector3 position, Space space)
		{
			return 0f;
		}

		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint)
		{
			nearestPoint = default(Vector3);
			return 0f;
		}

		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, Space space)
		{
			nearestPoint = default(Vector3);
			return 0f;
		}

		public float GetNearestPointTF(Vector3 position, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			return 0f;
		}

		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			nearestPoint = default(Vector3);
			return 0f;
		}

		public float GetNearestPointTF(Vector3 position, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestPointLocalF, int searchStartSegmentIndex = 0, int searchEndSegmentIndex = -1, Space space = Space.Self)
		{
			nearestPoint = default(Vector3);
			nearestSegment = null;
			nearestPointLocalF = default(float);
			return 0f;
		}

		public void Refresh()
		{
		}

		public void SetDirtyAll()
		{
		}

		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		public Vector3 ToWorldDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		public Vector3 ToLocalPosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		public Vector3 ToLocalDirection(Vector3 localDirection)
		{
			return default(Vector3);
		}

		public void SyncSplineFromHierarchy()
		{
		}

		public bool IsPlanar(out int ignoreAxis)
		{
			ignoreAxis = default(int);
			return false;
		}

		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			xplanar = default(bool);
			yplanar = default(bool);
			zplanar = default(bool);
			return false;
		}

		public bool IsPlanar(CurvyPlane plane)
		{
			return false;
		}

		public void MakePlanar(CurvyPlane plane)
		{
		}

		public void MakePlanar(int axis)
		{
		}

		public void Subdivide(CurvySplineSegment fromCP = null, CurvySplineSegment toCP = null)
		{
		}

		public void Simplify(CurvySplineSegment fromCP = null, CurvySplineSegment toCP = null)
		{
		}

		public void Equalize(CurvySplineSegment fromCP = null, CurvySplineSegment toCP = null)
		{
		}

		public void Normalize()
		{
		}

		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		public void Flip()
		{
		}

		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return false;
		}

		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return false;
		}

		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return 0;
		}

		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return 0;
		}

		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return 0;
		}

		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return 0;
		}

		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return false;
		}

		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return false;
		}

		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return 0;
		}

		public void SetFromString(string fieldAndValue)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Reset()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Initialize()
		{
		}

		private void doUpdate()
		{
		}

		private bool canHaveManualEndCP()
		{
			return false;
		}

		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		private void ReverseControlPoints()
		{
		}

		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return 0;
		}

		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return 0;
		}

		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return false;
		}

		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		private void ClearControlPoints()
		{
		}

		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		private void ProcessDirtyControlPoints()
		{
		}

		private void PrepareThreadCompatibleData()
		{
		}

		private void FillDirtyCpsExtendedList()
		{
		}

		internal void NotifyMetaDataModification()
		{
		}

		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 position, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents, Space space)
		{
			return null;
		}

		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e)
		{
			return null;
		}
	}
}
