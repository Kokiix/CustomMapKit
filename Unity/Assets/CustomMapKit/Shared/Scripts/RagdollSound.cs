using UnityEngine;

public class RagdollSound : MonoBehaviour
{
	private float timer;

	private bool trigger;

	[SerializeField]
	private AudioClip groundHitClip;

	[SerializeField]
	private AudioSource audio;

	private void Update()
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}
}
