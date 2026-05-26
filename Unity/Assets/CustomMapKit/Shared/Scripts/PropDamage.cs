using FishNet.Object;
using UnityEngine;

public class PropDamage : NetworkBehaviour
{
	[SerializeField]
	private GameObject[] states;

	[SerializeField]
	private AudioClip[] hitClips;

	private int index;

	private bool NetworkInitializeEarly_PropDamage_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PropDamage_Assembly_002DCSharp_002Edll;

	public void Damage()
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
