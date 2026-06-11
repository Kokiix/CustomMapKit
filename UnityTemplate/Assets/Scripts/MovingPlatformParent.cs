using FishNet.Object;
using UnityEngine;

public class MovingPlatformParent : NetworkBehaviour
{
	public bool doesEject;

	public Vector3 movingVector;

	private Vector3 previousPosition;

	private bool NetworkInitializeEarly_MovingPlatformParent_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_MovingPlatformParent_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

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
