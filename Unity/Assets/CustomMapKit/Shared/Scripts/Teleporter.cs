using UnityEngine;

public class Teleporter : MonoBehaviour
{
	public bool dontTranslateRotation;

	[Space]
	public Transform teleportPoint;

	public Transform selfOrientation;

	public float propulsionPower;

	public float propulsionDecel;

	public float anglesDifference;

	private void Start()
	{
	}
}
