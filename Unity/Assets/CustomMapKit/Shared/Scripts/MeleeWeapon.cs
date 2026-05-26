using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Component.Animating;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class MeleeWeapon : Weapon
{
	[CompilerGenerated]
	private sealed class _003CFireCoroutine_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MeleeWeapon _003C_003E4__this;

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
		public _003CFireCoroutine_003Ed__33(int _003C_003E1__state)
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
	private GameObject collisionObj;

	[SerializeField]
	private MeleeChildCollision collisionScript;

	[SerializeField]
	private NetworkAnimator attackAnimator;

	[SerializeField]
	private string baseAttackAnim;

	[SerializeField]
	private string baseAttackLeftAnim;

	[SerializeField]
	private string secondAttackAnim;

	[SerializeField]
	private float timeBetweenBaseAttack;

	[SerializeField]
	private float timeBetweenSecondAttack;

	[SerializeField]
	private float baseAttackDuration;

	[SerializeField]
	private float secondAttackDuration;

	[SerializeField]
	private bool propulsion;

	[SerializeField]
	private float basePropulsionAmount;

	[SerializeField]
	private float secondPropulsionAmount;

	[SerializeField]
	private bool bforce;

	[SerializeField]
	private float bforceDecel;

	[SerializeField]
	private float baseAttackDamage;

	[SerializeField]
	private float secondAttackDamage;

	[SerializeField]
	private AudioClip secondAttackClip;

	[SerializeField]
	private AudioClip firstAttackStartClip;

	[SerializeField]
	private AudioClip secondAttackStartClip;

	[Space]
	[SerializeField]
	private bool bounceHolder;

	[SerializeField]
	private float repulseForce;

	[SerializeField]
	private float playerKnockback;

	public int hitsAmount;

	[Space]
	[SerializeField]
	private float firstAttackDelay;

	[SerializeField]
	private float secondAttackDelay;

	[SerializeField]
	private bool minusScale;

	private float fireTimer;

	private bool touched;

	private bool zoomTrigger;

	private bool secondAttackPlaying;

	private bool hitOK;

	private bool NetworkInitializeEarly_MeleeWeapon_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_MeleeWeapon_Assembly_002DCSharp_002Edll;

	private void Update()
	{
	}

	private void Fire()
	{
	}

	[IteratorStateMachine(typeof(_003CFireCoroutine_003Ed__33))]
	private IEnumerator FireCoroutine()
	{
		return null;
	}

	private void TriggerAttack()
	{
	}

	public void BounceHolder()
	{
	}

	public void HitServer(PlayerHealth enemyHealth, Vector3 hitPosition, Vector3 hitNormal, string hitName)
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

	[ObserversRpc]
	private void NextRound()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ShootServerEffect(int x)
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

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ShootObserversEffect(int x)
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

	public override void NetworkInitialize___Early()
	{
	}

	public override void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
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

	private void RpcWriter___Observers_NextRound_2166136261()
	{
	}

	private void RpcLogic___NextRound_2166136261()
	{
	}

	private void RpcReader___Observers_NextRound_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ShootServerEffect_3316948804(int x)
	{
	}

	private void RpcLogic___ShootServerEffect_3316948804(int x)
	{
	}

	private void RpcReader___Server_ShootServerEffect_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
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

	private void RpcWriter___Observers_ShootObserversEffect_3316948804(int x)
	{
	}

	private void RpcLogic___ShootObserversEffect_3316948804(int x)
	{
	}

	private void RpcReader___Observers_ShootObserversEffect_3316948804(PooledReader PooledReader0, Channel channel)
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
