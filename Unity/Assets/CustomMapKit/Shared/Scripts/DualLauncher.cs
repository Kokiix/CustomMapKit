using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using HeathenEngineering.PhysKit;
using UnityEngine;

public class DualLauncher : Weapon
{
	[CompilerGenerated]
	private sealed class _003CLaunchWithDelay_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DualLauncher _003C_003E4__this;

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
		public _003CLaunchWithDelay_003Ed__28(int _003C_003E1__state)
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
	private sealed class _003CRocketJumpCheck_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DualLauncher _003C_003E4__this;

		public Vector3 firstPosition;

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
		public _003CRocketJumpCheck_003Ed__30(int _003C_003E1__state)
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
	private float launchForce;

	[SerializeField]
	private float playerKnockback;

	[SerializeField]
	private PredictedProjectile _projectile;

	[SerializeField]
	private ShrapnelBallistic shrapnelProj;

	[SerializeField]
	private RebondBalle _projectile2;

	[SerializeField]
	private HandGrenadeTwo _projectile3;

	[SerializeField]
	private TrickShot trickShot;

	[SerializeField]
	private Obus _projectile4;

	private const float MAX_PASSED_TIME = 0.3f;

	[SerializeField]
	private bool rebond;

	[SerializeField]
	private bool grenade;

	[SerializeField]
	private bool obus;

	[SerializeField]
	private bool kanye;

	[SerializeField]
	private bool kanyeShoot;

	[SerializeField]
	private bool shrapnel;

	[SerializeField]
	private bool bubble;

	[SerializeField]
	private List<GameObject> kanyeBullets;

	private float fireTimer;

	[Space]
	[SerializeField]
	private GameObject douilleGrenade;

	[SerializeField]
	private float timeBeforeExplosion;

	[SerializeField]
	private AudioClip douilleClip;

	[SerializeField]
	private AudioClip beforeDetonationClip;

	[SerializeField]
	private ParticleSystem grenadeSmoke;

	private float grenadeTimer;

	[SyncVar]
	public bool grenadeOpen;

	public SyncVar<bool> syncVar___grenadeOpen;

	private bool NetworkInitializeEarly_DualLauncher_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_DualLauncher_Assembly_002DCSharp_002Edll;

	public bool SyncAccessor_grenadeOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SetBool(bool value)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CLaunchWithDelay_003Ed__28))]
	private IEnumerator LaunchWithDelay()
	{
		return null;
	}

	private void Fire()
	{
	}

	[IteratorStateMachine(typeof(_003CRocketJumpCheck_003Ed__30))]
	private IEnumerator RocketJumpCheck(Vector3 firstPosition)
	{
		return null;
	}

	private void SpawnProjectile(Vector3 position, Vector3 direction, float passedTime, trickShotData trickShotData, NetworkConnection owner, int id)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ServerFire(Vector3 position, Vector3 direction, uint tick, trickShotData data, int id)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ObserversFire(NetworkConnection owner, Vector3 position, Vector3 direction, uint tick, trickShotData data, int id)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ShootObserversEffect()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void GrenadeSFXServer(int j)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void GrenadeSFX(int j)
	{
	}

	private void LocalSound(int index)
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

	public override void NetworkInitialize___Early()
	{
	}

	public override void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	private void RpcWriter___Server_SetBool_1140765316(bool value)
	{
	}

	private void RpcLogic___SetBool_1140765316(bool value)
	{
	}

	private void RpcReader___Server_SetBool_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_ServerFire_2601673839(Vector3 position, Vector3 direction, uint tick, trickShotData data, int id)
	{
	}

	private void RpcLogic___ServerFire_2601673839(Vector3 position, Vector3 direction, uint tick, trickShotData data, int id)
	{
	}

	private void RpcReader___Server_ServerFire_2601673839(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ObserversFire_1849124528(NetworkConnection owner, Vector3 position, Vector3 direction, uint tick, trickShotData data, int id)
	{
	}

	private void RpcLogic___ObserversFire_1849124528(NetworkConnection owner, Vector3 position, Vector3 direction, uint tick, trickShotData data, int id)
	{
	}

	private void RpcReader___Observers_ObserversFire_1849124528(PooledReader PooledReader0, Channel channel)
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

	private void RpcWriter___Server_GrenadeSFXServer_3316948804(int j)
	{
	}

	private void RpcLogic___GrenadeSFXServer_3316948804(int j)
	{
	}

	private void RpcReader___Server_GrenadeSFXServer_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_GrenadeSFX_3316948804(int j)
	{
	}

	private void RpcLogic___GrenadeSFX_3316948804(int j)
	{
	}

	private void RpcReader___Observers_GrenadeSFX_3316948804(PooledReader PooledReader0, Channel channel)
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

	public virtual bool ReadSyncVar___DualLauncher(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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
