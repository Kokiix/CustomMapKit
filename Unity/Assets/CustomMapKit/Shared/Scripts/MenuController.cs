using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class MenuController : MonoBehaviour
{
	[SerializeField]
	private PostProcessVolume blurCamera;

	[SerializeField]
	private DepthOfField depth;

	[SerializeField]
	private GameObject mapsMenu;

	public GameObject hatsMenu;

	public GameObject playMenu;

	[SerializeField]
	private GameObject statsMenu;

	[SerializeField]
	private GameObject progressMenu;

	public GameObject startMenu;

	[SerializeField]
	private GameObject buttonBar;

	[SerializeField]
	private GameObject hud;

	[SerializeField]
	private AudioClip openingClip;

	[Space]
	[SerializeField]
	private GameObject backButton;

	[SerializeField]
	private GameObject startScreenButton;

	public static MenuController Instance;

	[Space]
	[SerializeField]
	private GameObject PlayButton;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OpenGame()
	{
	}

	public void ActivateMenu(GameObject menu)
	{
	}

	public void OpenStartMenu()
	{
	}
}
