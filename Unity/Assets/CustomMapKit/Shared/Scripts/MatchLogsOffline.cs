using UnityEngine;

public class MatchLogsOffline : MonoBehaviour
{
	private GameObject ChatBox;

	public GameObject chatLinePrefab;

	public Transform parentForChatLines;

	public float duration;

	public float fadeDuration;

	public ClientInstance localPlayer;

	private string previousLine;

	public static MatchLogsOffline Instance { get; private set; }

	private void Awake()
	{
	}

	public void WriteLog(string line)
	{
	}

	private void OnDisable()
	{
	}
}
