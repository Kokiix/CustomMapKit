using System.Collections.Generic;
using UnityEngine;

public class CFX_SpawnSystem : MonoBehaviour
{
	private static CFX_SpawnSystem instance;

	public GameObject[] objectsToPreload;

	public int[] objectsToPreloadTimes;

	public bool hideObjectsInHierarchy;

	public bool spawnAsChildren;

	public bool onlyGetInactiveObjects;

	public bool instantiateIfNeeded;

	private bool allObjectsLoaded;

	private Dictionary<int, List<GameObject>> instantiatedObjects;

	private Dictionary<int, int> poolCursors;

	public static bool AllObjectsLoaded => false;

	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return null;
	}

	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	private void increasePoolCursor(int uniqueId)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
