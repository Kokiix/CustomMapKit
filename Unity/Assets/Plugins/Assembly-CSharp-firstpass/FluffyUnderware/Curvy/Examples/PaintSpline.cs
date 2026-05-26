using FluffyUnderware.Curvy.Controllers;
using UnityEngine;
using UnityEngine.UI;

namespace FluffyUnderware.Curvy.Examples
{
	public class PaintSpline : MonoBehaviour
	{
		public float StepDistance;

		public SplineController Controller;

		public Text InfoText;

		private CurvySpline mSpline;

		private Vector2 mLastControlPointPos;

		private bool mResetSpline;

		private void Awake()
		{
		}

		private void OnGUI()
		{
		}

		private CurvySplineSegment addCP(Vector3 mousePos)
		{
			return null;
		}
	}
}
