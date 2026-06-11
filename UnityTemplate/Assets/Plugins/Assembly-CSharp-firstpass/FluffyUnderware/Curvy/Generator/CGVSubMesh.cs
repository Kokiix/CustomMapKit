using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	public class CGVSubMesh : CGData
	{
		public int[] Triangles;

		public Material Material;

		public override int Count => 0;

		public CGVSubMesh(Material material = null)
		{
		}

		public CGVSubMesh(int[] triangles, Material material = null)
		{
		}

		public CGVSubMesh(int triangleCount, Material material = null)
		{
		}

		public CGVSubMesh(CGVSubMesh source)
		{
		}

		public override T Clone<T>()
		{
			return null;
		}

		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, Material material = null)
		{
			return null;
		}

		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
}
