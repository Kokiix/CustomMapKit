using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;

public class ScoreManager : NetworkBehaviour
{
	public static ScoreManager Instance;

	[SyncObject(WritePermissions = WritePermission.ServerOnly)]
	public readonly SyncDictionary<int, int> PlayerIdToTeamId;

	[SyncObject(WritePermissions = WritePermission.ServerOnly)]
	public readonly SyncDictionary<int, List<int>> TeamIdToPlayerIds;

	[SyncObject(WritePermissions = WritePermission.ServerOnly)]
	public readonly SyncDictionary<int, int> Points;

	public int RoundScoreRequiredToWin;

	[SyncObject(WritePermissions = WritePermission.ServerOnly)]
	public readonly SyncDictionary<int, int> RoundScore;

	[SyncVar]
	public int TakeIndex;

	public SyncVar<int> syncVar___TakeIndex;

	private bool NetworkInitializeEarly_ScoreManager_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_ScoreManager_Assembly_002DCSharp_002Edll;

	public int SyncAccessor_TakeIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual void Awake()
	{
	}

	public int GetTeamId(int playerId)
	{
		return 0;
	}

	public List<int> GetPlayerIdsForTeam(int teamId)
	{
		return null;
	}

	public void SetTeamId(int playerId, int teamId)
	{
	}

	public void ResetTeams()
	{
	}

	public void Default2v2()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void SetTeamIdServer(int playerId, int teamId)
	{
	}

	[ObserversRpc]
	public void UpdateDropdown(int playerId, int teamId)
	{
	}

	public int GetPoints(int teamId)
	{
		return 0;
	}

	public void AddPoints(int teamId, int score = 1)
	{
	}

	public void ResetScores()
	{
	}

	public bool CheckForRoundWin(out int winningTeamId)
	{
		winningTeamId = default(int);
		return false;
	}

	public Dictionary<int, int> GetRoundScoreDictionary()
	{
		return null;
	}

	public int GetRoundScore(int playerId)
	{
		return 0;
	}

	public void AddRoundScore(int playerId, int score = 1)
	{
	}

	public void ResetRound()
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	public void SetRoundIndex(int n)
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

	private void RpcWriter___Server_SetTeamIdServer_1692629761(int playerId, int teamId)
	{
	}

	public void RpcLogic___SetTeamIdServer_1692629761(int playerId, int teamId)
	{
	}

	private void RpcReader___Server_SetTeamIdServer_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_UpdateDropdown_1692629761(int playerId, int teamId)
	{
	}

	public void RpcLogic___UpdateDropdown_1692629761(int playerId, int teamId)
	{
	}

	private void RpcReader___Observers_UpdateDropdown_1692629761(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_SetRoundIndex_3316948804(int n)
	{
	}

	public void RpcLogic___SetRoundIndex_3316948804(int n)
	{
	}

	private void RpcReader___Server_SetRoundIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual bool ReadSyncVar___ScoreManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
