using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CosmeticInstance : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public bool isHat;

	public bool isCig;

	public GameObject hat;

	private Button button;

	public Sprite sprite;

	public bool acquired;

	private Image img;

	[Space]
	public string challengeDescription;

	[Space]
	public string cosmeticName;

	[Space]
	public int index;

	[Space]
	public bool unlockWithXp;

	public bool unlockWithDlc;

	public bool unlockWithSupporterDlc;

	public bool unlockWithChallenge;

	[Space]
	[SerializeField]
	private Color unlockedColor;

	[SerializeField]
	private Color lockedColor;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	public void ChangeDress()
	{
	}

	private void Update()
	{
	}

	public void Unlock()
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
