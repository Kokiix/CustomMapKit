using System;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Generator
{
	[Serializable]
	public class CGWeightedItem
	{
		[RangeEx(0f, 1f, "", "", Slider = true, Precision = 1)]
		[SerializeField]
		private float m_Weight;

		public float Weight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
