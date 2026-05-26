using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class WeaponHandSpawner : Weapon
{
	[Header("Weapon Specials")]
	[SerializeField]
	private GameObject objToSpawn;

	[SerializeField]
	private Transform previewObject;

	[SerializeField]
	private LayerMask landLayer;

	[SerializeField]
	private float maxInteractionDistance;

	[SerializeField]
	private bool canPlaceMaxDistance;

	private float interactionDistance;

	private float interactionDistanceFront;

	[SerializeField]
	private bool proximityMine;

	[SerializeField]
	private bool claymore;

	[SerializeField]
	private bool apmine;

	private float fireTimer;

	private bool canPlace;

	private Vector3 position;

	private Quaternion calculatorRot;

	private Quaternion rotation;

	private bool place;

	private bool placeDown;

	private bool NetworkInitializeEarly_WeaponHandSpawner_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_WeaponHandSpawner_Assembly_002DCSharp_002Edll;

	private void Update()
	{
	}

	private void HandlePlacement()
	{
	}

	private void Fire()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void RemoveAmmo()
	{
	}

	[ServerRpc]
	public void SpawnObject(GameObject obj, Vector3 position, Quaternion rotation)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ShootObserversEffect()
	{
	}

	private void LocalSound(int index)
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

	private void RpcWriter___Server_RemoveAmmo_2166136261()
	{
	}

	private void RpcLogic___RemoveAmmo_2166136261()
	{
	}

	private void RpcReader___Server_RemoveAmmo_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SpawnObject_2587446063(GameObject obj, Vector3 position, Quaternion rotation)
	{
	}

	public void RpcLogic___SpawnObject_2587446063(GameObject obj, Vector3 position, Quaternion rotation)
	{
	}

	private void RpcReader___Server_SpawnObject_2587446063(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ShootObserversEffect_2166136261()
	{
	}

	private void RpcLogic___ShootObserversEffect_2166136261()
	{
	}

	private void RpcReader___Observers_ShootObserversEffect_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
