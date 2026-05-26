using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class KillCam : MonoBehaviour
{
	public InputAction move;

	public InputAction run;

	public InputAction interact;

	public InputAction lookX;

	public InputAction lookY;

	public Transform enemy;

	public Transform ragdoll;

	public Vector3 firstPosition;

	private bool killcam;

	public bool triggerLookAtBody;

	public bool ragdollCam;

	public bool isDead;

	private float timer;

	private Vector3 deltaPosition;

	private Vector3 tempPosition;

	private GameObject[] players;

	private int alivePlayerCount;

	private int spectatePlayerId;

	private TextMeshProUGUI switchCamText;

	private TextMeshProUGUI playerNameText;

	private TextMeshProUGUI playerHpText;

	private bool midMatchJoin;

	private bool midMatchTrigger;

	private bool freeCam;

	private bool hideHud;

	private bool hasPressedFreecam;

	private Camera freeCamCamera;

	private Vector2 mouseInput;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private Transform FindRecursive(string name, Transform root)
	{
		return null;
	}

	private void OnDisable()
	{
	}
}
