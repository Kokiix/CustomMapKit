using System;
using UnityEngine;

namespace FluffyUnderware.Curvy
{
	[Serializable]
	internal class ControlPointCoordinates
	{
		[SerializeField]
		internal CurvySplineSegment ControlPoint;

		[SerializeField]
		internal Vector3 Position;

		[SerializeField]
		internal Quaternion Rotation;

		internal ControlPointCoordinates(CurvySplineSegment controlPoint)
		{
		}
	}
}
