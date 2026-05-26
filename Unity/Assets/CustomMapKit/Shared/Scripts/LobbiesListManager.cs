using System.Collections.Generic;
using Steamworks;
using UnityEngine;

public class LobbiesListManager : MonoBehaviour
{
	public static LobbiesListManager Instance;

	public GameObject lobbyDataItemPrefab;

	public GameObject lobbyListContent;

	public GameObject lobbiesButton;

	public GameObject hostButton;

	public List<GameObject> listOfLobbies;

	public string gamemodeFilter;

	private void Awake()
	{
	}

	public void GetListOfLobbies()
	{
	}

	public void DestroyLobbies()
	{
	}

	public void DisplayLobbyWithData(CSteamID lobbyID)
	{
	}

	public void SetGamemodeFilter(string filter)
	{
	}
}
