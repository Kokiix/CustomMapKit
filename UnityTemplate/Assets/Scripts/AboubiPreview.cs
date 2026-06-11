using UnityEngine;

public class AboubiPreview : MonoBehaviour
{
	public static AboubiPreview Instance;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private GameObject[] meshesToChange;

	[SerializeField]
	private Transform hatToWearPosition;

	private GameObject currentHat;

	private GameObject currentCig;

	private void Awake()
	{
	}

	public void ChangeDress(GameObject hat, Material mat, GameObject cig)
	{
	}

	private void SetGameLayerRecursive(GameObject _go, int _layer)
	{
	}

	private void Update()
	{
	}
}
