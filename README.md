# Custom Map Kit

> [!CAUTION]
> This project is in early access and changing constantly. Expect things to break, and contact @zkoki on discord when they do.

> [!NOTE]
> Your maps will need [Custom Levels Reborn (CLR)](https://github.com/Kokiix/custom_levels_reborn) to work!

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

You may have some build errors to begin with, because the kit includes DLL dependencies for all in game components/stubs, where those DLLs include some Unity packages you may already have installed. Read the error messages to remove duplicates and resolve the build errors.

### General

When testing changes to your map, you don't have to restart your game unless you change the name of the scene or name/path of the bundle.

The name of your .unity file determines the name of your map in game. Your map bundle can be named whatever, and can hold multiple scenes. 

For materials and thumbnails to work, you must have a bundle that ends in `_resources`. Any texture with the same name as your scene file will be assigned as the thumbnail. All materials you use (except those from the shared bundle) must go in here, so that the map loader can swap their shaders for in game ones. For custom shaders, see the wiki.

All users with CLR have the `shared` bundle, for vanilla assets like item/player spawners, etc. If you would like a vanilla asset (that would likely be re-used) to be added to the bundle , contact `@zkoki` on Discord through DM or [the modding channel of the STRAFTAT server](https://discord.com/channels/1124764095623741473/1364522283485626368). You can also contact me for custom map behavior or weapons :)

---

[Technical details can be found at the wiki.](https://github.com/Kokiix/CustomMapKit/wiki/Technical-Details)
