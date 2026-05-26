using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class FlashLight : Weapon
{
	[SerializeField]
	private float reloadTime;

	[SerializeField]
	private AudioClip reloadClip;

	private float fireTimer;

	private bool touched;

	private Vector3 spread;

	[SerializeField]
	private GameObject light;

	private bool isOn;

	private bool NetworkInitializeEarly_FlashLight_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_FlashLight_Assembly_002DCSharp_002Edll;

	private void Update()
	{
	}

	private void Fire()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void Power()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void PowerObservers()
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

	private void RpcWriter___Server_Power_2166136261()
	{
	}

	private void RpcLogic___Power_2166136261()
	{
	}

	private void RpcReader___Server_Power_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PowerObservers_2166136261()
	{
	}

	private void RpcLogic___PowerObservers_2166136261()
	{
	}

	private void RpcReader___Observers_PowerObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
