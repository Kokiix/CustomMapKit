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
    private static readonly Dictionary<string, Hash128> _cache = new Dictionary<string, Hash128>();

    // Property name caching to avoid repeating linear string searches in FindProperty
    private static readonly Dictionary<Type, Dictionary<string, string>> _propertyNameCache = new Dictionary<Type, Dictionary<string, string>>();

    // Pre-allocated static arrays to avoid params allocations
    private static readonly string[] AssetPathHashNames = { "<AssetPathHash>k__BackingField", "_assetPathHash", "AssetPathHash" };
    private static readonly string[] SceneIdNames = { "<SceneId>k__BackingField", "_sceneId", "SceneId" };
    private static readonly string[] IsNestedNames = { "<IsNested>k__BackingField", "_isNested", "IsNested" };
    private static readonly string[] NetworkBehavioursNames = { "NetworkBehaviours", "_networkBehaviours" };
    private static readonly string[] InitializedNestedNetworkObjectsNames = { "InitializedNestedNetworkObjects", "_initializedNestedNetworkObjects", "<InitializedNestedNetworkObjects>k__BackingField" };
    private static readonly string[] ComponentIndexNames = { "_componentIndexCache", "ComponentIndex", "_componentIndex" };
    private static readonly string[] NetworkObjectNames = { "_networkObjectCache", "NetworkObject", "_networkObject" };
    private static readonly string[] AddedNetworkObjectNames = { "_addedNetworkObject" };

    // Shared list caches to avoid GC allocation inside recursions and loops
    private static readonly List<NetworkBehaviour> _nbListCache = new List<NetworkBehaviour>();
    private static readonly List<NetworkObject> _nestedNobsCache = new List<NetworkObject>();
    private static readonly List<NetworkObject> _sceneNobsCache = new List<NetworkObject>();
    private static readonly List<NetworkBehaviour> _tempNbComponents = new List<NetworkBehaviour>();
    private static readonly List<string> _pathPartsCache = new List<string>();

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
                        _cache[entry.Path] = Hash128.Parse(entry.Hash);
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
                data.Entries.Add(new CacheEntry { Path = kvp.Key, Hash = kvp.Value.ToString() });
            }
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(CACHE_PATH, json);
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"Failed to save FishNet modding cache: {ex.Message}");
        }
    }

    private static bool IsAssetUpToDate(string path, Hash128 currentHash)
    {
        return _cache.TryGetValue(path, out Hash128 cachedHash) && cachedHash == currentHash;
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
            Hash128 currentHash = AssetDatabase.GetAssetDependencyHash(path);

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
            Hash128 currentHash = AssetDatabase.GetAssetDependencyHash(path);

            // Skip opening the scene entirely if it hasn't changed
            if (IsAssetUpToDate(path, currentHash))
            {
                skippedCount++;
                continue;
            }

            Scene scene = EditorSceneManager.OpenScene(path, OpenSceneMode.Single);
            if (!scene.IsValid()) continue;

            GameObject[] rootObjects = scene.GetRootGameObjects();
            _sceneNobsCache.Clear();

            foreach (GameObject root in rootObjects)
            {
                _sceneNobsCache.AddRange(root.GetComponentsInChildren<NetworkObject>(true));
            }

            if (_sceneNobsCache.Count > 0)
            {
                foreach (NetworkObject nob in _sceneNobsCache)
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
            SetSerializedField(serializedNob, pathHash, "AssetPathHash", AssetPathHashNames);
            SetSerializedField(serializedNob, 0UL, "SceneId", SceneIdNames);
        }
        else if (isSceneObject)
        {
            string hierarchyPath = GetHierarchyPath(go);
            ulong sceneId = GetFNV1a64(go.scene.name + "/" + hierarchyPath);
            SetSerializedField(serializedNob, sceneId, "SceneId", SceneIdNames);
            SetSerializedField(serializedNob, 0UL, "AssetPathHash", AssetPathHashNames);
        }

        bool isNested = false;
        Transform current = go.transform.parent;
        while (current != null)
        {
            if (current.TryGetComponent<NetworkObject>(out _))
            {
                isNested = true;
                break;
            }
            current = current.parent;
        }
        SetSerializedField(serializedNob, isNested, "IsNested", IsNestedNames);

        _nbListCache.Clear();
        GetNetworkBehaviours(go.transform, _nbListCache);

        SerializedProperty behavioursProp = FindPropertyCached(serializedNob, "NetworkBehaviours", NetworkBehavioursNames);
        if (behavioursProp != null)
        {
            behavioursProp.ClearArray();
            for (int i = 0; i < _nbListCache.Count; i++)
            {
                behavioursProp.InsertArrayElementAtIndex(i);
                behavioursProp.GetArrayElementAtIndex(i).objectReferenceValue = _nbListCache[i];
            }
        }

        _nestedNobsCache.Clear();
        GetNestedNetworkObjects(go.transform, _nestedNobsCache);
        SerializedProperty nestedProp = FindPropertyCached(serializedNob, "InitializedNestedNetworkObjects", InitializedNestedNetworkObjectsNames);
        if (nestedProp != null)
        {
            nestedProp.ClearArray();
            for (int i = 0; i < _nestedNobsCache.Count; i++)
            {
                nestedProp.InsertArrayElementAtIndex(i);
                nestedProp.GetArrayElementAtIndex(i).objectReferenceValue = _nestedNobsCache[i];
            }
        }

        serializedNob.ApplyModifiedProperties();
        EditorUtility.SetDirty(nob);

        for (int i = 0; i < _nbListCache.Count; i++)
        {
            NetworkBehaviour nb = _nbListCache[i];
            if (nb == null) continue;

            SerializedObject serializedNb = new SerializedObject(nb);
            SetSerializedField(serializedNb, (byte)i, "ComponentIndex", ComponentIndexNames);
            SetSerializedField(serializedNb, nob, "NetworkObject", NetworkObjectNames);
            SetSerializedField(serializedNb, nob, "AddedNetworkObject", AddedNetworkObjectNames);

            serializedNb.ApplyModifiedProperties();
            EditorUtility.SetDirty(nb);
        }
    }

    private static void GetNetworkBehaviours(Transform t, List<NetworkBehaviour> results)
    {
        _tempNbComponents.Clear();
        t.GetComponents(_tempNbComponents);
        for (int i = 0; i < _tempNbComponents.Count; i++)
        {
            NetworkBehaviour nb = _tempNbComponents[i];
            if (nb != null)
            {
                results.Add(nb);
            }
        }

        for (int i = 0; i < t.childCount; i++)
        {
            Transform child = t.GetChild(i);
            if (child != null && !child.TryGetComponent<NetworkObject>(out _))
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
                if (child.TryGetComponent<NetworkObject>(out var childNob))
                {
                    results.Add(childNob);
                }
                GetNestedNetworkObjects(child, results);
            }
        }
    }

    private static bool SetSerializedField(SerializedObject serializedObject, object value, string logicalKey, string[] possibleNames)
    {
        string propName = GetCachedPropertyName(serializedObject, logicalKey, possibleNames);
        if (string.IsNullOrEmpty(propName)) return false;

        SerializedProperty prop = serializedObject.FindProperty(propName);
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
        return false;
    }

    private static string GetCachedPropertyName(SerializedObject serializedObject, string logicalKey, string[] possibleNames)
    {
        Type type = serializedObject.targetObject.GetType();
        if (!_propertyNameCache.TryGetValue(type, out var typeCache))
        {
            typeCache = new Dictionary<string, string>();
            _propertyNameCache[type] = typeCache;
        }

        if (typeCache.TryGetValue(logicalKey, out string cachedName))
        {
            return cachedName;
        }

        foreach (var name in possibleNames)
        {
            SerializedProperty prop = serializedObject.FindProperty(name);
            if (prop != null)
            {
                typeCache[logicalKey] = name;
                return name;
            }
        }

        typeCache[logicalKey] = null;
        return null;
    }

    private static SerializedProperty FindPropertyCached(SerializedObject serializedObject, string logicalKey, string[] possibleNames)
    {
        string propName = GetCachedPropertyName(serializedObject, logicalKey, possibleNames);
        if (string.IsNullOrEmpty(propName)) return null;
        return serializedObject.FindProperty(propName);
    }

    private static string GetHierarchyPath(GameObject go)
    {
        _pathPartsCache.Clear();
        Transform current = go.transform;
        while (current != null)
        {
            _pathPartsCache.Add(current.name);
            current = current.parent;
        }
        _pathPartsCache.Reverse();
        return string.Join("/", _pathPartsCache);
    }

    private static ulong GetFNV1a64(string str)
    {
        if (string.IsNullOrEmpty(str)) return 0;

        ulong hash = 14695981039346656037UL;
        for (int i = 0; i < str.Length; i++)
        {
            char c = str[i];
            if (c == '\\')
            {
                c = '/';
            }
            else
            {
                c = char.ToLowerInvariant(c);
            }

            hash ^= c;
            hash *= 1099511628211UL;
        }
        return hash;
    }
}