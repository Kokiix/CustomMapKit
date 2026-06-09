# Custom Map Kit

> [!CAUTION]
> This project is functional, but under development. At the moment, making a map will likely requiring contacting `@zkoki` on Discord (through DM or [STRAFTAT server modding channel](https://discord.gg/xjx7PNq5)) for features or help.

> [!NOTE]
> Your maps will need [Custom Levels Reborn (CLR)](https://thunderstore.io/c/straftat/p/koki/Custom_Levels_Reborn/) to work!
> Your bundles will automatically be loaded by CLR. Don't create a bundle loader plugin unless you know what you're doing.

## General Process

1. Put the contents of `Unity` into your unity project. 
2. Work on your map.
3. Build the assetbundle using the given script, or your own.
4. Playtest your map. (Go back to step 2 if needed)
6. Copy your assetbundles into `Thunderstore/CustomMaps` (subfolders allowed)
7. Upload to thunderstore :)   (Your zip must have `CustomMaps` at the root level.)

### Setup

> [!WARNING]
> The kit comes with .dll in `Assets/Plugins`. You might already have some of these installed as packages, causing Unity to freak out about the duplicates. Remove the duplicates to resolve build errors.

1. Install Unity (Only [Unity 2021.3.45f2](https://unity.com/releases/editor/whats-new/2021.3.45f2) has been tested to work.)

2. (If you're using the bundle exporter that comes with the kit in `Assets/Editor/BundleBuild.cs`) Set your BepInEx plugin folder and folder structure for your assetbundles in the bundle build script. As long as the bundles end up inside `CustomMaps`, folder structure doesn't matter. Bundles are built using `Assets/Build Asset Bundles` in the top menu bar.

3. Make a copy of the test map to begin your project. The name of your new map is determined by the name of the `.unity` file. Your map bundle can be named whatever, and can hold multiple scenes. The version of your map is determined by the `manifest.json` in your Thunderstore upload.

4. For materials and thumbnails to work, you must export some assetbundle that ends in `_resources`. Any texture with the same name as your scene file will be assigned as the thumbnail. All materials you use (except those from the shared bundle) must go in here, so that the map loader can swap the bundled shaders for in game their in game equivalents. For custom shaders, see the wiki.

5. Set the name of your new map, change the weapon in the spawner, and export. Install [Custom Levels Reborn (CLR)](https://thunderstore.io/c/straftat/p/koki/Custom_Levels_Reborn/) if needed.

6. Run the game! You should see your new map with the custom name and different spawner item. When testing changes to your map, you don't have to restart your game, unless you change the name of the scene or name/path of the bundle. Just exit and re-enter exploration mode.

**Note**

All users with CLR have the `shared` bundle, which will contain vanilla assets like item/player spawners, ladders, materials, etc. This system means map makers don't have to rip assets themselves and export assets individually (which saves on map size). If you would like a vanilla asset (that would likely be re-used) to be added to the bundle , contact `@zkoki`. You can also contact me for custom weapons or map behavior :)

Large(ish) files for the shared bundle can be found here: [Google Drive Link](https://drive.google.com/drive/folders/1jtC7cRzBCGVyK0x6aaHw7uumLnIWoA8o?usp=sharing)

---

[Find more information in the wiki.](https://github.com/Kokiix/CustomMapKit/wiki)
