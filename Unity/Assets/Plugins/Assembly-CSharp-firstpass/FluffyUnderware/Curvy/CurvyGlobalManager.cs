using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(PoolManager))]
	[HelpURL("https://curvyeditor.com/doclink/curvyglobalmanager")]
	public class CurvyGlobalManager : DTSingleton<CurvyGlobalManager>
	{
		public static bool HideManager;

		public static float SceneViewResolution;

		public static Color DefaultGizmoColor;

		public static Color DefaultGizmoSelectionColor;

		public static CurvyInterpolation DefaultInterpolation;

		public static float GizmoControlPointSize;

		public static float GizmoOrientationLength;

		public static Color GizmoOrientationColor;

		public static int SplineLayer;

		public static CurvySplineGizmos Gizmos;

		private PoolManager mPoolManager;

		private ComponentPool mControlPointPool;

		public static bool ShowCurveGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShowApproximationGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShowTangentsGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShowOrientationGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShowLabelsGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShowMetadataGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool ShowBoundsGizmo
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public PoolManager PoolManager => null;

		public ComponentPool ControlPointPool => null;

		public CurvyConnection[] Connections => null;

		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void LoadRuntimeSettings()
		{
		}

		public static void SaveRuntimeSettings()
		{
		}

		public override void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}
	}
}
