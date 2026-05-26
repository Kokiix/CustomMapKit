using System.Collections.Generic;
using UnityEngine;

public class EjectedCaseScript : MonoBehaviour
{
	[SerializeField]
	private AudioClip[] normalCase;

	[SerializeField]
	private AudioClip shotgunCase;

	public int ejectCaseIndex;

	private AudioSource source;

	public bool shouldPlaySound;

	private bool triggered;

	public ParticleSystem part;

	public List<ParticleCollisionEvent> collisionEvents;

	private void Awake()
	{
	}

	private void OnParticleCollision(GameObject other)
	{
	}
}
