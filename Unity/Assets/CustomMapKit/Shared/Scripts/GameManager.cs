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
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : NetworkBehaviour
{
	private struct RoundTripTime
	{
		public readonly float Time;

		public readonly float RTT;

		public RoundTripTime(float time, float roundTripTime)
		{
			Time = 0f;
			RTT = 0f;
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitForDraw_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameManager _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

		private bool _003CisRoundWon_003E5__3;

		private int _003CwinningTeamId_003E5__4;

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
		public _003CWaitForDraw_003Ed__15(int _003C_003E1__state)
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

	public static GameManager Instance;

	public string MainMenuSceneName;

	public string VictorySceneName;

	public readonly HashSet<int> alivePlayers;

	private readonly List<Death> recentDeaths;

	[SyncVar]
	public bool roundWasWon;

	private float rttLastUpdated;

	private Coroutine waitForDrawCoroutine;

	public float timeTillStart;

	public bool hasSetStartTime;

	public readonly HashSet<NetworkConnection> ConnectionsToStartGame;

	public readonly HashSet<NetworkConnection> NetworkConnectionsReady;

	[SyncVar]
	public bool playingTeams;

	[SyncVar]
	public bool EnemyOutlinesEnabled;

	[SyncVar]
	public bool FriendlyFireEnabled;

	private readonly List<RoundTripTime> RoundTripTimes;

	public SyncVar<bool> syncVar___roundWasWon;

	public SyncVar<bool> syncVar___playingTeams;

	public SyncVar<bool> syncVar___EnemyOutlinesEnabled;

	public SyncVar<bool> syncVar___FriendlyFireEnabled;

	private bool NetworkInitializeEarly_GameManager_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_GameManager_Assembly_002DCSharp_002Edll;

	public bool SyncAccessor_roundWasWon
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SyncAccessor_playingTeams
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SyncAccessor_EnemyOutlinesEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SyncAccessor_FriendlyFireEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual void Awake()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public void ResetGame()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void PlayerDied(int playerId)
	{
	}

	private void Start()
	{
	}

	public void StartGame()
	{
	}

	public void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForDraw_003Ed__15))]
	private IEnumerator WaitForDraw()
	{
		return null;
	}

	[ObserversRpc(RunLocally = true)]
	private void UpdateMatchPointsHUD(int winningTeamId, Dictionary<int, int> roundScores)
	{
	}

	private void RoundWon(int winningTeamId)
	{
	}

	public void ProgressToNextTake()
	{
	}

	private int[] GetAliveTeams()
	{
		return null;
	}

	public int[] GetConnectedTeams()
	{
		return null;
	}

	[ObserversRpc(RunLocally = true)]
	public void ObserversRoundSpawn()
	{
	}

	public void CmdKickPlayer(NetworkConnection conn, string message = null)
	{
	}

	[TargetRpc]
	private void KickPlayerTarget(NetworkConnection conn, string message = null)
	{
	}

	[ObserversRpc(RunLocally = true)]
	public void SetStartTime(float serverTimeTillStart)
	{
	}

	public void RemoveNetworkConnection(NetworkConnection conn)
	{
	}

	public void SteamIdLeftHandlerShit(CSteamID steamId)
	{
	}

	public void ScrambleTeams(Dictionary<int, List<int>> originalTeamSetup)
	{
	}

	private void AddRoundTripTime(float time, float roundTripTime)
	{
	}

	private float GetAverageRoundTripTime()
	{
		return 0f;
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

	private void RpcWriter___Server_PlayerDied_3316948804(int playerId)
	{
	}

	public void RpcLogic___PlayerDied_3316948804(int playerId)
	{
	}

	private void RpcReader___Server_PlayerDied_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_UpdateMatchPointsHUD_1259646723(int winningTeamId, Dictionary<int, int> roundScores)
	{
	}

	private void RpcLogic___UpdateMatchPointsHUD_1259646723(int winningTeamId, Dictionary<int, int> roundScores)
	{
	}

	private void RpcReader___Observers_UpdateMatchPointsHUD_1259646723(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_ObserversRoundSpawn_2166136261()
	{
	}

	public void RpcLogic___ObserversRoundSpawn_2166136261()
	{
	}

	private void RpcReader___Observers_ObserversRoundSpawn_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Target_KickPlayerTarget_2971853958(NetworkConnection conn, string message = null)
	{
	}

	private void RpcLogic___KickPlayerTarget_2971853958(NetworkConnection conn, string message = null)
	{
	}

	private void RpcReader___Target_KickPlayerTarget_2971853958(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_SetStartTime_431000436(float serverTimeTillStart)
	{
	}

	public void RpcLogic___SetStartTime_431000436(float serverTimeTillStart)
	{
	}

	private void RpcReader___Observers_SetStartTime_431000436(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___GameManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
