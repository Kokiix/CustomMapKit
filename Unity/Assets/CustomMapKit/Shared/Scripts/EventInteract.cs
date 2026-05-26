using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

public class EventInteract : BaseEventInteract
{
	[Header("These events trigger when the player interacts with this object.")]
	[SerializeField]
	private UnityEvent onInteractEvent;

	[SerializeField]
	private UnityEvent onInteractServerEvent;

	private bool NetworkInitializeEarly_EventInteract_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_EventInteract_Assembly_002DCSharp_002Edll;

	[ObserversRpc]
	protected override void OnInteractObserverRpc()
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

	private void RpcWriter___Observers_OnInteractObserverRpc_2166136261()
	{
	}

	protected virtual void RpcLogic___OnInteractObserverRpc_2166136261()
	{
	}

	private void RpcReader___Observers_OnInteractObserverRpc_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
