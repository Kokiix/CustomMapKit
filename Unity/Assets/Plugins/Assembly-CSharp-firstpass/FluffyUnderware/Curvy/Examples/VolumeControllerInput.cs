using FluffyUnderware.Curvy.Controllers;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	public class VolumeControllerInput : MonoBehaviour
	{
		public float AngularVelocity;

		public ParticleSystem explosionEmitter;

		public VolumeController volumeController;

		public Transform rotatedTransform;

		public float maxSpeed;

		public float accelerationForward;

		public float accelerationBackward;

		private bool mGameOver;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void ResetController()
		{
		}

		private void Update()
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		private void StartOver()
		{
		}
	}
}
