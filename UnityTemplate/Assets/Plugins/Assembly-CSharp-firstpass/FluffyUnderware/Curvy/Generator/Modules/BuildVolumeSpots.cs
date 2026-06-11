using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Build/Volume Spots", ModuleName = "Volume Spots", Description = "Generate spots along a path/volume", UsesRandom = true)]
	[HelpURL("https://curvyeditor.com/doclink/cgvolumespots")]
	public class BuildVolumeSpots : CGModule, ISerializationCallbackReceiver
	{
		private class EndGroupData
		{
			internal CGBoundsGroup BoundsGroup { get; private set; }

			internal int[] ItemIndices { get; private set; }

			internal float GroupDepth { get; }

			internal CGBounds[] ItemBounds { get; }

			internal float SpaceBefore { get; }

			internal float SpaceAfter { get; }

			public EndGroupData(CGBoundsGroup boundsGroup, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
			{
			}
		}

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGPath) }, Name = "Path/Volume", DisplayName = "Volume/Rasterized Path")]
		public CGModuleInputSlot InPath;

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGBounds) }, Array = true)]
		public CGModuleInputSlot InBounds;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGSpots))]
		public CGModuleOutputSlot OutSpots;

		[SerializeField]
		[HideInInspector]
		private bool m_WasUpgraded;

		[Tab("General")]
		[Section("Default/General/Volume Path", true, false, 100)]
		[FloatRegion(RegionOptionsPropertyName = "RangeOptions", Precision = 4)]
		[SerializeField]
		private FloatRegion m_Range;

		[Section("Default/General/Volume Cross", true, false, 100)]
		[Tooltip("When the source is a Volume, you can choose if you want to use it's path or the volume")]
		[FieldCondition("Volume", null, true, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[Label("Use Volume's Surface", "")]
		private bool m_UseVolume;

		[SerializeField]
		[RangeEx(-1f, 1f, "", "")]
		[Tooltip("Shifts the Cross origin value by constant value")]
		private float m_CrossBase;

		[SerializeField]
		[Label("Cross Base Variation", "")]
		[Tooltip("Shifts the Cross origin value by a value that varies along the Volume's length. The Curve's X axis has values between 0 (start of the Range) and 1 (its end)")]
		private AnimationCurve m_CrossCurve;

		[Section("Default/General/Advanced Settings", false, false, 100)]
		[Tooltip("Check to run a dry run without actually creating spots")]
		[SerializeField]
		private bool m_Simulate;

		[SerializeField]
		[Tooltip("Until version 6.3.1, this module had a bug in the computation of the randomized values. Enable this value to keep that bugged behaviour if your project depends on it")]
		private bool m_UseBuggedRNG;

		[Tab("Groups")]
		[ArrayEx(Space = 10)]
		[SerializeField]
		private List<CGBoundsGroup> m_Groups;

		[IntRegion(UseSlider = false, RegionOptionsPropertyName = "RepeatingGroupsOptions", Options = AttributeOptionsFlags.Compact)]
		[SerializeField]
		[Tooltip("The range of groups that will be placed repetitively along the volume. Groups that are not in this range will be placed only once")]
		private IntRegion m_RepeatingGroups;

		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[SerializeField]
		[FieldCondition("ShowFitEnd", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[Label("Fits The End", "")]
		[Tooltip("If checked, the last non repeating group is placed exactly at the end of the volume used for spots. If not, the last group is placed at the first available spot, which might leave some space between it and the end of the volume")]
		private bool m_FitEnd;

		public CGSpots SimulatedSpots;

		private WeightedRandom<int> mGroupBag;

		private List<CGBounds> mBounds;

		public FloatRegion Range
		{
			get
			{
				return default(FloatRegion);
			}
			set
			{
			}
		}

		public bool UseVolume
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Simulate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseBuggedRng
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float CrossBase
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve CrossCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<CGBoundsGroup> Groups
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			set
			{
			}
		}

		public int FirstRepeating
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int LastRepeating
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool FitEnd
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int GroupCount => 0;

		public GUIContent[] BoundsNames => null;

		public int[] BoundsIndices => null;

		public int Count { get; private set; }

		private int lastGroupIndex => 0;

		private RegionOptions<float> RangeOptions => default(RegionOptions<float>);

		private RegionOptions<int> RepeatingGroupsOptions => default(RegionOptions<int>);

		private CGPath Path { get; set; }

		private CGVolume Volume => null;

		private float Length => 0f;

		private bool ShowFitEnd => false;

		protected override void OnEnable()
		{
		}

		public override void Reset()
		{
		}

		public override void OnStateChange()
		{
		}

		public void Clear()
		{
		}

		public override void Refresh()
		{
		}

		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		private static int[] GetGroupItemIndices(CGBoundsGroup boundsGroup, WeightedRandom<int> groupItemBag)
		{
			return null;
		}

		private float GetGroupDepth(int[] groupItemIndices, float spaceBefore, float spaceAfter, out CGBounds[] itemsBounds)
		{
			itemsBounds = null;
			return 0f;
		}

		private bool AddGroupItems(int groupIndex, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, Dictionary<CGBoundsGroup, WeightedRandom<int>> itemsBagDictionary, int MaxSpotsCount)
		{
			failedAddingAllItems = default(bool);
			return false;
		}

		private void AddGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, float remainingLength, float startDistance, ref float currentDistance, out bool failedAddingAllItems, int[] itemIndices, float groupDepth, CGBounds[] itemBounds, float spaceBefore, float spaceAfter)
		{
			failedAddingAllItems = default(bool);
		}

		private CGSpot GetSpot(int itemID, CGBoundsGroup boundsGroup, CGBounds bounds, float currentDistance, float startDistance)
		{
			return default(CGSpot);
		}

		private static float GetRegionNextValue(FloatRegion floatRegion)
		{
			return 0f;
		}

		private void GetTRS(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
			rotation = default(Quaternion);
			translation = default(Vector3);
			scale = default(Vector3);
		}

		private void GetTRS630(CGBoundsGroup boundsGroup, Vector3 tangent, Vector3 up, out Quaternion rotation, out Vector3 translation, out Vector3 scale)
		{
			rotation = default(Quaternion);
			translation = default(Vector3);
			scale = default(Vector3);
		}

		private Dictionary<CGBoundsGroup, WeightedRandom<int>> Prepare()
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
