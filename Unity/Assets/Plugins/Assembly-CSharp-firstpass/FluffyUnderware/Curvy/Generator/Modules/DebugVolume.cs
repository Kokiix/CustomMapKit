using System;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Debug/Volume", ModuleName = "Debug Volume")]
	[HelpURL("https://curvyeditor.com/doclink/cgdebugvolume")]
	public class DebugVolume : CGModule
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGVolume) }, Name = "Volume")]
		public CGModuleInputSlot InData;

		[Tab("General")]
		public bool ShowPathSamples;

		public bool ShowCrossSamples;

		[FieldCondition("ShowCrossSamples", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[IntRegion(RegionIsOptional = true)]
		public IntRegion LimitCross;

		public bool ShowNormals;

		public bool ShowIndex;

		public bool ShowMap;

		public Color PathColor;

		public Color VolumeColor;

		public Color NormalColor;

		[Tab("Interpolate")]
		public bool Interpolate;

		[RangeEx(-1f, 1f, "Path", "")]
		public float InterpolatePathF;

		[RangeEx(-1f, 1f, "Cross", "")]
		public float InterpolateCrossF;
	}
}
