using System;
using System.Collections.Generic;
using System.Reflection;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[ExecuteInEditMode]
	public abstract class CGModule : DTVersionedMonoBehaviour
	{
		[Group("Events", Expanded = false, Sort = 1000)]
		[SerializeField]
		protected CurvyCGEvent m_OnBeforeRefresh;

		[Group("Events")]
		[SerializeField]
		protected CurvyCGEvent m_OnRefresh;

		[SerializeField]
		[HideInInspector]
		private string m_ModuleName;

		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		[Group("Seed Options", Expanded = false, Sort = 1001)]
		[GroupCondition("usesRandom")]
		[FieldAction("CBSeedOptions", ActionAttribute.ActionEnum.Callback, ShowBelowProperty = true)]
		[SerializeField]
		private bool m_RandomizeSeed;

		[SerializeField]
		[HideInInspector]
		private int m_Seed;

		[NonSerialized]
		public List<string> UIMessages;

		private CurvyGenerator mGenerator;

		[SerializeField]
		[HideInInspector]
		private int m_UniqueID;

		internal int SortAncestors;

		[HideInInspector]
		public CGModuleProperties Properties;

		[HideInInspector]
		public List<CGModuleLink> InputLinks;

		[HideInInspector]
		public List<CGModuleLink> OutputLinks;

		private ModuleInfoAttribute mInfo;

		private bool mDirty;

		private bool mInitialized;

		private bool mStateChangeDirty;

		private bool mLastIsConfiguredState;

		public CurvyCGEvent OnBeforeRefresh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvyCGEvent OnRefresh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ModuleName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Active
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Seed
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool RandomizeSeed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CurvyGenerator Generator => null;

		public int UniqueID => 0;

		public bool CircularReferenceError { get; set; }

		public Dictionary<string, CGModuleInputSlot> InputByName { get; private set; }

		public Dictionary<string, CGModuleOutputSlot> OutputByName { get; private set; }

		public List<CGModuleInputSlot> Input { get; private set; }

		public List<CGModuleOutputSlot> Output { get; private set; }

		public ModuleInfoAttribute Info => null;

		public bool Dirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool IsConfigured => false;

		public virtual bool IsInitialized => false;

		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		public void Initialize()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		public virtual void Refresh()
		{
		}

		public virtual void Reset()
		{
		}

		public void ReInitializeLinkedSlots()
		{
		}

		public virtual void OnStateChange()
		{
		}

		public virtual void OnTemplateCreated()
		{
		}

		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		public Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		public void DeleteManagedResource(string resourceName, Component res, string context = "", bool dontUsePool = false)
		{
		}

		public bool IsManagedResource(Component res)
		{
			return false;
		}

		protected void RenameResource(string resourceName, Component resource, int index = -1)
		{
		}

		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		public void DeleteAllPrefabPools()
		{
		}

		public void Delete()
		{
		}

		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		public List<CGModuleInputSlot> GetInputSlots(Type filterType = null)
		{
			return null;
		}

		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		public List<CGModuleOutputSlot> GetOutputSlots(Type filterType = null)
		{
			return null;
		}

		public bool GetManagedResources(out List<Component> components, out List<string> componentNames)
		{
			components = null;
			componentNames = null;
			return false;
		}

		public int SetUniqueIdINTERNAL()
		{
			return 0;
		}

		internal void initializeSort()
		{
		}

		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		internal void doRefresh()
		{
		}

		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		private bool usesRandom()
		{
			return false;
		}

		private void loadSlots()
		{
		}

		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		private void setTreeDirtyStateChange()
		{
		}

		private CurvyGenerator RetrieveGenerator()
		{
			return null;
		}

		public void checkOnStateChangedINTERNAL()
		{
		}

		public void renameManagedResourcesINTERNAL()
		{
		}
	}
}
