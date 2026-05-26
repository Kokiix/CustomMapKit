using FishNet.Object;

public abstract class Interactable : NetworkBehaviour
{
	public bool canTake;

	private bool NetworkInitializeEarly_Interactable_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Interactable_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	public abstract void OnInteract();

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
