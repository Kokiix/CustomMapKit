using HeathenEngineering.PhysKit;

public struct BallisticPathFollowSyncData
{
	public float time;

	public int previous;

	public bool playing;

	public BallisticPath[] path;

	public bool isAppending;
}
