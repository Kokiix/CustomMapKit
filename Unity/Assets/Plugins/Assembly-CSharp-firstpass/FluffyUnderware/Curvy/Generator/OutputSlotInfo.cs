using System;

namespace FluffyUnderware.Curvy.Generator
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class OutputSlotInfo : SlotInfo
	{
		public Type DataType => null;

		public OutputSlotInfo(Type type)
			: base((string)null, (Type[])null)
		{
		}

		public OutputSlotInfo(string name, Type type)
			: base((string)null, (Type[])null)
		{
		}
	}
}
