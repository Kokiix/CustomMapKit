# Custom Map Kit

> [!CAUTION]
> This project is functional, but under development. At the moment, making a map will likely requiring contacting `@zkoki` on Discord (through DM or [STRAFTAT server modding channel](https://discord.gg/xjx7PNq5)) for features or help.

> [!NOTE]
> Your maps will need [Custom Levels Reborn (CLR)](https://thunderstore.io/c/straftat/p/koki/Custom_Levels_Reborn/) to work!
> Your bundles will automatically be loaded by CLR. Don't create a bundle loader plugin unless you know what you're doing.

### Unity Setup

> [!WARNING]
> The kit comes with `.dll`s in `Assets/Plugins`. You might already have some of these installed as packages, causing Unity to freak out about the duplicates. Remove the conflicting `.dll` to resolve build errors.

1. Install Unity (Only [Unity 2021.3.45f2](https://unity.com/releases/editor/whats-new/2021.3.45f2) has been tested to work.), then move the contents of the `UnityTemplate` folder into a new or existing Unity project.

2. Make a copy of the test map to begin your project. The name of your new map is determined by the name of the `.unity` file. Change the name of your new map and the spawner weapons to verify basic functionality.

3. Maps are exported through AssetBundles ([Unity Manual Link](https://docs.unity3d.com/6000.0/Documentation/Manual/assetbundles-section.html)). At the minimum, have 1 bundle for all your `.unity` files and 1 for your thumbnail textures (thumbnails are linked to maps by matching filename). The thumbnail bundle should end with `_resources` and ideally match the name of a scene bundle (like `testmap` and `testmap_resources`). Create/set the 2 bundles for your new map.

4. Open `Assets/Editor/BundleBuild.cs` and fill out the info inside.

5. Build bundles using the top menu bar (`Assets/Build Asset Bundles`).

6. Install [Custom Levels Reborn (CLR)](https://thunderstore.io/c/straftat/p/koki/Custom_Levels_Reborn/) if needed.

7. Run the game! You should see your new map with the custom name and different spawner item. When testing changes to your map, you don't have to restart your game, unless you change path of the bundle or `.unity` file. Just exit and re-enter exploration mode.

**Note**

All users with CLR have the `clr_shared` bundle, which will contain vanilla assets like gameobjects, meshes, and textures. This system means map makers don't have to rip export assets themselves, saving on time and map filesize. If you would like a vanilla asset (that would likely be re-used) to be added to the bundle , contact `@zkoki`. You can also contact me for custom weapons or map behavior :)

The kit on Github comes with only **part of the full shared bundle**. Large files, like textures, can be found here: [Google Drive Link](https://drive.google.com/drive/folders/1jtC7cRzBCGVyK0x6aaHw7uumLnIWoA8o?usp=sharing)

---

[Find more information in the wiki.](https://github.com/Kokiix/CustomMapKit/wiki)
