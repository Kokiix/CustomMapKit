using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

public abstract class BaseEventInteract : InteractEnvironment
{
	private bool IsReady;

	[Header("These events trigger when the player focuses on this object.")]
	[SerializeField]
	private UnityEvent onFocusEvent;

	[SerializeField]
	private UnityEvent onFocusServerEvent;

	[Header("These events trigger when the player loses focus on this object.")]
	[SerializeField]
	private UnityEvent onLoseFocusEvent;

	[SerializeField]
	private UnityEvent onLoseFocusServerEvent;

	private bool NetworkInitializeEarly_BaseEventInteract_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_BaseEventInteract_Assembly_002DCSharp_002Edll;

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	private void RoundStart()
	{
	}

	public override void Awake()
	{
	}

	public override void OnInteract(Transform player)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void OnInteractServerRpc()
	{
	}

	protected abstract void OnInteractObserverRpc();

	public override void OnFocus()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void OnFocusServerRpc()
	{
	}

	[ObserversRpc]
	private void OnFocusObserverRpc()
	{
	}

	public override void OnLoseFocus()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void OnLoseFocusServerRpc()
	{
	}

	[ObserversRpc]
	private void OnLoseFocusObserverRpc()
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

	private void RpcWriter___Server_OnInteractServerRpc_2166136261()
	{
	}

	private void RpcLogic___OnInteractServerRpc_2166136261()
	{
	}

	private void RpcReader___Server_OnInteractServerRpc_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_OnFocusServerRpc_2166136261()
	{
	}

	private void RpcLogic___OnFocusServerRpc_2166136261()
	{
	}

	private void RpcReader___Server_OnFocusServerRpc_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_OnFocusObserverRpc_2166136261()
	{
	}

	private void RpcLogic___OnFocusObserverRpc_2166136261()
	{
	}

	private void RpcReader___Observers_OnFocusObserverRpc_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_OnLoseFocusServerRpc_2166136261()
	{
	}

	private void RpcLogic___OnLoseFocusServerRpc_2166136261()
	{
	}

	private void RpcReader___Server_OnLoseFocusServerRpc_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_OnLoseFocusObserverRpc_2166136261()
	{
	}

	private void RpcLogic___OnLoseFocusObserverRpc_2166136261()
	{
	}

	private void RpcReader___Observers_OnLoseFocusObserverRpc_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
