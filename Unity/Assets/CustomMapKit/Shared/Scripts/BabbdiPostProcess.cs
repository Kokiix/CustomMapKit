using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class BabbdiPostProcess : MonoBehaviour
{
	[SerializeField]
	private ColorfulFog colorfulFog;

	[SerializeField]
	private PostProcessVolume volume;

	[SerializeField]
	private PostProcessVolume weaponCam;

	private void Start()
	{
	}
}
