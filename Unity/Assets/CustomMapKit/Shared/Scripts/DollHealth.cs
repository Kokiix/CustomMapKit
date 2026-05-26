using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.InputSystem;

public class DollHealth : NetworkBehaviour
{
	public float health;

	private float maxHealth;

	[SerializeField]
	private InputAction menu;

	private bool NetworkInitializeEarly_DollHealth_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_DollHealth_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void Menu(InputAction.CallbackContext ctx)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void ServerDollDeath()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void ServerDollRevive()
	{
	}

	[ObserversRpc]
	private void DollDeath()
	{
	}

	[ObserversRpc]
	private void DollRevive()
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

	private void RpcWriter___Server_ServerDollDeath_2166136261()
	{
	}

	private void RpcLogic___ServerDollDeath_2166136261()
	{
	}

	private void RpcReader___Server_ServerDollDeath_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_ServerDollRevive_2166136261()
	{
	}

	private void RpcLogic___ServerDollRevive_2166136261()
	{
	}

	private void RpcReader___Server_ServerDollRevive_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_DollDeath_2166136261()
	{
	}

	private void RpcLogic___DollDeath_2166136261()
	{
	}

	private void RpcReader___Observers_DollDeath_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Observers_DollRevive_2166136261()
	{
	}

	private void RpcLogic___DollRevive_2166136261()
	{
	}

	private void RpcReader___Observers_DollRevive_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
