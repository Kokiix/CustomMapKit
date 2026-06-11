using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[RequireComponent(typeof(MeshRenderer))]
	[HelpURL("https://curvyeditor.com/doclink/cgmeshresource")]
	public class CGMeshResource : DuplicateEditorMesh, IPoolable
	{
		private MeshRenderer mRenderer;

		private Collider mCollider;

		public MeshRenderer Renderer => null;

		public Collider Collider => null;

		public Mesh Prepare()
		{
			return null;
		}

		public bool ColliderMatches(CGColliderEnum type)
		{
			return false;
		}

		public void RemoveCollider()
		{
		}

		public bool UpdateCollider(CGColliderEnum mode, bool convex, bool isTrigger, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return false;
		}

		public void OnBeforePush()
		{
		}

		public void OnAfterPop()
		{
		}
	}
}
