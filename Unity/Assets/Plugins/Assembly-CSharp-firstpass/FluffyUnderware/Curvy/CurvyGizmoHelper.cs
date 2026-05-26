using UnityEngine;

namespace FluffyUnderware.Curvy
{
	public static class CurvyGizmoHelper
	{
		public static Matrix4x4 Matrix;

		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
}
