using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	public static class MaterialManager
	{
		public enum BlendingMode
		{
			Additive = 0,
			SoftAdditive = 1,
			TraditionalTransparency = 2,
			Count = 3
		}

		public enum Noise3D
		{
			Off = 0,
			On = 1,
			Count = 2
		}

		public enum DepthBlend
		{
			Off = 0,
			On = 1,
			Count = 2
		}

		public enum ColorGradient
		{
			Off = 0,
			MatrixLow = 1,
			MatrixHigh = 2,
			Count = 3
		}

		public enum DynamicOcclusion
		{
			Off = 0,
			ClippingPlane = 1,
			DepthTexture = 2,
			Count = 3
		}

		public enum MeshSkewing
		{
			Off = 0,
			On = 1,
			Count = 2
		}

		public enum ShaderAccuracy
		{
			Fast = 0,
			High = 1,
			Count = 2
		}

		public class StaticProperties
		{
			public BlendingMode blendingMode;

			public Noise3D noise3D;

			public DepthBlend depthBlend;

			public ColorGradient colorGradient;

			public DynamicOcclusion dynamicOcclusion;

			public MeshSkewing meshSkewing;

			public ShaderAccuracy shaderAccuracy;

			public int materialID => 0;

			public void ApplyToMaterial(Material mat)
			{
			}
		}

		private class MaterialsGroup
		{
			public Material[] materials;
		}

		public static MaterialPropertyBlock materialPropertyBlock;

		private static readonly BlendMode[] BlendingMode_SrcFactor;

		private static readonly BlendMode[] BlendingMode_DstFactor;

		private static readonly bool[] BlendingMode_AlphaAsBlack;

		private static int kStaticPropertiesCount;

		private static Hashtable ms_MaterialsGroup;

		public static Material NewMaterialTransient(bool gpuInstanced)
		{
			return null;
		}

		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
}
