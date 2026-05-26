using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[ExecuteInEditMode]
	[HelpURL("https://curvyeditor.com/doclink/generator")]
	[AddComponentMenu("Curvy/Generator", 3)]
	[RequireComponent(typeof(PoolManager))]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Tooltip("Show Debug Output?")]
		[SerializeField]
		private bool m_ShowDebug;

		[Tooltip("Whether to automatically refresh the generator's output when necessary")]
		[SerializeField]
		private bool m_AutoRefresh;

		[FieldCondition("m_AutoRefresh", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[Positive(Tooltip = "The minimum delay between two automatic generator's refreshing while in Play mode, in milliseconds")]
		[SerializeField]
		private int m_RefreshDelay;

		[FieldCondition("m_AutoRefresh", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[Positive(Tooltip = "The minimum delay between two automatic generator's refreshing while in Edit mode, in milliseconds")]
		[SerializeField]
		private int m_RefreshDelayEditor;

		[Section("Events", false, false, 1000, HelpURL = "https://curvyeditor.com/doclink/generator_events")]
		[SerializeField]
		protected CurvyCGEvent m_OnRefresh;

		[HideInInspector]
		public List<CGModule> Modules;

		[SerializeField]
		[HideInInspector]
		internal int m_LastModuleID;

		public Dictionary<int, CGModule> ModulesByID;

		private bool mInitialized;

		private bool mInitializedPhaseOne;

		private bool mNeedSort;

		private double mLastUpdateTime;

		private PoolManager mPoolManager;

		private const int ModulesReorderingDeltaX = 50;

		private const int ModulesReorderingDeltaY = 20;

		public bool ShowDebug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AutoRefresh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int RefreshDelay
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int RefreshDelayEditor
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public PoolManager PoolManager => null;

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

		public bool IsInitialized => false;

		public bool Destroying { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		public static CurvyGenerator Create()
		{
			return null;
		}

		public T AddModule<T>() where T : CGModule
		{
			return null;
		}

		public CGModule AddModule(Type type)
		{
			return null;
		}

		public void ArrangeModules()
		{
		}

		public void ReorderModules()
		{
		}

		public void Clear()
		{
		}

		public void DeleteModule(CGModule module)
		{
		}

		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		public CGModule GetModule(int moduleID, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		public T GetModule<T>(int moduleID, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		public CGModule GetModule(string moduleName, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		public T GetModule<T>(string moduleName, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		public void Initialize(bool force = false)
		{
		}

		public void Refresh(bool forceUpdate = false)
		{
		}

		public void TryAutoRefresh()
		{
		}

		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		private void clearModules()
		{
		}

		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		internal void sortModulesINTERNAL()
		{
		}

		private bool doSortModules()
		{
			return false;
		}

		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}
	}
}
