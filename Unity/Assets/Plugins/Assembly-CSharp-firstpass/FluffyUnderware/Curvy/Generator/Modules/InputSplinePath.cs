using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Input/Spline Path", ModuleName = "Input Spline Path", Description = "Spline Path")]
	[HelpURL("https://curvyeditor.com/doclink/cginputsplinepath")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[HideInInspector]
		[OutputSlotInfo(typeof(CGPath))]
		public CGModuleOutputSlot Path;

		[Tab("General", Sort = 0)]
		[SerializeField]
		[CGResourceManager("Spline")]
		[FieldCondition("m_Spline", null, false, ActionAttribute.ActionEnum.ShowWarning, "Create or assign spline", ActionAttribute.ActionPositionEnum.Below)]
		private CurvySpline m_Spline;

		public CurvySpline Spline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SupportsIPE => false;

		protected override CurvySpline InputSpline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		public override void OnTemplateCreated()
		{
		}
	}
}
