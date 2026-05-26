using FluffyUnderware.Curvy.Generator;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	public class PerformanceDynamicSpline : MonoBehaviour
	{
		private CurvySpline mSpline;

		public CurvyGenerator Generator;

		[Positive]
		public int UpdateInterval;

		[RangeEx(2f, 2000f, "", "")]
		public int CPCount;

		[Positive]
		public float Radius;

		public bool AlwaysClear;

		public bool UpdateCG;

		private float mAngleStep;

		private float mCurrentAngle;

		private float mLastUpdateTime;

		private TimeMeasure ExecTimes;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void addCP()
		{
		}

		private void OnGUI()
		{
		}
	}
}
