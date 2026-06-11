using UnityEngine;

public class CustomPostProcessing : MonoBehaviour
{
	public Material PostProcessingMaterial;

	public bool usePostProcessing;

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
