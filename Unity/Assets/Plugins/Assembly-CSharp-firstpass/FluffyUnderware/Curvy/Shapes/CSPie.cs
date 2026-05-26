using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Shapes
{
	[CurvyShapeInfo("2D/Pie", true)]
	[RequireComponent(typeof(CurvySpline))]
	[AddComponentMenu("Curvy/Shape/Pie")]
	public class CSPie : CSCircle
	{
		public enum EatModeEnum
		{
			Left = 0,
			Right = 1,
			Center = 2
		}

		[Range(0f, 1f)]
		[SerializeField]
		private float m_Roundness;

		[SerializeField]
		[RangeEx(0f, "maxEmpty", "Empty", "Number of empty slices")]
		private int m_Empty;

		[Label(Tooltip = "Eat Mode")]
		[SerializeField]
		private EatModeEnum m_Eat;

		public float Roundness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int Empty
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		private int maxEmpty => 0;

		public EatModeEnum Eat
		{
			get
			{
				return default(EatModeEnum);
			}
			set
			{
			}
		}

		protected override void Reset()
		{
		}

		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		protected override void ApplyShape()
		{
		}
	}
}
