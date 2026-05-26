using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Managing;
using FishNet.Object;
using FishySteamworks;
using HeathenEngineering.SteamworksIntegration;
using HeathenEngineering.SteamworksIntegration.UI;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SteamLobby : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CJoinRichPresenceLobbyWithDelayyyyy_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CSteamID lobbyId;

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
		public _003CJoinRichPresenceLobbyWithDelayyyyy_003Ed__64(int _003C_003E1__state)
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
	private sealed class _003CCreateLobbyWithDelay_003Ed__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamLobby _003C_003E4__this;

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
		public _003CCreateLobbyWithDelay_003Ed__72(int _003C_003E1__state)
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
	private sealed class _003CEnterMap_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamLobby _003C_003E4__this;

		public string name;

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
		public _003CEnterMap_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CWaitForAllToConnect_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamLobby _003C_003E4__this;

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
		public _003CWaitForAllToConnect_003Ed__92(int _003C_003E1__state)
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
	private sealed class _003CJoinLobbyWithDelay_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamLobby _003C_003E4__this;

		public CSteamID lobbyID;

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
		public _003CJoinLobbyWithDelay_003Ed__108(int _003C_003E1__state)
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
	private sealed class _003CReloadNetworkManagerCoroutine_003Ed__111 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SteamLobby _003C_003E4__this;

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
		public _003CReloadNetworkManagerCoroutine_003Ed__111(int _003C_003E1__state)
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

	protected Callback<LobbyCreated_t> LobbyCreated;

	protected Callback<GameLobbyJoinRequested_t> JoinRequest;

	protected Callback<LobbyEnter_t> LobbyEntered;

	protected Callback<LobbyMatchList_t> LobbyList;

	protected Callback<LobbyDataUpdate_t> LobbyDataUpdated;

	protected Callback<LobbyInvite_t> LobbyInvited;

	protected Callback<LobbyKicked_t> LobbyKicked;

	protected Callback<LobbyChatUpdate_t> LobbyChatUpdate;

	protected Callback<GameRichPresenceJoinRequested_t> RichPresenceJoinRequested;

	[Header("Lobby Settings")]
	public int maxPlayers;

	public bool _allowMidMatchJoining;

	[Header("Current State (don't touch)")]
	public UserData localSteamUser;

	public ulong CurrentLobbyID;

	public bool inSteamLobby;

	public bool playingTeams;

	public bool findingQuickMatchLobby;

	public List<CSteamID> lobbyIDs;

	public List<NetworkObject> players;

	private float CooldownTimer;

	private float lastActivityTime;

	public static bool ownDlc0;

	public static bool ownDlc1;

	public LobbyManager lobbyManager;

	public string QuickMatchFilterString;

	[Header("GameObject References")]
	[SerializeField]
	private global::FishySteamworks.FishySteamworks _fishySteamworks;

	[SerializeField]
	private GameObject _sceneMotorPrefab;

	public GameObject ShutdownWindow;

	public GameObject LobbyTypeDropdownBeforeLobbyGameObject;

	public GameObject ServerNameObject;

	public GameObject MaxPlayersObject;

	public GameObject MapSelectionWindow;

	public GameObject QuickMatchFilter;

	public TMP_Dropdown LobbyTypeDropdown;

	public TMP_Dropdown LobbyTypeDropdownBeforeLobby;

	public TMP_Dropdown MaxPlayersDropdown;

	public TMP_Dropdown GamemodeDropdown;

	public Toggle enemyOutlineToggle;

	public Toggle friendlyFireToggle;

	public AlphaYoyo ReadyTextScript;

	public MenuHUDTween MapSelectionWindow3D;

	public GameObject LobbyWindow;

	public GameObject LobbiesBrowser;

	public GameObject MatchmakingBanner;

	public GameObject MatchmakingController;

	public GameObject HostButton;

	public GameObject StopButton;

	public GameObject InviteButton;

	public GameObject lobbyInviteInstance;

	public GameObject LobbyIdTextInfo;

	public Transform invitePopupViewport;

	public TextMeshProUGUI LobbyNameText;

	public LobbyIDHandler lobbyIdText;

	public TextMeshProUGUI versionText;

	[SerializeField]
	private MenuHUDTween[] lobby3D;

	public static SteamLobby Instance;

	[Space]
	[SerializeField]
	private MapsManager mapsManager;

	public GameObject PSAObject;

	private bool privateLobby;

	[FormerlySerializedAs("isTestingMap")]
	[HideInInspector]
	public bool isInExplorationMap;

	public bool startAutomatically;

	[Space]
	public string lobbyName;

	public ELobbyType lobbyType;

	private IEnumerator WaitForAllToConnectCoroutine;

	[HideInInspector]
	public bool AllReady;

	public static readonly HashSet<ulong> bannedPlayers;

	private string HostAddress;

	private bool inviteInfo;

	[SerializeField]
	private FriendInviteDropDown friendInviteScript;

	private static PauseManager PauseManager => null;

	private static NetworkManager Manager => null;

	public void SetQuickMatchFilterString(int value)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnRichPresenceJoinRequested(GameRichPresenceJoinRequested_t callback)
	{
	}

	[IteratorStateMachine(typeof(_003CJoinRichPresenceLobbyWithDelayyyyy_003Ed__64))]
	private IEnumerator JoinRichPresenceLobbyWithDelayyyyy(CSteamID lobbyId)
	{
		return null;
	}

	private void AFKTimerThing()
	{
	}

	private void Update()
	{
	}

	public void SetMaxPlayers(TMP_Dropdown _dropdown)
	{
	}

	public void SetAllowMidMatchJoining(bool value)
	{
	}

	public void CreateLobbyDirect()
	{
	}

	public void Create()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateLobbyWithDelay_003Ed__72))]
	private IEnumerator CreateLobbyWithDelay()
	{
		return null;
	}

	public void EnterExplorationMap(string mapName)
	{
	}

	[IteratorStateMachine(typeof(_003CEnterMap_003Ed__76))]
	private IEnumerator EnterMap(string name)
	{
		return null;
	}

	public void SetLobbyType(TMP_Dropdown dropdown)
	{
	}

	public void SetLobbyType(ELobbyType newLobbyType)
	{
	}

	public void SetLobbyType(int value)
	{
	}

	public ELobbyType GetLobbyType(TMP_Dropdown dropdown)
	{
		return default(ELobbyType);
	}

	public void UpdateLobbyType()
	{
	}

	public void SetGamemode(TMP_Dropdown dropdown)
	{
	}

	public void SetGamemode(int value)
	{
	}

	public void SetGamemodeString()
	{
	}

	public void SetStartAutomatically(Toggle toggle)
	{
	}

	public void AutomaticStart()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForAllToConnect_003Ed__92))]
	private IEnumerator WaitForAllToConnect()
	{
		return null;
	}

	public void SetHUDActive(bool active)
	{
	}

	private void OnLobbyCreated(LobbyCreated_t callback)
	{
	}

	private void OnJoinRequest(GameLobbyJoinRequested_t callback)
	{
	}

	public void UpdatePlayerCountDisplay()
	{
	}

	public void AddLobbyBan(ulong player)
	{
	}

	private void OnLobbyEntered(LobbyEnter_t callback)
	{
	}

	private void OnInviteReceived(LobbyInvite_t result)
	{
	}

	private void OnGetLobbyData(LobbyDataUpdate_t result)
	{
	}

	private void OnLobbyKicked(LobbyKicked_t callback)
	{
	}

	private void OnLobbyChatUpdate(LobbyChatUpdate_t callback)
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void JoinLobby(CSteamID lobbyID)
	{
	}

	[IteratorStateMachine(typeof(_003CJoinLobbyWithDelay_003Ed__108))]
	private IEnumerator JoinLobbyWithDelay(CSteamID lobbyID)
	{
		return null;
	}

	public void JoinLobbyAuth(CSteamID lobbyID)
	{
	}

	public void LeaveSteamLobby(bool reloadMenu = true)
	{
	}

	[IteratorStateMachine(typeof(_003CReloadNetworkManagerCoroutine_003Ed__111))]
	private IEnumerator ReloadNetworkManagerCoroutine()
	{
		return null;
	}

	public void RunQuickMatch()
	{
	}

	public void CancelQuickMatch()
	{
	}

	public void JoinLobbyWithText(TMP_InputField text)
	{
	}

	public void SetLobbyName(TMP_InputField text)
	{
	}

	public void LeaveLobby()
	{
	}

	private void ReloadNetworkManager()
	{
	}

	public void LeaveMatch()
	{
	}

	public void KickSelf()
	{
	}

	public void DestroyInviteCards()
	{
	}

	public void GetLobbiesList()
	{
	}

	private void OnGetLobbyList(LobbyMatchList_t result)
	{
	}

	public void OpenDLCStorePage()
	{
	}

	public void OpenSupporterDLCStorePage()
	{
	}

	public void OpenFriendChat(string inputField)
	{
	}

	public void JoinFriendLobby(string inputField)
	{
	}

	public void InviteFriendToLobby(string inputField)
	{
	}

	public void AddSteamFriend(UserData user)
	{
	}

	public bool CanJoinFriend(string inputField)
	{
		return false;
	}

	public bool CanInviteFriend(string inputField)
	{
		return false;
	}

	public ulong GetSteamIdFromLobbyIndex(int index)
	{
		return 0uL;
	}

	public bool ValidateSteamIDisInLobby(ulong steamId)
	{
		return false;
	}

	public int GetLobbyIndexFromSteamId(ulong steamId)
	{
		return 0;
	}

	public void OpenSteamInviteUI()
	{
	}
}
