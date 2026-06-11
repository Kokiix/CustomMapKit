using System.Collections.Generic;
using System.Collections.ObjectModel;
using FluffyUnderware.DevTools;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FluffyUnderware.Curvy
{
	[ExecuteInEditMode]
	[HelpURL("https://curvyeditor.com/doclink/curvyconnection")]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[SerializeField]
		[Hide]
		private List<CurvySplineSegment> m_ControlPoints;

		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		private Couple<Vector3, Quaternion> processedConnectionCoordinates;

		[SerializeField]
		[Hide]
		private List<ControlPointCoordinates> processedControlPointsCoordinates;

		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList => null;

		public int Count => 0;

		public CurvySplineSegment this[int idx] => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDestroy()
		{
		}

		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		public void AutoSetFollowUp()
		{
		}

		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		public void Delete()
		{
		}

		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		private void DoUpdate()
		{
		}

		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		private void ResetProcessedCoordinates()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
