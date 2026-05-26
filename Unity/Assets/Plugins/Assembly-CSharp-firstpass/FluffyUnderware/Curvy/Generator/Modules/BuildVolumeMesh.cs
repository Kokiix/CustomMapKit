using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;
using UnityEngine.Serialization;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Build/Volume Mesh", ModuleName = "Volume Mesh", Description = "Build a volume mesh")]
	[HelpURL("https://curvyeditor.com/doclink/cgbuildvolumemesh")]
	public class BuildVolumeMesh : CGModule
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGVolume) })]
		public CGModuleInputSlot InVolume;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGVMesh), Array = true)]
		public CGModuleOutputSlot OutVMesh;

		[Tab("General")]
		[SerializeField]
		private bool m_GenerateUV;

		[SerializeField]
		private bool m_Split;

		[Positive(MinValue = 1f)]
		[FieldCondition("m_Split", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		private float m_SplitLength;

		[FieldAction("CBAddMaterial", ActionAttribute.ActionEnum.Callback)]
		[SerializeField]
		[FormerlySerializedAs("m_ReverseNormals")]
		private bool m_ReverseTriOrder;

		[SerializeField]
		[HideInInspector]
		private List<CGMaterialSettingsEx> m_MaterialSettings;

		[SerializeField]
		[HideInInspector]
		private Material[] m_Material;

		private List<SamplePointsMaterialGroupCollection> groupsByMatID;

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

		public bool Split
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float SplitLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<CGMaterialSettingsEx> MaterialSetttings => null;

		public int MaterialCount => 0;

		protected override void Awake()
		{
		}

		public override void Reset()
		{
		}

		public override void Refresh()
		{
		}

		public int AddMaterial()
		{
			return 0;
		}

		public void RemoveMaterial(int index)
		{
		}

		public void SetMaterial(int index, Material mat)
		{
		}

		public Material GetMaterial(int index)
		{
			return null;
		}

		private void prepare(CGVolume vol)
		{
		}

		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		private void createMaterialGroupUV(CGVMesh vmesh, CGVolume vol, SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return 0;
		}

		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		private bool validateMaterialIndex(int index)
		{
			return false;
		}
	}
}
