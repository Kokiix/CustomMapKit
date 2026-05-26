using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using UnityEngine;

public class WeaponPresetUtility : MonoBehaviour, ISaveable
{
	public string defaultPresetName;

	public readonly Dictionary<string, WeaponPreset> Presets;

	[ContextMenu("Save Preset")]
	public void SaveCurrentPreset()
	{
	}

	[ContextMenu("Load Preset")]
	public void LoadPreset(string presetName)
	{
	}

	public object SaveState()
	{
		return null;
	}

	public void LoadState(JContainer state)
	{
	}
}
