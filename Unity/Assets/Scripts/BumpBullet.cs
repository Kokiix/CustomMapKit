using UnityEngine;

public class BumpBullet : MonoBehaviour
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
	private float bumpForce;

	[SerializeField]
	private float bumpDecel;

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

	private float _force;

	private GameObject _gun;

	private PlayerHealth[] ph2;

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
