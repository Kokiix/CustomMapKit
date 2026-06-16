using UnityEditor;
using System.IO;
using UnityEngine;
using System;
using System.Linq;
using System.Collections.Generic;

public static class BundleBuilder
{
    // CHANGE THIS STUFF ---------------------------------------------------------------------------------------------------------------------------

    // Set once -----------------------------------------------------------------------
    private const string pluginDir = @"C:\Users\koki\AppData\Roaming\com.kesomannen.gale\straftat\profiles\Default\BepInEx\plugins";

    private const BuildTarget osTarget = BuildTarget.StandaloneWindows64; // Windows
    // private const BuildTarget osTarget = BuildTarget.StandaloneLinux64 // Linux
    // ---------------------------------------------------------------------------------


    // Set this every time you make a new bundle
    private static readonly Dictionary<string, string> bundleDestinations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        // These dirs are appended to your pluginDir set above.
        // _resources bundles with the same name as your main bundle will automatically be exported to the same dir (ex. testmap_resources)

        { "testmap", @"DEVELOPMENT-BUILD-testmap\CustomMaps" },

        // Duplicate and uncomment the line below, then fill in the all caps words, for each of your bundles.
        // Underneath CustomMaps you can have whatever folder structure you want, like CustomMaps\map_01, CustomMaps\map_02, etc
        // { "BUNDLE_NAME", @"YOUR_MOD_NAME\CustomMaps" },
    };
    // ---------------------------------------------------------------------------------------------------------------------------------------------


    private const string localBuildDir = "AssetBundles";

    [MenuItem("Assets/Build AssetBundles")]
    public static void PerformBuild()
    {
        FishNetMetadataSetup.SetupAllNetworkObjectsInProject();

        foreach (var entry in bundleDestinations.ToList())
        {
            bundleDestinations.Add(entry.Key + "_resources", entry.Value);
        }

        if (!Directory.Exists(localBuildDir)) Directory.CreateDirectory(localBuildDir);
        var manifest = BuildPipeline.BuildAssetBundles(localBuildDir, BuildAssetBundleOptions.None, osTarget);
        var bundles = manifest.GetAllAssetBundles().Where(bundleDestinations.ContainsKey);
        foreach (string bundleName in bundles)
        {
            var srcFile = Path.Combine(localBuildDir, bundleName);
            var exportDir = Path.Combine(pluginDir, bundleDestinations[bundleName]);
            if (!Directory.Exists(exportDir))
                Directory.CreateDirectory(exportDir);
            File.Copy(srcFile, Path.Combine(exportDir, bundleName), overwrite: true);
        }

        Debug.Log($"Bundle Build Complete.");
    }
}