using System;

namespace ComputerysModdingUtilities {
    /// <summary>
    /// This attribute is used to mark assemblies as Straftat mods, and if they are compatible with the vanilla game.
    /// This effects matchmaking. Mods that are not compatible with the vanilla game will not be able to join a vanilla game.
    ///
    /// By default, mods are not compatible with the vanilla game.
    /// If an assembly does not have this attribute, it is assumed to be a mod that is incompatible with the vanilla game.
    /// If an assembly with this attribute is marked as compatible with the vanilla game,
    /// dependencies of that assembly that lack a StraftatModAttribute will be marked as compatible.
    ///
    /// Disclaimer:
    /// Any mods that give the player an unfair advantage over other players are not allowed in the base game and should be marked as incompatible.
    /// Mods that do not mark themselves appropriately will be removed from thunderstore!
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public sealed class StraftatModAttribute : Attribute {
        public bool IsVanillaCompatible { get; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="StraftatModAttribute"/> class.
        /// </summary>
        /// <param name="isVanillaCompatible">
        /// Indicates whether the mod is compatible with the vanilla game.
        /// If true, the mod is compatible with the vanilla game and can be used in multiplayer with other players who are using the vanilla game.
        /// </param>
        public StraftatModAttribute(bool isVanillaCompatible = false) { IsVanillaCompatible = isVanillaCompatible; }
    }
}