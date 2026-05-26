using DG.Tweening;
using UnityEngine;

public class HandGrenadeTwo : MonoBehaviour
{
	public bool isOwner;

	[SerializeField]
	private float mass;

	private Vector3 impact;

	private CharacterController character;

	[SerializeField]
	private float airdeceleration;

	[SerializeField]
	private float deceleration;

	[SerializeField]
	private int maxRebond;

	[SerializeField]
	private float groundDetectionSlopeLimit;

	[SerializeField]
	private float ragdollEjectForce;

	[SerializeField]
	private LayerMask playerLayer;

	[SerializeField]
	private LayerMask bodyLayer;

	[SerializeField]
	private LayerMask rebondLayer;

	[SerializeField]
	private GameObject hitVfx;

	[SerializeField]
	private GameObject explosionVfx;

	[SerializeField]
	private AudioClip hitClip;

	[SerializeField]
	private AudioClip explosionClip;

	[SerializeField]
	private float gravity;

	private float _gravity;

	[SerializeField]
	private float friction;

	private float _force;

	[SerializeField]
	private float timeBeforeExplosion;

	[SerializeField]
	private float explosionRadius;

	private float explosionTimer;

	[SerializeField]
	private float rebondForce;

	private bool isGrounded;

	[Header("Screenshake values")]
	[SerializeField]
	private float duration;

	[SerializeField]
	private float minStrength;

	[SerializeField]
	private float maxStrength;

	[SerializeField]
	private int vibrato;

	[SerializeField]
	private float randomness;

	[SerializeField]
	private Ease shakeEase;

	[SerializeField]
	private float maxDistance;

	private bool touched;

	private bool touched2;

	private GameObject _gun;

	private PlayerHealth[] ph2;

	private float _passedTime;

	private GameObject _rootObject;

	private AudioSource audio;

	[HideInInspector]
	public Weapon weapon;

	private Vector3 currentPosition;

	private Vector3 lastPosition;

	private Vector3 velocity;

	private float safeTimer;

	private void Awake()
	{
	}

	public void Initialize(Vector3 direction, float force, float passedTime, GameObject rootObject, GameObject gun)
	{
	}

	public void AddForce(Vector3 dir, float force)
	{
	}

	private void OnControllerColliderHit(ControllerColliderHit collision)
	{
	}

	private void Update()
	{
	}

	private void HandleExplosion()
	{
	}
}
