using FishNet.Object;
using TMPro;
using UnityEngine;

public class VisualInfo : NetworkBehaviour
{
	public new TextMeshProUGUI name;

	[Header("Tweaks")]
	public Transform lookAt;

	public Vector3 offset;

	[Header("Logic")]
	public Camera cam;

	public GameObject container;

	private bool NetworkInitializeEarly_VisualInfo_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_VisualInfo_Assembly_002DCSharp_002Edll;

	private void Update()
	{
	}

	public virtual void NetworkInitialize___Early()
	{
	}

	public virtual void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
