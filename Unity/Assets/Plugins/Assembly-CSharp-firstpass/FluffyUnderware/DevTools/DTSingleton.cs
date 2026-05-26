using UnityEngine;

namespace FluffyUnderware.DevTools
{
	public class DTSingleton<T> : MonoBehaviour, IDTSingleton where T : MonoBehaviour, IDTSingleton
	{
		private static T _instance;

		private static object _lock;

		private static bool applicationIsQuitting;

		private bool isDuplicateInstance;

		public static bool HasInstance => false;

		public static T Instance => null;

		public virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		private void DestroySelf()
		{
		}
	}
}
