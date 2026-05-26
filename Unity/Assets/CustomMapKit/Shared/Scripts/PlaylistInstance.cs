using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlaylistInstance : MonoBehaviour
{
	public new string name;

	public int index;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private Color selectedColor;

	[SerializeField]
	private Color deselectedColor;

	[SerializeField]
	private TMP_InputField nameInputField;

	public Button button;

	private string temptext;

	private void Start()
	{
	}

	public void DeletePlaylist()
	{
	}

	public void OpenPlaylist()
	{
	}

	public void DuplicatePlaylist()
	{
	}

	public void RenamePlaylist()
	{
	}

	public void UpdateName(TMP_InputField field)
	{
	}

	public void OnSelect(TMP_InputField input)
	{
	}

	public void OnDeselect(TMP_InputField input)
	{
	}
}
