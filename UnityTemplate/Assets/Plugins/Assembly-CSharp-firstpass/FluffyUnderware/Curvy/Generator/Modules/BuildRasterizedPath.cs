using System;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Build/Rasterize Path", ModuleName = "Rasterize Path", Description = "Rasterizes a virtual path")]
	[HelpURL("https://curvyeditor.com/doclink/cgbuildrasterizedpath")]
	public class BuildRasterizedPath : CGModule, IPathProvider
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGPath) }, Name = "Path", RequestDataOnly = true)]
		public CGModuleInputSlot InPath;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGPath), Name = "Path", DisplayName = "Rasterized Path")]
		public CGModuleOutputSlot OutPath;

		[FloatRegion(UseSlider = true, RegionOptionsPropertyName = "RangeOptions", Precision = 4)]
		[SerializeField]
		private FloatRegion m_Range;

		[SerializeField]
		[RangeEx(1f, 100f, "Resolution", "Defines how densely the path spline's sampling points are. When the value is 100, the number of sampling points per world distance unit is equal to the spline's Max Points Per Unit")]
		private int m_Resolution;

		[SerializeField]
		private bool m_Optimize;

		[FieldCondition("m_Optimize", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[RangeEx(0.1f, 120f, "", "")]
		private float m_AngleTreshold;

		public float From
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float To
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Resolution
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool Optimize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float AngleThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public CGPath Path => null;

		public bool PathIsClosed => false;

		private RegionOptions<float> RangeOptions => default(RegionOptions<float>);

		protected override void OnEnable()
		{
		}

		public override void Reset()
		{
		}

		public override void Refresh()
		{
		}
	}
}
