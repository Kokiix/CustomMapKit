using System.Collections.Generic;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[CGDataInfo(0.73f, 0.87f, 0.98f, 1f)]
	public class CGShape : CGData
	{
		public float[] SourceF;

		public float[] F;

		public Vector3[] Position;

		public Vector3[] Normal;

		public float[] Map;

		public List<SamplePointsMaterialGroup> MaterialGroups;

		public bool SourceIsManaged;

		public bool Closed;

		public bool Seamless;

		public float Length;

		private float mCacheLastF;

		private int mCacheLastIndex;

		private float mCacheLastFrag;

		public override int Count => 0;

		public CGShape()
		{
		}

		public CGShape(CGShape source)
		{
		}

		public override T Clone<T>()
		{
			return null;
		}

		public static void Copy(CGShape dest, CGShape source)
		{
		}

		public void Copy(CGShape source)
		{
		}

		public float DistanceToF(float distance)
		{
			return 0f;
		}

		public float FToDistance(float f)
		{
			return 0f;
		}

		public int GetFIndex(float f, out float frag)
		{
			frag = default(float);
			return 0;
		}

		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		public void Interpolate(float f, out Vector3 position, out Vector3 up)
		{
			position = default(Vector3);
			up = default(Vector3);
		}

		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		public virtual void Recalculate()
		{
		}

		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
}
