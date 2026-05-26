using FluffyUnderware.DevTools;
using UnityEngine;
using UnityEngine.Serialization;

namespace FluffyUnderware.Curvy.Controllers
{
	[ExecuteInEditMode]
	public abstract class CurvyController : DTVersionedMonoBehaviour, ISerializationCallbackReceiver
	{
		public enum MoveModeEnum
		{
			Relative = 0,
			AbsolutePrecise = 1
		}

		public enum CurvyControllerState
		{
			Stopped = 0,
			Playing = 1,
			Paused = 2
		}

		[Section("General", true, false, 100, Sort = 0, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_general")]
		[Label(Tooltip = "Determines when to update")]
		public CurvyUpdateMethod UpdateIn;

		[Section("Position", true, false, 100, Sort = 100, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_position")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[RangeEx(0f, "maxPosition", "", "")]
		[SerializeField]
		[FormerlySerializedAs("m_InitialPosition")]
		protected float m_Position;

		[Section("Move", true, false, 100, Sort = 200, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_move")]
		[SerializeField]
		private MoveModeEnum m_MoveMode;

		[Positive]
		[SerializeField]
		private float m_Speed;

		[SerializeField]
		private MovementDirection m_Direction;

		[SerializeField]
		private CurvyClamping m_Clamping;

		[SerializeField]
		[Tooltip("Start playing automatically when entering play mode")]
		private bool m_PlayAutomatically;

		[Section("Orientation", true, false, 100, Sort = 300, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_orientation")]
		[Label("Source", "Source Vector")]
		[FieldCondition("ShowOrientationSection", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Hide)]
		[SerializeField]
		private OrientationModeEnum m_OrientationMode;

		[Label("Lock Rotation", "When set, the controller will enforce the rotation to not change")]
		[SerializeField]
		private bool m_LockRotation;

		[Label("Target", "Target Vector3")]
		[FieldCondition("m_OrientationMode", OrientationModeEnum.None, false, ConditionalAttribute.OperatorEnum.OR, "ShowOrientationSection", false, false, Action = ActionAttribute.ActionEnum.Hide)]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Tooltip("Should the orientation ignore the movement direction?")]
		[FieldCondition("m_OrientationMode", OrientationModeEnum.None, false, ConditionalAttribute.OperatorEnum.OR, "ShowOrientationSection", false, false, Action = ActionAttribute.ActionEnum.Hide)]
		[SerializeField]
		private bool m_IgnoreDirection;

		[FluffyUnderware.DevTools.Min(0f, "Direction Damping Time", "If non zero, the direction vector will not be updated instantly, but using a damping effect that will last the specified amount of time.")]
		[FieldCondition("ShowOrientationSection", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Hide)]
		[SerializeField]
		private float m_DampingDirection;

		[FluffyUnderware.DevTools.Min(0f, "Up Damping Time", "If non zero, the up vector will not be updated instantly, but using a damping effect that will last the specified amount of time.")]
		[FieldCondition("ShowOrientationSection", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Hide)]
		[SerializeField]
		private float m_DampingUp;

		[Section("Offset", true, false, 100, Sort = 400, HelpURL = "https://curvyeditor.com/doclink/curvycontroller_orientation")]
		[FieldCondition("ShowOffsetSection", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Hide)]
		[RangeEx(-180f, 180f, "", "")]
		[SerializeField]
		private float m_OffsetAngle;

		[FieldCondition("ShowOffsetSection", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Hide)]
		[SerializeField]
		private float m_OffsetRadius;

		[FieldCondition("ShowOffsetSection", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Hide)]
		[Label("Compensate Offset", "")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Section("Events", true, false, 100, Sort = 500)]
		[SerializeField]
		protected ControllerEvent onInitialized;

		protected const string ControllerNotReadyMessage = "The controller is not yet ready";

		protected CurvyControllerState State;

		protected Vector3 DirectionDampingVelocity;

		protected Vector3 UpDampingVelocity;

		protected float PrePlayPosition;

		protected MovementDirection PrePlayDirection;

		protected Quaternion LockedRotation;

		public ControllerEvent OnInitialized => null;

		public CurvyPositionMode PositionMode
		{
			get
			{
				return default(CurvyPositionMode);
			}
			set
			{
			}
		}

		public MoveModeEnum MoveMode
		{
			get
			{
				return default(MoveModeEnum);
			}
			set
			{
			}
		}

		public bool PlayAutomatically
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CurvyClamping Clamping
		{
			get
			{
				return default(CurvyClamping);
			}
			set
			{
			}
		}

		public OrientationModeEnum OrientationMode
		{
			get
			{
				return default(OrientationModeEnum);
			}
			set
			{
			}
		}

		public bool LockRotation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public OrientationAxisEnum OrientationAxis
		{
			get
			{
				return default(OrientationAxisEnum);
			}
			set
			{
			}
		}

		public float DirectionDampingTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float UpDampingTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IgnoreDirection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float OffsetAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float OffsetRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool OffsetCompensation
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float Speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float RelativePosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float AbsolutePosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Position
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public MovementDirection MovementDirection
		{
			get
			{
				return default(MovementDirection);
			}
			set
			{
			}
		}

		public CurvyControllerState PlayState => default(CurvyControllerState);

		public abstract bool IsReady { get; }

		public virtual Transform Transform => null;

		protected virtual bool ShowOrientationSection => false;

		protected virtual bool ShowOffsetSection => false;

		public abstract float Length { get; }

		protected bool isInitialized { get; private set; }

		protected float TimeSinceLastUpdate => 0f;

		protected bool UseOffset => false;

		private float maxPosition => 0f;

		protected virtual void OnEnable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void Reset()
		{
		}

		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
			targetPosition = default(Vector3);
			targetUp = default(Vector3);
			targetForward = default(Vector3);
		}

		protected virtual void Initialize()
		{
		}

		protected virtual void Deinitialize()
		{
		}

		protected virtual void BindEvents()
		{
		}

		protected virtual void UnbindEvents()
		{
		}

		protected virtual void SavePrePlayState()
		{
		}

		protected virtual void RestorePrePlayState()
		{
		}

		protected virtual void UserAfterInit()
		{
		}

		protected virtual void UserAfterUpdate()
		{
		}

		protected abstract void Advance(float speed, float deltaTime);

		protected abstract void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime);

		protected abstract float AbsoluteToRelative(float worldUnitDistance);

		protected abstract float RelativeToAbsolute(float relativeDistance);

		protected abstract Vector3 GetInterpolatedSourcePosition(float tf);

		protected abstract void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up);

		protected abstract Vector3 GetOrientation(float tf);

		protected abstract Vector3 GetTangent(float tf);

		public void Play()
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public void Refresh()
		{
		}

		public void ApplyDeltaTime(float deltaTime)
		{
		}

		public void TeleportTo(float newPosition)
		{
		}

		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		public void SetFromString(string fieldAndValue)
		{
		}

		protected static Vector3 ApplyOffset(Vector3 position, Vector3 tangent, Vector3 up, float offsetAngle, float offsetRadius)
		{
			return default(Vector3);
		}

		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return 0f;
		}

		protected float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return 0f;
		}

		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
			targetUp = default(Vector3);
			targetForward = default(Vector3);
		}

		public void OnBeforeSerialize()
		{
		}

		public virtual void OnAfterDeserialize()
		{
		}
	}
}
