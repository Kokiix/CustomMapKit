using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class StraftatTriggerZone : MonoBehaviour
{
	private Collider Collider;

	protected virtual void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	protected virtual void OnPlayerEnter(FirstPersonController player)
	{
	}

	protected virtual void OnPlayerExit(FirstPersonController player)
	{
	}

	protected virtual void OnPlayerStay(FirstPersonController player)
	{
	}

	protected virtual void OnPhysicsPropEnter(PhysicsProp physicsProp)
	{
	}

	protected virtual void OnPhysicsPropExit(PhysicsProp physicsProp)
	{
	}

	protected virtual void OnPhysicsPropStay(PhysicsProp physicsProp)
	{
	}
}
