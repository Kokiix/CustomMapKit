using System;
using System.Collections.Generic;
using FluffyUnderware.Curvy.ThirdParty.LibTessDotNet;
using UnityEngine;

namespace FluffyUnderware.Curvy.Utils
{
	[Serializable]
	public class SplinePolyLine
	{
		public enum VertexCalculation
		{
			ByApproximation = 0,
			ByAngle = 1
		}

		public ContourOrientation Orientation;

		public CurvySpline Spline;

		public VertexCalculation VertexMode;

		public float Angle;

		public float Distance;

		public Space Space;

		public bool IsClosed => false;

		public SplinePolyLine(CurvySpline spline)
		{
		}

		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		public Vector3[] GetVertices()
		{
			return null;
		}

		private static Vector3[] GetPolygon(CurvySpline spline, float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			vertexTF = null;
			vertexTangents = null;
			return null;
		}
	}
}
