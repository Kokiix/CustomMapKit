using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class BumpGun : Weapon
{
	[Header("Weapon Specials")]
	[SerializeField]
	private float launchForce;

	[SerializeField]
	private float playerKnockback;

	[SerializeField]
	private BumpBullet _projectile;

	private const float MAX_PASSED_TIME = 0.3f;

	private float fireTimer;

	private bool NetworkInitializeEarly_BumpGun_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_BumpGun_Assembly_002DCSharp_002Edll;

	private void Update()
	{
	}

	private void Fire()
	{
	}

	private void SpawnProjectile(Vector3 position, Vector3 direction, float passedTime)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ServerFire(Vector3 position, Vector3 direction, uint tick)
	{
	}

	[ObserversRpc(ExcludeOwner = true)]
	private void ObserversFire(Vector3 position, Vector3 direction, uint tick)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ShootObserversEffect()
	{
	}

	private void LocalSound(int index)
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

	private void RpcWriter___Server_ServerFire_2754081237(Vector3 position, Vector3 direction, uint tick)
	{
	}

	private void RpcLogic___ServerFire_2754081237(Vector3 position, Vector3 direction, uint tick)
	{
	}

	private void RpcReader___Server_ServerFire_2754081237(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ObserversFire_2754081237(Vector3 position, Vector3 direction, uint tick)
	{
	}

	private void RpcLogic___ObserversFire_2754081237(Vector3 position, Vector3 direction, uint tick)
	{
	}

	private void RpcReader___Observers_ObserversFire_2754081237(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_ShootObserversEffect_2166136261()
	{
	}

	private void RpcLogic___ShootObserversEffect_2166136261()
	{
	}

	private void RpcReader___Observers_ShootObserversEffect_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
