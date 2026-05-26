using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraEffect : MonoBehaviour
{
	private static readonly int DamageID;

	private static readonly int SuppressionID;

	public static float Intensity;

	public Material material;

	private float dmg;

	[SerializeField]
	private float speed;

	[SerializeField]
	private float suppSpeed;

	[SerializeField]
	private float start;

	[SerializeField]
	private float suppStart;

	[Space]
	[SerializeField]
	private AudioClip[] selfBodyHitClips;

	private void Awake()
	{
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[ContextMenu("TakeHit")]
	public void TakeHit()
	{
	}

	[ContextMenu("supp")]
	public void TrigSup()
	{
	}
}
