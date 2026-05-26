using System.Collections.Generic;
using UnityEngine;

namespace FluffyUnderware.DevTools
{
	[RequireComponent(typeof(PoolManager))]
	[HelpURL("https://curvyeditor.com/doclink/dtprefabpool")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[FieldCondition("m_Identifier", "", false, ActionAttribute.ActionEnum.ShowWarning, "Please enter an identifier! (Select a prefab to set automatically)", ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		private string m_Identifier;

		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		private PoolManager mManager;

		private List<GameObject> mObjects;

		private double mLastTime;

		private double mDeltaTime;

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

		public List<GameObject> Prefabs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public int Count => 0;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		public void Update()
		{
		}

		public void Reset()
		{
		}

		public void Clear()
		{
		}

		public GameObject Pop(Transform parent = null)
		{
			return null;
		}

		public virtual void Push(GameObject item)
		{
		}

		private GameObject create()
		{
			return null;
		}

		private void destroy(GameObject go)
		{
		}

		private void log(string msg)
		{
		}

		private void setParent(Transform item, Transform parent)
		{
		}

		private void sendAfterPop(GameObject item)
		{
		}

		private void sendBeforePush(GameObject item)
		{
		}
	}
}
