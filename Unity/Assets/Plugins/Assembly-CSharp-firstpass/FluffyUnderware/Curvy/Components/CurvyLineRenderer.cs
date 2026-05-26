using UnityEngine;

namespace FluffyUnderware.Curvy.Components
{
	[AddComponentMenu("Curvy/Misc/Curvy Line Renderer")]
	[RequireComponent(typeof(LineRenderer))]
	[ExecuteInEditMode]
	[HelpURL("https://curvyeditor.com/doclink/curvylinerenderer")]
	public class CurvyLineRenderer : MonoBehaviour
	{
		public CurvySpline m_Spline;

		private LineRenderer mRenderer;

		public CurvySpline Spline
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void EnforceWorldSpaceUsage()
		{
		}

		public void Refresh()
		{
		}

		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		private void OnSplineCoordinatesChanged(CurvySpline spline)
		{
		}

		private void BindEvents()
		{
		}

		private void UnbindEvents()
		{
		}
	}
}
