using System;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator.Modules
{
	[ModuleInfo("Modifier/Variable Mix Shapes", ModuleName = "Variable Mix Shapes", Description = "Interpolates between two shapes in a way that varies along the shape extrusion")]
	[HelpURL("https://curvyeditor.com/doclink/cgvariablemixshapes")]
	public class ModifierVariableMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing, IPathProvider
	{
		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGShape) }, Name = "Shape A")]
		public CGModuleInputSlot InShapeA;

		[HideInInspector]
		[InputSlotInfo(new Type[] { typeof(CGShape) }, Name = "Shape B")]
		public CGModuleInputSlot InShapeB;

		[HideInInspector]
		[ShapeOutputSlotInfo(OutputsVariableShape = true, Array = true, ArrayType = SlotInfo.SlotArrayType.Hidden)]
		public CGModuleOutputSlot OutShape;

		[Label("Mix Curve", "Mix between the shapes. Values (Y axis) between -1 for Shape A and 1 for Shape B. Times (X axis) between 0 for extrusion start and 1 for extrusion end")]
		[SerializeField]
		private AnimationCurve m_MixCurve;

		public bool PathIsClosed => false;

		public AnimationCurve MixCurve
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Reset()
		{
		}

		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}
	}
}
