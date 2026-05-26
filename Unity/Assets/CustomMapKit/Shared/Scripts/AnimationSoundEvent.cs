using FishNet.Object;
using UnityEngine;

public class AnimationSoundEvent : NetworkBehaviour
{
	private AudioSource audio;

	[SerializeField]
	private AudioClip[] clips;

	private bool NetworkInitializeEarly_AnimationSoundEvent_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_AnimationSoundEvent_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	public void PlaySound(int index)
	{
	}

	private void PlaySoundObservers(int index)
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
