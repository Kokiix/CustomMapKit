using System;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Modifier/Path Relative Translation", ModuleName = "Path Relative Translation", Description = "Translates a path relatively to it's direction, instead of relatively to the world as does the TRS Path module.")]
	[HelpURL("https://curvyeditor.com/doclink/cgpathrelativetranslation")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGPath) }, Name = "Path A", ModifiesData = true)]
		public CGModuleInputSlot InPath;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGPath))]
		public CGModuleOutputSlot OutPath;

		[SerializeField]
		[Tooltip("The translation amount")]
		private float lateralTranslation;

		public float LateralTranslation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool PathIsClosed => false;

		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		public override void Reset()
		{
		}
	}
}
