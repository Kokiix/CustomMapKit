using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingsResolution : MonoBehaviour
{
	[SerializeField]
	private TMP_Dropdown resolutionDropdown;

	private List<Resolution> sortedResolutions;

	private int highestRefreshRate;

	private void Start()
	{
	}

	public void SetResolution(int resolutionIndex)
	{
	}

	public void SetResolutionReal(TMP_Dropdown dropdown)
	{
	}

	private string GetAspectRatio(int width, int height)
	{
		return null;
	}

	private int GCD(int a, int b)
	{
		return 0;
	}
}
