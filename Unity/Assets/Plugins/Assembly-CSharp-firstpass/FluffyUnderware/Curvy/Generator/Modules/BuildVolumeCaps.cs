using System;
using FluffyUnderware.Curvy.ThirdParty.LibTessDotNet;
using FluffyUnderware.DevTools;
using UnityEngine;
using UnityEngine.Serialization;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Build/Volume Caps", ModuleName = "Volume Caps", Description = "Build volume caps")]
	[HelpURL("https://curvyeditor.com/doclink/cgbuildvolumecaps")]
	public class BuildVolumeCaps : CGModule
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGVolume) })]
		public CGModuleInputSlot InVolume;

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGVolume) }, Optional = true, Array = true)]
		public CGModuleInputSlot InVolumeHoles;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGVMesh), Array = true)]
		public CGModuleOutputSlot OutVMesh;

		[Tab("General")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[SerializeField]
		[FormerlySerializedAs("m_ReverseNormals")]
		private bool m_ReverseTriOrder;

		[SerializeField]
		private bool m_GenerateUV;

		[Tab("Start Cap")]
		[Inline]
		[SerializeField]
		private CGMaterialSettings m_StartMaterialSettings;

		[Label("Material", "")]
		[SerializeField]
		private Material m_StartMaterial;

		[Tab("End Cap")]
		[SerializeField]
		private bool m_CloneStartCap;

		[AsGroup(null, Invisible = true)]
		[GroupCondition("m_CloneStartCap", false, false)]
		[SerializeField]
		private CGMaterialSettings m_EndMaterialSettings;

		[Group("Default/End Cap")]
		[Label("Material", "")]
		[FieldCondition("m_CloneStartCap", false, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		private Material m_EndMaterial;

		public bool GenerateUV
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ReverseTriOrder
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CGYesNoAuto StartCap
		{
			get
			{
				return default(CGYesNoAuto);
			}
			set
			{
			}
		}

		public Material StartMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CGMaterialSettings StartMaterialSettings => null;

		public CGYesNoAuto EndCap
		{
			get
			{
				return default(CGYesNoAuto);
			}
			set
			{
			}
		}

		public bool CloneStartCap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CGMaterialSettings EndMaterialSettings => null;

		public Material EndMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		public override void Reset()
		{
		}

		public override void Refresh()
		{
		}

		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			bounds = default(Bounds);
			return null;
		}

		private static ContourVertex[] make2DSegment(CGVolume vol, int segmentIndex)
		{
			return null;
		}

		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}
	}
}
