using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSizeTween : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler, IDeselectHandler
{
	[SerializeField]
	private Vector3 targetScale;

	[SerializeField]
	private float tweenDuration;

	[SerializeField]
	private Ease easeType;

	[SerializeField]
	private bool parentScale;

	[SerializeField]
	private bool takeInitScale;

	private Vector3 initScale;

	[Space]
	[SerializeField]
	private bool closeWindow;

	[Space]
	[SerializeField]
	private bool biggerWhenSelected;

	[SerializeField]
	private bool biggerWithGamepadOnly;

	[SerializeField]
	private Vector3 selectedScale;

	[SerializeField]
	private float tweenDuration2;

	[SerializeField]
	private Ease easeType2;

	[Space]
	[SerializeField]
	private bool scaleTextOnly;

	private TextMeshProUGUI textChild;

	private Button button;

	[Space]
	[SerializeField]
	private bool startGameButton;

	[SerializeField]
	private bool dlcLockedButton;

	[SerializeField]
	private bool addFriendButton;

	[SerializeField]
	private bool randomizedLockedButton;

	public string customText;

	private bool isSelected;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void OnDeselect(BaseEventData eventData)
	{
	}

	private void TaskOnClick()
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
