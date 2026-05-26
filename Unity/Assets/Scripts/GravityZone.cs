using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class GravityZone : StraftatTriggerZone
{
	[SerializeField]
	private float gravityMultiplier;

	private readonly HashSet<PhysicsProp> _physicsProps;

	private readonly HashSet<PhysicsProp> _lastUpdatePhysicsProps;

	protected override void Awake()
	{
	}

	protected override void OnPlayerEnter(FirstPersonController player)
	{
	}

	protected override void OnPlayerExit(FirstPersonController player)
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
