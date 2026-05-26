using UnityEngine;
using UnityEngine.InputSystem;

public class FPArms : MonoBehaviour
{
	[Header("Jump Animation")]
	[SerializeField]
	private Vector3 jumpOffset;

	[SerializeField]
	private Vector3 fallOffset;

	[SerializeField]
	private float jumpBobSpeed;

	[SerializeField]
	private float fallBobSpeed;

	[Header("Movement Animation")]
	[SerializeField]
	private Transform bobPosition;

	[SerializeField]
	private float bobScale;

	[SerializeField]
	private float bobSpeed;

	[SerializeField]
	private float crouchBobScale;

	[SerializeField]
	private float crouchBobSpeed;

	[SerializeField]
	private float sprintBobScale;

	[SerializeField]
	private float sprintBobSpeed;

	[SerializeField]
	private float aimBobScale;

	[SerializeField]
	private float aimBobSpeed;

	[SerializeField]
	private float resetRecoverSpeed;

	private Vector3 restPos;

	private Quaternion restRot;

	private Vector3 targetIdlePos;

	private float IdleScaleTempTimer;

	private float tempBobScaleTimer;

	[Header("Idle Animation")]
	[SerializeField]
	private float idleSinSpeed;

	[SerializeField]
	private float idleScale;

	[SerializeField]
	private float idleLerpSpeed;

	[SerializeField]
	private float maxIdleScale;

	[Header("Members")]
	[SerializeField]
	private Animator animator;

	public PlayerControls playerControls;

	private InputAction move;

	private InputAction jump;

	private InputAction run;

	private InputAction lookY;

	private InputAction lookX;

	private InputAction zoom;

	private InputAction crouch;

	private Vector2 mouseInput;

	private bool jumped;

	[HideInInspector]
	public bool heavy;

	[HideInInspector]
	public bool vertical;

	private float landTimer;

	[SerializeField]
	private FirstPersonController player;

	private PauseManager pauseManager;

	[Header("Position")]
	public float amount;

	public float maxAmount;

	public float smoothAmount;

	[Header("Rotation")]
	public float rotationAmount;

	public float maxRotationAmount;

	public float smoothRotation;

	[Space]
	public bool rotationX;

	public bool rotationY;

	public bool rotationZ;

	private float InputX;

	private float InputY;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Jump(InputAction.CallbackContext ctx)
	{
	}

	private void WeaponSway(Vector3 initialPosition, Transform member)
	{
	}

	private void TiltSway(Quaternion initialRotation, Transform member)
	{
	}
}
