using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Managing.Scened;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using TMPro;
using UnityEngine;

public class SceneMotor : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCanLoadIntoSceneEnable_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneMotor _003C_003E4__this;

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
		public _003CCanLoadIntoSceneEnable_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CDelayLoad_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneMotor _003C_003E4__this;

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
		public _003CDelayLoad_003Ed__43(int _003C_003E1__state)
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
	private sealed class _003CStartGameClients_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
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
		public _003CStartGameClients_003Ed__44(int _003C_003E1__state)
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

	public static SceneMotor Instance;

	public bool firstToXWins;

	[Space]
	[SerializeField]
	public readonly List<string> PlayListMaps;

	public readonly Queue<string> PlayListMapsQueue;

	public readonly HashSet<string> PlayedMaps;

	public List<string> mapsPlayed;

	[SerializeField]
	private string victoryScene;

	[SyncVar]
	public int sceneIndex;

	private string currentSceneName;

	[SerializeField]
	public GameObject _loaderCanvas;

	[SerializeField]
	public TextMeshProUGUI sceneText;

	private TMP_Dropdown roundAmountDropdown;

	[SyncVar]
	public int roundAmount;

	private bool canLoadIntoScene;

	[Space]
	[SerializeField]
	private GameObject explorationText;

	public bool inLoadingScreen;

	public bool testMap;

	public SyncVar<int> syncVar___sceneIndex;

	public SyncVar<int> syncVar___roundAmount;

	private bool NetworkInitializeEarly_SceneMotor_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_SceneMotor_Assembly_002DCSharp_002Edll;

	public int SyncAccessor_sceneIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int SyncAccessor_roundAmount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void IncrementScene()
	{
	}

	public virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CCanLoadIntoSceneEnable_003Ed__19))]
	private IEnumerator CanLoadIntoSceneEnable()
	{
		return null;
	}

	public void OnRoundAmountChange()
	{
	}

	public string GetNextMap()
	{
		return null;
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	public void CmdChangeRoundAmount()
	{
	}

	private void Update()
	{
	}

	public void ChangeNetworkScene()
	{
	}

	public void ServerStartGameScene()
	{
	}

	public void ServerRestartGameScene()
	{
	}

	public void ServerEndGameScene()
	{
	}

	public void ServerLeaveGameScene()
	{
	}

	public void ClientLeaveGameScene()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void ChangeSceneId()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ResetSceneId()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetSceneIdToZero()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void CloseScene(string sceneToClose)
	{
	}

	[ObserversRpc]
	private void CloseScenesObserver(string sceneToClose)
	{
	}

	public void Shuffle(List<string> texts)
	{
	}

	[ServerRpc(RunLocally = true)]
	public void ReturnMenuServer()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ReturnMenuObservers()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void LeaveMatchForAll()
	{
	}

	public void OnLoadSceneStart(SceneLoadStartEventArgs args)
	{
	}

	public void ShowLoadingScreen()
	{
	}

	public void OnLoadSceneEnd(SceneLoadEndEventArgs args)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayLoad_003Ed__43))]
	private IEnumerator DelayLoad()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStartGameClients_003Ed__44))]
	public IEnumerator StartGameClients()
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void EnterScene(string sceneName)
	{
	}

	[ObserversRpc]
	private void EnterSceneForAll()
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

	private void RpcWriter___Server_CmdChangeRoundAmount_2166136261()
	{
	}

	public void RpcLogic___CmdChangeRoundAmount_2166136261()
	{
	}

	private void RpcReader___Server_CmdChangeRoundAmount_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_ChangeSceneId_2166136261()
	{
	}

	private void RpcLogic___ChangeSceneId_2166136261()
	{
	}

	private void RpcReader___Server_ChangeSceneId_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_ResetSceneId_2166136261()
	{
	}

	public void RpcLogic___ResetSceneId_2166136261()
	{
	}

	private void RpcReader___Server_ResetSceneId_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SetSceneIdToZero_2166136261()
	{
	}

	public void RpcLogic___SetSceneIdToZero_2166136261()
	{
	}

	private void RpcReader___Server_SetSceneIdToZero_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_CloseScene_3615296227(string sceneToClose)
	{
	}

	private void RpcLogic___CloseScene_3615296227(string sceneToClose)
	{
	}

	private void RpcReader___Server_CloseScene_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_CloseScenesObserver_3615296227(string sceneToClose)
	{
	}

	private void RpcLogic___CloseScenesObserver_3615296227(string sceneToClose)
	{
	}

	private void RpcReader___Observers_CloseScenesObserver_3615296227(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ReturnMenuServer_2166136261()
	{
	}

	public void RpcLogic___ReturnMenuServer_2166136261()
	{
	}

	private void RpcReader___Server_ReturnMenuServer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ReturnMenuObservers_2166136261()
	{
	}

	private void RpcLogic___ReturnMenuObservers_2166136261()
	{
	}

	private void RpcReader___Observers_ReturnMenuObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_LeaveMatchForAll_2166136261()
	{
	}

	public void RpcLogic___LeaveMatchForAll_2166136261()
	{
	}

	private void RpcReader___Server_LeaveMatchForAll_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_EnterScene_3615296227(string sceneName)
	{
	}

	public void RpcLogic___EnterScene_3615296227(string sceneName)
	{
	}

	private void RpcReader___Server_EnterScene_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_EnterSceneForAll_2166136261()
	{
	}

	private void RpcLogic___EnterSceneForAll_2166136261()
	{
	}

	private void RpcReader___Observers_EnterSceneForAll_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___SceneMotor(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
