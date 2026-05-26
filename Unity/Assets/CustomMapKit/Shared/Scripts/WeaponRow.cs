using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponRow : MonoBehaviour
{
	public string WeaponName;

	public string DisplayName;

	public TMP_InputField inputField;

	public Slider slider;

	public Toggle toggle;

	public TMP_Text weightedSpawnChance;

	public bool suppressEvents;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Init(string weaponName, string displayName)
	{
	}

	private void OnInputFieldChanged(string value)
	{
	}

	private void OnSliderChanged(float value)
	{
	}

	private void OnToggleChanged(bool value)
	{
	}

	public float GetSpawnProbabilityPercentage()
	{
		return 0f;
	}

	public void UpdateRowDisplay()
	{
	}
}
