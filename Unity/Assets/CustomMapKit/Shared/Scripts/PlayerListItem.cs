using System.Collections.Generic;
using HeathenEngineering.SteamworksIntegration;
using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListItem : MonoBehaviour
{
	public static readonly Dictionary<ulong, string> DevloperIds;

	public string PlayerName;

	public int ConnectionID;

	public int PlayerIdNumber;

	public ulong PlayerSteamID;

	public bool AvatarReceived;

	private ulong lobbyID;

	public TextMeshProUGUI PlayerNameText;

	public GameObject DevloperIndicator;

	public TMP_Text DevloperText;

	public RawImage PlayerIcon;

	public TextMeshProUGUI PlayerReadyText;

	public bool Ready;

	protected Callback<AvatarImageLoaded_t> ImageLoaded;

	[SerializeField]
	private GameObject kickbutton;

	[SerializeField]
	private GameObject banbutton;

	[SerializeField]
	private GameObject cosmeticbutton;

	[SerializeField]
	private GameObject mutebutton;

	[SerializeField]
	private GameObject textmutebutton;

	[SerializeField]
	private GameObject addButton;

	[SerializeField]
	private TMP_Dropdown teamIdDropdown;

	[Space]
	[SerializeField]
	private Color readyColor;

	[SerializeField]
	private Color notreadyColor;

	private PauseManager pauseManager;

	private LobbyController lobbyController;

	private GameManager gameManager;

	private UserData thisUser;

	private ulong localSteamId;

	[Space]
	[SerializeField]
	private Image muteImg;

	[SerializeField]
	private Sprite mute;

	[SerializeField]
	private Sprite notmute;

	[Space]
	[SerializeField]
	private Image textMuteImg;

	[SerializeField]
	private Sprite textMute;

	[SerializeField]
	private Sprite textNotmute;

	public void ChangeReadyStatus()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void GetPlayerIcon()
	{
	}

	public void CAcacas()
	{
	}

	public void SetPlayerValues()
	{
	}

	private void OnImageLoaded(AvatarImageLoaded_t callback)
	{
	}

	public void KickPlayer()
	{
	}

	public void LobbyBan()
	{
	}

	private Texture2D GetSteamImageAsTexture(int iImage)
	{
		return null;
	}

	public void SwitchMute()
	{
	}

	public void SwitchTextMute()
	{
	}

	private void OnEnable()
	{
	}

	public void OnDropdownTeamIdEnabled()
	{
	}

	public void AddFriend()
	{
	}

	public void SetSelfTeamId(TMP_Dropdown dropdown)
	{
	}
}
