using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
	{
		[CompilerGenerated]
		private sealed class _003CCoUpdateFadeOut_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BeamGeometry _003C_003E4__this;

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
			public _003CCoUpdateFadeOut_003Ed__30(int _003C_003E1__state)
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

		private VolumetricLightBeam m_Master;

		private Matrix4x4 m_ColorGradientMatrix;

		private MeshType m_CurrentMeshType;

		private Material m_CustomMaterial;

		private MaterialModifier.Callback m_MaterialModifierCallback;

		private Coroutine m_CoFadeOut;

		private Camera m_CurrentCameraRenderingSRP;

		public MeshRenderer meshRenderer { get; private set; }

		public MeshFilter meshFilter { get; private set; }

		public Mesh coneMesh { get; private set; }

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public bool _INTERNAL_IsFadeOutCoroutineRunning => false;

		public static bool isCustomRenderPipelineSupported => false;

		private bool shouldUseGPUInstancedMaterial => false;

		private bool isNoiseEnabled => false;

		private bool isDepthBlendEnabled => false;

		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CCoUpdateFadeOut_003Ed__30))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		private void ComputeFadeOutFactor()
		{
		}

		private void SetFadeOutFactorProp(float value)
		{
		}

		public void RestartFadeOutCoroutine()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize(VolumetricLightBeam master)
		{
		}

		public void RegenerateMesh()
		{
		}

		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		private bool ApplyMaterial()
		{
			return false;
		}

		public void SetMaterialProp(int nameID, float value)
		{
		}

		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		public void SetMaterialProp(int nameID, Color value)
		{
		}

		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		private void MaterialChangeStart()
		{
		}

		private void MaterialChangeStop()
		{
		}

		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		public void UpdateMaterialAndBounds()
		{
		}

		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		private void OnWillRenderObject()
		{
		}

		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}
	}
}
