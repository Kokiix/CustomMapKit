using UnityEngine;

[CreateAssetMenu(fileName = "PlaylistPreset", menuName = "ComputeryStuff/PlaylistPreset", order = 1)]
public class PlaylistPreset : ScriptableObject
{
	public string Name;

	public string[] Maps;

	[Header("This will make the playlist only available if the player owns the DLC, you can include DLC exclusive maps in non-DLC playlists, but they will not show up if the player does not own the DLC.")]
	public bool IsDlcExclusive;
}
