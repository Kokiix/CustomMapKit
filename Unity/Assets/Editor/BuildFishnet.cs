using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
using FishNet.Object;

public static class FishNetMetadataSetup
{
    private const string CACHE_PATH = "Library/FishNetModdingCache.json";
    private static Dictionary<string, string> _cache = new Dictionary<string, string>();

    // Serializable structures for native Unity JSON serialization
    [Serializable]
    private class CacheData
    {
        public List<CacheEntry> Entries = new List<CacheEntry>();
    }

    [Serializable]
    private class CacheEntry
    {
        public string Path;
        public string Hash;
    }

    #region Cache Management

    private static void LoadCache()
    {
        _cache.Clear();
        if (File.Exists(CACHE_PATH))
        {
            try
            {
                string json = File.ReadAllText(CACHE_PATH);
                CacheData data = JsonUtility.FromJson<CacheData>(json);
                if (data != null && data.Entries != null)
                {
                    foreach (var entry in data.Entries)
                    {
                        _cache[entry.Path] = entry.Hash;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogWarning($"Failed to load FishNet modding cache: {ex.Message}");
            }
        }
    }

    private static void SaveCache()
    {
        try
        {
            CacheData data = new CacheData();
            foreach (var kvp in _cache)
            {
                data.Entries.Add(new CacheEntry { Path = kvp.Key, Hash = kvp.Value });
            }
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(CACHE_PATH, json);
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"Failed to save FishNet modding cache: {ex.Message}");
        }
    }

    private static bool IsAssetUpToDate(string path, string currentHash)
    {
        if (_cache.TryGetValue(path, out string cachedHash))
        {
            return cachedHash == currentHash;
        }
        return false;
    }

    #endregion

    [MenuItem("Tools/FishNet Modding/Setup All NetworkObjects in Project")]
    public static void SetupAllNetworkObjectsInProject()
    {
        // Load the tracking cache from disk
        LoadCache();

        // Save active modifications in current scenes
        string originalScenePath = SceneManager.GetActiveScene().path;
        if (!string.IsNullOrEmpty(originalScenePath))
        {
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        }

        int prefabProcessedCount = 0;
        int sceneProcessedCount = 0;
        int skippedCount = 0;

        // --- PHASE 1: PROCESS ALL PREFABS IN THE ASSETS DIRECTORY ---
        string[] prefabGuids = AssetDatabase.FindAssets("t:Prefab", new[] { "Assets" });

        foreach (string guid in prefabGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            string currentHash = AssetDatabase.GetAssetDependencyHash(path).ToString(); //

            // Skip loading the asset entirely if it hasn't changed
            if (IsAssetUpToDate(path, currentHash))
            {
                skippedCount++;
                continue;
            }

            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            if (prefab == null) continue;

            NetworkObject[] nobs = prefab.GetComponentsInChildren<NetworkObject>(true);
            if (nobs.Length > 0)
            {
                foreach (NetworkObject nob in nobs)
                {
                    ProcessNetworkObject(nob);
                    prefabProcessedCount++;
                }

                EditorUtility.SetDirty(prefab);
            }

            // Mark this prefab as updated in our local cache
            _cache[path] = currentHash;
        }

        // --- PHASE 2: PROCESS ALL SCENES IN THE ASSETS DIRECTORY ---
        string[] sceneGuids = AssetDatabase.FindAssets("t:Scene", new[] { "Assets" });

        foreach (string guid in sceneGuids)
        {
            string path = AssetDatabase.GUIDToAssetPath(guid);
            string currentHash = AssetDatabase.GetAssetDependencyHash(path).ToString(); //

            // Skip opening the scene entirely if it hasn't changed
            if (IsAssetUpToDate(path, currentHash))
            {
                skippedCount++;
                continue;
            }

            Scene scene = EditorSceneManager.OpenScene(path, OpenSceneMode.Single);
            if (!scene.IsValid()) continue;

            GameObject[] rootObjects = scene.GetRootGameObjects();
            List<NetworkObject> sceneNobs = new List<NetworkObject>();

            foreach (GameObject root in rootObjects)
            {
                sceneNobs.AddRange(root.GetComponentsInChildren<NetworkObject>(true));
            }

            if (sceneNobs.Count > 0)
            {
                foreach (NetworkObject nob in sceneNobs)
                {
                    ProcessNetworkObject(nob);
                    sceneProcessedCount++;
                }

                EditorSceneManager.MarkSceneDirty(scene);
                EditorSceneManager.SaveScene(scene);
            }

            // Mark this scene as updated in our local cache
            _cache[path] = currentHash;
        }

        // --- PHASE 3: RESTORE ORIGINAL WORKSPACE STATE ---
        if (!string.IsNullOrEmpty(originalScenePath))
        {
            EditorSceneManager.OpenScene(originalScenePath, OpenSceneMode.Single);
        }

        // Save modifications to the cache file
        SaveCache();

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log($"Setup completed! Processed: {prefabProcessedCount} prefabs, {sceneProcessedCount} scenes. Skipped: {skippedCount} unmodified files.");
    }

    public static void ProcessNetworkObject(NetworkObject nob)
    {
        if (nob == null) return;

        GameObject go = nob.gameObject;
        SerializedObject serializedNob = new SerializedObject(nob);

        string assetPath = AssetDatabase.GetAssetPath(go);
        bool isPrefab = !string.IsNullOrEmpty(assetPath);
        bool isSceneObject = !isPrefab && !string.IsNullOrEmpty(go.scene.name);

        if (isPrefab)
        {
            ulong pathHash = GetFNV1a64(assetPath);
            SetSerializedField(serializedNob, pathHash, "<AssetPathHash>k__BackingField", "_assetPathHash", "AssetPathHash");
            SetSerializedField(serializedNob, 0UL, "<SceneId>k__BackingField", "_sceneId", "SceneId");
        }
        else if (isSceneObject)
        {
            string hierarchyPath = GetHierarchyPath(go);
            ulong sceneId = GetFNV1a64(go.scene.name + "/" + hierarchyPath);
            SetSerializedField(serializedNob, sceneId, "<SceneId>k__BackingField", "_sceneId", "SceneId");
            SetSerializedField(serializedNob, 0UL, "<AssetPathHash>k__BackingField", "_assetPathHash", "AssetPathHash");
        }

        bool isNested = false;
        Transform current = go.transform.parent;
        while (current != null)
        {
            if (current.GetComponent<NetworkObject>() != null)
            {
                isNested = true;
                break;
            }
            current = current.parent;
        }
        SetSerializedField(serializedNob, isNested, "<IsNested>k__BackingField", "_isNested", "IsNested");

        List<NetworkBehaviour> nbList = new List<NetworkBehaviour>();
        GetNetworkBehaviours(go.transform, nbList);

        SerializedProperty behavioursProp = serializedNob.FindProperty("NetworkBehaviours") ?? serializedNob.FindProperty("_networkBehaviours");
        if (behavioursProp != null)
        {
            behavioursProp.ClearArray();
            for (int i = 0; i < nbList.Count; i++)
            {
                behavioursProp.InsertArrayElementAtIndex(i);
                behavioursProp.GetArrayElementAtIndex(i).objectReferenceValue = nbList[i];
            }
        }

        List<NetworkObject> nestedNobs = new List<NetworkObject>();
        GetNestedNetworkObjects(go.transform, nestedNobs);
        SerializedProperty nestedProp = serializedNob.FindProperty("InitializedNestedNetworkObjects")
                                     ?? serializedNob.FindProperty("_initializedNestedNetworkObjects")
                                     ?? serializedNob.FindProperty("<InitializedNestedNetworkObjects>k__BackingField");
        if (nestedProp != null)
        {
            nestedProp.ClearArray();
            for (int i = 0; i < nestedNobs.Count; i++)
            {
                nestedProp.InsertArrayElementAtIndex(i);
                nestedProp.GetArrayElementAtIndex(i).objectReferenceValue = nestedNobs[i];
            }
        }

        serializedNob.ApplyModifiedProperties();
        EditorUtility.SetDirty(nob);

        for (int i = 0; i < nbList.Count; i++)
        {
            NetworkBehaviour nb = nbList[i];
            if (nb == null) continue;

            SerializedObject serializedNb = new SerializedObject(nb);
            SetSerializedField(serializedNb, (byte)i, "_componentIndexCache", "ComponentIndex", "_componentIndex");
            SetSerializedField(serializedNb, nob, "_networkObjectCache", "NetworkObject", "_networkObject");
            SetSerializedField(serializedNb, nob, "_addedNetworkObject");

            serializedNb.ApplyModifiedProperties();
            EditorUtility.SetDirty(nb);
        }
    }

    private static void GetNetworkBehaviours(Transform t, List<NetworkBehaviour> results)
    {
        var behavioursOnTransform = t.GetComponents<NetworkBehaviour>();
        foreach (var nb in behavioursOnTransform)
        {
            if (nb != null)
            {
                results.Add(nb);
            }
        }

        for (int i = 0; i < t.childCount; i++)
        {
            Transform child = t.GetChild(i);
            if (child != null && child.GetComponent<NetworkObject>() == null)
            {
                GetNetworkBehaviours(child, results);
            }
        }
    }

    private static void GetNestedNetworkObjects(Transform t, List<NetworkObject> results)
    {
        for (int i = 0; i < t.childCount; i++)
        {
            Transform child = t.GetChild(i);
            if (child != null)
            {
                NetworkObject childNob = child.GetComponent<NetworkObject>();
                if (childNob != null)
                {
                    results.Add(childNob);
                    GetNestedNetworkObjects(child, results);
                }
                else
                {
                    GetNestedNetworkObjects(child, results);
                }
            }
        }
    }

    private static bool SetSerializedField(SerializedObject serializedObject, object value, params string[] possibleNames)
    {
        foreach (var name in possibleNames)
        {
            SerializedProperty prop = serializedObject.FindProperty(name);
            if (prop != null)
            {
                if (value is ulong ulongVal)
                {
                    prop.longValue = unchecked((long)ulongVal);
                }
                else if (value is long longVal)
                {
                    prop.longValue = longVal;
                }
                else if (value is int intVal)
                {
                    prop.intValue = intVal;
                }
                else if (value is byte byteVal)
                {
                    prop.intValue = byteVal;
                }
                else if (value is bool boolVal)
                {
                    prop.boolValue = boolVal;
                }
                else if (value is string stringVal)
                {
                    prop.stringValue = stringVal;
                }
                else if (value == null || value is UnityEngine.Object)
                {
                    prop.objectReferenceValue = (UnityEngine.Object)value;
                }
                return true;
            }
        }
        return false;
    }

    private static string GetHierarchyPath(GameObject go)
    {
        string path = go.name;
        Transform parent = go.transform.parent;
        while (parent != null)
        {
            path = parent.name + "/" + path;
            parent = parent.parent;
        }
        return path;
    }

    private static ulong GetFNV1a64(string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;
        string normalized = str.Replace('\\', '/').ToLowerInvariant();

        ulong hash = 14695981039346656037UL;
        for (int i = 0; i < normalized.Length; i++)
        {
            hash ^= normalized[i];
            hash *= 1099511628211UL;
        }
        return hash;
    }
}