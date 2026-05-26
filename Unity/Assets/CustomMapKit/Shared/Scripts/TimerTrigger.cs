using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
	public enum TriggerType
	{
		Start = 0,
		Checkpoint = 1,
		End = 2,
		ShowUI = 3
	}

	[SerializeField]
	private TriggerType type;

	private TimerManager timerManager;

	private string courseName;

	private Renderer renderer;

	private Material matDefault;

	public Material checkpointMatActive;

	private void Start()
	{
	}

	public void SetMatActive(string course, int checkpointNumber)
	{
	}

	private void SetMatActiveFirstCheckpoint(string c)
	{
	}

	private void SetMatVisible(string c)
	{
	}

	private void SetMatInvisible(string c)
	{
	}

	public void ResetMat()
	{
	}

	public void HideMat()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
