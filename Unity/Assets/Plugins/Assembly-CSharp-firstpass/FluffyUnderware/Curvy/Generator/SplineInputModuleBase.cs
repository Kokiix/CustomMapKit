using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	public abstract class SplineInputModuleBase : CGModule
	{
		[Tab("General")]
		[SerializeField]
		[Tooltip("Makes this module use the cached approximations of the spline's positions and tangents")]
		private bool m_UseCache;

		[Tooltip("Whether to use local or global coordinates of the input's control points.\r\nUsing the global space when the input's transform is updating every frame will lead to the generator refreshing too frequently")]
		[SerializeField]
		private bool m_UseGlobalSpace;

		[Tab("Range")]
		[SerializeField]
		protected CurvySplineSegment m_StartCP;

		[FieldCondition("m_StartCP", null, true, ActionAttribute.ActionEnum.Show, null, ActionAttribute.ActionPositionEnum.Below, Action = ActionAttribute.ActionEnum.Enable)]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		public bool UseCache
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CurvySplineSegment StartCP
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CurvySplineSegment EndCP
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseGlobalSpace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool IsConfigured => false;

		public override bool IsInitialized => false;

		public bool PathIsClosed => false;

		protected abstract CurvySpline InputSpline { get; set; }

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public override void Reset()
		{
		}

		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		private void OnInputSplineCoordinatesChanged(CurvySpline sender)
		{
		}

		private void ForceRefresh()
		{
		}

		private bool getPathClosed(CurvySpline spline)
		{
			return false;
		}

		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		private static void FillData(CGShape dataToFill, SamplePointsMaterialGroup materialGroup, List<float> sourceFs, List<float> relativeFs, bool isFullPath, List<Vector3> positions, List<Vector3> tangents, List<Vector3> normals, bool considerSplineTransform, Transform splineTransform, Transform generatorTransform)
		{
		}

		private static void AddPoint(float sourceF, float relativeF, bool isFullPath, Vector3 position, Vector3 tangent, Vector3 up, List<float> sourceFList, List<float> relativeFList, List<Vector3> positionList, List<Vector3> tangentList, List<Vector3> upList)
		{
		}

		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, float stopTF, bool loop, float stepDist)
		{
			pos = default(Vector3);
			tan = default(Vector3);
			return false;
		}

		private static void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			cp = null;
			return null;
		}

		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			cp = null;
			return null;
		}

		protected virtual void OnSplineAssigned()
		{
		}

		protected void ValidateStartAndEndCps()
		{
		}
	}
}
