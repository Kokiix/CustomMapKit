using FishNet.Object;
using UnityEngine;
using UnityEngine.Serialization;

public abstract class Spawner : NetworkBehaviour
{
	[FormerlySerializedAs("countdown")]
	[Range(0f, 60f)]
	[SerializeField]
	protected float weaponRespawnTimeInSeconds;

	protected float CountdownTimer;

	protected bool WaitTillTaken;

	protected ItemBehaviour ItemBehaviour;

	private bool NetworkInitializeEarly_Spawner_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Spawner_Assembly_002DCSharp_002Edll;

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public abstract void Spawn();

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
