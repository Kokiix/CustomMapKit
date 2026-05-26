using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[ExecuteAlways]
public class CableProceduralSimple : MonoBehaviour
{
	private LineRenderer line;

	[SerializeField]
	private Transform endPointTransform;

	[SerializeField]
	[Tooltip("Number of points per unit length, using the straight line from the start to the end transform.")]
	private float pointDensity;

	[SerializeField]
	private float sagAmplitude;

	[SerializeField]
	private float swayMultiplier;

	[SerializeField]
	private float swayXMultiplier;

	[SerializeField]
	private float swayYMultiplier;

	[SerializeField]
	private float swayFrequency;

	private int pointsInLineRenderer;

	private Vector3 vectorFromStartToEnd;

	private Vector3 sagDirection;

	private float swayValue;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Draw()
	{
	}
}
