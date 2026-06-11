using System.Collections.Generic;

namespace FluffyUnderware.Curvy.Generator
{
	public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
	{
		public int MaterialID;

		public float AspectCorrection;

		public int TriangleCount => 0;

		public SamplePointsMaterialGroupCollection()
		{
		}

		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
		{
		}
	}
}
