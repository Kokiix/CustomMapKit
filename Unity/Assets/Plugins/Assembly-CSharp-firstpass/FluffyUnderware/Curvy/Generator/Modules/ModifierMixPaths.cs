using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using JetBrains.Annotations;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Modifier/Mix Paths", ModuleName = "Mix Paths", Description = "Interpolates between two paths")]
	[HelpURL("https://curvyeditor.com/doclink/cgmixpaths")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGPath) }, Name = "Path A")]
		public CGModuleInputSlot InPathA;

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGPath) }, Name = "Path B")]
		public CGModuleInputSlot InPathB;

		[HideInInspector]
		[OutputSlotInfo(typeof(CGPath))]
		public CGModuleOutputSlot OutPath;

		[SerializeField]
		[RangeEx(-1f, 1f, "", "", Tooltip = "Mix between the paths. Values between -1 for Path A and 1 for Path B")]
		private float m_Mix;

		public float Mix
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

		protected override void OnEnable()
		{
		}

		public override void Reset()
		{
		}

		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}
	}
}
