using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[ResourceLoader("Spline")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		public Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		public void Destroy(CGModule cgModule, Component obj, string context, bool kill)
		{
		}
	}
}
