# Custom Map Kit

> [!NOTE]
> Your maps will need Custom Levels Reloaded {INSERT URL HERE} (CLR) to work!

### General Process

1. Put the contents of `Unity` into your unity project. 
2. Work on your map.
3. Build the assetbundle using the given script, or your own.
4. Playtest your map.
5. Repeat from step 2 as needed
6. Copy your assetbundles into `Thunderstore/CustomMaps` (subfolders allowed)
7. Upload to thunderstore :)   (Your zip must have `CustomMaps` at the root level.)

### Unity

The name of your .unity file determines the name of your map in game. Your assetbundle name must match the name of your map (case insensitive). Create a thumbnail by assigning a certain bundle name to some Texture2D. This name should be the name of your main bundle, plus `_resources`. See the test map for examples.

Assets in the "shared" folder should be marked with the "shared" bundle, and will be ignored by the bundle exporter that comes with the kit. If you use your own bundle export method, make sure to ignore the bundle, or avoid copying it to your Thunderstore package. Every user that has CLR will have a bundle with the shared assets. 

The shared bundle should (mostly) represent vanilla assets, so that map makers do not have to not re-export vanilla assets constantly. If you would like a vanilla asset (that would likely be re-used) to be added to the bundle , contact `@zkoki` on Discord. You can also contact me for custom map behavior or weapons :)