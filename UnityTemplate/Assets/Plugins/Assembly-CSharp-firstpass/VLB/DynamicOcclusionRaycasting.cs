using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		public class HitResult
		{
			public Vector3 point;

			public Vector3 normal;

			public float distance;

			private Collider2D collider2D;

			private Collider collider3D;

			public bool hasCollider => false;

			public string name => null;

			public Bounds bounds => default(Bounds);

			public HitResult(RaycastHit hit3D)
			{
			}

			public HitResult(RaycastHit2D hit2D)
			{
			}

			public HitResult()
			{
			}
		}

		private enum Direction
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3,
			Max2D = 1,
			Max3D = 3
		}

		public Dimensions dimensions;

		public LayerMask layerMask;

		public bool considerTriggers;

		public float minOccluderArea;

		public float minSurfaceRatio;

		public float maxSurfaceDot;

		public PlaneAlignment planeAlignment;

		public float planeOffset;

		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		private float m_RangeMultiplier;

		private uint m_PrevNonSubHitDirectionId;

		[Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public HitResult currentHit { get; private set; }

		public Plane planeEquationWS { get; private set; }

		private QueryTriggerInteraction queryTriggerInteraction => default(QueryTriggerInteraction);

		private float raycastMaxDistance => 0f;

		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return false;
		}

		protected override string GetShaderKeyword()
		{
			return null;
		}

		protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.DynamicOcclusion);
		}

		protected override void OnValidateProperties()
		{
		}

		protected override void OnEnablePostValidate()
		{
		}

		protected override void OnDisable()
		{
		}

		private void Start()
		{
		}

		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		private uint GetDirectionCount()
		{
			return 0u;
		}

		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		private bool IsHitValid(HitResult hit, Vector3 forwardVec)
		{
			return false;
		}

		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return false;
		}

		private void SetHit(HitResult hit)
		{
		}

		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		private void SetClippingPlane(Plane planeWS)
		{
		}

		private void SetClippingPlaneOff()
		{
		}

		private void SetPlaneWS(Plane planeWS)
		{
		}
	}
}
