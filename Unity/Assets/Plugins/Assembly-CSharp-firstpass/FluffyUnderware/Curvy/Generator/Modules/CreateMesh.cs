using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;
using UnityEngine.Rendering;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Create/Mesh", ModuleName = "Create Mesh")]
	[HelpURL("https://curvyeditor.com/doclink/cgcreatemesh")]
	public class CreateMesh : CGModule
	{
		private const string DefaultTag = "Untagged";

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGVMesh) }, Array = true, Name = "VMesh")]
		public CGModuleInputSlot InVMeshArray;

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGSpots) }, Array = true, Name = "Spots", Optional = true)]
		public CGModuleInputSlot InSpots;

		[SerializeField]
		[CGResourceCollectionManager("Mesh", ShowCount = true)]
		private CGMeshResourceCollection m_MeshResources;

		[Tab("General")]
		[Tooltip("Merge meshes")]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		[SerializeField]
		private bool m_Combine;

		[Tooltip("Merge meshes sharing the same Index")]
		[SerializeField]
		private bool m_GroupMeshes;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private CGYesNoAuto m_AddNormals;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private CGYesNoAuto m_AddTangents;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private bool m_AddUV2;

		[SerializeField]
		[Tooltip("If enabled, meshes will have the Static flag set, and will not be updated in Play Mode")]
		[FieldCondition("canModifyStaticFlag", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private bool m_MakeStatic;

		[SerializeField]
		[Tooltip("The Layer of the created game object")]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		[Layer("", "")]
		private int m_Layer;

		[SerializeField]
		[Tooltip("The Tag of the created game object")]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		[Tag("", "")]
		private string m_Tag;

		[Tab("Renderer")]
		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private bool m_RendererEnabled;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private ShadowCastingMode m_CastShadows;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private bool m_ReceiveShadows;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private LightProbeUsage m_LightProbeUsage;

		[HideInInspector]
		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private bool m_UseLightProbes;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private ReflectionProbeUsage m_ReflectionProbes;

		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private Transform m_AnchorOverride;

		[Tab("Collider")]
		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private CGColliderEnum m_Collider;

		[FieldCondition("m_Collider", CGColliderEnum.Mesh, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private bool m_Convex;

		[SerializeField]
		[FieldCondition("EnableIsTrigger", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private bool m_IsTrigger;

		[Tooltip("Options used to enable or disable certain features in Collider mesh cooking. See Unity's MeshCollider.cookingOptions for more details")]
		[FieldCondition("m_Collider", CGColliderEnum.Mesh, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below)]
		[SerializeField]
		[EnumFlag("", "")]
		[FieldCondition("canUpdate", true, false, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		private MeshColliderCookingOptions m_CookingOptions;

		[Label("Auto Update", "")]
		[SerializeField]
		private bool m_AutoUpdateColliders;

		[SerializeField]
		private PhysicMaterial m_Material;

		private int mCurrentMeshCount;

		public bool Combine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool GroupMeshes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CGYesNoAuto AddNormals
		{
			get
			{
				return default(CGYesNoAuto);
			}
			set
			{
			}
		}

		public CGYesNoAuto AddTangents
		{
			get
			{
				return default(CGYesNoAuto);
			}
			set
			{
			}
		}

		public bool AddUV2
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int Layer
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Tag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool MakeStatic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RendererEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ShadowCastingMode CastShadows
		{
			get
			{
				return default(ShadowCastingMode);
			}
			set
			{
			}
		}

		public bool ReceiveShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseLightProbes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public LightProbeUsage LightProbeUsage
		{
			get
			{
				return default(LightProbeUsage);
			}
			set
			{
			}
		}

		public ReflectionProbeUsage ReflectionProbes
		{
			get
			{
				return default(ReflectionProbeUsage);
			}
			set
			{
			}
		}

		public Transform AnchorOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CGColliderEnum Collider
		{
			get
			{
				return default(CGColliderEnum);
			}
			set
			{
			}
		}

		public bool AutoUpdateColliders
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Convex
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsTrigger
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public MeshColliderCookingOptions CookingOptions
		{
			get
			{
				return default(MeshColliderCookingOptions);
			}
			set
			{
			}
		}

		public PhysicMaterial Material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CGMeshResourceCollection Meshes => null;

		public int MeshCount => 0;

		public int VertexCount { get; private set; }

		private bool canGroupMeshes => false;

		private bool canModifyStaticFlag => false;

		private bool canUpdate => false;

		private bool EnableIsTrigger => false;

		public override void Reset()
		{
		}

		public override void OnTemplateCreated()
		{
		}

		public void Clear()
		{
		}

		public override void OnStateChange()
		{
		}

		public override void Refresh()
		{
		}

		public GameObject SaveToScene(Transform parent = null)
		{
			return null;
		}

		public void UpdateColliders()
		{
		}

		private static GameObject SaveMeshResourceToScene(Component managedResource, Transform newParent)
		{
			return null;
		}

		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		private void createSpotMeshes(ref List<CGVMesh> vMeshes, CGSpot[] spots, bool combine)
		{
		}

		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		private void removeUnusedResource()
		{
		}

		private CGMeshResource getNewMesh()
		{
			return null;
		}
	}
}
