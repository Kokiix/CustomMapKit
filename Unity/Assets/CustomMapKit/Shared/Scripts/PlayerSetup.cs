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

public class PlayerSetup : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGetPlayersName_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CGetPlayersName_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CStartingRound_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerSetup _003C_003E4__this;

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
		public _003CStartingRound_003Ed__45(int _003C_003E1__state)
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
	private Behaviour[] componentsToDisableForEnemy;

	[SerializeField]
	private GameObject[] gameObjectToDisableForEnemy;

	[SerializeField]
	private Behaviour[] componentsToDisableForMe;

	[SerializeField]
	private AudioSource[] audioMuteForMe;

	[SerializeField]
	private GameObject[] gameObjectsToDisableForMe;

	[SerializeField]
	private GameObject[] fpArms;

	[SerializeField]
	private GameObject stunVFX;

	[SerializeField]
	private GameObject colliderParent;

	[SerializeField]
	private GameObject graphics;

	[SerializeField]
	private GameObject suppression;

	[SerializeField]
	private Camera[] cameras;

	[SerializeField]
	private LayerMask lowMask;

	[SerializeField]
	private LayerMask highMask;

	[SyncVar]
	public int mat;

	[SyncVar]
	public int cig;

	[Space]
	[SerializeField]
	private GameObject startLights;

	[SerializeField]
	private GameObject hudObject;

	public Camera sceneCamera;

	private float timer;

	private bool mainCameraActive;

	private FirstPersonController controller;

	[HideInInspector]
	public bool wasMoving;

	private bool canMoveAgain;

	private bool dress;

	public GameObject hat;

	public Material normalMat;

	[SerializeField]
	private Material normalHeadMat;

	[SerializeField]
	private Material stunMat;

	[SerializeField]
	private Material stunHeadMat;

	private float enemyHealth;

	public GameObject[] meshesToChange;

	public GameObject[] fpArmsSuits;

	public Transform hatToWearPosition;

	public SyncVar<int> syncVar___mat;

	public SyncVar<int> syncVar___cig;

	private bool NetworkInitializeEarly_PlayerSetup_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PlayerSetup_Assembly_002DCSharp_002Edll;

	public int SyncAccessor_mat
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SyncAccessor_cig
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[IteratorStateMachine(typeof(_003CGetPlayersName_003Ed__20))]
	private IEnumerator GetPlayersName()
	{
		return null;
	}

	public override void OnStartClient()
	{
	}

	public void ChangeMotionBlur(bool state)
	{
	}

	[ServerRpc]
	public void EnableTaserEffectServer()
	{
	}

	[ObserversRpc(RunLocally = true)]
	private void EnableTaserEffectClient()
	{
	}

	[ServerRpc(RunLocally = true)]
	public void ChangeSkinWidth(float value)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	public void ChangeSkinWidthObservers(float value)
	{
	}

	public void HideHUD(bool hide)
	{
	}

	public virtual void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[ServerRpc]
	private void CmdChangeDress(GameObject player, GameObject temphat, Vector3 direction)
	{
	}

	[ObserversRpc(BufferLast = true)]
	private void ChangeDress(GameObject player, GameObject temphat, Vector3 direction)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void StunMatServer(int i)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void StunMatObservers(int i)
	{
	}

	public void StartLights()
	{
	}

	[IteratorStateMachine(typeof(_003CStartingRound_003Ed__45))]
	private IEnumerator StartingRound()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public void EnemyHealth()
	{
	}

	private void SetGameLayerRecursive(GameObject _go, int _layer)
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

	private void RpcWriter___Server_EnableTaserEffectServer_2166136261()
	{
	}

	public void RpcLogic___EnableTaserEffectServer_2166136261()
	{
	}

	private void RpcReader___Server_EnableTaserEffectServer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_EnableTaserEffectClient_2166136261()
	{
	}

	private void RpcLogic___EnableTaserEffectClient_2166136261()
	{
	}

	private void RpcReader___Observers_EnableTaserEffectClient_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ChangeSkinWidth_431000436(float value)
	{
	}

	public void RpcLogic___ChangeSkinWidth_431000436(float value)
	{
	}

	private void RpcReader___Server_ChangeSkinWidth_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ChangeSkinWidthObservers_431000436(float value)
	{
	}

	public void RpcLogic___ChangeSkinWidthObservers_431000436(float value)
	{
	}

	private void RpcReader___Observers_ChangeSkinWidthObservers_431000436(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_CmdChangeDress_1876325648(GameObject player, GameObject temphat, Vector3 direction)
	{
	}

	private void RpcLogic___CmdChangeDress_1876325648(GameObject player, GameObject temphat, Vector3 direction)
	{
	}

	private void RpcReader___Server_CmdChangeDress_1876325648(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ChangeDress_1876325648(GameObject player, GameObject temphat, Vector3 direction)
	{
	}

	private void RpcLogic___ChangeDress_1876325648(GameObject player, GameObject temphat, Vector3 direction)
	{
	}

	private void RpcReader___Observers_ChangeDress_1876325648(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_StunMatServer_3316948804(int i)
	{
	}

	private void RpcLogic___StunMatServer_3316948804(int i)
	{
	}

	private void RpcReader___Server_StunMatServer_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_StunMatObservers_3316948804(int i)
	{
	}

	private void RpcLogic___StunMatObservers_3316948804(int i)
	{
	}

	private void RpcReader___Observers_StunMatObservers_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___PlayerSetup(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
