using FluffyUnderware.DevTools;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	[ExecuteInEditMode]
	public class ChaseCam : MonoBehaviour
	{
		public Transform LookAt;

		public Transform MoveTo;

		public Transform RollTo;

		[Positive]
		public float ChaseTime;

		private Vector3 mVelocity;

		private Vector3 mRollVelocity;

		private void LateUpdate()
		{
		}
	}
}
