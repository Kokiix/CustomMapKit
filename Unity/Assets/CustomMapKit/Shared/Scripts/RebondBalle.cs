using UnityEngine;

public class RebondBalle : MonoBehaviour
{
	private Vector3 _direction;

	private float _passedTime;

	[SerializeField]
	private float MOVE_RATE;

	[SerializeField]
	private float radius;

	[SerializeField]
	private float damage;

	[SerializeField]
	private float rebonds;

	[SerializeField]
	private GameObject vfx;

	[SerializeField]
	private LayerMask playerLayer;

	[SerializeField]
	private AudioClip hitClip;

	[SerializeField]
	private GameObject hitVfx;

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

	[SerializeField]
	private float ragdollEjectForce;

	private float _force;

	private bool backupRaycast;

	private bool forwardCast;

	private float safeTimer;

	private GameObject _gun;

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
}
