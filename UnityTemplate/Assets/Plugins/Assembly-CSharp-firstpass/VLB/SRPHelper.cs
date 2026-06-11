using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	public static class SRPHelper
	{
		public enum RenderPipeline
		{
			Undefined = 0,
			BuiltIn = 1,
			URP = 2,
			LWRP = 3,
			HDRP = 4
		}

		private static RenderPipeline m_RenderPipelineCached;

		public static RenderPipeline renderPipelineType => default(RenderPipeline);

		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		public static bool IsUsingCustomRenderPipeline()
		{
			return false;
		}

		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
}
