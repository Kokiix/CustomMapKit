using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class DisableTimeAttackParkour : InteractEnvironment
{
	[SerializeField]
	private InputAction menu;

	[SerializeField]
	private InputAction menu2;

	private Vector3 restPos;

	[SerializeField]
	private float focusOffset;

	[SerializeField]
	private float pressOffset;

	[SerializeField]
	private float moveSpeed;

	[Space]
	[SerializeField]
	private TMP_Text text;

	private TimerManager timerManager;

	private bool act;

	private bool focused;

	private bool rematch;

	private bool NetworkInitializeEarly_DisableTimeAttackParkour_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_DisableTimeAttackParkour_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	public override void OnFocus()
	{
	}

	public override void OnInteract(Transform player)
	{
	}

	public override void OnLoseFocus()
	{
	}

	private void Update()
	{
	}

	public override void NetworkInitialize___Early()
	{
	}

	public override void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
