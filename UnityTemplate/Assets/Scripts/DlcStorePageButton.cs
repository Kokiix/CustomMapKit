using UnityEngine;
using UnityEngine.EventSystems;

public class DlcStorePageButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private GameObject notOwnedImage;

	[SerializeField]
	private GameObject[] notOwnedObjects;

	[SerializeField]
	private GameObject ownedImage;

	[SerializeField]
	private GameObject ownedImage1;

	[SerializeField]
	private MeshRenderer screen;

	[SerializeField]
	private Material notOwnedMat;

	[SerializeField]
	private Material ownedMat;

	[SerializeField]
	private Material owned1Mat;

	private bool Dlc0Owned;

	private bool Dlc1Owned;

	private void Update()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateMaterial(Material mat)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnClick()
	{
	}

	private void OpenSpecificFolder(string folderPath)
	{
	}
}
