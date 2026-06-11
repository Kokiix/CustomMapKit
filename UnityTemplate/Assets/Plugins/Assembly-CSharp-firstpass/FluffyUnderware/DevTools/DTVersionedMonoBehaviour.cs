using UnityEngine;

namespace FluffyUnderware.DevTools
{
	public abstract class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private string m_Version;

		public string Version
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public void Destroy()
		{
		}
	}
}
