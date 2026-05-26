using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(100000)]
public class CrosshairThing : MonoBehaviour
{
	[SerializeField]
	private Crosshair crosshair;

	[SerializeField]
	private ColorInputSetting tintColorSettings;

	[SerializeField]
	private TMP_InputField sizeSlider;

	[SerializeField]
	private Toggle disableFilteringToggle;

	private Color _currentColor;

	private float _currentSize;

	[SerializeField]
	private Image previewImage;

	public static readonly string CrosshairFolderPath;

	private string[] _supportedExtensions;

	private List<string> _crosshairPaths;

	private string _currentCrosshairPath;

	private int _currentCrosshairIndex;

	private bool _filteringDisabled;

	public void TintColor(Color color)
	{
	}

	public void SizeSlider(string sizeText)
	{
	}

	private void NonImageThings()
	{
	}

	public void Awake()
	{
	}

	public void OpenFolder()
	{
	}

	public void LoadCrosshairPaths()
	{
	}

	public void UpArrow()
	{
	}

	public void DownArrow()
	{
	}

	public void SetCrosshair()
	{
	}

	public bool LoadNewCrosshair(string path, out Sprite sprite)
	{
		sprite = null;
		return false;
	}

	public void LoadDefaultCrosshair()
	{
	}

	public void DisableFiltering(bool disable)
	{
	}
}
