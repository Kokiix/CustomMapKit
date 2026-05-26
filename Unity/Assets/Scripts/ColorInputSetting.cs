using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class ColorInputSetting : MonoBehaviour
{
	[FormerlySerializedAs("outlineColor")]
	[HideInInspector]
	public Color color;

	public UnityEvent<Color> onColorChanged;

	[SerializeField]
	private TMP_InputField redText;

	[SerializeField]
	private TMP_InputField greenText;

	[SerializeField]
	private TMP_InputField blueText;

	[SerializeField]
	private TMP_InputField alphaText;

	[SerializeField]
	private Image previewImage;

	public void Start()
	{
	}

	public void Red(string redInput)
	{
	}

	public void Green(string greenInput)
	{
	}

	public void Blue(string blueInput)
	{
	}

	public void Alpha(string alphaInput)
	{
	}

	public void OnColorChanged()
	{
	}
}
