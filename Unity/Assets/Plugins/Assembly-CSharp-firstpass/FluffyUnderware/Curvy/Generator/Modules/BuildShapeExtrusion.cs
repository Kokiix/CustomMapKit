using System;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Build/Shape Extrusion", ModuleName = "Shape Extrusion", Description = "Simple Shape Extrusion")]
	[HelpURL("https://curvyeditor.com/doclink/cgbuildshapeextrusion")]
	public class BuildShapeExtrusion : CGModule, IPathProvider
	{
		public enum ScaleModeEnum
		{
			Simple = 0,
			Advanced = 1
		}

		public enum CrossShiftModeEnum
		{
			None = 0,
			ByOrientation = 1,
			Custom = 2
		}

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGPath) }, RequestDataOnly = true)]
		public CGModuleInputSlot InPath;

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGShape) }, Array = true, ArrayType = SlotInfo.SlotArrayType.Hidden, RequestDataOnly = true)]
		public CGModuleInputSlot InCross;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGVolume))]
		public CGModuleOutputSlot OutVolume;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGVolume))]
		public CGModuleOutputSlot OutVolumeHollow;

		[Tab("Path")]
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
		[RangeEx(0.1f, 120f, "", "", Tooltip = "Max angle")]
		private float m_AngleThreshold;

		[Tab("Cross")]
		[FieldAction("CBEditCrossButton", ActionAttribute.ActionEnum.Callback, Position = ActionAttribute.ActionPositionEnum.Above)]
		[FloatRegion(UseSlider = true, RegionOptionsPropertyName = "CrossRangeOptions", Precision = 4)]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[SerializeField]
		[RangeEx(1f, 100f, "Resolution", "", Tooltip = "Defines how densely the cross spline's sampling points are. When the value is 100, the number of sampling points per world distance unit is equal to the spline's Max Points Per Unit")]
		private int m_CrossResolution;

		[SerializeField]
		[Label("Optimize", "")]
		private bool m_CrossOptimize;

		[FieldCondition("m_CrossOptimize", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[RangeEx(0.1f, 120f, "Angle Threshold", "", Tooltip = "Max angle")]
		private float m_CrossAngleThreshold;

		[SerializeField]
		[Label("Include CP", "")]
		private bool m_CrossIncludeControlpoints;

		[SerializeField]
		[Label("Hard Edges", "")]
		private bool m_CrossHardEdges;

		[SerializeField]
		[Label("Materials", "")]
		private bool m_CrossMaterials;

		[SerializeField]
		[Label("Extended UV", "")]
		private bool m_CrossExtendedUV;

		[SerializeField]
		[Label("Shift", "", Tooltip = "Defines a shift to be applied on the output volume's cross.\r\nThis shift is used when interpolating values (position, normal, ...) along the volume's surface.")]
		private CrossShiftModeEnum m_CrossShiftMode;

		[SerializeField]
		[RangeEx(0f, 1f, "Value", "Shift By", Slider = true)]
		[FieldCondition("m_CrossShiftMode", CrossShiftModeEnum.Custom, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		private float m_CrossShiftValue;

		[Label("Reverse Normal", "Reverse Vertex Normals?")]
		[SerializeField]
		private bool m_CrossReverseNormals;

		[Tab("Scale")]
		[Label("Mode", "")]
		[SerializeField]
		private ScaleModeEnum m_ScaleMode;

		[FieldCondition("m_ScaleMode", ScaleModeEnum.Advanced, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[Label("Reference", "")]
		[SerializeField]
		private CGReferenceMode m_ScaleReference;

		[FieldCondition("m_ScaleMode", ScaleModeEnum.Advanced, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[Label("Offset", "")]
		[SerializeField]
		private float m_ScaleOffset;

		[SerializeField]
		[Label("Uniform Scaling", "", Tooltip = "The same scaling value is applied on all dimensions")]
		private bool m_ScaleUniform;

		[SerializeField]
		private float m_ScaleX;

		[SerializeField]
		[FieldCondition("m_ScaleUniform", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		private float m_ScaleY;

		[SerializeField]
		[FieldCondition("m_ScaleMode", ScaleModeEnum.Advanced, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[AnimationCurveEx("Multiplier X", "")]
		[Tooltip("Defines scale multiplier depending on the TF, the relative position of a point on the path")]
		private AnimationCurve m_ScaleCurveX;

		[SerializeField]
		[FieldCondition("m_ScaleUniform", false, false, ConditionalAttribute.OperatorEnum.AND, "m_ScaleMode", ScaleModeEnum.Advanced, false)]
		[AnimationCurveEx("Multiplier Y", "")]
		[Tooltip("Defines scale multiplier depending on the TF, the relative position of a point on the path")]
		private AnimationCurve m_ScaleCurveY;

		[Tab("Hollow")]
		[RangeEx(0f, 1f, "", "", Slider = true, Label = "Inset")]
		[SerializeField]
		private float m_HollowInset;

		[Label("Reverse Normal", "Reverse Vertex Normals?")]
		[SerializeField]
		private bool m_HollowReverseNormals;

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

		public float CrossFrom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CrossTo
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CrossLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int CrossResolution
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool CrossOptimize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float CrossAngleThreshold
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool CrossIncludeControlPoints
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CrossHardEdges
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CrossMaterials
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CrossExtendedUV
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CrossShiftModeEnum CrossShiftMode
		{
			get
			{
				return default(CrossShiftModeEnum);
			}
			set
			{
			}
		}

		public float CrossShiftValue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool CrossReverseNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ScaleModeEnum ScaleMode
		{
			get
			{
				return default(ScaleModeEnum);
			}
			set
			{
			}
		}

		public CGReferenceMode ScaleReference
		{
			get
			{
				return default(CGReferenceMode);
			}
			set
			{
			}
		}

		public bool ScaleUniform
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float ScaleOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ScaleY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public AnimationCurve ScaleMultiplierX
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public AnimationCurve ScaleMultiplierY
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float HollowInset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool HollowReverseNormals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int PathSamples { get; private set; }

		public int CrossSamples { get; private set; }

		public int CrossGroups { get; private set; }

		public IExternalInput Cross => null;

		public Vector3 CrossPosition { get; protected set; }

		public Quaternion CrossRotation { get; protected set; }

		public bool PathIsClosed => false;

		private bool ClampPath => false;

		private bool ClampCross => false;

		private RegionOptions<float> RangeOptions => default(RegionOptions<float>);

		private RegionOptions<float> CrossRangeOptions => default(RegionOptions<float>);

		protected override void OnEnable()
		{
		}

		public override void Reset()
		{
		}

		public override void Refresh()
		{
		}

		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}
	}
}
