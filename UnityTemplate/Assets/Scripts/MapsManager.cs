using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class MapsManager : MonoBehaviour, ISaveable
{
	[Serializable]
	private struct SaveData
	{
		public List<string[]> savedPlaylists;

		public List<string> savedPlaylistNames;

		public int savedActivePlaylistIndex;
	}

	public static MapsManager Instance;

	public Map[] allMaps;

	public Dictionary<string, Map> allMapsDict;

	public int[] unlockedMaps;

	public List<int> selectedMaps;

	[Space]
	public List<Playlist> Playlists;

	[Space]
	[SerializeField]
	private GameObject playlistInstance;

	[FormerlySerializedAs("playlistsViewport")]
	[SerializeField]
	private Transform playlistParent;

	[Space]
	[SerializeField]
	private GameObject mapInstance;

	[FormerlySerializedAs("mapsViewport")]
	[SerializeField]
	private Transform standardMapParent;

	[FormerlySerializedAs("dlcMapsViewport")]
	[SerializeField]
	private Transform dlcMapParent;

	[FormerlySerializedAs("altMapsViewport")]
	[SerializeField]
	private Transform altMapParent;

	[FormerlySerializedAs("mapsAddedViewport")]
	[SerializeField]
	private Transform selectedMapParent;

	[Space]
	[FormerlySerializedAs("loadListInstance")]
	[SerializeField]
	private GameObject loadPlayListInstance;

	[FormerlySerializedAs("loadListsViewport")]
	[SerializeField]
	private Transform playListLoadButtonParent;

	[Space]
	[FormerlySerializedAs("mapScreen")]
	[SerializeField]
	private RawImage mapPreviewImage;

	[SerializeField]
	private TextMeshProUGUI mapText;

	[Space]
	[SerializeField]
	private ScrollRect scrollRect;

	public TextMeshProUGUI currentPlaylistText;

	[Space]
	[SerializeField]
	private MapSelection mapSelectionScript;

	private static PlaylistPreset[] Presets;

	private ProgressManager ProgressManager;

	public int selectedPlaylistIndex;

	public int activePlaylistIndex;

	[SerializeField]
	private TextMeshProUGUI activePlaylistText;

	[FormerlySerializedAs("inTestMap")]
	[HideInInspector]
	public bool inExplorationMap;

	private bool MenuTrigger;

	[SerializeField]
	private TMP_InputField unselectedMapsSearchInput;

	[SerializeField]
	private TMP_InputField selectedMapsSearchText;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void InitMaps()
	{
	}

	public void UpdateUnlockedMaps()
	{
	}

	public void OpenFirstPlaylist()
	{
	}

	public void AddPlaylist(string[] tempPlaylist, string n)
	{
	}

	public void DupePlaylist(int i)
	{
	}

	public void ResetActivePlaylist()
	{
	}

	public void SetActivePlaylistFromSelectedItem()
	{
	}

	public void SetActivePlaylist(int index)
	{
	}

	public void LoadActivePlaylist()
	{
	}

	public void AddPlaylistWithoutUpdate(string[] tempPlaylist, string n)
	{
	}

	public void RemovePlaylist(int i)
	{
	}

	public void CreatePlaylist()
	{
	}

	public void UpdateLoadLists()
	{
	}

	public void UpdatePlaylists(bool hasCreatedNewPlaylist)
	{
	}

	public void PopulateMapsFromPlayList(int playListIndex)
	{
	}

	public void ChangeMapsState(string mapName)
	{
	}

	public void ChangePicture(Texture2D sprite, string txt)
	{
	}

	private void Update()
	{
	}

	private void ReturnToMenu()
	{
	}

	public void SortMapsFromMapInstanceName()
	{
	}

	public void ExportSelectedPlaylistToClipboard()
	{
	}

	public void ImportPlaylistFromClipboard()
	{
	}

	public object SaveState()
	{
		return null;
	}

	public void LoadState(JContainer state)
	{
	}

	private void AddPresetPlaylists()
	{
	}

	private void AddPresetPlaylist(Playlist preset)
	{
	}
}
