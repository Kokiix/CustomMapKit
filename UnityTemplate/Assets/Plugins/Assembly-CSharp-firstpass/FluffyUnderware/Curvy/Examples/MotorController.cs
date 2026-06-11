using FluffyUnderware.Curvy.Controllers;
using FluffyUnderware.DevTools;

namespace FluffyUnderware.Curvy.Examples
{
	public class MotorController : SplineController
	{
		[Section("Motor", true, false, 100)]
		public float MaxSpeed;

		protected override void Update()
		{
		}
	}
}
