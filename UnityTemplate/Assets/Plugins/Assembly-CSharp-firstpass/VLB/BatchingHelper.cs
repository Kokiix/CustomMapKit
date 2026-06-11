using UnityEngine;

namespace VLB
{
	public static class BatchingHelper
	{
		public const bool isGpuInstancingSupported = true;

		public static bool forceEnableDepthBlend => false;

		public static bool IsGpuInstancingEnabled(Material material)
		{
			return false;
		}

		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reasons)
		{
			return false;
		}

		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
}
