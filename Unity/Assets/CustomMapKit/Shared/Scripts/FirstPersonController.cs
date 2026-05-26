using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FishNet.Component.Animating;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using HeathenEngineering.PhysKit;
using HeathenEngineering.SteamworksIntegration;
using LambdaTheDev.NetworkAudioSync;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.PostProcessing;

public class FirstPersonController : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActiveTorso_003Ed__309 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FirstPersonController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CActiveTorso_003Ed__309(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CHighCameraShake_003Ed__335 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FirstPersonController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CHighCameraShake_003Ed__335(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CDeactivateVault_003Ed__385 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FirstPersonController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDeactivateVault_003Ed__385(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRotateBackAfterVault_003Ed__386 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FirstPersonController _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRotateBackAfterVault_003Ed__386(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public bool canMove;

	public bool isSprinting;

	public bool isWalking;

	public bool isCrouching;

	public bool isGrounded;

	public bool safeGrounded;

	public bool isSliding;

	public bool isLeaning;

	public bool isTouchingAnything;

	public PlayerControls playerControls;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction move;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction jump;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction run;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction lookY;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction lookX;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction zoom;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction crouch;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction moveUp;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction leanLeft;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction leanRight;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction record;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction fire1;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction fire2;

	[HideInInspector]
	public UnityEngine.InputSystem.InputAction reload;

	[Header("Functional Options")]
	[SerializeField]
	private bool canSprint;

	[SerializeField]
	private bool canJump;

	[SerializeField]
	private bool canCrouch;

	[SerializeField]
	private bool canUseHeadMovement;

	[SerializeField]
	private bool WillSlideOnSlopes;

	[SerializeField]
	private bool useFootsteps;

	[Header("Movement Parameters")]
	[SerializeField]
	private float walkSpeed;

	[SerializeField]
	private float sprintSpeed;

	[SerializeField]
	private float crouchSpeed;

	[SerializeField]
	private float slopeSpeed;

	[SerializeField]
	private float airControl;

	[SerializeField]
	private float airSpeed;

	[SerializeField]
	private float sprintAirSpeed;

	[SerializeField]
	private float globalAcceleration;

	[SerializeField]
	private float globalDeceleration;

	[SerializeField]
	private float walkAcceleration;

	[SerializeField]
	private float sprintAcceleration;

	[SerializeField]
	private float crouchAcceleration;

	[SerializeField]
	private float airAcceleration;

	[SerializeField]
	private float sprintAirAcceleration;

	public float movementFactor;

	public float jumpFactor;

	public float wallJumpFactor;

	public int maxWallJumps;

	public Vector3 moveDirection;

	private Vector3 objectCollisionMoveDirection;

	public Vector3 moveAdded;

	public Vector3 groundNormal;

	public float playerSpeed;

	public float speedFactor;

	public Vector2 currentInput;

	public Vector2 currentInputRaw;

	private float verticalInput;

	private float horizontalInput;

	private float verticalInputRaw;

	private float horizontalInputRaw;

	[Header("Look Parameters")]
	[SerializeField]
	[Range(0.1f, 5f)]
	public float lookSpeedX;

	[SerializeField]
	[Range(0.1f, 5f)]
	public float lookSpeedY;

	[SerializeField]
	[Range(0.1f, 5f)]
	public float lookSpeedAim;

	[SerializeField]
	[Range(0.1f, 5f)]
	public float lookSpeedAimNoScope;

	public bool isScopeAiming;

	[SerializeField]
	[Range(0f, 90f)]
	private float upperLookLimit;

	[SerializeField]
	[Range(0f, 90f)]
	private float lowerLookLimit;

	[SerializeField]
	private Vector3 offset;

	public float rotationX;

	private float rotationZ;

	private Vector2 mouseInput;

	[Space]
	public float killShockWaveStrength;

	[SerializeField]
	private float saturationSpeed;

	[Header("Lean Parameters")]
	[SerializeField]
	private Transform leanCamera;

	[SerializeField]
	private float leanSpeed;

	[SerializeField]
	private float leanLimit;

	[SerializeField]
	private float constrainSphereRadius;

	private float currentRot;

	[Header("Jumping Parameters")]
	public float jumpForce;

	[SerializeField]
	private float jumpSlopeForce;

	[SerializeField]
	private float jumpSlopeDecel;

	[SerializeField]
	private float gravity;

	[SerializeField]
	private float crouchGravity;

	[SerializeField]
	private float jumpGravity;

	[HideInInspector]
	public float gravityMultiplier;

	[SerializeField]
	private float ladderDetectionLength;

	[SerializeField]
	private float ladderSpeed;

	[SerializeField]
	private float vaultMinimumAngle;

	[SerializeField]
	private LayerMask ladderLayer;

	public LayerMask landLayer;

	[SerializeField]
	private AudioClip jumpClip;

	[SerializeField]
	private AudioClip wallOutClip;

	[SerializeField]
	private AudioClip teleportClip;

	[SerializeField]
	private AudioClip landClip;

	[SerializeField]
	private AudioClip ceilingHitClip;

	[SerializeField]
	private AudioClip groundSlideClip;

	[SerializeField]
	private AudioClip wallSlideClip;

	[SerializeField]
	private GameObject jumpDust;

	[SerializeField]
	private GameObject landDust;

	private bool prejump;

	[Header("Crouch Parameters")]
	[SerializeField]
	private float crouchHeight;

	[SerializeField]
	private float slideHeight;

	[SerializeField]
	private float standHeight;

	[SerializeField]
	private float crouchingSpeed;

	[SerializeField]
	private Ease crouchingEase;

	[Header("Slide Parameters")]
	[SerializeField]
	private float walkSlideImpulsion;

	[SerializeField]
	private float walkSlideDuration;

	[SerializeField]
	private float sprintSlideImpulsion;

	[SerializeField]
	private float sprintSlideDuration;

	[SerializeField]
	private float slideResetTime;

	[SerializeField]
	private GameObject slideDust;

	[SerializeField]
	private GameObject legRight;

	[SerializeField]
	private GameObject legLeft;

	[SerializeField]
	private GameObject torso;

	private bool walkSlide;

	private bool sprintSlide;

	[Header("Head Movement")]
	[SerializeField]
	private Transform landBobPivot;

	[SerializeField]
	private float landRecoverSpeed;

	[SerializeField]
	private float landBobAmount;

	[SerializeField]
	private float landBobDuration;

	[SerializeField]
	private Ease landBobEase;

	[Header("Headbob Parameters")]
	[SerializeField]
	private float walkBobSpeed;

	[SerializeField]
	private float walkBobAmount;

	[SerializeField]
	private float sprintBobSpeed;

	[SerializeField]
	private float sprintBobAmount;

	[SerializeField]
	private float crouchBobSpeed;

	[SerializeField]
	private float crouchBobAmount;

	[SerializeField]
	private float fallBobSpeed;

	[SerializeField]
	private float fallBobUpSpeed;

	[SerializeField]
	private float fallBobAmount;

	[SerializeField]
	private float fallShakeHeight;

	[SerializeField]
	private Vector3 fallShakeForce;

	[SerializeField]
	private float fallShakeDuration;

	[SerializeField]
	private int fallShakeVibrato;

	[SerializeField]
	private float fallShakeElasticity;

	[SerializeField]
	private Vector3 highFallShakeForce;

	[SerializeField]
	private float highFallShakeDuration;

	[SerializeField]
	private float highFallShakeRecoverTime;

	[SerializeField]
	private float highFallShakeRecoverSpeed;

	[SerializeField]
	private float highFallShakeHeight;

	[SerializeField]
	private AudioClip highFallAudioClip;

	[SerializeField]
	private GameObject highFallVfx;

	[SerializeField]
	private float fallAudioLerpSpeed;

	[SerializeField]
	private float fallAudioLerpOutSpeed;

	[SerializeField]
	private float lensDistortionWhenFalling;

	[SerializeField]
	private float lensDistortionLerpSpeed;

	[SerializeField]
	private float lensDistortionLerpOutSpeed;

	private ParticleSystem highFallVfxComponent;

	private float defaultYPos;

	[Header("Camera Controller")]
	[SerializeField]
	private float zoomSpeed;

	[SerializeField]
	public float zoomFOV;

	[SerializeField]
	private Ease zoomEase;

	[SerializeField]
	private float runEaseSpeed;

	[SerializeField]
	private float runFOV;

	[SerializeField]
	private Ease slideEase;

	[SerializeField]
	private float slideEaseSpeed;

	[SerializeField]
	private float slideFOV;

	[SerializeField]
	private Ease runSlideEase;

	[SerializeField]
	private float runSlideEaseSpeed;

	[SerializeField]
	private float runSlideFOV;

	[SerializeField]
	private Ease runEase;

	[SerializeField]
	private float tiltAmount;

	[SerializeField]
	private float tiltSpeed;

	[SerializeField]
	private float slideTiltAmount;

	public bool camController;

	public bool isZooming;

	public bool isAiming;

	[HideInInspector]
	public float defaultFOV;

	public bool smoothCam;

	[Header("Camera mouse incidence")]
	[SerializeField]
	private float rotationAmount;

	[SerializeField]
	private float maxRotationAmount;

	[SerializeField]
	private float smoothRotation;

	[Header("Footsteps Parameters")]
	[SerializeField]
	private float baseStepSpeed;

	[SerializeField]
	private float crouchStepMultiplier;

	[SerializeField]
	private float sprintStepMultiplier;

	[SerializeField]
	private float ladderStep;

	[SerializeField]
	private float walkStepVolume;

	[SerializeField]
	private AudioClip[] concreteClips;

	[SerializeField]
	private AudioClip[] dallesClips;

	[SerializeField]
	private AudioClip[] betonSolideClips;

	[SerializeField]
	private AudioClip[] betonPleinairClips;

	[SerializeField]
	private AudioClip[] woodClips;

	[SerializeField]
	private AudioClip[] woodSecClips;

	[SerializeField]
	private AudioClip[] dirtClips;

	[SerializeField]
	private AudioClip[] sandClips;

	[SerializeField]
	private AudioClip[] grassClips;

	[SerializeField]
	private AudioClip[] graviersClips;

	[SerializeField]
	private AudioClip[] waterClips;

	[SerializeField]
	private AudioClip[] metalClips;

	[SerializeField]
	private AudioClip[] grilleClips;

	[SerializeField]
	private AudioClip[] pipeClips;

	[SerializeField]
	private AudioClip[] matelasClips;

	[SerializeField]
	private AudioClip[] moquetteClips;

	private float footstepTimer;

	private float ladderStepTimer;

	[Space]
	[SerializeField]
	private AudioClip[] chainClips;

	[SerializeField]
	private AudioClip[] ladderClips;

	[Space]
	[SerializeField]
	private AudioClip[] tauntClip;

	private Vector3 hitPointNormal;

	private Vector3 wallPointNormal;

	public bool IsSliding;

	public bool CanWallJump;

	private string currentwalltag;

	public int wallJumpsCount;

	private bool hitDiagonalCeiling;

	[HideInInspector]
	public float wallSlideLean;

	[SerializeField]
	public Camera playerCamera;

	[SerializeField]
	public GameObject playerCameraHolder;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private NetworkAnimator networkAnimator;

	public CharacterController characterController;

	private NetworkObject networkObject;

	public SlopeSlide slopeSlideScript;

	public CustomAddForce customForceScript;

	[HideInInspector]
	public PauseManager pauseManager;

	public PlayerPickup playerPickupScript;

	[HideInInspector]
	public PlayerSetup setupScript;

	public CameraShakeConstrains cameraScript;

	private Slope slopeScript;

	[HideInInspector]
	public PostProcessVolume volume;

	[HideInInspector]
	public LensDistortion lensDistortion;

	[HideInInspector]
	public ColorGrading colorGrading;

	[SerializeField]
	private AudioSource slideAudio;

	[SerializeField]
	private NetworkAudioSource networkSlideAudio;

	[SerializeField]
	private AudioSource audio;

	[SerializeField]
	private AudioSource fallAudio;

	[Header("Functionnal Variables")]
	public bool landBool;

	private float landTimer;

	private bool slideEnd;

	private bool jumpSlope;

	private bool onLadder;

	private float aftervaultjumpTimer;

	public float headbobTimer;

	private float slideTimer;

	private float setSpeedTimer;

	private float slideResetTimer;

	private float slideCancelTimer;

	private float slideTime;

	private float coyoteTimer;

	private float fallShakeOldPos;

	private float fallDistance;

	private bool crouchPress;

	[HideInInspector]
	public bool jumped;

	private bool allJumped;

	public bool onMovingPlatform;

	public bool groundSphereCast;

	private float tauntTimer;

	private const float TauntObserverRateLimit = 0.2f;

	private float nextTauntObserverPlayTime;

	[HideInInspector]
	public bool slopeSlideJumped;

	[Header("Raycasts")]
	public bool shortfrontRay;

	public bool vaulRayDown;

	public bool vaulRayUp;

	public bool vaultRayUpShort;

	private bool steepSlideForward;

	private bool steepSlideBackward;

	public bool downRay;

	private bool animDownRay;

	private bool slideDownRay;

	private bool upSphere;

	private bool ladderRay;

	[Header("Slope Parameters")]
	[SerializeField]
	private float slopeForce;

	[SerializeField]
	private float slopeForceRayLength;

	private bool flymode;

	public static FirstPersonController instance;

	private VerletSpring[] physCables;

	private SetPlayerVolume playerVolume;

	private TextMeshProUGUI speedometer;

	public bool sprintToggle;

	public bool aimToggle;

	public bool leanToggle;

	public bool crouchToggle;

	public bool reverseSprintBind;

	public bool invertX;

	public bool invertY;

	private bool funcSprint;

	private bool funcSprintTrigger;

	private bool isLeaningLeft;

	private bool isLeaningRight;

	private bool funcLeanRightTrigger;

	private bool funcLeanLeftTrigger;

	private bool funcAim;

	private bool funcInvertX;

	private bool funcInvertY;

	private float distToRunFov;

	private float distToSlideFov;

	private float distToRunSlideFov;

	private bool safeDeathFalling;

	private float dmgZoneTimer;

	private float tempSetSpeed;

	private Vector3 dirForward;

	private Vector3 dirRight;

	[SerializeField]
	private Transform legsPivot;

	private float legsRotation;

	private bool camWall;

	private bool camWallExit;

	private Quaternion wallExitRot;

	private bool crouchExit;

	private bool prejumpLand;

	private bool activateFallAudio;

	public bool startOfRound;

	private bool isSlideSprinting;

	private Collider[] ladderColliders;

	private string groundTag;

	private bool rightHeadCast;

	private bool leftHeadCast;

	public bool addingForce;

	public Vector3 forceAdded;

	public Vector3 force;

	public float forceFactor;

	public float initforceFactor;

	public float forceSpeed;

	public float tempforceSpeed;

	[Range(0f, 100f)]
	public float deceleration;

	public Vector3 customForceFinal;

	private Vector3 bforcefinal;

	private Vector3 bdirection;

	private float bfactor;

	private float bdecel;

	private bool bstop;

	private bool bgroundStop;

	private bool baircontrol;

	private float btimer;

	private Settings settings;

	public bool vault;

	private bool vaultActivate;

	private bool roundHasStarted;

	private bool entered;

	[SerializeField]
	private float movingPlatformEjectForce;

	[SerializeField]
	private VoiceStream vstream;

	[SerializeField]
	private VoiceRecorder vstreamRecorder;

	public MatchPoitnsHUD matchPoitnsHUD;

	public SyncVar<bool> syncVar___canMove;

	private bool NetworkInitializeEarly_FirstPersonController_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_FirstPersonController_Assembly_002DCSharp_002Edll;

	private float GetCurrentOffset => 0f;

	private float GetCurrentVolume => 0f;

	public bool SyncAccessor_canMove
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnControllerColliderHit(ControllerColliderHit collision)
	{
	}

	private bool OnSlopeAir()
	{
		return false;
	}

	private bool OnSlopeForSlide()
	{
		return false;
	}

	private bool OnSlopeIce()
	{
		return false;
	}

	public virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBeforeSpawn()
	{
	}

	[ServerRpc(RunLocally = true)]
	public void CmdChangeRootMotion(bool istrue)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ChangeRootMotion(bool istrue)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void HandleTaunt()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void AboubiPlayServer(int clip)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void AboubiPlayObservers(int clip)
	{
	}

	private void HandleAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CActiveTorso_003Ed__309))]
	private IEnumerator ActiveTorso()
	{
		return null;
	}

	private void CalculateMovementInput()
	{
	}

	public void SetSpeed(float speed, float time)
	{
	}

	private void HandleMovementInput()
	{
	}

	private void HandleMouseLook()
	{
	}

	private void HandleCameraLean()
	{
	}

	private void CameraLean(Quaternion rot)
	{
	}

	public void Jump(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
	{
	}

	public void SetZoom(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
	{
	}

	public void SetZoomToggle(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
	{
	}

	public void SetCrouch(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
	{
	}

	private void HandleCrouch()
	{
	}

	private void HandleHeadMovement()
	{
	}

	private void ApplyFinalMovements()
	{
	}

	[IteratorStateMachine(typeof(_003CHighCameraShake_003Ed__335))]
	private IEnumerator HighCameraShake()
	{
		return null;
	}

	private void HandleCameraController()
	{
	}

	private void AdjustHeight(float height)
	{
	}

	private void ChangeFOV(float fov, Ease easeType, float speed)
	{
	}

	private void SideTilt(float temptiltAmount)
	{
	}

	public void Slide(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
	{
	}

	public void SlideEnd(UnityEngine.InputSystem.InputAction.CallbackContext ctx)
	{
	}

	private void EndSlide()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ChangeSlideClipServer(int index)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ChangeSlideClipObservers(int index)
	{
	}

	private void HandleSlide()
	{
	}

	private void HandleFootsteps()
	{
	}

	private void HandlePhysicsCasting()
	{
	}

	private void HandleLadders()
	{
	}

	private void HandleLadderSounds()
	{
	}

	public void AddForce(Vector3 tempforce, float tempforceFactor)
	{
	}

	public void AddAccumulatedForce(Vector3 tempforce, float tempforceFactor)
	{
	}

	public void AddHorizontalForce(Vector3 tempforce, float tempforceFactor)
	{
	}

	public void AddVerticalForce(Vector3 tempforce, float tempforceFactor)
	{
	}

	private void HandleAddingForce()
	{
	}

	public void CustomAddForce(Vector3 dir, float force)
	{
	}

	public void BForce(Vector3 dir, float factor, bool vertical, bool stopOnGround, float decel, bool aircontrol)
	{
	}

	private void HandleBForce()
	{
	}

	private void HandleTimers()
	{
	}

	private void CheckForVault()
	{
	}

	[IteratorStateMachine(typeof(_003CDeactivateVault_003Ed__385))]
	private IEnumerator DeactivateVault()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CRotateBackAfterVault_003Ed__386))]
	private IEnumerator RotateBackAfterVault()
	{
		return null;
	}

	private void OnGUI()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void SlideFadeOut()
	{
	}

	[ServerRpc]
	private void SlideAudioPlay()
	{
	}

	[ServerRpc]
	private void SlideAudioStop()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void PlaySoundServer(int clip)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void PlaySoundObservers(int clip)
	{
	}

	private void JumpClip()
	{
	}

	private void JumpClipObservers()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void WallJumpClip(string walltag)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void JumpClipObservers(string walltag)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void VaultClip(string surface)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void VaultClipObservers(string surface)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SpawnVFX(Vector3 position, Quaternion rotation)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SpawnVFXObservers(Vector3 position, Quaternion rotation)
	{
	}

	private void roundStartEvent()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}

	private void OnTriggerStay(Collider col)
	{
	}

	private void OnTriggerExit(Collider col)
	{
	}

	public void SetNetworkParent(bool set, Transform t)
	{
	}

	[ServerRpc]
	public void DespawnObject(GameObject obj)
	{
	}

	[ObserversRpc]
	private void ExplodeOnDeath()
	{
	}

	public void Teleport(Vector3 position, float angle, bool boost, Transform cac, float power, float decel, bool dontTranslateRotation)
	{
	}

	public void KillShockWave()
	{
	}

	[ServerRpc(RunLocally = true)]
	public void BreakGlassServer(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void BreakGlassObservers(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	public void Shuffle(AudioClip[] texts)
	{
	}

	[ServerRpc]
	public void PlayVoiceChat(byte[] data)
	{
	}

	[ObserversRpc]
	public void PlayVoiceChatObservers(byte[] data)
	{
	}

	private void VoiceChat()
	{
	}

	public virtual void NetworkInitialize___Early()
	{
	}

	public virtual void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	private void RpcWriter___Server_CmdChangeRootMotion_1140765316(bool istrue)
	{
	}

	public void RpcLogic___CmdChangeRootMotion_1140765316(bool istrue)
	{
	}

	private void RpcReader___Server_CmdChangeRootMotion_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ChangeRootMotion_1140765316(bool istrue)
	{
	}

	private void RpcLogic___ChangeRootMotion_1140765316(bool istrue)
	{
	}

	private void RpcReader___Observers_ChangeRootMotion_1140765316(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_AboubiPlayServer_3316948804(int clip)
	{
	}

	private void RpcLogic___AboubiPlayServer_3316948804(int clip)
	{
	}

	private void RpcReader___Server_AboubiPlayServer_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_AboubiPlayObservers_3316948804(int clip)
	{
	}

	private void RpcLogic___AboubiPlayObservers_3316948804(int clip)
	{
	}

	private void RpcReader___Observers_AboubiPlayObservers_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ChangeSlideClipServer_3316948804(int index)
	{
	}

	private void RpcLogic___ChangeSlideClipServer_3316948804(int index)
	{
	}

	private void RpcReader___Server_ChangeSlideClipServer_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ChangeSlideClipObservers_3316948804(int index)
	{
	}

	private void RpcLogic___ChangeSlideClipObservers_3316948804(int index)
	{
	}

	private void RpcReader___Observers_ChangeSlideClipObservers_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SlideAudioPlay_2166136261()
	{
	}

	private void RpcLogic___SlideAudioPlay_2166136261()
	{
	}

	private void RpcReader___Server_SlideAudioPlay_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SlideAudioStop_2166136261()
	{
	}

	private void RpcLogic___SlideAudioStop_2166136261()
	{
	}

	private void RpcReader___Server_SlideAudioStop_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_PlaySoundServer_3316948804(int clip)
	{
	}

	private void RpcLogic___PlaySoundServer_3316948804(int clip)
	{
	}

	private void RpcReader___Server_PlaySoundServer_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlaySoundObservers_3316948804(int clip)
	{
	}

	private void RpcLogic___PlaySoundObservers_3316948804(int clip)
	{
	}

	private void RpcReader___Observers_PlaySoundObservers_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_WallJumpClip_3615296227(string walltag)
	{
	}

	private void RpcLogic___WallJumpClip_3615296227(string walltag)
	{
	}

	private void RpcReader___Server_WallJumpClip_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_JumpClipObservers_3615296227(string walltag)
	{
	}

	private void RpcLogic___JumpClipObservers_3615296227(string walltag)
	{
	}

	private void RpcReader___Observers_JumpClipObservers_3615296227(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_VaultClip_3615296227(string surface)
	{
	}

	private void RpcLogic___VaultClip_3615296227(string surface)
	{
	}

	private void RpcReader___Server_VaultClip_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_VaultClipObservers_3615296227(string surface)
	{
	}

	private void RpcLogic___VaultClipObservers_3615296227(string surface)
	{
	}

	private void RpcReader___Observers_VaultClipObservers_3615296227(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SpawnVFX_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	private void RpcLogic___SpawnVFX_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	private void RpcReader___Server_SpawnVFX_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SpawnVFXObservers_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	private void RpcLogic___SpawnVFXObservers_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	private void RpcReader___Observers_SpawnVFXObservers_3848837105(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_DespawnObject_1934289915(GameObject obj)
	{
	}

	public void RpcLogic___DespawnObject_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_DespawnObject_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ExplodeOnDeath_2166136261()
	{
	}

	private void RpcLogic___ExplodeOnDeath_2166136261()
	{
	}

	private void RpcReader___Observers_ExplodeOnDeath_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_BreakGlassServer_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	public void RpcLogic___BreakGlassServer_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	private void RpcReader___Server_BreakGlassServer_4203392553(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_BreakGlassObservers_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	private void RpcLogic___BreakGlassObservers_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	private void RpcReader___Observers_BreakGlassObservers_4203392553(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_PlayVoiceChat_3345084894(byte[] data)
	{
	}

	public void RpcLogic___PlayVoiceChat_3345084894(byte[] data)
	{
	}

	private void RpcReader___Server_PlayVoiceChat_3345084894(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlayVoiceChatObservers_3345084894(byte[] data)
	{
	}

	public void RpcLogic___PlayVoiceChatObservers_3345084894(byte[] data)
	{
	}

	private void RpcReader___Observers_PlayVoiceChatObservers_3345084894(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___FirstPersonController(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
