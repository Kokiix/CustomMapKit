using FluffyUnderware.Curvy.Controllers;
using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	[RequireComponent(typeof(Rigidbody))]
	public class RigidBodySplineController : MonoBehaviour
	{
		public CurvySpline Spline;

		public SplineController CameraController;

		public float VSpeed;

		public float HSpeed;

		public float CenterDrag;

		public float JumpForce;

		private Rigidbody mRigidBody;

		private float mTF;

		private float velocity;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void FixedUpdate()
		{
		}
	}
}
