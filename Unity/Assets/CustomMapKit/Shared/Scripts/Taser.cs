using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class Taser : Weapon
{
	[Header("Weapon Specials")]
	[SerializeField]
	private float chargeTime;

	[SerializeField]
	private AudioClip reloadClip;

	[SerializeField]
	private float stunTime;

	[SerializeField]
	private Vector3 boxdimensions;

	[Space]
	[SerializeField]
	private MeshRenderer light;

	[SerializeField]
	private Material chargingMat;

	[SerializeField]
	private Material readyMat;

	[SerializeField]
	private AudioSource chargingAudio;

	[SerializeField]
	private GameObject readyVfx;

	private float fireTimer;

	private PlayerHealth enemyHealth;

	private bool NetworkInitializeEarly_Taser_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Taser_Assembly_002DCSharp_002Edll;

	private void Update()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SetVfxActive(bool active)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SetVfxActiveObservers(bool active)
	{
	}

	private void Fire()
	{
	}

	private void ShootServer(float damageToGive, Vector3 position, Vector3 direction)
	{
	}

	[ServerRpc]
	private void TaserEnemy(PlayerHealth enemyHealth)
	{
	}

	[TargetRpc]
	private void TaserEnemyTarget(NetworkConnection conn, PlayerHealth enemyHealth)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ShootServerEffect()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ShootObserversEffect()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SpawnBulletTrailServer(Vector3 hitPoint)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SpawnBulletTrail(Vector3 hitPoint)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SpawnVFXServer(int index, Vector3 hitPoint, Vector3 hitNormal)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SpawnVFX(int index, Vector3 hitPoint, Vector3 hitNormal)
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

	private void RpcWriter___Server_SetVfxActive_1140765316(bool active)
	{
	}

	private void RpcLogic___SetVfxActive_1140765316(bool active)
	{
	}

	private void RpcReader___Server_SetVfxActive_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SetVfxActiveObservers_1140765316(bool active)
	{
	}

	private void RpcLogic___SetVfxActiveObservers_1140765316(bool active)
	{
	}

	private void RpcReader___Observers_SetVfxActiveObservers_1140765316(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_TaserEnemy_1722911636(PlayerHealth enemyHealth)
	{
	}

	private void RpcLogic___TaserEnemy_1722911636(PlayerHealth enemyHealth)
	{
	}

	private void RpcReader___Server_TaserEnemy_1722911636(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Target_TaserEnemyTarget_4033860311(NetworkConnection conn, PlayerHealth enemyHealth)
	{
	}

	private void RpcLogic___TaserEnemyTarget_4033860311(NetworkConnection conn, PlayerHealth enemyHealth)
	{
	}

	private void RpcReader___Target_TaserEnemyTarget_4033860311(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ShootServerEffect_2166136261()
	{
	}

	private void RpcLogic___ShootServerEffect_2166136261()
	{
	}

	private void RpcReader___Server_ShootServerEffect_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
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

	private void RpcWriter___Server_SpawnBulletTrailServer_4276783012(Vector3 hitPoint)
	{
	}

	private void RpcLogic___SpawnBulletTrailServer_4276783012(Vector3 hitPoint)
	{
	}

	private void RpcReader___Server_SpawnBulletTrailServer_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SpawnBulletTrail_4276783012(Vector3 hitPoint)
	{
	}

	private void RpcLogic___SpawnBulletTrail_4276783012(Vector3 hitPoint)
	{
	}

	private void RpcReader___Observers_SpawnBulletTrail_4276783012(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SpawnVFXServer_2552092910(int index, Vector3 hitPoint, Vector3 hitNormal)
	{
	}

	private void RpcLogic___SpawnVFXServer_2552092910(int index, Vector3 hitPoint, Vector3 hitNormal)
	{
	}

	private void RpcReader___Server_SpawnVFXServer_2552092910(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SpawnVFX_2552092910(int index, Vector3 hitPoint, Vector3 hitNormal)
	{
	}

	private void RpcLogic___SpawnVFX_2552092910(int index, Vector3 hitPoint, Vector3 hitNormal)
	{
	}

	private void RpcReader___Observers_SpawnVFX_2552092910(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
