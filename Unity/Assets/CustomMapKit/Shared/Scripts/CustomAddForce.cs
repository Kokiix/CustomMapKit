using UnityEngine;

public class CustomAddForce : MonoBehaviour
{
	[SerializeField]
	private float mass;

	private Vector3 impact;

	private CharacterController character;

	private FirstPersonController controller;

	[SerializeField]
	private float airdeceleration;

	[SerializeField]
	private float deceleration;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void AddForce(Vector3 dir, float force)
	{
	}
}
