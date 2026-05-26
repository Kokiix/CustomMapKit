using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectSceneInstance : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public string sceneName;

	public bool selected;

	[SerializeField]
	private Color selectedColor;

	[SerializeField]
	private Color deselectedColor;

	[SerializeField]
	private RawImage mapImg;

	private Button button;

	private Texture2D sprite;

	public MapSelection mapSelectionScript;

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

	public void SetState(bool state)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
