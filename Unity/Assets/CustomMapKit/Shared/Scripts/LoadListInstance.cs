using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadListInstance : MonoBehaviour
{
	public List<string> maps;

	public new string name;

	public int index;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private Color selectedColor;

	[SerializeField]
	private Color deselectedColor;

	[SerializeField]
	private Button button;

	private void Start()
	{
	}

	public void LoadPlaylist()
	{
	}
}
