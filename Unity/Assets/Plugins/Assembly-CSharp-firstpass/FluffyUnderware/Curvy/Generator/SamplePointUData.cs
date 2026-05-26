using System;

namespace FluffyUnderware.Curvy.Generator
{
	public struct SamplePointUData : IEquatable<SamplePointUData>
	{
		public int Vertex;

		public bool UVEdge;

		public float FirstU;

		public float SecondU;

		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
			Vertex = 0;
			UVEdge = false;
			FirstU = 0f;
			SecondU = 0f;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(SamplePointUData other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return false;
		}

		public static bool operator !=(SamplePointUData left, SamplePointUData right)
		{
			return false;
		}
	}
}
