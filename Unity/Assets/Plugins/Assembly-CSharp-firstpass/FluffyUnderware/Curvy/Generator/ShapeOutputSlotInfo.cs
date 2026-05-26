using System;

namespace FluffyUnderware.Curvy.Generator
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class ShapeOutputSlotInfo : OutputSlotInfo
	{
		public bool OutputsVariableShape;

		public ShapeOutputSlotInfo()
			: base(null)
		{
		}

		public ShapeOutputSlotInfo(string name)
			: base(null)
		{
		}
	}
}
