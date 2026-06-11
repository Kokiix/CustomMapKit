using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Input/Meshes", ModuleName = "Input Meshes", Description = "Create VMeshes")]
	[HelpURL("https://curvyeditor.com/doclink/cginputmesh")]
	public class InputMesh : CGModule, IExternalInput
	{
		[HideInInspector]
		[OutputSlotInfo(typeof(CGVMesh), Array = true)]
		public CGModuleOutputSlot OutVMesh;

		[SerializeField]
		[ArrayEx]
		private List<CGMeshProperties> m_Meshes;

		public List<CGMeshProperties> Meshes => null;

		public bool SupportsIPE => false;

		public override void Reset()
		{
		}

		public override void Refresh()
		{
		}

		public override void OnTemplateCreated()
		{
		}
	}
}
