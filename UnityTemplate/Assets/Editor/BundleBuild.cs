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
    private const string BepInExPluginDir = @"C:\Users\koki\AppData\Roaming\com.kesomannen.gale\straftat\profiles\Default\BepInEx\plugins";

    private const BuildTarget OSTarget = BuildTarget.StandaloneWindows64; // Windows
    // private const BuildTarget OSTarget = BuildTarget.StandaloneLinux64 // Linux
    // ---------------------------------------------------------------------------------


    // Set this for every new bundle
    private static readonly Dictionary<string, string> bundleDestinations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        { "testmap", @"DEVELOPMENT-BUILD-testmap\CustomMaps" },
        { "testmap_resources", @"DEVELOPMENT-BUILD-testmap\CustomMaps" },
        // { "BUNDLE_NAME", @"MOD_FOLDER_NAME\CustomMaps" },

        /* 
        The directories above will be created under the BepInEx pluginDir. Your mod folder must have a folder named "CustomMaps" that only holds assetbundles.

        Below are 2 example map structures.

        Example A:

                MOD_FOLDER_NAME/
                └── CustomMaps/
                   ├── map_name_resources
                   └── map_name

                { "map_name_resources", @"MOD_FOLDER_NAME\CustomMaps\" },
                { "map_name", @"MOD_FOLDER_NAME\CustomMaps\" },

        Example B:

                MOD_FOLDER_NAME/
                ├── CustomMaps/
                │   ├── mymap_resources
                │   ├── map-series-a/
                │   │   ├── map_a_00
                │   │   └── map_a_01
                │   ├── map-series-b/
                │   │   ├── map_b_00
                │   │   └── map_b_01
                ├── manifest.json
                ├── README.md
                └── thumbnail.png

                { "mymap_resources", @"MOD_FOLDER_NAME\CustomMaps\" },
                { "map_a_00", @"MOD_FOLDER_NAME\CustomMaps\map-series-a" },
                { "map_a_01", @"MOD_FOLDER_NAME\CustomMaps\map-series-a" },
                { "map_b_00", @"MOD_FOLDER_NAME\CustomMaps\map-series-b" },
                { "map_b_01", @"MOD_FOLDER_NAME\CustomMaps\map-series-b" },

                (manifest, README, etc, will be present in final mod but aren't needed for testing)
        
        */
    };
    // ---------------------------------------------------------------------------------------------------------------------------------------------


    private const string localBuildDir = "AssetBundles";

    [MenuItem("Assets/Build AssetBundles")]
    public static void PerformBuild()
    {
        FishNetMetadataSetup.SetupAllNetworkObjectsInProject();

        if (!Directory.Exists(localBuildDir)) Directory.CreateDirectory(localBuildDir);
        var manifest = BuildPipeline.BuildAssetBundles(localBuildDir, BuildAssetBundleOptions.None, OSTarget);
        var bundles = manifest.GetAllAssetBundles().Where(bundleDestinations.ContainsKey);
        foreach (string bundleName in bundles)
        {
            var srcFile = Path.Combine(localBuildDir, bundleName);
            var exportDir = Path.Combine(BepInExPluginDir, bundleDestinations[bundleName]);
            if (!Directory.Exists(exportDir))
                Directory.CreateDirectory(exportDir);
            File.Copy(srcFile, Path.Combine(exportDir, bundleName), overwrite: true);
        }

        Debug.Log($"Bundle Build Complete.");
    }
}