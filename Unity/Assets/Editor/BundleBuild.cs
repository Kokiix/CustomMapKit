using UnityEditor;
using System.IO;
using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

// Caution: mostly vibe coded

public static class BundleBuilder
{
    private static readonly string localDir = "AssetBundles";

    // CHANGE THIS STUFF ---------------------------------------------------------------------------------------------------------------------------

    // Set once
    private static readonly BuildTarget platform = BuildTarget.StandaloneWindows64; // BuildTarget.StandaloneLinux64 for linux
    private static readonly string pluginDir = @"C:\Users\koki\AppData\Roaming\com.kesomannen.gale\straftat\profiles\Default\BepInEx\plugins";

    // Update whenever you make new bundles
    private static readonly List<string> bundlesToIgnore = new() { "shared" };
    private static readonly Dictionary<string, string> bundleToOutputDir = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        // These output dirs are appended to your plugin directory set above
        { "testmap", @"DEVELOPMENT-BUILD-testmap\Custom Maps" }
    };
    // ---------------------------------------------------------------------------------------------------------------------------------------------

    [MenuItem("Assets/Build AssetBundles")]
    public static void PerformBuild()
    {
        if (!Directory.Exists(localDir)) Directory.CreateDirectory(localDir);

        AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(localDir, BuildAssetBundleOptions.None, platform);
        if (manifest != null)
        {
            CopyChangedBundles(manifest);
        }
    }

    static void CopyChangedBundles(AssetBundleManifest manifest)
    {
        var bundles = manifest.GetAllAssetBundles().Where(b => !bundlesToIgnore.Contains(b));
        int copiedCount = 0;

        foreach (string bundleName in bundles)
        {
            string currentTargetDir = GetTargetDirectory(bundleName);
            if (currentTargetDir == "") continue;

            string mainSource = Path.Combine(localDir, bundleName);
            string mainDest = Path.Combine(currentTargetDir, bundleName);
            if (CopyFileIfNewer(mainSource, mainDest))
            {
                copiedCount++;
            }
        }

        Debug.Log($"Build Complete. {copiedCount} bundles exported to Plugins.");
    }

    static string GetTargetDirectory(string bundleName)
    {
        if (bundleName.EndsWith("_resources"))
        {
            bundleName = bundleName[..^10];
            if (bundlesToIgnore.Contains(bundleName)) return "";
        }
        if (!bundleToOutputDir.TryGetValue(bundleName, out string projectDir))
        {
            throw new Exception($"No output dir has been set for bundle {bundleName}!");
        }
        else if (!projectDir.Contains("Custom Maps") && bundleName != "shared")
        {
            throw new Exception("Your mod folder must have a folder named 'Custom Maps' to be seen by Custom Levels Reborn!");
        }

        return Path.Combine(pluginDir, projectDir);
    }

    static bool CopyFileIfNewer(string sourceFile, string destFile)
    {
        if (!File.Exists(sourceFile)) return false;

        // Ensure the target folder exists dynamically before writing files
        string destDir = Path.GetDirectoryName(destFile);
        if (!string.IsNullOrEmpty(destDir) && !Directory.Exists(destDir))
        {
            Directory.CreateDirectory(destDir);
        }

        // Only copy if the destination doesn't exist, or the source file is newer than the destination
        if (!File.Exists(destFile) || File.GetLastWriteTimeUtc(sourceFile) > File.GetLastWriteTimeUtc(destFile))
        {
            File.Copy(sourceFile, destFile, true);
            Debug.Log($"<color=cyan>Exported:</color> {Path.GetFileName(sourceFile)} to {destDir}");
            return true;
        }

        return false;
    }
}