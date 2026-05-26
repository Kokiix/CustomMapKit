using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class PlayerSpawnObject : NetworkBehaviour
{
	public GameObject objToSpawn;

	public GameObject spawnedObject;

	private bool NetworkInitializeEarly_PlayerSpawnObject_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PlayerSpawnObject_Assembly_002DCSharp_002Edll;

	public override void OnStartClient()
	{
	}

	private void Update()
	{
	}

	[ServerRpc]
	public void SpawnObject(GameObject obj, Transform player, PlayerSpawnObject script)
	{
	}

	[ObserversRpc]
	public void SetSpawnedObject(GameObject spawned, PlayerSpawnObject script)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void DespawnObject(GameObject obj)
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

	private void RpcWriter___Server_SpawnObject_1585589339(GameObject obj, Transform player, PlayerSpawnObject script)
	{
	}

	public void RpcLogic___SpawnObject_1585589339(GameObject obj, Transform player, PlayerSpawnObject script)
	{
	}

	private void RpcReader___Server_SpawnObject_1585589339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SetSpawnedObject_1450126728(GameObject spawned, PlayerSpawnObject script)
	{
	}

	public void RpcLogic___SetSpawnedObject_1450126728(GameObject spawned, PlayerSpawnObject script)
	{
	}

	private void RpcReader___Observers_SetSpawnedObject_1450126728(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_DespawnObject_1934289915(GameObject obj)
	{
	}

	public void RpcLogic___DespawnObject_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_DespawnObject_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
