using FishNet.Object;
using TMPro;
using UnityEngine;

public class MatchChat : NetworkBehaviour
{
	private GameObject ChatBox;

	public TMP_InputField inputLine;

	private bool NetworkInitializeEarly_MatchChat_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_MatchChat_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	[Client]
	public void Update()
	{
	}

	private void OnDisable()
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

	public virtual void Awake___UserLogic()
	{
	}
}
