using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class ProximityMine : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CActivateTrap_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProximityMine _003C_003E4__this;

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
		public _003CActivateTrap_003Ed__36(int _003C_003E1__state)
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

	[SerializeField]
	private string weaponName;

	[SerializeField]
	private float explosionRadius;

	[SerializeField]
	private LayerMask playerLayer;

	[SerializeField]
	private LayerMask bodyLayer;

	[SerializeField]
	private bool instantExplode;

	[SerializeField]
	private float damage;

	[SyncVar]
	public bool detonated;

	[SerializeField]
	private float ragdollEjectForce;

	[SerializeField]
	private GameObject explosionVfx;

	[SerializeField]
	private AudioClip explosionClip;

	[SerializeField]
	private AudioClip bipClip;

	[SyncVar]
	public GameObject _rootObject;

	[SerializeField]
	private GameObject graph;

	[SerializeField]
	private AudioClip activationSound;

	public bool canExplode;

	private AudioSource audio;

	private float bipTimer;

	private PlayerHealth[] ph2;

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

	[Space]
	[SerializeField]
	private Material realMat;

	[SerializeField]
	private GameObject indicator;

	[SyncVar]
	public Weapon weapon;

	[Space]
	[SerializeField]
	private bool stunMine;

	[SerializeField]
	private float stunTime;

	public bool isOwner;

	private bool touched;

	private bool touched2;

	private bool activated;

	private bool sendKillLog;

	private bool suicide;

	private bool increaseKillAmount;

	private bool canActivate;

	[SerializeField]
	private GameObject hitMarker;

	[SerializeField]
	private AudioClip hitSfx;

	private GameObject marker;

	public SyncVar<bool> syncVar___detonated;

	public SyncVar<GameObject> syncVar____rootObject;

	public SyncVar<Weapon> syncVar___weapon;

	private bool NetworkInitializeEarly_ProximityMine_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_ProximityMine_Assembly_002DCSharp_002Edll;

	public bool SyncAccessor_detonated
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObject SyncAccessor__rootObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Weapon SyncAccessor_weapon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void StartNewRound()
	{
	}

	[IteratorStateMachine(typeof(_003CActivateTrap_003Ed__36))]
	private IEnumerator ActivateTrap()
	{
		return null;
	}

	private void Update()
	{
	}

	public void HandleExplosion()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void ExplodeServer()
	{
	}

	[ObserversRpc]
	private void ExplodeObservers()
	{
	}

	private void SendKillLog(PlayerHealth enemyHealth)
	{
	}

	private void IncreaseSuicidesAmount()
	{
	}

	public void KillShockWave()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}

	private void OnTriggerStay(Collider col)
	{
	}

	private void OnTriggerExit(Collider col)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ChangeState()
	{
	}

	private void HitMarker(bool head)
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

	private void RpcWriter___Server_ExplodeServer_2166136261()
	{
	}

	private void RpcLogic___ExplodeServer_2166136261()
	{
	}

	private void RpcReader___Server_ExplodeServer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ExplodeObservers_2166136261()
	{
	}

	private void RpcLogic___ExplodeObservers_2166136261()
	{
	}

	private void RpcReader___Observers_ExplodeObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ChangeState_2166136261()
	{
	}

	public void RpcLogic___ChangeState_2166136261()
	{
	}

	private void RpcReader___Server_ChangeState_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual bool ReadSyncVar___ProximityMine(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
