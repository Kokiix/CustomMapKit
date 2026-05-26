using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		public delegate void OnWillCameraRenderCB(Camera cam);

		public delegate void OnBeamGeometryInitialized();

		[CompilerGenerated]
		private sealed class _003CCoPlaytimeUpdate_003Ed__181 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VolumetricLightBeam _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoPlaytimeUpdate_003Ed__181(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public bool colorFromLight;

		public ColorMode colorMode;

		[ColorUsage(false, true)]
		[FormerlySerializedAs("colorValue")]
		public Color color;

		public Gradient colorGradient;

		public bool intensityFromLight;

		public bool intensityModeAdvanced;

		[FormerlySerializedAs("alphaInside")]
		[Range(0f, 8f)]
		public float intensityInside;

		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		[Range(0f, 8f)]
		public float intensityOutside;

		public BlendingMode blendingMode;

		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[Range(0.1f, 179.9f)]
		public float spotAngle;

		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		public ShaderAccuracy shaderAccuracy;

		public MeshType geomMeshType;

		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		public int geomCustomSegments;

		public Vector3 skewingLocalForwardDirection;

		public Transform clippingPlaneTransform;

		public bool geomCap;

		[FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		public AttenuationEquation attenuationEquation;

		[Range(0f, 1f)]
		public float attenuationCustomBlending;

		[FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		public float depthBlendDistance;

		public float cameraClippingDistance;

		[Range(0f, 1f)]
		public float glareFrontal;

		[Range(0f, 1f)]
		public float glareBehind;

		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		public NoiseMode noiseMode;

		[Range(0f, 1f)]
		public float noiseIntensity;

		public bool noiseScaleUseGlobal;

		[Range(0.01f, 2f)]
		public float noiseScaleLocal;

		public bool noiseVelocityUseGlobal;

		public Vector3 noiseVelocityLocal;

		public Dimensions dimensions;

		public Vector2 tiltFactor;

		private bool m_IsDynamicOcclusionEnabled;

		private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[SerializeField]
		private int pluginVersion;

		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[SerializeField]
		private int _SortingLayerID;

		[SerializeField]
		private int _SortingOrder;

		[FormerlySerializedAs("fadeOutBegin")]
		[SerializeField]
		private float _FadeOutBegin;

		[FormerlySerializedAs("fadeOutEnd")]
		[SerializeField]
		private float _FadeOutEnd;

		private BeamGeometry m_BeamGeom;

		private Coroutine m_CoPlaytimeUpdate;

		private Light _CachedLight;

		[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float intensityGlobal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float coneAngle => 0f;

		public float coneRadiusEnd => 0f;

		public float coneVolume => 0f;

		public float coneApexOffsetZ => 0f;

		public int geomSides
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int geomSegments
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Vector3 skewingLocalForwardDirectionNormalized => default(Vector3);

		public Vector4 additionalClippingPlane => default(Vector4);

		public bool canHaveMeshSkewing => false;

		public bool hasMeshSkewing => false;

		[Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float attenuationLerpLinearQuad => 0f;

		[Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxGeometryDistance => 0f;

		public bool isNoiseEnabled => false;

		[Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fadeOutBegin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fadeOutEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isFadeOutEnabled => false;

		public bool isTilted => false;

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool trackChangesDuringPlaytime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isCurrentlyTrackingChanges => false;

		public bool hasGeometry => false;

		public Bounds bounds => default(Bounds);

		public int blendingModeAsInt => 0;

		public Quaternion beamInternalLocalRotation => default(Quaternion);

		public Vector3 beamLocalForward => default(Vector3);

		public Vector3 lossyScale => default(Vector3);

		public float raycastDistance => 0f;

		public Vector3 raycastGlobalForward => default(Vector3);

		public Vector3 raycastGlobalUp => default(Vector3);

		public Vector3 raycastGlobalRight => default(Vector3);

		public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode { get; set; }

		public MaterialManager.DynamicOcclusion _INTERNAL_EnabledDynamicOcclusionMode => default(MaterialManager.DynamicOcclusion);

		public int _INTERNAL_pluginVersion => 0;

		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; }

		public string meshStats => null;

		public int meshVerticesCount => 0;

		public int meshTrianglesCount => 0;

		private Light lightSpotAttached => null;

		public event OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
		{
		}

		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		private void OnFadeOutStateChanged()
		{
		}

		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return 0f;
		}

		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return 0f;
		}

		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
		}

		public virtual void GenerateGeometry()
		{
		}

		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[IteratorStateMachine(typeof(_003CCoPlaytimeUpdate_003Ed__181))]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		private void OnDestroy()
		{
		}

		private void DestroyBeam()
		{
		}

		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		private void ClampProperties()
		{
		}

		private void ValidateProperties()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}
	}
}
