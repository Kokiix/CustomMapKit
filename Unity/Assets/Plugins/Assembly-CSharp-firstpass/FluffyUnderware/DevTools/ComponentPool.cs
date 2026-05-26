using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FluffyUnderware.DevTools
{
	[HelpURL("https://curvyeditor.com/doclink/dtcomponentpool")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[SerializeField]
		[HideInInspector]
		private string m_Identifier;

		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		private PoolManager mManager;

		private List<Component> mObjects;

		private double mLastTime;

		private double mDeltaTime;

		public PoolSettings Settings
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PoolManager Manager => null;

		public string Identifier
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Type Type => null;

		public int Count => 0;

		public void Initialize(Type type, PoolSettings settings)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Update()
		{
		}

		public void Reset()
		{
		}

		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		public void Clear()
		{
		}

		public void Push(Component item)
		{
		}

		public Component Pop(Transform parent = null)
		{
			return null;
		}

		public T Pop<T>(Transform parent) where T : Component
		{
			return null;
		}

		private Component create()
		{
			return null;
		}

		private void destroy(Component item)
		{
		}

		private void setParent(Component item, Transform parent)
		{
		}

		private void sendAfterPop(Component item)
		{
		}

		private void sendBeforePush(Component item)
		{
		}

		private void log(string msg)
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
