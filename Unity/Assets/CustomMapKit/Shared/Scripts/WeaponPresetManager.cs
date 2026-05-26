using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponPresetManager : MonoBehaviour
{
	[SerializeField]
	private Transform buttonContainer;

	[SerializeField]
	private Button buttonPrefab;

	[SerializeField]
	public TMP_InputField presetNameField;

	[SerializeField]
	public WeaponPresetUtility weaponPresetUtil;

	public static WeaponPresetManager Instance { get; private set; }

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void PopulatePresetList()
	{
	}
}
