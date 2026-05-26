using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FishNet.Component.Utility;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using TMPro;
using UnityEngine;

public class PlayerHealth : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHealth _003C_003E4__this;

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
		public _003CStart_003Ed__36(int _003C_003E1__state)
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
	private sealed class _003CUnfreezePlayer_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public PlayerHealth _003C_003E4__this;

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
		public _003CUnfreezePlayer_003Ed__38(int _003C_003E1__state)
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
	private sealed class _003CSafeDeathFix_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHealth _003C_003E4__this;

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
		public _003CSafeDeathFix_003Ed__40(int _003C_003E1__state)
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

	[SyncVar]
	public float health;

	public float fullHealth;

	public Vector3 spawn;

	[HideInInspector]
	public FirstPersonController controller;

	private float respawnTimer;

	private float sceneTimer;

	[SyncVar]
	public bool canMove;

	[SyncVar]
	public PlayerValues playerValues;

	[SyncVar]
	public Transform killer;

	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public bool isKilled;

	[SyncVar]
	public bool isShot;

	[SyncVar]
	public Vector3 lastKillDirection;

	public bool shouldBounce;

	public bool shouldDropWeapon;

	public bool isDeadFromTargetRpc;

	public Vector3 bounceDirection;

	public float bounceForce;

	[SerializeField]
	private GameObject[] bodyParts;

	[SerializeField]
	private GameObject aboubiRagdoll;

	[SerializeField]
	private Vector3 killCamRagdollOffset;

	[SerializeField]
	private float directionOffset;

	[SerializeField]
	private GameObject bloodFX;

	[SerializeField]
	private HealthTween tweenScript;

	[SerializeField]
	private CameraEffect camHit;

	private TMP_Text healthDisplay;

	public GameObject graphics;

	private GameObject mainCamObject;

	private KillCam killCamScript;

	private Transform playerCamera;

	private float tempHealth;

	private bool spawnedRagdoll;

	[HideInInspector]
	public bool suicide;

	[HideInInspector]
	public bool fellVoid;

	private PingDisplay PingDisplay;

	private float count;

	public SyncVar<float> syncVar___health;

	public SyncVar<bool> syncVar___canMove;

	public SyncVar<PlayerValues> syncVar___playerValues;

	public SyncVar<Transform> syncVar___killer;

	public SyncVar<bool> syncVar___isKilled;

	public SyncVar<bool> syncVar___isShot;

	public SyncVar<Vector3> syncVar___lastKillDirection;

	private bool NetworkInitializeEarly_PlayerHealth_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PlayerHealth_Assembly_002DCSharp_002Edll;

	public float SyncAccessor_health
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool SyncAccessor_canMove
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public PlayerValues SyncAccessor_playerValues
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Transform SyncAccessor_killer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool SyncAccessor_isKilled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SyncAccessor_isShot
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 SyncAccessor_lastKillDirection
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public virtual void Awake()
	{
	}

	[IteratorStateMachine(typeof(_003CStart_003Ed__36))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CUnfreezePlayer_003Ed__38))]
	public IEnumerator UnfreezePlayer(float time)
	{
		return null;
	}

	[ServerRpc]
	private void UnfreezePlayerServer()
	{
	}

	[IteratorStateMachine(typeof(_003CSafeDeathFix_003Ed__40))]
	private IEnumerator SafeDeathFix()
	{
		return null;
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	public void RemoveHealth(float damage)
	{
	}

	[ObserversRpc]
	private void HitFeedbackObservers()
	{
	}

	public void BumpPlayer(Vector3 dir, float force)
	{
	}

	private void BumpPlayerObservers(Vector3 dir, float force)
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	public void SetKiller(Transform tempKiller)
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	public void ChangeKilledState(bool tempBool)
	{
	}

	[ObserversRpc]
	private void RemoveHealthObservers()
	{
	}

	public void Dismemberment(string col)
	{
	}

	public void HitFeeback()
	{
	}

	public void Explode(bool explode, bool dismemberment, string memberName, Vector3 ejectForceDir, float force, Vector3 position)
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	public void ExplodeServer(bool explode, bool dismemberment, string memberName, Vector3 ejectForceDir, float force, Vector3 position)
	{
	}

	[ObserversRpc(RunLocally = true)]
	private void ExplodeForAll(bool explode, bool dismemberment, string memberName, Vector3 ejectForceDir, float force, Vector3 position)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void DisablePlayerObjectWhenKilled()
	{
	}

	[ObserversRpc]
	private void DisablePlayerObjectForAll()
	{
	}

	private void Hat(GameObject obj, Vector3 dir)
	{
	}

	[ServerRpc(RunLocally = true)]
	public void DespawnObject()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void DespawnObjectObservers()
	{
	}

	public void KillCam()
	{
	}

	private void OnDisable()
	{
	}

	public void AddForce(Vector3 force, float factor)
	{
	}

	public void LocalScreenshake(float duration, float strength, int vibrato, float randomness, Ease shakeEase)
	{
	}

	private GameObject FindRecursive(string name, Transform root)
	{
		return null;
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	public void TaserEnemy(PlayerHealth enemyHealth, float stunTime)
	{
	}

	[TargetRpc]
	private void TaserEnemyTarget(NetworkConnection conn, PlayerHealth enemyHealth, float stunTime)
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

	private void RpcWriter___Server_UnfreezePlayerServer_2166136261()
	{
	}

	private void RpcLogic___UnfreezePlayerServer_2166136261()
	{
	}

	private void RpcReader___Server_UnfreezePlayerServer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_RemoveHealth_431000436(float damage)
	{
	}

	public void RpcLogic___RemoveHealth_431000436(float damage)
	{
	}

	private void RpcReader___Server_RemoveHealth_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_HitFeedbackObservers_2166136261()
	{
	}

	private void RpcLogic___HitFeedbackObservers_2166136261()
	{
	}

	private void RpcReader___Observers_HitFeedbackObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SetKiller_3068987916(Transform tempKiller)
	{
	}

	public void RpcLogic___SetKiller_3068987916(Transform tempKiller)
	{
	}

	private void RpcReader___Server_SetKiller_3068987916(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_ChangeKilledState_1140765316(bool tempBool)
	{
	}

	public void RpcLogic___ChangeKilledState_1140765316(bool tempBool)
	{
	}

	private void RpcReader___Server_ChangeKilledState_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_RemoveHealthObservers_2166136261()
	{
	}

	private void RpcLogic___RemoveHealthObservers_2166136261()
	{
	}

	private void RpcReader___Observers_RemoveHealthObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ExplodeServer_576886416(bool explode, bool dismemberment, string memberName, Vector3 ejectForceDir, float force, Vector3 position)
	{
	}

	public void RpcLogic___ExplodeServer_576886416(bool explode, bool dismemberment, string memberName, Vector3 ejectForceDir, float force, Vector3 position)
	{
	}

	private void RpcReader___Server_ExplodeServer_576886416(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ExplodeForAll_576886416(bool explode, bool dismemberment, string memberName, Vector3 ejectForceDir, float force, Vector3 position)
	{
	}

	private void RpcLogic___ExplodeForAll_576886416(bool explode, bool dismemberment, string memberName, Vector3 ejectForceDir, float force, Vector3 position)
	{
	}

	private void RpcReader___Observers_ExplodeForAll_576886416(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_DisablePlayerObjectWhenKilled_2166136261()
	{
	}

	public void RpcLogic___DisablePlayerObjectWhenKilled_2166136261()
	{
	}

	private void RpcReader___Server_DisablePlayerObjectWhenKilled_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_DisablePlayerObjectForAll_2166136261()
	{
	}

	private void RpcLogic___DisablePlayerObjectForAll_2166136261()
	{
	}

	private void RpcReader___Observers_DisablePlayerObjectForAll_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_DespawnObject_2166136261()
	{
	}

	public void RpcLogic___DespawnObject_2166136261()
	{
	}

	private void RpcReader___Server_DespawnObject_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_DespawnObjectObservers_2166136261()
	{
	}

	private void RpcLogic___DespawnObjectObservers_2166136261()
	{
	}

	private void RpcReader___Observers_DespawnObjectObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_TaserEnemy_4069068711(PlayerHealth enemyHealth, float stunTime)
	{
	}

	public void RpcLogic___TaserEnemy_4069068711(PlayerHealth enemyHealth, float stunTime)
	{
	}

	private void RpcReader___Server_TaserEnemy_4069068711(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Target_TaserEnemyTarget_865840858(NetworkConnection conn, PlayerHealth enemyHealth, float stunTime)
	{
	}

	private void RpcLogic___TaserEnemyTarget_865840858(NetworkConnection conn, PlayerHealth enemyHealth, float stunTime)
	{
	}

	private void RpcReader___Target_TaserEnemyTarget_865840858(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___PlayerHealth(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
