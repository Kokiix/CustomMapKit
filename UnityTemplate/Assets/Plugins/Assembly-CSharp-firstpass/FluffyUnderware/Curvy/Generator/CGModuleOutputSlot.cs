using System;
using System.Collections.Generic;

namespace FluffyUnderware.Curvy.Generator
{
	[Serializable]
	public class CGModuleOutputSlot : CGModuleSlot
	{
		public CGData[] Data;

		public CGDataRequestParameter[] LastRequestParameters;

		public OutputSlotInfo OutputInfo => null;

		public bool HasData => false;

		protected override void LoadLinkedSlots()
		{
		}

		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		public void ClearData()
		{
		}

		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		public void SetData(params CGData[] data)
		{
		}

		public T GetData<T>() where T : CGData
		{
			return null;
		}

		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}
	}
}
