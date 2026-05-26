using FluffyUnderware.Curvy.Controllers;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	[ExecuteInEditMode]
	public class TrainCarManager : MonoBehaviour
	{
		public SplineController Waggon;

		public SplineController FrontAxis;

		public SplineController BackAxis;

		private TrainManager mTrain;

		public float Position
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private void LateUpdate()
		{
		}

		public void setup()
		{
		}

		private void setController(SplineController c, CurvySpline spline, float speed)
		{
		}

		public void OnCPReached(CurvySplineMoveEventArgs e)
		{
		}
	}
}
