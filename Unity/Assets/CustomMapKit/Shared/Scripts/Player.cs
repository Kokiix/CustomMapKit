using UnityEngine;

public class Player : MonoBehaviour
{
	public float MoveSpeed;

	public float JumpSpeed;

	public float FallSpeed;

	private Vector3 MoveDirection;

	public float Sensitivity;

	public bool Smooth;

	public Texture Crosshair;

	private int CrosshairSize;

	public UseArea[] UseAreas;

	private float Yaw;

	private float Pitch;

	private float[] YawAvg;

	private float[] PitchAvg;

	private bool PrevUse;

	private bool PrevSlowMotion;

	private float Avg(float[] AvgValues, float New)
	{
		return 0f;
	}

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void Update()
	{
	}
}
