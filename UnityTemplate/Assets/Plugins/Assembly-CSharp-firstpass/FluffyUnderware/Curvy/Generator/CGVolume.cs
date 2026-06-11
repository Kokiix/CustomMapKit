using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[CGDataInfo(0.08f, 0.4f, 0.75f, 1f)]
	public class CGVolume : CGPath
	{
		public Vector3[] Vertex;

		public Vector3[] VertexNormal;

		public float[] CrossF;

		public float[] CrossMap;

		public float[] SegmentLength;

		public bool CrossClosed;

		public bool CrossSeamless;

		public float CrossFShift;

		public SamplePointsMaterialGroupCollection CrossMaterialGroups;

		public int CrossSize => 0;

		public int VertexCount => 0;

		public CGVolume()
		{
		}

		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		public CGVolume(CGVolume source)
		{
		}

		public static CGVolume Get(CGVolume data, CGPath path, CGShape crossShape)
		{
			return null;
		}

		public override T Clone<T>()
		{
			return null;
		}

		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
			pos = default(Vector3);
			dir = default(Vector3);
			up = default(Vector3);
		}

		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		public float GetCrossLength(float pathF)
		{
			return 0f;
		}

		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return 0f;
		}

		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return 0f;
		}

		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
			s0Index = default(int);
			s1Index = default(int);
			frag = default(float);
		}

		public int GetSegmentIndex(int segment)
		{
			return 0;
		}

		public int GetCrossFIndex(float crossF, out float frag)
		{
			frag = default(float);
			return 0;
		}

		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			pathFrag = default(float);
			return 0;
		}

		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			pathFrag = default(float);
			crossFrag = default(float);
			return 0;
		}

		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		private float calcSegmentLength(int segmentIndex)
		{
			return 0f;
		}
	}
}
