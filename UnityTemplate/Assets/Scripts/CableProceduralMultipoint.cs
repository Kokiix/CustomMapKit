using System;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[ExecuteAlways]
public class CableProceduralMultipoint : MonoBehaviour
{
	[Serializable]
	private class CableSection
	{
		public Transform start;

		public Transform end;

		public float sag;
	}

	private LineRenderer line;

	[SerializeField]
	[Tooltip("Series of points in cable.  If this transform is the desired start, add it to this array.")]
	private CableSection[] cableSections;

	[SerializeField]
	[Tooltip("Number of points per unit length, using the straight line from the start to the end transform.")]
	private float pointDensity;

	private Vector3 sagDirection;

	private void Start()
	{
	}

	private void Draw(CableSection section)
	{
	}
}
