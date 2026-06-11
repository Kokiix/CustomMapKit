using UnityEngine;
using UnityEngine.SceneManagement;

public class RichPresenceManager : MonoBehaviour
{
	private string currentMapName;

	public static RichPresenceManager Instance { get; private set; }

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetStatusText(string status)
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public void UpdateStatusFromGameState()
	{
	}
}
