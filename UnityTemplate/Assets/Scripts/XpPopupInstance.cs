using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XpPopupInstance : MonoBehaviour
{
	public int index;

	public int mapIndex;

	public bool clicked;

	[SerializeField]
	private RawImage img;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private TextMeshProUGUI challengeText;

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private TextMeshProUGUI dlcText;

	[SerializeField]
	private GameObject spawnVfx;

	[SerializeField]
	private AudioClip spawnSfx;

	private GameObject tempVfx;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void PassPopup()
	{
	}

	public void SkipAll()
	{
	}
}
