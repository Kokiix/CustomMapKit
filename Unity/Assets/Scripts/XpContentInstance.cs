using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class XpContentInstance : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public int index;

	public int mapIndex;

	[SerializeField]
	private RawImage img;

	[SerializeField]
	private RawImage frame;

	[SerializeField]
	private Color unlockedColor;

	[SerializeField]
	private Color DlcunlockedColor;

	[SerializeField]
	private Color lockedColor;

	[SerializeField]
	private Color DlclockedColor;

	[SerializeField]
	private Color DlcFrameColor;

	[SerializeField]
	private Color DlcLockedTextColor;

	[SerializeField]
	private Color LockedTextColor;

	[SerializeField]
	private Color FrameColor;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private TextMeshProUGUI lockedText;

	private XpContentLayout contentLayout;

	private void Start()
	{
	}

	public void UpdateUI()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
