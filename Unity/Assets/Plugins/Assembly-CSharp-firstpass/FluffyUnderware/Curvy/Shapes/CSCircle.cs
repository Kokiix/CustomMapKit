using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Shapes
{
	[CurvyShapeInfo("2D/Circle", true)]
	[RequireComponent(typeof(CurvySpline))]
	[AddComponentMenu("Curvy/Shape/Circle")]
	public class CSCircle : CurvyShape2D
	{
		[Positive(Tooltip = "Number of Control Points")]
		[SerializeField]
		private int m_Count;

		[SerializeField]
		private float m_Radius;

		public int Count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void Reset()
		{
		}

		protected override void ApplyShape()
		{
		}
	}
}
