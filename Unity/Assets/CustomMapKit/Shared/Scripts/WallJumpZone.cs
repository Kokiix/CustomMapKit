using UnityEngine;

[RequireComponent(typeof(Collider))]
public class WallJumpZone : StraftatTriggerZone
{
	[SerializeField]
	private bool resetAllWallJumps;

	[SerializeField]
	private int wallJumpsToAdd;

	protected override void OnPlayerEnter(FirstPersonController player)
	{
	}
}
