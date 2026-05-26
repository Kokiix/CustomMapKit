using FluffyUnderware.DevTools;
using UnityEngine;
using UnityEngine.UI;

namespace FluffyUnderware.Curvy.Examples
{
	[ExecuteInEditMode]
	public class MoveToNearestPoint : MonoBehaviour
	{
		public Transform Lookup;

		public CurvySpline Spline;

		public Text StatisticsText;

		public Slider Density;

		private TimeMeasure Timer;

		private void Update()
		{
		}

		public void OnSliderChange()
		{
		}
	}
}
