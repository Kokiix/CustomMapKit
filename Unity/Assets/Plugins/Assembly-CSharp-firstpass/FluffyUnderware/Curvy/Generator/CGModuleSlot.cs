using System;
using System.Collections.Generic;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	public class CGModuleSlot
	{
		protected List<CGModuleSlot> mLinkedSlots;

		public CGModule Module { get; internal set; }

		public SlotInfo Info { get; internal set; }

		public Vector2 Origin { get; set; }

		public Rect DropZone { get; set; }

		public bool IsLinked => false;

		public bool IsLinkedAndConfigured => false;

		public IOnRequestProcessing OnRequestModule => null;

		[Obsolete("IOnRequestPath is an interface with no added value, and will get removed in a future update. Use OnRequestModule or PathProvider instead")]
		public IOnRequestPath OnRequestPathModule => null;

		public IPathProvider PathProvider => null;

		public IExternalInput ExternalInput => null;

		public List<CGModuleSlot> LinkedSlots => null;

		public int Count => 0;

		public string Name => null;

		public bool HasLinkTo(CGModuleSlot other)
		{
			return false;
		}

		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		protected static void LinkInputAndOutput(CGModuleSlot inputSlot, CGModuleSlot outputSlot)
		{
		}

		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		public virtual void UnlinkAll()
		{
		}

		public void ReInitializeLinkedSlots()
		{
		}

		protected virtual void LoadLinkedSlots()
		{
		}

		public static implicit operator bool(CGModuleSlot a)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
