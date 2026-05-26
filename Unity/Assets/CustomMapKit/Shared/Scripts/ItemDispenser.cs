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
using UnityEngine;

public class ItemDispenser : InteractEnvironment
{
	[CompilerGenerated]
	private sealed class _003CSpawnItem_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ItemDispenser _003C_003E4__this;

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
		public _003CSpawnItem_003Ed__22(int _003C_003E1__state)
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

	public GameObject[] itemsToSpawn;

	public Vector3 restPos;

	[SyncVar]
	public GameObject spawnedItem;

	[SerializeField]
	private Transform origin;

	[SerializeField]
	private Animator anim;

	[SerializeField]
	private AudioClip triggerClip;

	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public float timer;

	private float localTimer;

	[SerializeField]
	private float countdown;

	[Space]
	[SerializeField]
	private Light light;

	[SerializeField]
	private MeshRenderer screen;

	[SerializeField]
	private GameObject availableScreen;

	[SerializeField]
	private GameObject loadingScreen;

	[SerializeField]
	private Color availableLightColor;

	[SerializeField]
	private Color loadingLightColor;

	[SerializeField]
	private Material availableLightMat;

	[SerializeField]
	private Material loadingLightMat;

	private AudioSource audio;

	private GameObject item;

	public SyncVar<GameObject> syncVar___spawnedItem;

	public SyncVar<float> syncVar___timer;

	private bool NetworkInitializeEarly_ItemDispenser_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_ItemDispenser_Assembly_002DCSharp_002Edll;

	public GameObject SyncAccessor_spawnedItem
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float SyncAccessor_timer
	{
		get
		{
			return 0f;
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

	[IteratorStateMachine(typeof(_003CSpawnItem_003Ed__22))]
	private IEnumerator SpawnItem()
	{
		return null;
	}

	public override void OnLoseFocus()
	{
	}

	private void Update()
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	private void CmdTimer()
	{
	}

	[ObserversRpc]
	private void PlaySound()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void SpawnWeapon(GameObject item)
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

	private void RpcWriter___Server_CmdTimer_2166136261()
	{
	}

	private void RpcLogic___CmdTimer_2166136261()
	{
	}

	private void RpcReader___Server_CmdTimer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlaySound_2166136261()
	{
	}

	private void RpcLogic___PlaySound_2166136261()
	{
	}

	private void RpcReader___Observers_PlaySound_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SpawnWeapon_1934289915(GameObject item)
	{
	}

	private void RpcLogic___SpawnWeapon_1934289915(GameObject item)
	{
	}

	private void RpcReader___Server_SpawnWeapon_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual bool ReadSyncVar___ItemDispenser(PooledReader PooledReader0, uint UInt321, bool Boolean2)
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
