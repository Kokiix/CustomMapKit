using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MapInstance : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public new string name;

	public bool selected;

	[Space]
	public Transform mapsViewport;

	public Transform mapsAddedViewport;

	[Space]
	[SerializeField]
	private Color selectedColor;

	[SerializeField]
	private Color deselectedColor;

	[SerializeField]
	private TextMeshProUGUI addText;

	[SerializeField]
	private Texture2D sprite;

	[SerializeField]
	private RawImage img;

	[SerializeField]
	private Button button;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UpdateUI()
	{
	}

	public void ChangeState()
	{
	}

	public void OpenMap()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	private void OnDisable()
	{
	}
}
