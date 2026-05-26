using System;
using UnityEngine;

namespace FluffyUnderware.Curvy.Controllers
{
	[Obsolete]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		public readonly CurvyController Controller;

		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
			: base(null, null)
		{
		}
	}
}
