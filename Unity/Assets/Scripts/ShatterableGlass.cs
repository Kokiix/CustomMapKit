using UnityEngine;

public class ShatterableGlass : MonoBehaviour
{
	private struct ShatterableGlassInfo
	{
		public Vector3 HitPoint;

		public Vector3 HitDirrection;

		public ShatterableGlassInfo(Vector3 HitPoint, Vector3 HitDirrection)
		{
			this.HitPoint = default(Vector3);
			this.HitDirrection = default(Vector3);
		}
	}

	private class Figure
	{
		public Vector2[] Points;

		public int ForceScale;

		public Figure(Vector2[] Points, int ForceScale)
		{
		}

		public void GenerateCollider(float GlassThickness, GameObject Obj)
		{
		}

		public Mesh GenerateMesh(bool GenerateGlassSides, float GlassHalfThickness, Vector2 UVScale)
		{
			return null;
		}

		private void GlassSideVertex(Vector2 Ref, ref Vector3 A, ref Vector3 B, float GlassHalfThickness)
		{
		}
	}

	private class BaseLine
	{
		public Vector2[] Points;

		public BaseLine(Vector2 HitPoint, Vector2 End, int Count)
		{
		}
	}

	private bool canBreak;

	private Vector3 TempHitPoint;

	private Vector3 TempDirection;

	public int Sectors;

	public int DetailsPerSector;

	public float SimplifyThreshold;

	public bool GlassSides;

	public Material GlassSidesMaterial;

	public float GlassThickness;

	public bool ShatterButNotBreak;

	public bool SlightlyRotateGibs;

	public bool DestroyGibs;

	public float AfterSeconds;

	public bool GibsOnSeparateLayer;

	public int GibsLayer;

	public float Force;

	public bool AdoptFragments;

	private Vector2[] Bounds;

	private float Area;

	private Material GlassMaterial;

	private AudioSource SoundEmitter;

	private BoxCollider col;

	private AudioSource source;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Start()
	{
	}

	public void Shatter2D(Vector2 HitPoint)
	{
	}

	public void Shatter3D(Vector3 hitPoint, Vector3 direction)
	{
	}

	public void Shatter3DLocal(Vector3 hitPoint, Vector3 direction)
	{
	}

	public void Shatter(Vector2 HitPoint, Vector3 ForceDirrection)
	{
	}
}
