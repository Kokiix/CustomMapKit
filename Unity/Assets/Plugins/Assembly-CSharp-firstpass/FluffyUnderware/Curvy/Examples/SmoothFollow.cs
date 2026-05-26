using UnityEngine;

namespace FluffyUnderware.Curvy.Examples
{
	public class SmoothFollow : MonoBehaviour
	{
		[SerializeField]
		private Transform target;

		[SerializeField]
		private float distance;

		[SerializeField]
		private float height;

		[SerializeField]
		private float rotationDamping;

		[SerializeField]
		private float heightDamping;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
