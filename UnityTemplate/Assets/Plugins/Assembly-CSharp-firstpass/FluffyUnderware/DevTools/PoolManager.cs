using System;
using System.Collections.Generic;
using UnityEngine;

namespace FluffyUnderware.DevTools
{
	[HelpURL("https://curvyeditor.com/doclink/dtpoolmanager")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class PoolManager : MonoBehaviour
	{
		[Section("General", true, false, 100)]
		[SerializeField]
		private bool m_AutoCreatePools;

		[AsGroup(null, Expanded = false)]
		[SerializeField]
		private PoolSettings m_DefaultSettings;

		public Dictionary<string, IPool> Pools;

		public Dictionary<Type, IPool> TypePools;

		private IPool[] mPools;

		public bool AutoCreatePools
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PoolSettings DefaultSettings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsInitialized { get; private set; }

		public int Count => 0;

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void Initialize()
		{
		}

		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		public ComponentPool GetComponentPool<T>() where T : Component
		{
			return null;
		}

		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		public Pool<T> CreateTypePool<T>(PoolSettings settings = null)
		{
			return null;
		}

		public ComponentPool CreateComponentPool<T>(PoolSettings settings = null) where T : Component
		{
			return null;
		}

		public PrefabPool CreatePrefabPool(string name, PoolSettings settings = null, params GameObject[] prefabs)
		{
			return null;
		}

		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		public void DeletePools(string startsWith)
		{
		}

		public void DeletePool(IPool pool)
		{
		}

		public void DeletePool<T>()
		{
		}
	}
}
