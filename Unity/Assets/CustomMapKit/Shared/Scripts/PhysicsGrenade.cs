using DG.Tweening;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class PhysicsGrenade : NetworkBehaviour
{
	[SerializeField]
	private string weaponName;

	public bool isOwner;

	private Vector3 impact;

	private CharacterController character;

	[SerializeField]
	private float ragdollEjectForce;

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

	[SerializeField]
	private AudioClip swooshClip;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private Vector3 rotateAxis;

	[SerializeField]
	private Vector3 vfxScale;

	[SerializeField]
	private Transform graph;

	[SerializeField]
	private GameObject explosionDecal;

	[SerializeField]
	private GameObject bloodSplatter;

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

	private Vector3 currentPosition;

	private Vector3 lastPosition;

	private Vector3 velocity;

	[SerializeField]
	private bool fragGrenade;

	[SerializeField]
	private float numberOfRays;

	[SerializeField]
	private bool stunGrenade;

	[SerializeField]
	private float stunTime;

	private float safeTimer;

	private bool exploded;

	private bool makeBlood;

	private bool sendKillLog;

	private bool suicide;

	private bool increaseKillAmount;

	private int maxHits;

	private int hits;

	private bool NetworkInitializeEarly_PhysicsGrenade_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PhysicsGrenade_Assembly_002DCSharp_002Edll;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void StartNewRound()
	{
	}

	public virtual void Awake()
	{
	}

	private void Start()
	{
	}

	[ObserversRpc(RunLocally = true)]
	public void Initialize(GameObject rootObject, GameObject gun, float passedTime, float grenadeOpenSince)
	{
	}

	private void Update()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ServerHandlerExplosion(Vector3 position)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void HandleExplosion(Vector3 position)
	{
	}

	private void SendKillLog(PlayerHealth enemyHealth)
	{
	}

	private void IncreaseSuicidesAmount()
	{
	}

	public void KillShockWave()
	{
	}

	private void RenderObject(Vector3 direction, float maxDistance)
	{
	}

	private void OnCollisionEnter(Collision col)
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

	private void RpcWriter___Observers_Initialize_4208556499(GameObject rootObject, GameObject gun, float passedTime, float grenadeOpenSince)
	{
	}

	public void RpcLogic___Initialize_4208556499(GameObject rootObject, GameObject gun, float passedTime, float grenadeOpenSince)
	{
	}

	private void RpcReader___Observers_Initialize_4208556499(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ServerHandlerExplosion_4276783012(Vector3 position)
	{
	}

	private void RpcLogic___ServerHandlerExplosion_4276783012(Vector3 position)
	{
	}

	private void RpcReader___Server_ServerHandlerExplosion_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_HandleExplosion_4276783012(Vector3 position)
	{
	}

	private void RpcLogic___HandleExplosion_4276783012(Vector3 position)
	{
	}

	private void RpcReader___Observers_HandleExplosion_4276783012(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
