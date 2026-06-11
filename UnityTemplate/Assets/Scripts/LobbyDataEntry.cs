using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LobbyDataEntry : MonoBehaviour
{
	public CSteamID lobbyID;

	public string lobbyName;

	public string ownDlc0;

	public string gamemode;

	public int playerCount;

	public int maxPlayers;

	public TextMeshProUGUI lobbyNameText;

	public TextMeshProUGUI playerCountText;

	public TextMeshProUGUI gamemodeText;

	[SerializeField]
	private Image background;

	[SerializeField]
	private Color bgColor;

	[SerializeField]
	private Color textColor;

	[SerializeField]
	private GameObject DlcStar;

	[SerializeField]
	private GameObject DlcFrame;

	public void RenderLobby()
	{
	}

	public void JoinLobby()
	{
	}
}
