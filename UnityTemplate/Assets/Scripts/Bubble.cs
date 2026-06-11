using DG.Tweening;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class Bubble : NetworkBehaviour
{
	public bool isOwner;

	private Vector3 impact;

	private CharacterController character;

	[SerializeField]
	private float ragdollEjectForce;

	[SerializeField]
	private float damage;

	[SerializeField]
	private GameObject hitVfx;

	[SerializeField]
	private AudioClip hitClip;

	[SerializeField]
	private Transform graph;

	[SerializeField]
	private float timeBeforeDestroy;

	private float explosionTimer;

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

	private PlayerHealth ph2;

	private float _passedTime;

	private GameObject _rootObject;

	private AudioSource audio;

	private Vector3 currentPosition;

	private Vector3 lastPosition;

	private Vector3 velocity;

	private float safeTimer;

	private bool hit;

	private bool calledExplode;

	private bool increaseKillAmount;

	private bool sendKillLog;

	private bool NetworkInitializeEarly_Bubble_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Bubble_Assembly_002DCSharp_002Edll;

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

	public void Start()
	{
	}

	[ObserversRpc(RunLocally = true)]
	public void Initialize(GameObject rootObject, GameObject gun, float passedTime)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void Update()
	{
	}

	private void HandleExplosion(Vector3 position)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void HandleExplosionServer(Vector3 position)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void Explode(Vector3 position)
	{
	}

	public void KillShockWave()
	{
	}

	private void SendKillLog(PlayerHealth enemyHealth)
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

	private void RpcWriter___Observers_Initialize_3846171640(GameObject rootObject, GameObject gun, float passedTime)
	{
	}

	public void RpcLogic___Initialize_3846171640(GameObject rootObject, GameObject gun, float passedTime)
	{
	}

	private void RpcReader___Observers_Initialize_3846171640(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_HandleExplosionServer_4276783012(Vector3 position)
	{
	}

	private void RpcLogic___HandleExplosionServer_4276783012(Vector3 position)
	{
	}

	private void RpcReader___Server_HandleExplosionServer_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_Explode_4276783012(Vector3 position)
	{
	}

	private void RpcLogic___Explode_4276783012(Vector3 position)
	{
	}

	private void RpcReader___Observers_Explode_4276783012(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
