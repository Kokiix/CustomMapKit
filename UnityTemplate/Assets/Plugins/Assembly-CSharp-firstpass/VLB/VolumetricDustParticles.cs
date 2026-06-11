using System;
using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Range(0f, 1f)]
		public float alpha;

		[Range(0.0001f, 0.1f)]
		public float size;

		public ParticlesDirection direction;

		public Vector3 velocity;

		[Obsolete("Use 'velocity' instead")]
		public float speed;

		public float density;

		[Range(0f, 1f)]
		public float spawnMinDistance;

		[Range(0f, 1f)]
		public float spawnMaxDistance;

		public bool cullingEnabled;

		public float cullingMaxDistance;

		public static bool isFeatureSupported;

		private ParticleSystem m_Particles;

		private ParticleSystemRenderer m_Renderer;

		private static bool ms_NoMainCameraLogged;

		private static Camera ms_MainCamera;

		private VolumetricLightBeam m_Master;

		public bool isCulled { get; private set; }

		public bool particlesAreInstantiated => false;

		public int particlesCurrentCount => 0;

		public int particlesMaxCount => 0;

		public Camera mainCamera => null;

		private void Start()
		{
		}

		private void InstantiateParticleSystem()
		{
		}

		private void OnEnable()
		{
		}

		private void SetActiveAndPlay()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void SetParticleProperties()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		private void UpdateCulling()
		{
		}
	}
}
