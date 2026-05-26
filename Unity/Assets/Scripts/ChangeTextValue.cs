using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTextValue : MonoBehaviour
{
	private TextMeshProUGUI textMesh;

	private Slider _slider;

	[SerializeField]
	private float factor;

	[SerializeField]
	private float factor2;

	[SerializeField]
	private string correct;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void ChangeIntValue(Slider value)
	{
	}
}
