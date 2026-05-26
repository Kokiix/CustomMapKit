using FishNet.Object;
using UnityEngine;

public class Suppression : NetworkBehaviour
{
	private AudioSource audio;

	[SerializeField]
	private AudioClip[] supClip;

	[SerializeField]
	private CameraEffect camPP;

	private bool NetworkInitializeEarly_Suppression_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Suppression_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	public void SuppressionTrigger()
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
