using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Components
{
	[HelpURL("https://curvyeditor.com/doclink/curvyglrenderer")]
	[AddComponentMenu("Curvy/Misc/Curvy GL Renderer")]
	public class CurvyGLRenderer : MonoBehaviour
	{
		[ArrayEx(ShowAdd = false, Draggable = false)]
		public List<GLSlotData> Splines;

		private Material lineMaterial;

		private void CreateLineMaterial()
		{
		}

		private void OnPostRender()
		{
		}

		private void sanitize()
		{
		}

		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		public void Add(CurvySpline spline)
		{
		}

		public void Remove(CurvySpline spline)
		{
		}
	}
}
