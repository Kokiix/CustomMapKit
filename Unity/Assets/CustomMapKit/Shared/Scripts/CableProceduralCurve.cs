using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[ExecuteAlways]
public class CableProceduralCurve : MonoBehaviour
{
	private LineRenderer line;

	[SerializeField]
	private Transform endPointTransform;

	[SerializeField]
	[Tooltip("Number of points per unit length, using the straight line from the start to the end transform.")]
	private float pointDensity;

	[SerializeField]
	[Tooltip("Positive keys are applied downward on cable.  Recommended use is to have keys at 0 at the start and end of the curve.")]
	private AnimationCurve curve;

	private int pointsInLineRenderer;

	private Vector3 vectorFromStartToEnd;

	private Vector3 sagDirection;

	private void Start()
	{
	}

	private void Draw()
	{
	}
}
