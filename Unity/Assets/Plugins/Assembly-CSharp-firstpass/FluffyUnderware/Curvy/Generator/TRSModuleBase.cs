using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	public abstract class TRSModuleBase : CGModule
	{
		[SerializeField]
		[VectorEx("", "")]
		private Vector3 m_Transpose;

		[SerializeField]
		[VectorEx("", "")]
		private Vector3 m_Rotation;

		[SerializeField]
		[VectorEx("", "")]
		private Vector3 m_Scale;

		public Vector3 Transpose
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

		protected Matrix4x4 ApplyTrsOnShape(CGShape shape)
		{
			return default(Matrix4x4);
		}

		protected override void OnEnable()
		{
		}

		public override void Reset()
		{
		}
	}
}
