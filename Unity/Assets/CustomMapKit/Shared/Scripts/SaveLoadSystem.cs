using System.Collections.Generic;
using UnityEngine;

public class SaveLoadSystem : MonoBehaviour
{
	private delegate Dictionary<string, object> SaveFileUpgradeDelegate(string path);

	private static bool DisableSavingDueToSteam;

	private const string SettingsSaveId = "7ec1c0a0-f12f-4b9f-a6b6-38f4c4e6519b";

	private static readonly Dictionary<string, SaveFileUpgradeDelegate> OldSaveFileUpgradeMap;

	public static SaveLoadSystem Instance;

	private static string SavePath => null;

	private static string PreviousSavePath => null;

	private static Dictionary<string, object> UpgradeV2Save(string path)
	{
		return null;
	}

	private bool UpgradeSaveFile()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[ContextMenu("Save")]
	public void Save()
	{
	}

	[ContextMenu("Load")]
	public void Load()
	{
	}

	private void SaveFile(Dictionary<string, object> state)
	{
	}

	private Dictionary<string, object> LoadFile()
	{
		return null;
	}

	private bool SaveState(Dictionary<string, object> state)
	{
		return false;
	}

	private void LoadState(Dictionary<string, object> state)
	{
	}

	public void OnApplicationQuit()
	{
	}
}
