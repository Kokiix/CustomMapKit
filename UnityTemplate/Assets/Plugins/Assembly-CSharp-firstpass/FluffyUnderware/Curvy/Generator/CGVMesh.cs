using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[CGDataInfo(0.98f, 0.5f, 0f, 1f)]
	public class CGVMesh : CGBounds
	{
		public Vector3[] Vertex;

		public Vector2[] UV;

		public Vector2[] UV2;

		public Vector3[] Normal;

		public Vector4[] Tangents;

		public CGVSubMesh[] SubMeshes;

		public override int Count => 0;

		public bool HasUV => false;

		public bool HasUV2 => false;

		public bool HasNormals => false;

		public bool HasTangents => false;

		public int TriangleCount => 0;

		public CGVMesh()
		{
		}

		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		public CGVMesh(CGVolume volume)
		{
		}

		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		public CGVMesh(CGVMesh source)
		{
		}

		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		public override T Clone<T>()
		{
			return null;
		}

		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		public void SetSubMeshCount(int count)
		{
		}

		public void AddSubMesh(CGVSubMesh submesh = null)
		{
		}

		public void MergeVMesh(CGVMesh source)
		{
		}

		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		public Mesh AsMesh()
		{
			return null;
		}

		public void ToMesh(ref Mesh msh)
		{
		}

		public Material[] GetMaterials()
		{
			return null;
		}

		public override void RecalculateBounds()
		{
		}

		public void RecalculateUV2()
		{
		}

		public void TRS(Matrix4x4 matrix)
		{
		}

		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
}
