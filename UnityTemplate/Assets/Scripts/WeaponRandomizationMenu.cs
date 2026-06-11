using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponRandomizationMenu : MonoBehaviour
{
	public static uint CachedTotalSpawnableWeight;

	[SerializeField]
	private VerticalLayoutGroup weaponList;

	[SerializeField]
	private GameObject weaponRowPrefab;

	[SerializeField]
	private GameObject menuButton;

	[SerializeField]
	private Canvas menuCanvas;

	[SerializeField]
	private TMP_Text presetName;

	[SerializeField]
	private TMP_InputField weaponNameInputField;

	private static bool toggleState;

	private static bool sliderMaxToggle;

	private static List<WeaponRow> weaponRows;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private static void UpdateCachedTotalWeight()
	{
	}

	public void ToggleMenu()
	{
	}

	private void PopulateMenu()
	{
	}

	private void RegisterRow(WeaponRow row)
	{
	}

	public static void UpdateAllSpawnProbabilities()
	{
	}

	public void ToggleAllWeapons()
	{
	}

	public void SetAllSlidersToMinOrMax()
	{
	}

	public static void RandomizeSettings()
	{
	}

	public void FilterListByWeaponName(string weaponName)
	{
	}
}
