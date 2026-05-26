using DG.Tweening;
using UnityEngine;

public class PredictedProjectile : MonoBehaviour
{
	[HideInInspector]
	public bool isOwner;

	private Vector3 _direction;

	private float _passedTime;

	private float actualPassedTime;

	[SerializeField]
	private float MOVE_RATE;

	[SerializeField]
	private float radius;

	[SerializeField]
	private float explosionRadius;

	[SerializeField]
	private bool explosionBullet;

	[SerializeField]
	private bool spawnObject;

	[SerializeField]
	private GameObject objToSpawn;

	[SerializeField]
	private float bumpForce;

	[SerializeField]
	private bool orientateVfx;

	[SerializeField]
	private float launchOffset;

	[SerializeField]
	private bool shouldDestroy;

	[SerializeField]
	private float damage;

	[SerializeField]
	private bool skipSafeStartTimer;

	[SerializeField]
	private bool destroySelf;

	[SerializeField]
	private float ragdollEjectForce;

	[SerializeField]
	private LayerMask playerLayer;

	[SerializeField]
	private LayerMask bodyLayer;

	[SerializeField]
	private LayerMask headLayer;

	[SerializeField]
	private AudioClip hitClip;

	[SerializeField]
	private AudioClip launchClip;

	[SerializeField]
	private GameObject hitVfx;

	[SerializeField]
	private GameObject bloodVfx;

	[SerializeField]
	private GameObject headBloodVfx;

	[SerializeField]
	private GameObject bloodSplatter;

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

	private GameObject _gun;

	[SerializeField]
	private GameObject graph;

	private PlayerHealth[] ph2;

	private PlayerHealth[] ph3;

	private bool backupRaycast;

	[HideInInspector]
	public Weapon weapon;

	[Space]
	[SerializeField]
	private GameObject explosionDecal;

	[SerializeField]
	private bool SurfacesImpact;

	[SerializeField]
	private GameObject concreteHitImpact;

	[SerializeField]
	private GameObject sandHitImpact;

	[SerializeField]
	private GameObject dirtHitImpact;

	[SerializeField]
	private GameObject metalHitImpact;

	[SerializeField]
	private GameObject tauleHitImpact;

	[SerializeField]
	private GameObject waterHitImpact;

	[SerializeField]
	private GameObject woodHitImpact;

	[SerializeField]
	private GameObject softbodyHitImpact;

	[SerializeField]
	private bool SurfacesVFX;

	[SerializeField]
	private GameObject sandHitFx;

	[SerializeField]
	private GameObject dirtHitFx;

	[SerializeField]
	private GameObject metalHitFx;

	[SerializeField]
	private GameObject tauleHitFx;

	[SerializeField]
	private GameObject waterHitFx;

	[SerializeField]
	private GameObject woodHitFx;

	[SerializeField]
	private GameObject softbodyHitFx;

	[SerializeField]
	private GameObject bulletHole;

	private Vector3 currentPosition;

	private Vector3 lastPosition;

	private Vector3 velocity;

	private bool headshot;

	private bool isGlass;

	private float distanceTraveled;

	[SerializeField]
	private float backupRayLength;

	private bool touched;

	private bool touched2;

	[SerializeField]
	private bool prophet;

	private bool prophetHit;

	[SerializeField]
	private GameObject hitMarker;

	[SerializeField]
	private AudioClip hitSfx;

	private GameObject marker;

	private bool sendKillLog;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnHit(Vector3 position, Vector3 normal)
	{
	}

	private void StartNewRound()
	{
	}

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

	private void HitMarker(bool head)
	{
	}

	private void SendKillLog(PlayerHealth enemyHealth)
	{
	}

	public void KillShockWave()
	{
	}

	private void Glass()
	{
	}

	private void SpawnVFX(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	public bool StartsWithVowel(string name)
	{
		return false;
	}
}
