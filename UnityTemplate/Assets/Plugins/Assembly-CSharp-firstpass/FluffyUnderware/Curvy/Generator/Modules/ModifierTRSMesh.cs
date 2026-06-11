using System;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Modifier/TRS Mesh", ModuleName = "TRS Mesh", Description = "Transform,Rotate,Scale a VMesh")]
	[HelpURL("https://curvyeditor.com/doclink/cgtrsmesh")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGVMesh) }, Array = true, ModifiesData = true)]
		public CGModuleInputSlot InVMesh;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGVMesh), Array = true)]
		public CGModuleOutputSlot OutVMesh;

		public override void Refresh()
		{
		}
	}
}
