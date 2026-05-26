using UnityEngine;

public struct MusicTrack
{
	public readonly string AudioPath;

	public readonly string TrackName;

	public readonly string ArtistName;

	public readonly int TrackNumber;

	public readonly AudioType AudioType;

	public MusicTrack(string audioPath, string trackName, string artistName, int trackNumber, AudioType audioType)
	{
		AudioPath = null;
		TrackName = null;
		ArtistName = null;
		TrackNumber = 0;
		AudioType = default(AudioType);
	}
}
