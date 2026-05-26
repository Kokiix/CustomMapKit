using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[ResourceLoader("GameObject")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
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
