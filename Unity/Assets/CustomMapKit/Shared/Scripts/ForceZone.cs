using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class ForceZone : StraftatTriggerZone
{
	[Header("Applied continuously to the player while in the zone")]
	public Vector3 force;

	private readonly HashSet<FirstPersonController> _players;

	private readonly HashSet<PhysicsProp> _physicsProps;

	protected override void OnPlayerEnter(FirstPersonController player)
	{
	}

	protected override void OnPlayerExit(FirstPersonController player)
	{
	}

	protected override void OnPhysicsPropEnter(PhysicsProp physicsProp)
	{
	}

	protected override void OnPhysicsPropExit(PhysicsProp physicsProp)
	{
	}

	public void Update()
	{
	}
}
