using FluffyUnderware.Curvy.Controllers;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	[ExecuteInEditMode]
	public class TrainCarDrifter : MonoBehaviour
	{
		public float speed;

		public float wheelSpacing;

		public Vector3 bodyOffset;

		public SplineController controllerWheelLeading;

		public SplineController controllerWheelTrailing;

		public Transform trainCar;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
