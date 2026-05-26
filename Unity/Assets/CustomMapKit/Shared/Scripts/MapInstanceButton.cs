using UnityEngine;
using UnityEngine.EventSystems;

public class MapInstanceButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private bool isExplore;

	[SerializeField]
	private MapInstance parentScript;

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}
}
