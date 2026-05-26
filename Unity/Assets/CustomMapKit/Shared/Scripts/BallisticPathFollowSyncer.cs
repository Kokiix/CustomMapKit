using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using HeathenEngineering.PhysKit;
using UnityEngine;

[RequireComponent(typeof(BallisticPathFollow))]
public class BallisticPathFollowSyncer : NetworkBehaviour
{
	private BallisticPathFollow pathFollow;

	private int previousLength;

	private uint _fixedUpdateCount;

	public static Dictionary<int, BallisticPathFollowSyncer> idToSyncer;

	private bool NetworkInitializeEarly_BallisticPathFollowSyncer_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_BallisticPathFollowSyncer_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	private void Start()
	{
	}

	[ObserversRpc(ExcludeOwner = true)]
	public void ReconcileTheThing(Vector3 position, Quaternion rotation, BallisticPathFollowSyncData data)
	{
	}

	[ServerRpc]
	public void ReconcileTheThingServer(Vector3 position, Quaternion rotation, BallisticPathFollowSyncData data)
	{
	}

	private void FixedUpdate()
	{
	}

	[ObserversRpc(RunLocally = true)]
	public void Shoot(trickShotData data, int id)
	{
	}

	public void ShootNonRPC(trickShotData data, int id)
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

	private void RpcWriter___Observers_ReconcileTheThing_3122646897(Vector3 position, Quaternion rotation, BallisticPathFollowSyncData data)
	{
	}

	public void RpcLogic___ReconcileTheThing_3122646897(Vector3 position, Quaternion rotation, BallisticPathFollowSyncData data)
	{
	}

	private void RpcReader___Observers_ReconcileTheThing_3122646897(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_ReconcileTheThingServer_3122646897(Vector3 position, Quaternion rotation, BallisticPathFollowSyncData data)
	{
	}

	public void RpcLogic___ReconcileTheThingServer_3122646897(Vector3 position, Quaternion rotation, BallisticPathFollowSyncData data)
	{
	}

	private void RpcReader___Server_ReconcileTheThingServer_3122646897(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_Shoot_170526399(trickShotData data, int id)
	{
	}

	public void RpcLogic___Shoot_170526399(trickShotData data, int id)
	{
	}

	private void RpcReader___Observers_Shoot_170526399(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
