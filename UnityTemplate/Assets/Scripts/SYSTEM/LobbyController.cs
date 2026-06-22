using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FishNet;
using FishNet.Object;
using Steamworks;
using UnityEngine.UI;
using System.Linq;
using TMPro;
using FishNet.Managing;

public class LobbyController : MonoBehaviour
{
    public static LobbyController Instance;

    //UI Elements
    public TextMeshProUGUI LobbyNameText;
    [SerializeField] private Transform hostPosition;
    public Transform[] clientPosition;

    [SerializeField] private Transform tabhostPosition;
    public Transform[] tabclientPosition;
    [Space]
    public AboubiPreviewLobby[] previews;
    [Space]

    //Player Data
    public GameObject PlayerListViewContent;
    public GameObject PlayerListItemPrefab;
    public GameObject LocalPlayerObject;

    //Other Data
    public ulong CurrentLobbyID;
    public bool PlayerItemCreated = false;
    private List<PlayerListItem> PlayerListItems = new List<PlayerListItem>();
    private List<PlayerListItem> PlayerListItemsTab = new List<PlayerListItem>();
    public ClientInstance LocalPlayerController;

    //Ready status
    [SerializeField] private Button StartGameButton;
    [SerializeField] private TextMeshProUGUI ReadyButtonText;

    private SteamLobby manager;
    private NetworkManager networkManager;

    [Space]
    [SerializeField] private Transform tabScreen;

    void Awake()
    {
        

        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        manager = SteamLobby.Instance;
        networkManager = InstanceFinder.NetworkManager;
    }

    public void ReadyPlayer()
    {
        LocalPlayerController.ChangeReady();
    }

    public void UpdateButton()
    {
        
        if (LocalPlayerController.Ready)
        {
            ReadyButtonText.text = "Ready !";
        }
        else{
            ReadyButtonText.text = "Ready Up";
        }
    }

    // Make work with more than 2 players
    public bool HasEnoughPlayers()
    {
        return SteamLobby.Instance.players.Count >= 2 || Application.isEditor;
    }

    void Update()
    {
        if (LocalPlayerController == null) return;
        if (PlayerListItems.Count > SteamLobby.Instance.maxPlayers) 
        {
            LobbyController.Instance.RemoveExtraPlayerItem();
        }
    }

    public void CheckIfAllReady()
    {
        bool allReady = true;

        foreach (NetworkObject player in manager.players)
        {
            if (!player.GetComponent<ClientInstance>().Ready)
            {
                allReady = false;
                break;
            }
        }

        StartGameButton.interactable = allReady && HasEnoughPlayers() && LocalPlayerController.IsServer;
        SteamLobby.Instance.AllReady = StartGameButton.interactable;
    }

    public void UpdateLobbyName()
    {
        CurrentLobbyID = manager.CurrentLobbyID;
        LobbyNameText.text = SteamMatchmaking.GetLobbyData(new CSteamID(CurrentLobbyID), "name");
        LobbyNameText.text = FilterSystem.FilterString(LobbyNameText.text);
    }

    public void UpdatePlayerList()
    {
        if (PlayerListItems.Count == 0) PlayerItemCreated = false;
        if (!PlayerItemCreated) CreateHostPlayerItem();

        if (PlayerListItems.Count < manager.players.Count) CreateClientPlayerItem();

        if (PlayerListItems.Count > manager.players.Count) RemovePlayerItem();

        if (PlayerListItems.Count == manager.players.Count) UpdatePlayerItem();
    }

    public void CreateHostPlayerItem()
    {
        foreach (NetworkObject player in manager.players)
        {
            GameObject NewPlayerItem = Instantiate(PlayerListItemPrefab) as GameObject;
            PlayerListItem NewPlayerItemScript = NewPlayerItem.GetComponent<PlayerListItem>();

            NewPlayerItemScript.PlayerName = player.GetComponent<ClientInstance>().PlayerName;
            NewPlayerItemScript.ConnectionID = player.GetComponent<ClientInstance>().ConnectionID;
            NewPlayerItemScript.PlayerIdNumber = player.GetComponent<ClientInstance>().PlayerId;
            NewPlayerItemScript.PlayerSteamID = player.GetComponent<ClientInstance>().PlayerSteamID;
            NewPlayerItemScript.Ready = player.GetComponent<ClientInstance>().Ready;
            NewPlayerItemScript.SetPlayerValues();

            NewPlayerItem.transform.SetParent(PlayerListViewContent.transform);
            NewPlayerItem.transform.localScale = Vector3.one;
            NewPlayerItem.transform.position = hostPosition.position;

            PlayerListItems.Add(NewPlayerItemScript);
        }
        foreach (NetworkObject player in manager.players)
        {
            GameObject NewPlayerItem2 = Instantiate(PlayerListItemPrefab) as GameObject;
            PlayerListItem NewPlayerItemScript2 = NewPlayerItem2.GetComponent<PlayerListItem>();

            NewPlayerItemScript2.PlayerName = player.GetComponent<ClientInstance>().PlayerName;
            NewPlayerItemScript2.ConnectionID = player.GetComponent<ClientInstance>().ConnectionID;
            NewPlayerItemScript2.PlayerIdNumber = player.GetComponent<ClientInstance>().PlayerId;
            NewPlayerItemScript2.PlayerSteamID = player.GetComponent<ClientInstance>().PlayerSteamID;
            NewPlayerItemScript2.Ready = player.GetComponent<ClientInstance>().Ready;
            NewPlayerItemScript2.SetPlayerValues();

            NewPlayerItem2.transform.SetParent(tabScreen);
            NewPlayerItem2.transform.localScale = Vector3.one;
            NewPlayerItem2.transform.position = tabhostPosition.position;

            PlayerListItemsTab.Add(NewPlayerItemScript2);
        }
        PlayerItemCreated = true;
    }

    public void CreateClientPlayerItem()
    {
        foreach (NetworkObject player in manager.players)
        {
            if (!PlayerListItems.Any(b => b.ConnectionID == player.Owner.ClientId))
            {
                GameObject NewPlayerItem = Instantiate(PlayerListItemPrefab) as GameObject;

                PlayerListItem NewPlayerItemScript = NewPlayerItem.GetComponent<PlayerListItem>();

                NewPlayerItemScript.PlayerName = player.GetComponent<ClientInstance>().PlayerName;
                NewPlayerItemScript.ConnectionID = player.GetComponent<ClientInstance>().ConnectionID;
                NewPlayerItemScript.PlayerIdNumber = player.GetComponent<ClientInstance>().PlayerId;
                NewPlayerItemScript.PlayerSteamID = player.GetComponent<ClientInstance>().PlayerSteamID;
                NewPlayerItemScript.Ready = player.GetComponent<ClientInstance>().Ready;                
                NewPlayerItemScript.SetPlayerValues();

                NewPlayerItem.transform.SetParent(PlayerListViewContent.transform);
                NewPlayerItem.transform.localScale = Vector3.one;
                NewPlayerItem.transform.position = clientPosition[player.GetComponent<ClientInstance>().PlayerId-1].position;

                PlayerListItems.Add(NewPlayerItemScript);
            }
            if (!PlayerListItemsTab.Any(b => b.ConnectionID == player.Owner.ClientId))
            {
                GameObject NewPlayerItem2 = Instantiate(PlayerListItemPrefab) as GameObject;

                PlayerListItem NewPlayerItemScript2 = NewPlayerItem2.GetComponent<PlayerListItem>();

                NewPlayerItemScript2.PlayerName = player.GetComponent<ClientInstance>().PlayerName;
                NewPlayerItemScript2.ConnectionID = player.GetComponent<ClientInstance>().ConnectionID;
                NewPlayerItemScript2.PlayerIdNumber = player.GetComponent<ClientInstance>().PlayerId;
                NewPlayerItemScript2.PlayerSteamID = player.GetComponent<ClientInstance>().PlayerSteamID;
                NewPlayerItemScript2.Ready = player.GetComponent<ClientInstance>().Ready;                
                NewPlayerItemScript2.SetPlayerValues();

                NewPlayerItem2.transform.SetParent(tabScreen);
                NewPlayerItem2.transform.localScale = Vector3.one;
                NewPlayerItem2.transform.position = tabclientPosition[player.GetComponent<ClientInstance>().PlayerId-1].position;

                PlayerListItemsTab.Add(NewPlayerItemScript2);
            }
        }
    }

    public void UpdatePlayerItem()
    {
        foreach (NetworkObject player in manager.players)
        {
            foreach (PlayerListItem PlayerListItemScript in PlayerListItems)
            {
                if (PlayerListItemScript.ConnectionID == player.GetComponent<ClientInstance>().ConnectionID)
                {
                    PlayerListItemScript.PlayerName = player.GetComponent<ClientInstance>().PlayerName;
                    PlayerListItemScript.Ready = player.GetComponent<ClientInstance>().Ready;
                    PlayerListItemScript.SetPlayerValues();
                    if (player == LocalPlayerController.GetComponent<NetworkObject>()) UpdateButton();
                }
            }

            foreach (PlayerListItem PlayerListItemScript in PlayerListItemsTab)
            {
                if (PlayerListItemScript.ConnectionID == player.GetComponent<ClientInstance>().ConnectionID)
                {
                    PlayerListItemScript.PlayerName = player.GetComponent<ClientInstance>().PlayerName;
                    PlayerListItemScript.Ready = player.GetComponent<ClientInstance>().Ready;
                    PlayerListItemScript.SetPlayerValues();
                    if (player == LocalPlayerController.GetComponent<NetworkObject>()) UpdateButton();
                }
            }
        }

        CheckIfAllReady();
    }

    public void RemovePlayerItem()
    {
        List<PlayerListItem> playerListItemToRemove = new List<PlayerListItem>();
        List<PlayerListItem> playerListItemToRemoveTab = new List<PlayerListItem>();

        foreach(PlayerListItem playerlistItem in PlayerListItems)
        {
            if (!manager.players.Any(b => b.GetComponent<ClientInstance>().ConnectionID == playerlistItem.ConnectionID))
            {
                playerListItemToRemove.Add(playerlistItem);
            }
        }
        if (playerListItemToRemove.Count > 0)
        {
            foreach (PlayerListItem playerlistItemToRemove in playerListItemToRemove)
            {
                GameObject ObjectToRemove = playerlistItemToRemove.gameObject;
                PlayerListItems.Remove(playerlistItemToRemove);
                Destroy(ObjectToRemove);
                ObjectToRemove = null;
            }
        }



        foreach(PlayerListItem playerlistItem in PlayerListItemsTab)
        {
            if (!manager.players.Any(b => b.GetComponent<ClientInstance>().ConnectionID == playerlistItem.ConnectionID))
            {
                playerListItemToRemoveTab.Add(playerlistItem);
            }
        }
        if (playerListItemToRemoveTab.Count > 0)
        {
            foreach (PlayerListItem playerlistItemToRemove in playerListItemToRemoveTab)
            {
                GameObject ObjectToRemove = playerlistItemToRemove.gameObject;
                PlayerListItemsTab.Remove(playerlistItemToRemove);
                Destroy(ObjectToRemove);
                ObjectToRemove = null;
            }
        }
    }

    public void RemoveExtraPlayerItem()
    {
        List<PlayerListItem> playerListItemToRemove = new List<PlayerListItem>();

        for (int i=0; i < PlayerListItems.Count; i++)
        {
            if (i > 1)
            {
                playerListItemToRemove.Add(PlayerListItems[i]);
            }
        }
        if (playerListItemToRemove.Count > 0)
        {
            foreach (PlayerListItem playerlistItemToRemove in playerListItemToRemove)
            {
                GameObject ObjectToRemove = playerlistItemToRemove.gameObject;
                PlayerListItems.Remove(playerlistItemToRemove);
                Destroy(ObjectToRemove);
                ObjectToRemove = null;
            }
        }



        List<PlayerListItem> playerListItemToRemoveTab = new List<PlayerListItem>();

        for (int i=0; i < PlayerListItemsTab.Count; i++)
        {
            if (i > 1)
            {
                playerListItemToRemoveTab.Add(PlayerListItemsTab[i]);
            }
        }
        if (playerListItemToRemoveTab.Count > 0)
        {
            foreach (PlayerListItem playerlistItemToRemove in playerListItemToRemoveTab)
            {
                GameObject ObjectToRemove = playerlistItemToRemove.gameObject;
                PlayerListItemsTab.Remove(playerlistItemToRemove);
                Destroy(ObjectToRemove);
                ObjectToRemove = null;
            }
        }
    }
    
}
