using FluffyUnderware.Curvy.Controllers;
using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	public class MetaDataController : SplineController
	{
		[Section("MetaController", true, false, 100, Sort = 0)]
		[RangeEx(0f, 30f, "", "")]
		[SerializeField]
		private float m_MaxHeight;

		public float MaxHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		protected override void UserAfterInit()
		{
		}

		protected override void UserAfterUpdate()
		{
		}

		private void setHeight()
		{
		}
	}
}
