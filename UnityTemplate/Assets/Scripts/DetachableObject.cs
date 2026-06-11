using FishNet.Object;
using UnityEngine;

public class DetachableObject : NetworkObject
{
	[SerializeField]
	private GameObject vfx;

	[SerializeField]
	private float ejectForce;

	private Rigidbody rb;

	private new void Start()
	{
	}

	public void Detach(Vector3 hitNormal, Vector3 direction)
	{
	}
}
