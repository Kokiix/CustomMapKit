using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using LambdaTheDev.NetworkAudioSync;
using UnityEngine;

public class BeamGun : Weapon
{
	[Header("Weapon Specials")]
	[SerializeField]
	private float launchForce;

	[SerializeField]
	private float playerKnockback;

	[SerializeField]
	private PredictedProjectile _projectile;

	[SerializeField]
	private GameObject muzzleFlash2;

	[SerializeField]
	private AudioClip smallFireClip;

	private const float MAX_PASSED_TIME = 0.3f;

	private float accumulatedPower;

	[SerializeField]
	private AudioSource newSource;

	[SerializeField]
	private float maxChargeTime;

	[SerializeField]
	private bool hasIntermediateStates;

	[SerializeField]
	private float radius;

	private float fireTimer;

	private bool isClicked2;

	private bool isClicked3;

	private bool isClicked4;

	private bool lastInRightHand;

	private bool lastInLeftHand;

	private NetworkAudioSource networkAudioSource;

	private bool hitOK;

	private ParticleSystem tempBeam;

	private bool NetworkInitializeEarly_BeamGun_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_BeamGun_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FireBlast()
	{
	}

	private void Fire()
	{
	}

	private void ShootServer(float damageToGive, Vector3 position, Vector3 direction)
	{
	}

	[ServerRpc(RunLocally = true)]
	public void ServerFX(Vector3 position, Quaternion rotation)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ObserversFX(Vector3 position, Quaternion rotation)
	{
	}

	[ServerRpc]
	private void KillServer(PlayerHealth enemyHealth)
	{
	}

	[TargetRpc]
	private void KillObserver(NetworkConnection conn, ClientInstance client, PlayerHealth enemyHealth)
	{
	}

	[ObserversRpc]
	private void HitFeeback(PlayerHealth enemyHealth)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void GiveDamage(float damageToGive, PlayerHealth enemyHealth, string name)
	{
	}

	[ServerRpc]
	private void SupressionServer(Transform supp)
	{
	}

	[ObserversRpc]
	private void SuppressionTarget(Transform supp)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ShootServerEffect()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ShootObserversEffect2()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ShootServerEffect2()
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
	private void BeamEffectServer(int i)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void BeamEffectObservers(int i)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SoundServerEffect()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SoundObserversEffect()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SoundServerEffect2()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SoundObserversEffect2()
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

	[ServerRpc]
	private void AudioPlay()
	{
	}

	[ServerRpc]
	private void AudioStop()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void CancelChargeEffect()
	{
	}

	[ObserversRpc(RunLocally = true)]
	private void CancelChargeEffectObservers()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SpawnVFXServer(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SpawnVFX(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
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

	private void RpcWriter___Server_ServerFX_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	public void RpcLogic___ServerFX_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	private void RpcReader___Server_ServerFX_3848837105(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ObserversFX_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	private void RpcLogic___ObserversFX_3848837105(Vector3 position, Quaternion rotation)
	{
	}

	private void RpcReader___Observers_ObserversFX_3848837105(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_KillServer_1722911636(PlayerHealth enemyHealth)
	{
	}

	private void RpcLogic___KillServer_1722911636(PlayerHealth enemyHealth)
	{
	}

	private void RpcReader___Server_KillServer_1722911636(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Target_KillObserver_123853379(NetworkConnection conn, ClientInstance client, PlayerHealth enemyHealth)
	{
	}

	private void RpcLogic___KillObserver_123853379(NetworkConnection conn, ClientInstance client, PlayerHealth enemyHealth)
	{
	}

	private void RpcReader___Target_KillObserver_123853379(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_HitFeeback_1722911636(PlayerHealth enemyHealth)
	{
	}

	private void RpcLogic___HitFeeback_1722911636(PlayerHealth enemyHealth)
	{
	}

	private void RpcReader___Observers_HitFeeback_1722911636(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_GiveDamage_324487999(float damageToGive, PlayerHealth enemyHealth, string name)
	{
	}

	private void RpcLogic___GiveDamage_324487999(float damageToGive, PlayerHealth enemyHealth, string name)
	{
	}

	private void RpcReader___Server_GiveDamage_324487999(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SupressionServer_3068987916(Transform supp)
	{
	}

	private void RpcLogic___SupressionServer_3068987916(Transform supp)
	{
	}

	private void RpcReader___Server_SupressionServer_3068987916(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SuppressionTarget_3068987916(Transform supp)
	{
	}

	private void RpcLogic___SuppressionTarget_3068987916(Transform supp)
	{
	}

	private void RpcReader___Observers_SuppressionTarget_3068987916(PooledReader PooledReader0, Channel channel)
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

	private void RpcWriter___Observers_ShootObserversEffect2_2166136261()
	{
	}

	private void RpcLogic___ShootObserversEffect2_2166136261()
	{
	}

	private void RpcReader___Observers_ShootObserversEffect2_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ShootServerEffect2_2166136261()
	{
	}

	private void RpcLogic___ShootServerEffect2_2166136261()
	{
	}

	private void RpcReader___Server_ShootServerEffect2_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
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

	private void RpcWriter___Server_BeamEffectServer_3316948804(int i)
	{
	}

	private void RpcLogic___BeamEffectServer_3316948804(int i)
	{
	}

	private void RpcReader___Server_BeamEffectServer_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_BeamEffectObservers_3316948804(int i)
	{
	}

	private void RpcLogic___BeamEffectObservers_3316948804(int i)
	{
	}

	private void RpcReader___Observers_BeamEffectObservers_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SoundServerEffect_2166136261()
	{
	}

	private void RpcLogic___SoundServerEffect_2166136261()
	{
	}

	private void RpcReader___Server_SoundServerEffect_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SoundObserversEffect_2166136261()
	{
	}

	private void RpcLogic___SoundObserversEffect_2166136261()
	{
	}

	private void RpcReader___Observers_SoundObserversEffect_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SoundServerEffect2_2166136261()
	{
	}

	private void RpcLogic___SoundServerEffect2_2166136261()
	{
	}

	private void RpcReader___Server_SoundServerEffect2_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SoundObserversEffect2_2166136261()
	{
	}

	private void RpcLogic___SoundObserversEffect2_2166136261()
	{
	}

	private void RpcReader___Observers_SoundObserversEffect2_2166136261(PooledReader PooledReader0, Channel channel)
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

	private void RpcWriter___Server_AudioPlay_2166136261()
	{
	}

	private void RpcLogic___AudioPlay_2166136261()
	{
	}

	private void RpcReader___Server_AudioPlay_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_AudioStop_2166136261()
	{
	}

	private void RpcLogic___AudioStop_2166136261()
	{
	}

	private void RpcReader___Server_AudioStop_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_CancelChargeEffect_2166136261()
	{
	}

	private void RpcLogic___CancelChargeEffect_2166136261()
	{
	}

	private void RpcReader___Server_CancelChargeEffect_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_CancelChargeEffectObservers_2166136261()
	{
	}

	private void RpcLogic___CancelChargeEffectObservers_2166136261()
	{
	}

	private void RpcReader___Observers_CancelChargeEffectObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SpawnVFXServer_606331033(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	private void RpcLogic___SpawnVFXServer_606331033(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	private void RpcReader___Server_SpawnVFXServer_606331033(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SpawnVFX_606331033(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	private void RpcLogic___SpawnVFX_606331033(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	private void RpcReader___Observers_SpawnVFX_606331033(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
