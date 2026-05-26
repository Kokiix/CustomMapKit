using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProfileDisplay : MonoBehaviour
{
	public string PlayerName;

	public ulong PlayerSteamID;

	public bool AvatarReceived;

	public TextMeshProUGUI PlayerNameText;

	public RawImage PlayerIcon;

	protected Callback<AvatarImageLoaded_t> ImageLoaded;

	private void Start()
	{
	}

	private void GetPlayerIcon()
	{
	}

	public void SetPlayerValues()
	{
	}

	private void OnImageLoaded(AvatarImageLoaded_t callback)
	{
	}

	private Texture2D GetSteamImageAsTexture(int iImage)
	{
		return null;
	}
}
