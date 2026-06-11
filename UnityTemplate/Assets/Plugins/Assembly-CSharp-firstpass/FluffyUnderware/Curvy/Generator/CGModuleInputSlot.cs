using System;
using System.Collections.Generic;

namespace FluffyUnderware.Curvy.Generator
{
	[Serializable]
	public class CGModuleInputSlot : CGModuleSlot
	{
		public InputSlotInfo InputInfo => null;

		protected override void LoadLinkedSlots()
		{
		}

		public override void UnlinkAll()
		{
		}

		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return false;
		}

		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return false;
		}

		private CGModule SourceModule(int index)
		{
			return null;
		}

		public T GetData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		public List<T> GetAllData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		private CGData[] GetData<T>(int slotIndex, params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		private static CGData[] cloneData<T>(ref CGData[] source) where T : CGData
		{
			return null;
		}
	}
}
