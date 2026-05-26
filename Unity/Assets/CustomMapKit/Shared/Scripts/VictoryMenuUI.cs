using TMPro;
using UnityEngine;

public class VictoryMenuUI : MonoBehaviour
{
	[SerializeField]
	private GameObject positionCell;

	[SerializeField]
	private GameObject cellParent;

	[Space]
	[SerializeField]
	private TMP_Text victoryDefeatText;

	[SerializeField]
	private Color victoryColor;

	[SerializeField]
	private Color defeatColor;

	private void Start()
	{
	}

	private Texture2D GetSteamImageAsTexture(int iImage)
	{
		return null;
	}

	public static string ToOrdinal(int n)
	{
		return null;
	}
}
