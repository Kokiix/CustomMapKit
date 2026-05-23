using UnityEditor;
using System.IO;
using UnityEngine;
using System;

// Vibe coded

public static class BundleBuilder
{
    private static readonly string localDir = "AssetBundles";


    // CHANGE THIS STUFF -------------------------------------------------------------------------------------------------------------------------------
    private static readonly string pluginDir = @"C:\Users\koki\AppData\Roaming\com.kesomannen.gale\straftat\profiles\Default\BepInEx\plugins\";
    private static readonly string projectDir = "DEVELOPMENT-BUILD-My Test Map";
    // -------------------------------------------------------------------------------------------------------------------------------------------------


    // And maybe this if you want to
    private static readonly string targetDir = pluginDir + projectDir + @"\CustomMaps"; // "CustomMaps" folder exact naming required for CLR

    [MenuItem("Assets/Build AssetBundles")]
    public static void PerformBuild()
    {
        if (!Directory.Exists(localDir)) Directory.CreateDirectory(localDir);
        if (!Directory.Exists(targetDir)) Directory.CreateDirectory(targetDir);

        AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(localDir, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        if (manifest != null)
        {
            CopyChangedBundles(manifest);
        }
    }

    static void CopyChangedBundles(AssetBundleManifest manifest)
    {
        string[] bundles = manifest.GetAllAssetBundles();
        int copiedCount = 0;

        foreach (string bundleName in bundles)
        {
            // Skip the "shared" bundle entirely
            if (string.Equals(bundleName, "shared", System.StringComparison.OrdinalIgnoreCase))
            {
                continue;
            }

            string sourceFile = Path.Combine(localDir, bundleName);
            string destFile = Path.Combine(targetDir, bundleName);

            if (!File.Exists(sourceFile)) continue;

            // Only copy if the destination doesn't exist, or the source file is newer than the destination
            if (!File.Exists(destFile) || File.GetLastWriteTimeUtc(sourceFile) > File.GetLastWriteTimeUtc(destFile))
            {
                File.Copy(sourceFile, destFile, true);
                Debug.Log($"<color=cyan>Exported:</color> {bundleName}");
                copiedCount++;
            }
        }

        Debug.Log($"Build Complete. {copiedCount} bundles exported to Plugins (Manifests ignored).");
    }
}