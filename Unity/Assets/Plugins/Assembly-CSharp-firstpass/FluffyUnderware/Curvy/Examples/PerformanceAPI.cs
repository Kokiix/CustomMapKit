using System.Collections.Generic;
using System.Reflection;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	public class PerformanceAPI : MonoBehaviour
	{
		private const int LOOPS = 20;

		private List<string> mTests;

		private List<string> mTestResults;

		private CurvyInterpolation mInterpolation;

		private CurvyOrientation mOrientation;

		private int mCacheSize;

		private int mControlPointCount;

		private int mTotalSplineLength;

		private bool mUseCache;

		private bool mUseMultiThreads;

		private int mCurrentTest;

		private bool mExecuting;

		private TimeMeasure Timer;

		private MethodInfo mGUIMethod;

		private MethodInfo mRunMethod;

		private bool mInterpolate_UseDistance;

		private int mRefresh_Mode;

		private void Awake()
		{
		}

		private void OnGUI()
		{
		}

		private void GUI_Interpolate()
		{
		}

		private void Test_Interpolate()
		{
		}

		private void GUI_Refresh()
		{
		}

		private void Work()
		{
		}

		private void work()
		{
		}

		private void Test_Refresh()
		{
		}

		private CurvySpline getSpline()
		{
			return null;
		}

		private void addRandomCP(ref CurvySpline spline, int count, int totalLength)
		{
		}

		private void runTest()
		{
		}
	}
}
