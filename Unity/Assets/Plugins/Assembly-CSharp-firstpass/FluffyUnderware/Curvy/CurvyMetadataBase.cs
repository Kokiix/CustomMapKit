using UnityEngine;

namespace FluffyUnderware.Curvy
{
	[RequireComponent(typeof(CurvySplineSegment))]
	[ExecuteInEditMode]
	public abstract class CurvyMetadataBase : MonoBehaviour
	{
		private CurvySplineSegment mCP;

		public CurvySplineSegment ControlPoint => null;

		public CurvySpline Spline => null;

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public T GetPreviousData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : CurvyMetadataBase
		{
			return null;
		}

		public T GetNextData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : CurvyMetadataBase
		{
			return null;
		}

		protected void NotifyModification()
		{
		}
	}
}
