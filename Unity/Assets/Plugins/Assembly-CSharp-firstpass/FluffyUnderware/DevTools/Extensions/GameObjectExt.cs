using System;
using UnityEngine;

namespace FluffyUnderware.DevTools.Extensions
{
	public static class GameObjectExt
	{
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
}
