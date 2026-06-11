using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
	public static LobbyController Instance;

	public TextMeshProUGUI LobbyNameText;

	[SerializeField]
	private Transform hostPosition;

	public Transform[] clientPosition;

	[SerializeField]
	private Transform tabhostPosition;

	public Transform[] tabclientPosition;

	[Space]
	public AboubiPreviewLobby[] previews;

	[Space]
	public GameObject PlayerListViewContent;

	public GameObject PlayerListItemPrefab;

	public ulong CurrentLobbyID;

	private Dictionary<int, PlayerListItems> PlayerIdToListItem;

	public ClientInstance LocalPlayerController;

	[SerializeField]
	private Button StartGameButton;

	[SerializeField]
	private TextMeshProUGUI ReadyButtonText;

	private SteamLobby manager;

	[Space]
	[SerializeField]
	private Transform tabScreen;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ReadyPlayer()
	{
	}

	public void UpdateButton()
	{
	}

	private bool HasEnoughPlayers()
	{
		return false;
	}

	private void Update()
	{
	}

	public void UpdateLobbyName()
	{
	}

	public void UpdatePlayerList()
	{
	}

	private void CreateNewObjects(int playerId, ClientInstance clientInstance)
	{
	}
}
