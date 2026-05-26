using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

namespace FluffyUnderware.Curvy
{
	[ExecuteInEditMode]
	[HelpURL("https://curvyeditor.com/doclink/curvysplinesegment")]
	public class CurvySplineSegment : MonoBehaviour, IPoolable
	{
		internal readonly struct ControlPointExtrinsicProperties : IEquatable<ControlPointExtrinsicProperties>
		{
			private readonly bool isVisible;

			private readonly short segmentIndex;

			private readonly short controlPointIndex;

			private readonly short nextControlPointIndex;

			private readonly short previousControlPointIndex;

			private readonly bool previousControlPointIsSegment;

			private readonly bool nextControlPointIsSegment;

			private readonly bool canHaveFollowUp;

			private readonly short orientationAnchorIndex;

			internal bool IsVisible => false;

			internal short SegmentIndex => 0;

			internal short ControlPointIndex => 0;

			internal short NextControlPointIndex => 0;

			internal short PreviousControlPointIndex => 0;

			internal bool PreviousControlPointIsSegment => false;

			internal bool NextControlPointIsSegment => false;

			internal bool CanHaveFollowUp => false;

			internal bool IsSegment => false;

			internal short OrientationAnchorIndex => 0;

			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
				this.isVisible = false;
				this.segmentIndex = 0;
				this.controlPointIndex = 0;
				this.nextControlPointIndex = 0;
				this.previousControlPointIndex = 0;
				this.previousControlPointIsSegment = false;
				this.nextControlPointIsSegment = false;
				this.canHaveFollowUp = false;
				this.orientationAnchorIndex = 0;
			}

			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return false;
			}

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}

			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return false;
			}

			public static bool operator !=(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return false;
			}
		}

		public static readonly Color GizmoTangentColor;

		[NonSerialized]
		public Vector3[] Approximation;

		[NonSerialized]
		public float[] ApproximationDistances;

		[NonSerialized]
		public Vector3[] ApproximationUp;

		[NonSerialized]
		public Vector3[] ApproximationT;

		[Group("General")]
		[FieldAction("CBBakeOrientation", ActionAttribute.ActionEnum.Callback, Position = ActionAttribute.ActionPositionEnum.Below)]
		[Label("Bake Orientation", "Automatically apply orientation to CP transforms?")]
		[SerializeField]
		private bool m_AutoBakeOrientation;

		[Group("General")]
		[Tooltip("Check to use this transform's rotation")]
		[FieldCondition("IsOrientationAnchorEditable", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		private bool m_OrientationAnchor;

		[Label("Swirl", "Add Swirl to orientation?")]
		[Group("General")]
		[FieldCondition("canHaveSwirl", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		private CurvyOrientationSwirl m_Swirl;

		[Label("Turns", "Number of swirl turns")]
		[Group("General")]
		[FieldCondition("canHaveSwirl", true, false, ConditionalAttribute.OperatorEnum.AND, "m_Swirl", CurvyOrientationSwirl.None, true)]
		[SerializeField]
		private float m_SwirlTurns;

		[Section("Bezier Options", true, false, 100, Sort = 1, HelpURL = "https://curvyeditor.com/doclink/curvysplinesegment_bezier")]
		[GroupCondition("interpolation", CurvyInterpolation.Bezier, false)]
		[SerializeField]
		private bool m_AutoHandles;

		[RangeEx(0f, 1f, "Distance %", "Handle length by distance to neighbours")]
		[FieldCondition("m_AutoHandles", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		[SerializeField]
		private float m_AutoHandleDistance;

		[VectorEx("", "", Precision = 3, Options = (AttributeOptionsFlags)1152, Color = "#FFFF00")]
		[SerializeField]
		[FormerlySerializedAs("HandleIn")]
		private Vector3 m_HandleIn;

		[VectorEx("", "", Precision = 3, Options = (AttributeOptionsFlags)1152, Color = "#00FF00")]
		[SerializeField]
		[FormerlySerializedAs("HandleOut")]
		private Vector3 m_HandleOut;

		[Section("TCB Options", true, false, 100, Sort = 1, HelpURL = "https://curvyeditor.com/doclink/curvysplinesegment_tcb")]
		[GroupCondition("interpolation", CurvyInterpolation.TCB, false)]
		[GroupAction("TCBOptionsGUI", ActionAttribute.ActionEnum.Callback, Position = ActionAttribute.ActionPositionEnum.Below)]
		[Label("Local Tension", "Override Spline Tension?")]
		[SerializeField]
		[FormerlySerializedAs("OverrideGlobalTension")]
		private bool m_OverrideGlobalTension;

		[Label("Local Continuity", "Override Spline Continuity?")]
		[SerializeField]
		[FormerlySerializedAs("OverrideGlobalContinuity")]
		private bool m_OverrideGlobalContinuity;

		[Label("Local Bias", "Override Spline Bias?")]
		[SerializeField]
		[FormerlySerializedAs("OverrideGlobalBias")]
		private bool m_OverrideGlobalBias;

		[Tooltip("Synchronize Start and End Values")]
		[SerializeField]
		[FormerlySerializedAs("SynchronizeTCB")]
		private bool m_SynchronizeTCB;

		[Label("Tension", "")]
		[FieldCondition("m_OverrideGlobalTension", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[FormerlySerializedAs("StartTension")]
		private float m_StartTension;

		[Label("Tension (End)", "")]
		[FieldCondition("m_OverrideGlobalTension", true, false, ConditionalAttribute.OperatorEnum.AND, "m_SynchronizeTCB", false, false)]
		[SerializeField]
		[FormerlySerializedAs("EndTension")]
		private float m_EndTension;

		[Label("Continuity", "")]
		[FieldCondition("m_OverrideGlobalContinuity", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[FormerlySerializedAs("StartContinuity")]
		private float m_StartContinuity;

		[Label("Continuity (End)", "")]
		[FieldCondition("m_OverrideGlobalContinuity", true, false, ConditionalAttribute.OperatorEnum.AND, "m_SynchronizeTCB", false, false)]
		[SerializeField]
		[FormerlySerializedAs("EndContinuity")]
		private float m_EndContinuity;

		[Label("Bias", "")]
		[FieldCondition("m_OverrideGlobalBias", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[FormerlySerializedAs("StartBias")]
		private float m_StartBias;

		[Label("Bias (End)", "")]
		[FieldCondition("m_OverrideGlobalBias", true, false, ConditionalAttribute.OperatorEnum.AND, "m_SynchronizeTCB", false, false)]
		[SerializeField]
		[FormerlySerializedAs("EndBias")]
		private float m_EndBias;

		[SerializeField]
		[HideInInspector]
		private CurvySplineSegment m_FollowUp;

		[SerializeField]
		[HideInInspector]
		private ConnectionHeadingEnum m_FollowUpHeading;

		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncPosition;

		[SerializeField]
		[HideInInspector]
		private bool m_ConnectionSyncRotation;

		[SerializeField]
		[HideInInspector]
		private CurvyConnection m_Connection;

		private int cacheSize;

		private Transform cachedTransform;

		private Vector3 threadSafeLocalPosition;

		private Vector3 threadSafeNextCpLocalPosition;

		private Vector3 threadSafePreviousCpLocalPosition;

		private Quaternion threadSafeLocalRotation;

		private CurvySplineSegment cachedNextControlPoint;

		private CurvySpline mSpline;

		private float mStepSize;

		private Bounds? mBounds;

		private readonly HashSet<CurvyMetadataBase> mMetadata;

		private Vector3 lastProcessedLocalPosition;

		private Quaternion lastProcessedLocalRotation;

		private ControlPointExtrinsicProperties extrinsicPropertiesINTERNAL;

		public bool AutoBakeOrientation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SerializedOrientationAnchor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CurvyOrientationSwirl Swirl
		{
			get
			{
				return default(CurvyOrientationSwirl);
			}
			set
			{
			}
		}

		public float SwirlTurns
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector3 HandleIn
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 HandleOut
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 HandleInPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 HandleOutPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public bool AutoHandles
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

		public bool SynchronizeTCB
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool OverrideGlobalTension
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool OverrideGlobalContinuity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool OverrideGlobalBias
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float StartTension
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StartContinuity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StartBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float EndTension
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float EndContinuity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float EndBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public CurvySplineSegment FollowUp
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public ConnectionHeadingEnum FollowUpHeading
		{
			get
			{
				return default(ConnectionHeadingEnum);
			}
			set
			{
			}
		}

		public bool ConnectionSyncPosition
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ConnectionSyncRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CurvyConnection Connection
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public int CacheSize
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public Bounds Bounds => default(Bounds);

		public float Length { get; private set; }

		public float Distance { get; internal set; }

		public float TF { get; internal set; }

		public bool IsFirstControlPoint => false;

		public bool IsLastControlPoint => false;

		[Obsolete("Use Metadata instead")]
		public HashSet<Component> MetaDataSet => null;

		public HashSet<CurvyMetadataBase> Metadata => null;

		public CurvySpline Spline => null;

		public bool HasUnprocessedLocalPosition => false;

		public bool HasUnprocessedLocalOrientation => false;

		public bool OrientatinInfluencesSpline => false;

		private CurvyInterpolation interpolation => default(CurvyInterpolation);

		private bool isDynamicOrientation => false;

		private bool IsOrientationAnchorEditable => false;

		private bool canHaveSwirl => false;

		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		public void Disconnect()
		{
		}

		public void Disconnect(bool destroyEmptyConnection)
		{
		}

		[Obsolete("Use Disconnect instead")]
		public void ResetConnectionRelatedData()
		{
		}

		public Vector3 Interpolate(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangent(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangent(float localF, Vector3 position, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Vector3 GetTangentFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public void InterpolateAndGetTangent(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
			position = default(Vector3);
			tangent = default(Vector3);
		}

		public void InterpolateAndGetTangentFast(float localF, out Vector3 position, out Vector3 tangent, Space space = Space.Self)
		{
			position = default(Vector3);
			tangent = default(Vector3);
		}

		public Vector3 GetOrientationUpFast(float localF, Space space = Space.Self)
		{
			return default(Vector3);
		}

		public Quaternion GetOrientationFast(float localF, bool inverse = false, Space space = Space.Self)
		{
			return default(Quaternion);
		}

		[Obsolete("Member not used by Curvy, will get remove. Copy it if you still need it")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		public void ReloadMetaData()
		{
		}

		public void RegisterMetaData(CurvyMetadataBase metaData)
		{
		}

		public void UnregisterMetaData(CurvyMetadataBase metaData)
		{
		}

		public T GetMetadata<T>(bool autoCreate = false) where T : CurvyMetadataBase
		{
			return null;
		}

		public U GetInterpolatedMetadata<T, U>(float f) where T : CurvyInterpolatableMetadataBase<U>
		{
			return default(U);
		}

		public void DeleteMetadata()
		{
		}

		public float GetNearestPointF(Vector3 position, Space space = Space.Self)
		{
			return 0f;
		}

		public float DistanceToLocalF(float localDistance)
		{
			return 0f;
		}

		public float LocalFToDistance(float localF)
		{
			return 0f;
		}

		public float LocalFToTF(float localF)
		{
			return 0f;
		}

		public override string ToString()
		{
			return null;
		}

		public void BakeOrientationToTransform()
		{
		}

		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			frag = default(float);
			return 0;
		}

		public void LinkToSpline(CurvySpline spline)
		{
		}

		public void UnlinkFromSpline()
		{
		}

		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		public void SetPosition(Vector3 value)
		{
		}

		public void SetLocalRotation(Quaternion value)
		{
		}

		public void SetRotation(Quaternion value)
		{
		}

		public static bool CanFollowUpHeadToStart([NotNull] CurvySplineSegment followUp)
		{
			return false;
		}

		public static bool CanFollowUpHeadToEnd([NotNull] CurvySplineSegment followUp)
		{
			return false;
		}

		public void OnBeforePush()
		{
		}

		public void OnAfterPop()
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Reset()
		{
		}

		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		internal ref readonly ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		private void CheckAgainstMetaDataDuplication()
		{
		}

		private bool SetConnection(CurvyConnection newConnection)
		{
			return false;
		}

		private static ConnectionHeadingEnum GetValidateConnectionHeading(ConnectionHeadingEnum connectionHeading, [CanBeNull] CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}

		private bool SetAutoHandles(bool newValue)
		{
			return false;
		}

		private float getApproximationLocalF(int idx)
		{
			return 0f;
		}

		internal void refreshCurveINTERNAL()
		{
		}

		private float InterpolateBezierSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return 0f;
		}

		private float InterpolateTCBSegment(CurvySplineSegment nextControlPoint, int newCacheSize, float splineTension, float splineContinuity, float splineBias)
		{
			return 0f;
		}

		private float InterpolateCatmullSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return 0f;
		}

		private float InterpolateLinearSegment(CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return 0f;
		}

		internal void refreshOrientationNoneINTERNAL()
		{
		}

		internal void refreshOrientationStaticINTERNAL()
		{
		}

		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		internal void ClearBoundsINTERNAL()
		{
		}

		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		internal void PrepareThreadCompatibleDataINTERNAL(bool useFollowUp)
		{
		}
	}
}
