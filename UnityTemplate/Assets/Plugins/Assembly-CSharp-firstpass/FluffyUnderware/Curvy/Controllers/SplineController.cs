using System.Collections.ObjectModel;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Controllers
{
	[AddComponentMenu("Curvy/Controller/Spline Controller", 5)]
	[HelpURL("https://curvyeditor.com/doclink/splinecontroller")]
	public class SplineController : CurvyController
	{
		[Section("General", true, false, 100, Sort = 0)]
		[FieldCondition("m_Spline", null, false, ActionAttribute.ActionEnum.ShowError, "Missing source Spline", ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		protected CurvySpline m_Spline;

		[SerializeField]
		[Tooltip("Whether spline's cache data should be used. Set this to true to gain performance if precision is not required.")]
		private bool m_UseCache;

		[Section("Connections handling", true, false, 100, Sort = 250, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_connectionshandling")]
		[SerializeField]
		[Label("At connection, use", "What spline should the controller use when reaching a Connection")]
		private SplineControllerConnectionBehavior connectionBehavior;

		[SerializeField]
		[Label("Allow direction change", "When true, the controller will modify its direction to best fit the connected spline")]
		private bool allowDirectionChange;

		[SerializeField]
		[Label("Reject current spline", "Whether the current spline should be excluded from the randomly selected splines")]
		[FieldCondition("ShowRandomConnectionOptions", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		private bool rejectCurrentSpline;

		[SerializeField]
		[Label("Reject divergent splines", "Whether splines that diverge from the current spline with more than a specific angle should be excluded from the randomly selected splines")]
		[FieldCondition("ShowRandomConnectionOptions", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		private bool rejectTooDivergentSplines;

		[SerializeField]
		[Label("Max allowed angle", "Maximum allowed divergence angle in degrees")]
		[Range(0f, 180f)]
		private float maxAllowedDivergenceAngle;

		[SerializeField]
		[Label("Custom Selector", "A custom logic to select which connected spline to follow. Select a Script inheriting from SplineControllerConnectionBehavior")]
		[FieldCondition("connectionBehavior", SplineControllerConnectionBehavior.Custom, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[FieldCondition("connectionCustomSelector", null, false, ActionAttribute.ActionEnum.ShowWarning, "Missing custom selector", ActionAttribute.ActionPositionEnum.Below)]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Section("Events", false, false, 1000, HelpURL = "https://curvyeditor.com/doclink/splinecontroller_events")]
		[SerializeField]
		protected CurvySplineMoveEvent m_OnControlPointReached;

		[SerializeField]
		protected CurvySplineMoveEvent m_OnEndReached;

		[SerializeField]
		protected CurvySplineMoveEvent m_OnSwitch;

		private CurvySpline prePlaySpline;

		private readonly CurvySplineMoveEventArgs preAllocatedEventArgs;

		protected float SwitchStartTime;

		protected float SwitchDuration;

		protected CurvySpline SwitchTarget;

		protected float TfOnSwitchTarget;

		protected MovementDirection DirectionOnSwitchTarget;

		private const string InvalidSegmentErrorMessage = "[Curvy] Controller {0} reached segment {1} which is invalid segment because it has a length of 0. Please fix the invalid segment to avoid issues with the controller";

		public virtual CurvySpline Spline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseCache
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			set
			{
			}
		}

		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool AllowDirectionChange
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RejectCurrentSpline
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RejectTooDivergentSplines
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float MaxAllowedDivergenceAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public CurvySplineMoveEvent OnControlPointReached
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvySplineMoveEvent OnEndReached
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvySplineMoveEvent OnSwitch
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsSwitching { get; private set; }

		public float SwitchProgress => 0f;

		public override float Length => 0f;

		public override bool IsReady => false;

		private bool ShowRandomConnectionOptions => false;

		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		public void FinishCurrentSwitch()
		{
		}

		public void CancelCurrentSwitch()
		{
		}

		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return 0f;
		}

		protected override void SavePrePlayState()
		{
		}

		protected override void RestorePrePlayState()
		{
		}

		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return 0f;
		}

		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return 0f;
		}

		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
			interpolatedPosition = default(Vector3);
			tangent = default(Vector3);
			up = default(Vector3);
		}

		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		protected override void Advance(float speed, float deltaTime)
		{
		}

		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
			targetPosition = default(Vector3);
			targetUp = default(Vector3);
			targetForward = default(Vector3);
		}

		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint, float clampedPosition)
		{
			controlPoint = null;
			isOnControlPoint = default(bool);
			return 0f;
		}

		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float specialClampedPosition)
		{
		}

		private void EventAwareMove(float distance)
		{
		}

		private void HandleReachingNewControlPoint(CurvySplineSegment controlPoint, float controlPointPosition, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement, out CurvySplineSegment postEventsControlPoint, out bool postEventsIsControllerOnControlPoint, out float postEventsControlPointPosition)
		{
			postEventsControlPoint = null;
			postEventsIsControllerOnControlPoint = default(bool);
			postEventsControlPointPosition = default(float);
		}

		private void InvokeEventHandler(CurvySplineMoveEvent @event, CurvySplineMoveEventArgs eventArgument, CurvyPositionMode positionMode, ref CurvySplineSegment postEventsControlPoint, ref bool postEventsIsControllerOnControlPoint, ref float postEventsControlPointPosition)
		{
		}

		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			newDirection = default(MovementDirection);
			return null;
		}

		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		private CurvySplineSegment HandleFollowUpConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			newDirection = default(MovementDirection);
			return null;
		}

		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode)
		{
			return 0f;
		}
	}
}
