using System.Collections.Generic;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerManager : NetworkBehaviour
{
	public static GameObject[] AllWeapons;

	public static readonly Dictionary<string, GameObject> NameToWeaponDict;

	public static readonly Dictionary<string, int> NameToIndexDict;

	[SyncVar]
	public bool randomiseWeapons;

	[SyncObject]
	public readonly SyncList<WeaponData> spawnChances;

	[SyncVar]
	public uint totalSpawnWeight;

	[SyncVar]
	public bool swapGuns;

	public Dictionary<string, string> Swaps;

	private static string _currentMap;

	private const string WeaponsPath = "RandomWeapons";

	public static SpawnerManager Instance;

	public static Dictionary<string, WeaponData> weaponInfo;

	public SyncVar<bool> syncVar___randomiseWeapons;

	public SyncVar<uint> syncVar___totalSpawnWeight;

	public SyncVar<bool> syncVar___swapGuns;

	private bool NetworkInitializeEarly_SpawnerManager_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_SpawnerManager_Assembly_002DCSharp_002Edll;

	public bool SyncAccessor_randomiseWeapons
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint SyncAccessor_totalSpawnWeight
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool SyncAccessor_swapGuns
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[ObserversRpc(BufferLast = true, RunLocally = true)]
	public void SyncRandomSettings(Dictionary<string, string> newSwaps)
	{
	}

	private static void TryBakeSyncForMap(string mapName)
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public static void PopulateAllWeapons()
	{
	}

	public virtual void Awake()
	{
	}

	public void SyncRandomSettings(IEnumerable<WeaponData> weaponData, uint totalWeight)
	{
	}

	public GameObject GetRandomSpawnableWeapon()
	{
		return null;
	}

	public static void UpdateSpawnableWeapons()
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

	private void RpcWriter___Observers_SyncRandomSettings_2210485484(Dictionary<string, string> newSwaps)
	{
	}

	public void RpcLogic___SyncRandomSettings_2210485484(Dictionary<string, string> newSwaps)
	{
	}

	private void RpcReader___Observers_SyncRandomSettings_2210485484(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___SpawnerManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
