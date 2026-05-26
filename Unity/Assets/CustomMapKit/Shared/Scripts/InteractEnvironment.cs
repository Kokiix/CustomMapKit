using FishNet.Object;
using UnityEngine;

public abstract class InteractEnvironment : NetworkBehaviour
{
	public string popupText;

	private bool NetworkInitializeEarly_InteractEnvironment_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_InteractEnvironment_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	public abstract void OnInteract(Transform player);

	public abstract void OnFocus();

	public abstract void OnLoseFocus();

	public virtual void NetworkInitialize___Early()
	{
	}

	public virtual void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
