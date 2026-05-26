using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ImpulseZone : StraftatTriggerZone
{
	[Header("Applied once when a player enters the trigger")]
	public Vector3 force;

	protected override void OnPlayerEnter(FirstPersonController player)
	{
	}

	protected override void OnPhysicsPropEnter(PhysicsProp physicsProp)
	{
	}
}
