using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{
	public RectTransform rectTransform;

	public static Crosshair Instance;

	public Image image;

	public Image scopeImage;

	public Sprite invisibleCrosshair;

	public Sprite nogunCrosshair;

	public Sprite standCrosshair;

	public Sprite sprintCrosshair;

	public Sprite aimCrosshair;

	[HideInInspector]
	public Sprite fixedCrosshair;

	[HideInInspector]
	public Vector2 fixedCrosshairSize;

	private Vector2 defaultCrosshairSize;

	[FormerlySerializedAs("FixedCrosshair")]
	public Sprite defaultFixedCrosshair;

	public bool canScopeAim;

	public AudioClip headshotHitClip;

	[SerializeField]
	private float aimCrosshairLimit;

	public FirstPersonController player;

	private Settings settings;

	public GameObject hatObj;

	public bool instantAimLens;

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
