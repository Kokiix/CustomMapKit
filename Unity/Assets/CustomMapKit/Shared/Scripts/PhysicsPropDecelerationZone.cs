using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PhysicsPropDecelerationZone : StraftatTriggerZone
{
	[SerializeField]
	private float decelerationMultiplier;

	private readonly HashSet<PhysicsProp> _physicsProps;

	private readonly HashSet<PhysicsProp> _lastUpdatePhysicsProps;

	protected override void Awake()
	{
	}

	public void FixedUpdate()
	{
	}

	protected override void OnPhysicsPropStay(PhysicsProp physicsProp)
	{
	}

	protected override void OnPhysicsPropEnter(PhysicsProp physicsProp)
	{
	}

	protected override void OnPhysicsPropExit(PhysicsProp physicsProp)
	{
	}
}
