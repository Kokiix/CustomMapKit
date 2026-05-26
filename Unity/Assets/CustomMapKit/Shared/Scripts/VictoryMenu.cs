using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class VictoryMenu : InteractEnvironment
{
	[SerializeField]
	private InputAction menu;

	[SerializeField]
	private InputAction menu2;

	[SerializeField]
	private bool returnMenu;

	[SerializeField]
	private bool restartGame;

	[SerializeField]
	private bool quitGame;

	[SerializeField]
	private bool savePlaylist;

	[SerializeField]
	private bool sharePlaylist;

	[SerializeField]
	private bool scrambleTeams;

	private Vector3 restPos;

	[SerializeField]
	private float focusOffset;

	[SerializeField]
	private float pressOffset;

	[SerializeField]
	private float moveSpeed;

	[Space]
	[SerializeField]
	private GameObject textObject;

	[SerializeField]
	private TMP_Text voteRematchText;

	[SerializeField]
	private TMP_Text playersText;

	private bool act;

	private bool focused;

	private HashSet<NetworkObject> playersThatCanRequestARestart;

	private bool rematch;

	[SyncObject]
	private readonly SyncList<int> VotedPlayers;

	public bool hasAskedForMapPool;

	public bool hasAskedForPlaylist;

	private Dictionary<int, List<int>> OriginalTeamSetup;

	private bool NetworkInitializeEarly_VictoryMenu_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_VictoryMenu_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	private void HideButton()
	{
	}

	public override void OnFocus()
	{
	}

	public override void OnInteract(Transform player)
	{
	}

	public override void OnLoseFocus()
	{
	}

	private void Update()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void VoteRematchServer(NetworkConnection sender = null)
	{
	}

	private void SaveCurrentPoolToPlaylist()
	{
	}

	private void SharePlaylist()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void RequestArrayData(NetworkConnection sender = null)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void RequestArrayDataForPlayedMaps(NetworkConnection sender = null)
	{
	}

	[TargetRpc]
	private void GetPlaylist(NetworkConnection conn, string[] playlist)
	{
	}

	[TargetRpc]
	private void GetPlaylistPlayedMaps(NetworkConnection conn, string[] playlist)
	{
	}

	private void ScrambleTeams()
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

	private void RpcWriter___Server_VoteRematchServer_328543758(NetworkConnection sender = null)
	{
	}

	public void RpcLogic___VoteRematchServer_328543758(NetworkConnection sender = null)
	{
	}

	private void RpcReader___Server_VoteRematchServer_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_RequestArrayData_328543758(NetworkConnection sender = null)
	{
	}

	public void RpcLogic___RequestArrayData_328543758(NetworkConnection sender = null)
	{
	}

	private void RpcReader___Server_RequestArrayData_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_RequestArrayDataForPlayedMaps_328543758(NetworkConnection sender = null)
	{
	}

	public void RpcLogic___RequestArrayDataForPlayedMaps_328543758(NetworkConnection sender = null)
	{
	}

	private void RpcReader___Server_RequestArrayDataForPlayedMaps_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Target_GetPlaylist_2890081366(NetworkConnection conn, string[] playlist)
	{
	}

	private void RpcLogic___GetPlaylist_2890081366(NetworkConnection conn, string[] playlist)
	{
	}

	private void RpcReader___Target_GetPlaylist_2890081366(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Target_GetPlaylistPlayedMaps_2890081366(NetworkConnection conn, string[] playlist)
	{
	}

	private void RpcLogic___GetPlaylistPlayedMaps_2890081366(NetworkConnection conn, string[] playlist)
	{
	}

	private void RpcReader___Target_GetPlaylistPlayedMaps_2890081366(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
