using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	[ExecuteInEditMode]
	public class TrainManager : MonoBehaviour
	{
		public CurvySpline Spline;

		public float Speed;

		public float Position;

		public float CarSize;

		public float AxisDistance;

		public float CarGap;

		public float Limit;

		private bool isSetup;

		private TrainCarManager[] Cars;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private void setup()
		{
		}
	}
}
