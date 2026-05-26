using System;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[Serializable]
	public class CGMeshProperties
	{
		[SerializeField]
		private Mesh m_Mesh;

		[SerializeField]
		private Material[] m_Material;

		[SerializeField]
		[VectorEx("", "")]
		private Vector3 m_Translation;

		[SerializeField]
		[VectorEx("", "")]
		private Vector3 m_Rotation;

		[SerializeField]
		[VectorEx("", "")]
		private Vector3 m_Scale;

		public Mesh Mesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material[] Material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 Translation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Rotation
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 Scale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Matrix4x4 Matrix => default(Matrix4x4);

		public CGMeshProperties()
		{
		}

		public CGMeshProperties(Mesh mesh)
		{
		}
	}
}
