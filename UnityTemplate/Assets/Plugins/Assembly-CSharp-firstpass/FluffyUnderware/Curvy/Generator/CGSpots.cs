using System.Collections.Generic;

namespace FluffyUnderware.Curvy.Generator
{
	[CGDataInfo(0.96f, 0.96f, 0.96f, 1f)]
	public class CGSpots : CGData
	{
		public CGSpot[] Points;

		public override int Count => 0;

		public CGSpots()
		{
		}

		public CGSpots(params CGSpot[] points)
		{
		}

		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		public CGSpots(CGSpots source)
		{
		}

		public override T Clone<T>()
		{
			return null;
		}
	}
}
