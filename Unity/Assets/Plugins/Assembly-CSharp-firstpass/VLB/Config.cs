using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		public bool geometryOverrideLayer;

		public int geometryLayerID;

		public string geometryTag;

		public int geometryRenderQueue;

		[FormerlySerializedAs("renderPipeline")]
		[SerializeField]
		private RenderPipeline _RenderPipeline;

		[FormerlySerializedAs("renderingMode")]
		[SerializeField]
		private RenderingMode _RenderingMode;

		public float ditheringFactor;

		public int sharedMeshSides;

		public int sharedMeshSegments;

		[Range(0.01f, 2f)]
		public float globalNoiseScale;

		public Vector3 globalNoiseVelocity;

		public string fadeOutCameraTag;

		[HighlightNull]
		public TextAsset noise3DData;

		public int noise3DSize;

		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		public Texture2D ditheringNoiseTexture;

		[SerializeField]
		private int pluginVersion;

		[SerializeField]
		private Material _DummyMaterial;

		[SerializeField]
		private Shader _BeamShader;

		private Transform m_CachedFadeOutCamera;

		private static Config m_Instance;

		public RenderPipeline renderPipeline
		{
			get
			{
				return default(RenderPipeline);
			}
			set
			{
			}
		}

		public RenderingMode renderingMode
		{
			get
			{
				return default(RenderingMode);
			}
			set
			{
			}
		}

		public RenderingMode actualRenderingMode => default(RenderingMode);

		public bool useSinglePassShader => false;

		public bool requiresDoubleSidedMesh => false;

		public Shader beamShader => null;

		public Transform fadeOutCameraTransform => null;

		public bool hasRenderPipelineMismatch => false;

		public static Config Instance => null;

		public void SetRenderingModeAndRefreshShader(RenderingMode mode)
		{
		}

		public bool IsSRPBatcherSupported()
		{
			return false;
		}

		public void ForceUpdateFadeOutCamera()
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		public void Reset()
		{
		}

		private void RefreshGlobalShaderProperties()
		{
		}

		public void ResetInternalData()
		{
		}

		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}
	}
}
