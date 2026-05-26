using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;

public class WeaponRemapper : MonoBehaviour, ISaveable
{
	[SerializeField]
	private WeaponRemapperPresetUI weaponRemapperPresetTemplate;

	[SerializeField]
	private RectTransform presetParent;

	[SerializeField]
	private WeaponRemapperMapUI weaponRemapperMapTemplate;

	[SerializeField]
	private RectTransform mapParent;

	[SerializeField]
	private WeaponRemapperSelector weaponRemapperSelectorTemplate;

	[SerializeField]
	private RectTransform selectorParent;

	[SerializeField]
	private TMP_Text selectedPresetText;

	[SerializeField]
	private TMP_Text selectedMapText;

	[HideInInspector]
	private List<WeaponRemapPreset> _weaponRemaps;

	public static WeaponRemapPreset SelectedPreset;

	private WeaponRemapMap _selectedMap;

	public GameObject helpScreen;

	public void Awake()
	{
	}

	public void Update()
	{
	}

	public void AddNewPreset()
	{
	}

	public void InitPreset(WeaponRemapPreset weaponRemapPreset)
	{
	}

	public void AddNewMap()
	{
	}

	private void InitMap(WeaponRemapMap weaponRemapMap)
	{
	}

	private void MoveMap(WeaponRemapMap weaponRemapMap1, Transform mapTransform, int offset)
	{
	}

	public void AddNewOverride()
	{
	}

	private void InitOverride(WeaponRemap weaponRemap)
	{
	}

	public void TriggerSave()
	{
	}

	public object SaveState()
	{
		return null;
	}

	public void LoadState(JContainer state)
	{
	}

	public void DeselectPreset()
	{
	}

	public void Export()
	{
	}

	public void Import()
	{
	}

	public void OnEnable()
	{
	}

	public void ToggleHelpScreen()
	{
	}
}
