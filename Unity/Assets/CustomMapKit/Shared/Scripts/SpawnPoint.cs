using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	[Tooltip("Radius of this spawn point.")]
	[SerializeField]
	private float _radius;

	[SerializeField]
	private bool snapToGround;

	public float Radius => 0f;

	private void Awake()
	{
	}

	private void SnapToGround()
	{
	}
}
