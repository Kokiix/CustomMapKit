using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using FishNet.Connection;
using FishNet.Managing;
using FishNet.Managing.Transporting;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using HeathenEngineering.SteamworksIntegration;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class ClientInstance : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAddPlayerToHistory_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientInstance self;

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
		public _003CAddPlayerToHistory_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CStopPlayerRunning_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ClientInstance _003C_003E4__this;

		public int id;

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
		public _003CStopPlayerRunning_003Ed__26(int _003C_003E1__state)
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

	public static ClientInstance Instance;

	public static Dictionary<int, ClientInstance> playerInstances;

	public bool textMuted;

	public PlayerManager PlayerSpawner;

	public bool alreadySpawned;

	public int ConnectionID;

	[FormerlySerializedAs("PlayerIdNumber")]
	public int PlayerId;

	public ulong PlayerSteamID;

	public string PlayerName;

	private static readonly Regex PlayerNameTagRegex;

	public bool Ready;

	private NetworkManager networkManager;

	private TransportManager transportManager;

	private PauseManager pauseManager;

	[HideInInspector]
	public bool nonSteamworksTransport;

	private UnityEngine.InputSystem.InputAction record;

	private PlayerControls playerControls;

	[SerializeField]
	private AudioClip joinSfx;

	[SerializeField]
	private AudioClip leaveSfx;

	[SerializeField]
	public VoiceStream vstream;

	[SerializeField]
	private VoiceRecorder vstreamRecorder;

	public AudioSource voiceChatSource;

	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public bool IsTalking;

	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public bool IsTyping;

	public SyncVar<bool> syncVar___IsTalking;

	public SyncVar<bool> syncVar___IsTyping;

	private bool NetworkInitializeEarly_ClientInstance_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_ClientInstance_Assembly_002DCSharp_002Edll;

	public string PlayerNameTag => null;

	public bool SyncAccessor_IsTalking
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SyncAccessor_IsTyping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static string ReplaceAllPlayerNameTags(string inputString)
	{
		return null;
	}

	public override void OnStartClient()
	{
	}

	[ServerRpc]
	private void ReportModsToServer(string[] modNames)
	{
	}

	[ObserversRpc(ExcludeOwner = true)]
	private void ReceiveModsFromServer(string[] modNames)
	{
	}

	[IteratorStateMachine(typeof(_003CAddPlayerToHistory_003Ed__25))]
	private IEnumerator AddPlayerToHistory(ClientInstance self)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CStopPlayerRunning_003Ed__26))]
	private IEnumerator StopPlayerRunning(int id)
	{
		return null;
	}

	private void SetSyncValues(NetworkObject newPlayer)
	{
	}

	[ObserversRpc]
	private void UpdateOnClients(int maxPlayers)
	{
	}

	[ContextMenu("UpdateOnClients")]
	public void UpdateOnClients()
	{
	}

	[ObserversRpc(BufferLast = true)]
	private void AddNewPlayer(NetworkConnection owner, NetworkObject newPlayer, int id, ulong steamid)
	{
	}

	[ObserversRpc]
	private void RunIntoLobby(int id)
	{
	}

	[TargetRpc]
	private void InitiateClient(NetworkConnection conn, int id)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void UpdateServerMaxPlayers()
	{
	}

	[ObserversRpc]
	private void UpdateObserversMaxPlayers(int maxPlayers)
	{
	}

	public void ChangeReady()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void ServerSetPlayerReady()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void ServerSetPlayerReadyState(bool state)
	{
	}

	[ObserversRpc(BufferLast = true)]
	private void PlayerReadyUpdate(bool newValue)
	{
	}

	[ObserversRpc]
	private void PlayerReadyUpdated()
	{
	}

	private void OnDisable()
	{
	}

	public virtual void Awake()
	{
	}

	private void Update()
	{
	}

	[ServerRpc]
	public void DressAboubi(GameObject hat, int matIndex, int cigIndex, int id)
	{
	}

	[ObserversRpc(BufferLast = true)]
	public void DressAboubiObservers(GameObject hat, int matIndex, int cigIndex, int id)
	{
	}

	[ServerRpc]
	public void PlayVoiceChat(byte[] data)
	{
	}

	[ObserversRpc]
	public void PlayVoiceChatObservers(byte[] data)
	{
	}

	private void VoiceChat()
	{
	}

	[ServerRpc(RunLocally = true)]
	public void SetTalking(bool isTalking)
	{
	}

	[ServerRpc(RunLocally = true)]
	public void SetTyping(bool isTyping)
	{
	}

	private void MenuAnimation()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void MenuAnimationServer(int index, int id)
	{
	}

	[ObserversRpc]
	public void MenuAnimationObservers(int index, int id)
	{
	}

	public void KickSelf()
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

	private void RpcWriter___Server_ReportModsToServer_1782520955(string[] modNames)
	{
	}

	private void RpcLogic___ReportModsToServer_1782520955(string[] modNames)
	{
	}

	private void RpcReader___Server_ReportModsToServer_1782520955(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ReceiveModsFromServer_1782520955(string[] modNames)
	{
	}

	private void RpcLogic___ReceiveModsFromServer_1782520955(string[] modNames)
	{
	}

	private void RpcReader___Observers_ReceiveModsFromServer_1782520955(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_UpdateOnClients_3316948804(int maxPlayers)
	{
	}

	private void RpcLogic___UpdateOnClients_3316948804(int maxPlayers)
	{
	}

	private void RpcReader___Observers_UpdateOnClients_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_AddNewPlayer_2166193949(NetworkConnection owner, NetworkObject newPlayer, int id, ulong steamid)
	{
	}

	private void RpcLogic___AddNewPlayer_2166193949(NetworkConnection owner, NetworkObject newPlayer, int id, ulong steamid)
	{
	}

	private void RpcReader___Observers_AddNewPlayer_2166193949(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_RunIntoLobby_3316948804(int id)
	{
	}

	private void RpcLogic___RunIntoLobby_3316948804(int id)
	{
	}

	private void RpcReader___Observers_RunIntoLobby_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Target_InitiateClient_2681120339(NetworkConnection conn, int id)
	{
	}

	private void RpcLogic___InitiateClient_2681120339(NetworkConnection conn, int id)
	{
	}

	private void RpcReader___Target_InitiateClient_2681120339(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_UpdateServerMaxPlayers_2166136261()
	{
	}

	public void RpcLogic___UpdateServerMaxPlayers_2166136261()
	{
	}

	private void RpcReader___Server_UpdateServerMaxPlayers_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_UpdateObserversMaxPlayers_3316948804(int maxPlayers)
	{
	}

	private void RpcLogic___UpdateObserversMaxPlayers_3316948804(int maxPlayers)
	{
	}

	private void RpcReader___Observers_UpdateObserversMaxPlayers_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ServerSetPlayerReady_2166136261()
	{
	}

	private void RpcLogic___ServerSetPlayerReady_2166136261()
	{
	}

	private void RpcReader___Server_ServerSetPlayerReady_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_ServerSetPlayerReadyState_1140765316(bool state)
	{
	}

	public void RpcLogic___ServerSetPlayerReadyState_1140765316(bool state)
	{
	}

	private void RpcReader___Server_ServerSetPlayerReadyState_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlayerReadyUpdate_1140765316(bool newValue)
	{
	}

	private void RpcLogic___PlayerReadyUpdate_1140765316(bool newValue)
	{
	}

	private void RpcReader___Observers_PlayerReadyUpdate_1140765316(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_PlayerReadyUpdated_2166136261()
	{
	}

	private void RpcLogic___PlayerReadyUpdated_2166136261()
	{
	}

	private void RpcReader___Observers_PlayerReadyUpdated_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_DressAboubi_2497120398(GameObject hat, int matIndex, int cigIndex, int id)
	{
	}

	public void RpcLogic___DressAboubi_2497120398(GameObject hat, int matIndex, int cigIndex, int id)
	{
	}

	private void RpcReader___Server_DressAboubi_2497120398(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_DressAboubiObservers_2497120398(GameObject hat, int matIndex, int cigIndex, int id)
	{
	}

	public void RpcLogic___DressAboubiObservers_2497120398(GameObject hat, int matIndex, int cigIndex, int id)
	{
	}

	private void RpcReader___Observers_DressAboubiObservers_2497120398(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_PlayVoiceChat_3345084894(byte[] data)
	{
	}

	public void RpcLogic___PlayVoiceChat_3345084894(byte[] data)
	{
	}

	private void RpcReader___Server_PlayVoiceChat_3345084894(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlayVoiceChatObservers_3345084894(byte[] data)
	{
	}

	public void RpcLogic___PlayVoiceChatObservers_3345084894(byte[] data)
	{
	}

	private void RpcReader___Observers_PlayVoiceChatObservers_3345084894(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SetTalking_1140765316(bool isTalking)
	{
	}

	public void RpcLogic___SetTalking_1140765316(bool isTalking)
	{
	}

	private void RpcReader___Server_SetTalking_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SetTyping_1140765316(bool isTyping)
	{
	}

	public void RpcLogic___SetTyping_1140765316(bool isTyping)
	{
	}

	private void RpcReader___Server_SetTyping_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_MenuAnimationServer_1692629761(int index, int id)
	{
	}

	public void RpcLogic___MenuAnimationServer_1692629761(int index, int id)
	{
	}

	private void RpcReader___Server_MenuAnimationServer_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_MenuAnimationObservers_1692629761(int index, int id)
	{
	}

	public void RpcLogic___MenuAnimationObservers_1692629761(int index, int id)
	{
	}

	private void RpcReader___Observers_MenuAnimationObservers_1692629761(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___ClientInstance(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
