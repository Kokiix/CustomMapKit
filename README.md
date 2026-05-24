# Custom Map Kit

> [!NOTE]
> Your maps will need Custom Levels Reborn {INSERT URL HERE} (CLR) to work!

## General Process

1. Put the contents of `Unity` into your unity project. 
2. Work on your map.
3. Build the assetbundle using the given script, or your own.
4. Playtest your map.
5. Repeat from step 2 as needed
6. Copy your assetbundles into `Thunderstore/CustomMaps` (subfolders allowed)
7. Upload to thunderstore :)   (Your zip must have `CustomMaps` at the root level.)

## Unity

### Setup

STRAFTAT (or at least this kit) was made in [Unity 2021.3.45f2](https://unity.com/releases/editor/whats-new/2021.3.45f2). The kit may possibly work in other versions, but I haven't tested anything.

If you're using the bundle exporter that comes with the kit in `Assets/Editor/BundleBuild.cs`, set your BepInEx plugin folder and folder structure for your assetbundles in there. Build bundles with the `Assets/Build Asset Bundles` menu in the top menu bar. As long as bundles are within `CustomMaps`, folder structure doesn't matter.

> [!WARNING]
> Linux users new to Unity, watch out for [issues potentially caused by bee_backend. Solutions are included in the linked discussion.](https://discussions.unity.com/t/linux-editor-stuck-on-loading-because-of-bee-backend-w-workaround/854480)

### General

The name of your .unity file determines the name of your map in game. Your map bundle can be named whatever, and can hold multiple scenes. To create a thumbnail, create a new bundle (Unity requires scene bundles and general assetbundles to be separate) with a Texture2D that has the same name as your scene (you can have multiple thumbnails in this bundle). If you're using the default bundle build script, naming your thumbnail bundle `{SCENE_BUNDLE_NAME}_resources` will make your thumbnail bundle export alongside your scene bundle, without having to define it in the build script.

Assets in the "shared" folder should be marked with the "shared" bundle, and will be ignored by the bundle exporter that comes with the kit. If you use your own bundle export method, make sure to ignore the bundle, or avoid copying it to your Thunderstore package. Every user that has CLR will have a bundle with the shared assets. 

The shared bundle should (mostly) represent vanilla assets, so that map makers do not have to not re-export vanilla assets constantly. If you would like a vanilla asset (that would likely be re-used) to be added to the bundle , contact `@zkoki` on Discord. You can also contact me for custom map behavior or weapons :)

---

[Technical details can be found at the wiki.](https://github.com/Kokiix/CustomMapKit/wiki/Technical-Details)