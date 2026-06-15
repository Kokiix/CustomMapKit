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

2. Make a copy of the test map to begin your project. The name of your new map is determined by the name of the `.unity` file.

3. Set the name of your new map and change the weapon in the spawner to verify basic functionality.

4. The minimum export setup for a mod is a single *uniquely named* (`{USERNAME}-{MAP}` format would be smart) assetbundle with just the `.unity` file inside. You can have multiple `.unity` files in a bundle and multiple bundles exported.

5. Set the build location for your bundle in the `Assets/Editor/BundleBuild.cs` file. Your mod must contain a folder named `CustomMaps`, and that folder must hold only assetbundles, in order for those bundles to be loaded.

6. For thumbnails to work, you must **also** export an assetbundle with some name that ends in `_resources`. Any texture inside that matches the name of your map will be assigned as the thumbnail.

7. Install [Custom Levels Reborn (CLR)](https://thunderstore.io/c/straftat/p/koki/Custom_Levels_Reborn/) if needed.

8. Run the game! You should see your new map with the custom name and different spawner item. When testing changes to your map, you don't have to restart your game, unless you change path of the bundle or `.unity` file. Just exit and re-enter exploration mode.

**Note**

All users with CLR have the `clr_shared` bundle, which will contain vanilla assets like gameobjects, meshes, and textures. This system means map makers don't have to rip export assets themselves, saving on time and map filesize. If you would like a vanilla asset (that would likely be re-used) to be added to the bundle , contact `@zkoki`. You can also contact me for custom weapons or map behavior :)

The kit on Github comes with only **part of the full shared bundle**. Large files, like textures, can be found here: [Google Drive Link](https://drive.google.com/drive/folders/1jtC7cRzBCGVyK0x6aaHw7uumLnIWoA8o?usp=sharing)

---

[Find more information in the wiki.](https://github.com/Kokiix/CustomMapKit/wiki)
