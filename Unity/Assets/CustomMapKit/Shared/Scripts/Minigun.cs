using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using LambdaTheDev.NetworkAudioSync;
using UnityEngine;

public class Minigun : Weapon
{
	[CompilerGenerated]
	private sealed class _003CReload_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigun _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CReload_003Ed__38(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CBurstFire_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Minigun _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CBurstFire_003Ed__39(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Weapon Specials")]
	[SerializeField]
	private float reloadTime;

	[SerializeField]
	private AudioClip reloadClip;

	[SerializeField]
	private AudioClip releaseClip;

	[SerializeField]
	private float timeBeforeShooting;

	[SerializeField]
	private Transform rotativePart;

	[SerializeField]
	private float rotationSpeed;

	private float fireTimer;

	private bool touched;

	private Vector3 spread;

	private float shootTimer;

	private bool pressed;

	private bool released;

	private bool noammoBool;

	private NetworkAudioSource networkAudioSource;

	private bool hitOK;

	private PlayerHealth enemyHealth;

	private bool NetworkInitializeEarly_Minigun_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Minigun_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	private void Update()
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

	private void Fire()
	{
	}

	private void ShootServer(float damageToGive, Vector3 position, Vector3 direction)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void RemoveAmmo()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void GiveDamage(float damageToGive, PlayerHealth enemyHealth, string name)
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
	private void ShootServerEffect()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void PlayReleaseClip()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void PlayReleaseClipObservers()
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
	private void SpawnVFXServer(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SpawnVFX(int index, Vector3 hitPoint, Vector3 hitNormal, string surface, Transform parent)
	{
	}

	private void LocalSound(int index)
	{
	}

	[IteratorStateMachine(typeof(_003CReload_003Ed__38))]
	private IEnumerator Reload()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBurstFire_003Ed__39))]
	private IEnumerator BurstFire()
	{
		return null;
	}

	[ServerRpc]
	private void SupressionServer(Transform supp)
	{
	}

	[ObserversRpc]
	private void SuppressionTarget(Transform supp)
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

	private void RpcWriter___Server_RemoveAmmo_2166136261()
	{
	}

	private void RpcLogic___RemoveAmmo_2166136261()
	{
	}

	private void RpcReader___Server_RemoveAmmo_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
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

	private void RpcWriter___Server_ShootServerEffect_2166136261()
	{
	}

	private void RpcLogic___ShootServerEffect_2166136261()
	{
	}

	private void RpcReader___Server_ShootServerEffect_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_PlayReleaseClip_2166136261()
	{
	}

	private void RpcLogic___PlayReleaseClip_2166136261()
	{
	}

	private void RpcReader___Server_PlayReleaseClip_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlayReleaseClipObservers_2166136261()
	{
	}

	private void RpcLogic___PlayReleaseClipObservers_2166136261()
	{
	}

	private void RpcReader___Observers_PlayReleaseClipObservers_2166136261(PooledReader PooledReader0, Channel channel)
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

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
