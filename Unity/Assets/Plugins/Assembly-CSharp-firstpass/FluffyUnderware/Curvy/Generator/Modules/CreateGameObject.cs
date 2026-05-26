using System;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Create/GameObject", ModuleName = "Create GameObject")]
	[HelpURL("https://curvyeditor.com/doclink/cgcreategameobject")]
	public class CreateGameObject : CGModule
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGGameObject) }, Array = true, Name = "GameObject")]
		public CGModuleInputSlot InGameObjectArray;

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGSpots) }, Name = "Spots")]
		public CGModuleInputSlot InSpots;

		[SerializeField]
		[CGResourceCollectionManager("GameObject", ShowCount = true)]
		private CGGameObjectResourceCollection m_Resources;

		[Tab("General")]
		[SerializeField]
		private bool m_MakeStatic;

		[SerializeField]
		[Layer("", "")]
		private int m_Layer;

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

		public CGGameObjectResourceCollection GameObjects => null;

		public int GameObjectCount => 0;

		public override void Reset()
		{
		}

		protected override void OnDestroy()
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
	}
}
