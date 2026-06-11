using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeButton : MonoBehaviour
{
	[SerializeField]
	private TMP_Text text;

	[SerializeField]
	private WeaponRandomizationMenu weaponRandomizationMenu;

	[SerializeField]
	private WeaponRemapper weaponRemapper;

	[SerializeField]
	private ButtonSizeTween _buttonSizeTween;

	[SerializeField]
	private Button button;

	public void Update()
	{
	}

	public void PressedButton()
	{
	}
}
