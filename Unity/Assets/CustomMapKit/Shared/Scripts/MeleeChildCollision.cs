using UnityEngine;

public class MeleeChildCollision : MonoBehaviour
{
	[SerializeField]
	private MeleeWeapon weaponScript;

	[SerializeField]
	private ItemBehaviour behaviour;

	[SerializeField]
	private GameObject graphicalObject;

	[SerializeField]
	private GameObject hitVFX;

	[SerializeField]
	private GameObject trailObject;

	[SerializeField]
	private AudioClip hitSFX;

	public bool canHit;

	public bool canHitEnvi;

	private int hitsCounter;

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
