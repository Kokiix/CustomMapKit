using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/Rendering/Colorful Fog")]
public class ColorfulFog : MonoBehaviour
{
	public enum ColoringMode
	{
		Solid = 0,
		Cube = 1,
		SimpleGradient = 2,
		Gradient = 3,
		GradientTexture = 4
	}

	public bool useCustomDepthTexture;

	public bool distanceFog;

	public bool useRadialDistance;

	public bool heightFog;

	public float height;

	[Range(0.001f, 10f)]
	public float heightDensity;

	public float startDistance;

	public FogMode fogMode;

	public float fogDensity;

	public float fogStart;

	public float fogEnd;

	public ColoringMode coloringMode;

	public Cubemap fogCube;

	public Color solidColor;

	public Color skyColor;

	public Color equatorColor;

	public Color groundColor;

	public Gradient gradient;

	public int gradientResolution;

	public Texture2D gradientTexture;

	public Shader fogShader;

	public Shader customDepthShader;

	protected Texture2D tmpGradientTexture;

	private Material fogMaterial;

	private Camera cam;

	private Camera depthCamera;

	private RenderTexture depthTexture;

	private Vector2 cachedResolution;

	private Material GetFogMaterial()
	{
		return null;
	}

	private bool CheckResources()
	{
		return false;
	}

	private void OnDisable()
	{
	}

	private bool ScreenResolutionChanged()
	{
		return false;
	}

	private void OnPreRender()
	{
	}

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	private static void CustomGraphicsBlit(RenderTexture source, RenderTexture dest, Material fxMaterial, int passNr)
	{
	}

	public void ApplyGradientChanges()
	{
	}

	public void NullTmpGradTex()
	{
	}

	private Texture2D GetGradientTexture(Gradient gradient, int resolution = 10)
	{
		return null;
	}
}
