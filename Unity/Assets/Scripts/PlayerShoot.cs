using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : NetworkBehaviour
{
	public PlayerControls playerControls;

	private InputAction fire1;

	private InputAction fire2;

	[SerializeField]
	private LayerMask playerLayer;

	public float timeBetweenFire;

	public int damage;

	private float fireTimer;

	private Camera cam;

	private bool NetworkInitializeEarly_PlayerShoot_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PlayerShoot_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void Fire(InputAction.CallbackContext ctx)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void ShootServer(float damageToGive, Vector3 position, Vector3 direction)
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

	private void RpcWriter___Server_ShootServer_1867452766(float damageToGive, Vector3 position, Vector3 direction)
	{
	}

	private void RpcLogic___ShootServer_1867452766(float damageToGive, Vector3 position, Vector3 direction)
	{
	}

	private void RpcReader___Server_ShootServer_1867452766(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
