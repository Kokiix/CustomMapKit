using System;
using System.Collections.Generic;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy
{
	[RequireComponent(typeof(CurvySpline))]
	[ExecuteInEditMode]
	[HelpURL("https://curvyeditor.com/doclink/curvyshape")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[SerializeField]
		[Label("Plane", "")]
		private CurvyPlane m_Plane;

		[SerializeField]
		[HideInInspector]
		private bool m_Persistent;

		private static Dictionary<CurvyShapeInfo, Type> mShapeDefs;

		private CurvySpline mSpline;

		[NonSerialized]
		public bool Dirty;

		public CurvyPlane Plane
		{
			get
			{
				return default(CurvyPlane);
			}
			set
			{
			}
		}

		[Obsolete("This will be removed in a future update. All shapes are now Persistent")]
		public bool Persistent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public CurvySpline Spline => null;

		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions => null;

		private void Update()
		{
		}

		protected virtual void Reset()
		{
		}

		public void Delete()
		{
		}

		public void Refresh()
		{
		}

		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		protected void SetPosition(int no, Vector3 position)
		{
		}

		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		protected virtual void ApplyShape()
		{
		}

		protected void PrepareControlPoints(int count)
		{
		}

		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			currentIndex = default(int);
			return null;
		}

		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		private void applyPlane()
		{
		}

		private void applyRotation(Quaternion q)
		{
		}
	}
}
