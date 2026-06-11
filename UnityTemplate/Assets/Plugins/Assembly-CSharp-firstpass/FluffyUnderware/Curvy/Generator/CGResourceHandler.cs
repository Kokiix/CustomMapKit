using System.Collections.Generic;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	public static class CGResourceHandler
	{
		private static Dictionary<string, ICGResourceLoader> Loader;

		public static Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		public static void DestroyResource(CGModule module, string resName, Component obj, string context, bool kill)
		{
		}

		private static void getLoaders()
		{
		}
	}
}
