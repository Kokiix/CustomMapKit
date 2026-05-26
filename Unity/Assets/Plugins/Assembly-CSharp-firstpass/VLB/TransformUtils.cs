using UnityEngine;

namespace VLB
{
	public static class TransformUtils
	{
		public class Packed
		{
			public Vector3 position;

			public Quaternion rotation;

			public Vector3 lossyScale;
		}

		public static Packed GetWorldPacked(this Transform self)
		{
			return null;
		}

		public static bool IsSame(this Transform self, Packed packed)
		{
			return false;
		}
	}
}
