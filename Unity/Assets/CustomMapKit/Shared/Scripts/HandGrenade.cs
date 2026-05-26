using UnityEngine;

public class HandGrenade : MonoBehaviour
{
	private Vector3 _direction;

	private float _passedTime;

	[SerializeField]
	private float MOVE_RATE;

	[SerializeField]
	private float radius;

	[SerializeField]
	private float explosionRadius;

	[SerializeField]
	private float rebonds;

	[SerializeField]
	private float rebondFactor;

	[SerializeField]
	private float rebondDecel;

	[SerializeField]
	private float rebondDrag;

	[SerializeField]
	private float ragdollEjectForce;

	[SerializeField]
	private GameObject vfx;

	[SerializeField]
	private LayerMask playerLayer;

	[SerializeField]
	private LayerMask bodyLayer;

	[SerializeField]
	private GameObject hitVfx;

	[SerializeField]
	private GameObject explosionVfx;

	[SerializeField]
	private AudioClip hitClip;

	[SerializeField]
	private AudioClip explosionClip;

	private GameObject _rootObject;

	private AudioSource audio;

	[SerializeField]
	private bool useGravity;

	[SerializeField]
	private float gravityStart;

	[SerializeField]
	private float gravity;

	private float _gravity;

	[SerializeField]
	private bool usePhysics;

	[SerializeField]
	private float friction;

	public float explosionTimer;

	[SerializeField]
	private float timeBeforeExplosion;

	private float _force;

	private bool backupRaycast;

	private bool forwardCast;

	private float safeTimer;

	private GameObject _gun;

	private Vector3 lastFrameVelocity;

	[HideInInspector]
	public Weapon weapon;

	private Vector3 currentPosition;

	private Vector3 lastPosition;

	private Vector3 velocity;

	[SerializeField]
	private float backupRayLength;

	[SerializeField]
	private float backupRayDistance;

	[SerializeField]
	private float forwardCastLength;

	private Vector3 firstNormal;

	private Vector3 secondNormal;

	private Vector3 lastVel;

	private void Awake()
	{
	}

	public void Initialize(Vector3 direction, float force, float passedTime, GameObject rootObject, GameObject gun)
	{
	}

	private void Update()
	{
	}

	private void Move()
	{
	}

	private void HandleCollision()
	{
	}

	private void HandleExplosion()
	{
	}
}
