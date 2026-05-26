using System.Collections.Generic;
using DG.Tweening;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class ItemBehaviour : Interactable
{
	public string weaponName;

	public bool heavy;

	public bool vertical;

	public int camChildIndex;

	public int camChildIndexLeftHand;

	public int aimIndex;

	public bool aimWeapon;

	public float aimFOV;

	[Space]
	public bool vfxAttachedOnGun;

	public ParticleSystem smokeTrail;

	[Space]
	public string rightHandAnim;

	public string leftHandAnim;

	public string outofhandsAnim;

	[SerializeField]
	private Sprite standCrosshair;

	[SerializeField]
	private Sprite sprintCrosshair;

	[SerializeField]
	private bool instantAimLens;

	[SerializeField]
	private Sprite aimCrosshair;

	[SerializeField]
	private float ejectForce;

	[SerializeField]
	private float torqueForce;

	[SerializeField]
	private float gravityAdded;

	[SerializeField]
	private AudioClip hitSurfaceClip;

	public Transform gripRight;

	public Transform gripLeft;

	private Vector3 finalPos;

	[SerializeField]
	private AudioClip grabClip;

	public GameObject depopVFX;

	[SerializeField]
	private LayerMask groundLayer;

	public Camera cam;

	public bool isTaken;

	private Tween groundMov;

	private Tween tween1;

	private Tween tween2;

	private Tween tween3;

	private Tween tween4;

	public GameObject rootObject;

	public GameObject lastPlayerHolder;

	public Transform[] fpArms;

	public PlayerPickup playerPickup;

	public FirstPersonController playerController;

	private Weapon weaponScript;

	private MeshRenderer[] hoveredObjectRenderer;

	private List<Material> hoveredObjectMat;

	private AudioSource audio;

	private Rigidbody tempRb;

	public bool dispenserStart;

	[Header("AimStrafe Lean")]
	[SerializeField]
	private Transform aimStrafePivot;

	[SerializeField]
	private float maxPivot;

	[SerializeField]
	private float aimStrafeLeanSpeed;

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

	[Header("Headbob")]
	[SerializeField]
	public float walkBobSpeed;

	[SerializeField]
	public float walkBobAmount;

	[SerializeField]
	public float sprintBobSpeed;

	[SerializeField]
	public float sprintBobAmount;

	[SerializeField]
	public float crouchBobSpeed;

	[SerializeField]
	public float crouchBobAmount;

	private float InputX;

	private float InputY;

	private Vector2 currentInputRaw;

	private float verticalInputRaw;

	private float horizontalInputRaw;

	private float movTimer;

	private Collider col;

	private bool alreadyPlayed;

	[Header("Wall Clip Fix")]
	[SerializeField]
	private float distance;

	[SerializeField]
	private float radius;

	[SerializeField]
	private LayerMask clippingLayerMask;

	[SerializeField]
	private AnimationCurve offsetCurve;

	private Vector3 initialLocalPosition;

	private bool NetworkInitializeEarly_ItemBehaviour_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_ItemBehaviour_Assembly_002DCSharp_002Edll;

	public override void OnFocus()
	{
	}

	public override void OnInteract()
	{
	}

	public override void OnLoseFocus()
	{
	}

	public void OnGrab(bool owner, bool rightHand)
	{
	}

	public void OnDrop(Camera tempCam)
	{
	}

	[ObserversRpc(RunLocally = true)]
	public void DispenserDrop(Vector3 dir)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void InstantComeBackOnFire()
	{
	}

	private void FixedUpdate()
	{
	}

	public void KillAnimation()
	{
	}

	private void WeaponTransform(Transform pos)
	{
	}

	private void CalculateMovementInput()
	{
	}

	private void ItemMovement(Vector3 initialPosition)
	{
	}

	private void WeaponSway(Vector3 initialPosition)
	{
	}

	private void TiltSway(Quaternion initialRotation)
	{
	}

	public void StickOnGround()
	{
	}

	public void StickOnGroundObservers()
	{
	}

	public void GroundMovement()
	{
	}

	private void SetLayerAllChildren(Transform root, int layer)
	{
	}

	public void KillTweens()
	{
	}

	public void SetLayer()
	{
	}

	public void UnsetLayer()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}

	public override void NetworkInitialize___Early()
	{
	}

	public override void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	private void RpcWriter___Observers_DispenserDrop_4276783012(Vector3 dir)
	{
	}

	public void RpcLogic___DispenserDrop_4276783012(Vector3 dir)
	{
	}

	private void RpcReader___Observers_DispenserDrop_4276783012(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
