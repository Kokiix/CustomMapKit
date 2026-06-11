using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

public class ToggleEventInteract : BaseEventInteract
{
	private bool IsToggled;

	[Header("These events trigger when the player toggles this object on.")]
	[SerializeField]
	private UnityEvent onEnableEvent;

	[SerializeField]
	private UnityEvent onEnableServerEvent;

	[Header("These events trigger when the player toggles this object off.")]
	[SerializeField]
	private UnityEvent onDisableEvent;

	[SerializeField]
	private UnityEvent onDisableServerEvent;

	private bool NetworkInitializeEarly_ToggleEventInteract_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_ToggleEventInteract_Assembly_002DCSharp_002Edll;

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
