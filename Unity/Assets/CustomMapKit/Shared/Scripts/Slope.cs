using UnityEngine;

public class Slope : MonoBehaviour
{
	public Transform rearRayPos;

	public Transform frontRayPos;

	public LayerMask layerMask;

	private FirstPersonController controller;

	public float surfaceAngle;

	public bool uphill;

	public bool downhill;

	public bool flatSurface;

	private RaycastHit rearHit;

	private bool rearCast;

	private RaycastHit frontHit;

	private bool frontCast;

	private RaycastHit middleHit;

	private bool middleCast;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
