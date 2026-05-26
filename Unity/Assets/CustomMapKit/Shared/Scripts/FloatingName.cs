using TMPro;
using UnityEngine;

public class FloatingName : MonoBehaviour
{
	public string nameToShow;

	[SerializeField]
	private TextMeshProUGUI text;

	public static FloatingName Instance;

	public GameObject display;

	private PauseManager pauseManager;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
