using UnityEngine;

public class MapSelection : MonoBehaviour
{
	public static MapSelection Instance;

	public SceneMotor sceneMotor;

	private SelectSceneInstance[] sceneInstances;

	[SerializeField]
	private string[] sceneNames;

	[SerializeField]
	private GameObject sceneInstance;

	[Space]
	[SerializeField]
	private GameObject loadPlaylistPanel;

	private bool haveInitiated;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void PopulateMaps()
	{
	}

	public void InitiateMaps()
	{
	}

	public void LoadScenes(string[] tempscenes)
	{
	}

	public void UpdateScenes()
	{
	}

	public void SelectAll()
	{
	}

	public void DeselectAll()
	{
	}

	public void AddPlaylistFromSelection()
	{
	}
}
