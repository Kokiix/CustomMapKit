using UnityEngine;

namespace FluffyUnderware.DevTools
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(MeshFilter))]
	public abstract class DuplicateEditorMesh : MonoBehaviour
	{
		private MeshFilter mFilter;

		public MeshFilter Filter => null;

		protected virtual void Awake()
		{
		}
	}
}
