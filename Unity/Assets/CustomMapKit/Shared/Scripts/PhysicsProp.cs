using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class PhysicsProp : InteractEnvironment
{
	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public bool grabbed;

	private CharacterController physics;

	[SerializeField]
	private LayerMask defaultMask;

	[SerializeField]
	private float launchForce;

	[SerializeField]
	private float distanceFromPlayer;

	[SerializeField]
	private float damage;

	[SerializeField]
	private AudioClip[] hitClips;

	[SerializeField]
	private GameObject bloodImpact;

	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public FirstPersonController playerThatHasGrabbedBarrel;

	private Transform cam;

	[Space]
	[SerializeField]
	public float gravity;

	public Vector3 moveDirection;

	private AudioSource audio;

	private BoxCollider col;

	private bool canHit;

	private bool canThrow;

	private float throwTimer;

	private PlayerPickup LocalPickup;

	private bool shouldPlaySfx;

	private bool shouldPlaySfx2;

	private bool sendKillLog;

	private bool increaseKillAmount;

	[SerializeField]
	private float mass;

	private Vector3 impact;

	private Vector3 customForceFinal;

	[SerializeField]
	public float airdeceleration;

	[SerializeField]
	public float deceleration;

	public SyncVar<bool> syncVar___grabbed;

	public SyncVar<FirstPersonController> syncVar___playerThatHasGrabbedBarrel;

	private bool NetworkInitializeEarly_PhysicsProp_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PhysicsProp_Assembly_002DCSharp_002Edll;

	public bool SyncAccessor_grabbed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FirstPersonController SyncAccessor_playerThatHasGrabbedBarrel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public override void OnFocus()
	{
	}

	public override void OnInteract(Transform player)
	{
	}

	public override void OnLoseFocus()
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	private void CmdInteract(FirstPersonController player)
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	private void SetGrabbed(bool newGrabbed)
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	private void SetPlayer(FirstPersonController player)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void PlaySfx()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void PlaySfxObservers()
	{
	}

	private void Update()
	{
	}

	private void OnControllerColliderHit(ControllerColliderHit collision)
	{
	}

	private void SendKillLog(PlayerHealth enemyHealth)
	{
	}

	public void KillShockWave()
	{
	}

	[ServerRpc]
	private void BumpPlayerServer(Vector3 direction, float force, PlayerHealth ph)
	{
	}

	[TargetRpc]
	private void BumpPlayer(NetworkConnection conn, PlayerHealth enemyHealth, float force, Vector3 direction)
	{
	}

	public void AddForce(Vector3 dir, float force)
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

	private void RpcWriter___Server_CmdInteract_1903182658(FirstPersonController player)
	{
	}

	private void RpcLogic___CmdInteract_1903182658(FirstPersonController player)
	{
	}

	private void RpcReader___Server_CmdInteract_1903182658(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SetGrabbed_1140765316(bool newGrabbed)
	{
	}

	private void RpcLogic___SetGrabbed_1140765316(bool newGrabbed)
	{
	}

	private void RpcReader___Server_SetGrabbed_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SetPlayer_1903182658(FirstPersonController player)
	{
	}

	private void RpcLogic___SetPlayer_1903182658(FirstPersonController player)
	{
	}

	private void RpcReader___Server_SetPlayer_1903182658(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_PlaySfx_2166136261()
	{
	}

	private void RpcLogic___PlaySfx_2166136261()
	{
	}

	private void RpcReader___Server_PlaySfx_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlaySfxObservers_2166136261()
	{
	}

	private void RpcLogic___PlaySfxObservers_2166136261()
	{
	}

	private void RpcReader___Observers_PlaySfxObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_BumpPlayerServer_1076951378(Vector3 direction, float force, PlayerHealth ph)
	{
	}

	private void RpcLogic___BumpPlayerServer_1076951378(Vector3 direction, float force, PlayerHealth ph)
	{
	}

	private void RpcReader___Server_BumpPlayerServer_1076951378(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Target_BumpPlayer_2429708885(NetworkConnection conn, PlayerHealth enemyHealth, float force, Vector3 direction)
	{
	}

	private void RpcLogic___BumpPlayer_2429708885(NetworkConnection conn, PlayerHealth enemyHealth, float force, Vector3 direction)
	{
	}

	private void RpcReader___Target_BumpPlayer_2429708885(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___PhysicsProp(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
