using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AudioPositionSlider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	private SetMenuMusicVolume musicController;

	public Slider slider;

	private bool isDragging;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
