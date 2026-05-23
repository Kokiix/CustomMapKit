using UnityEditor;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

// WARNING: Vibe Coded

public class BundleBuilder : EditorWindow
{
    private static readonly string localDir = "AssetBundles";

    public static readonly string YourModName = "TestName";

    private static readonly string targetDir = @"C:\Users\koki\AppData\Roaming\com.kesomannen.gale\straftat\profiles\Default\BepInEx\plugins\" + YourModName + @"\bundles";
    private static readonly string hashCacheFile = "AssetBundles/build_hashes.json";

    [MenuItem("Assets/Build AssetBundles")]
    public static void PerformBuild()
    {
        if (!Directory.Exists(localDir)) Directory.CreateDirectory(localDir);
        if (!Directory.Exists(targetDir)) Directory.CreateDirectory(targetDir);

        AssetBundleManifest manifest;
        manifest = BuildPipeline.BuildAssetBundles(localDir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        if (manifest != null) CopyChangedBundles(manifest);
    }

    static void CopyChangedBundles(AssetBundleManifest manifest)
    {
        string[] bundles = manifest.GetAllAssetBundles();
        Dictionary<string, string> oldHashes = LoadHashes();
        Dictionary<string, string> newHashes = new Dictionary<string, string>();
        int copiedCount = 0;

        foreach (string bundleName in bundles)
        {
            // 1. Check if the bundle has changed using Unity's internal Hash
            string currentHash = manifest.GetAssetBundleHash(bundleName).ToString();
            newHashes[bundleName] = currentHash;

            bool hasChanged = !oldHashes.ContainsKey(bundleName) || oldHashes[bundleName] != currentHash;
            string destFile = Path.Combine(targetDir, bundleName);

            // 2. Only copy if changed or missing
            if (hasChanged || !File.Exists(destFile))
            {
                string sourceFile = Path.Combine(localDir, bundleName);
                if (File.Exists(sourceFile))
                {
                    // WE ONLY COPY THE BUNDLE FILE - NO .MANIFEST COPIES HERE
                    File.Copy(sourceFile, destFile, true);
                    Debug.Log($"<color=cyan>Exported:</color> {bundleName}");
                    copiedCount++;
                }
            }
        }

        SaveHashes(newHashes);
        Debug.Log($"Build Complete. {copiedCount} bundles exported to Plugins (Manifests ignored).");
    }

    #region Hash System
    private static Dictionary<string, string> LoadHashes()
    {
        if (!File.Exists(hashCacheFile)) return new Dictionary<string, string>();
        try
        {
            return JsonUtility.FromJson<HashContainer>(File.ReadAllText(hashCacheFile)).ToDict();
        }
        catch { return new Dictionary<string, string>(); }
    }

    private static void SaveHashes(Dictionary<string, string> dict) =>
        File.WriteAllText(hashCacheFile, JsonUtility.ToJson(new HashContainer(dict)));

    [System.Serializable]
    private class HashContainer
    {
        public List<string> k = new List<string>(); public List<string> v = new List<string>();
        public HashContainer(Dictionary<string, string> d) { foreach (var n in d) { k.Add(n.Key); v.Add(n.Value); } }
        public Dictionary<string, string> ToDict()
        {
            var d = new Dictionary<string, string>();
            for (int i = 0; i < k.Count; i++) d[k[i]] = v[i];
            return d;
        }
    }
    #endregion
}