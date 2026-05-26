using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Input/Game Objects", ModuleName = "Input GameObjects", Description = "")]
	[HelpURL("https://curvyeditor.com/doclink/cginputgameobject")]
	public class InputGameObject : CGModule
	{
		[HideInInspector]
		[OutputSlotInfo(typeof(CGGameObject), Array = true)]
		public CGModuleOutputSlot OutGameObject;

		[ArrayEx]
		[SerializeField]
		private List<CGGameObjectProperties> m_GameObjects;

		public List<CGGameObjectProperties> GameObjects => null;

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
