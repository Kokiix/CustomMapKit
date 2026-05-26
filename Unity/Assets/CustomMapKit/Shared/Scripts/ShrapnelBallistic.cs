using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class ShrapnelBallistic : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAction_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShrapnelBallistic _003C_003E4__this;

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
		public _003CAction_003Ed__47(int _003C_003E1__state)
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

	[SerializeField]
	private string weaponName;

	[SerializeField]
	private float damage;

	public bool isOwner;

	private Vector3 impact;

	private CharacterController character;

	[SerializeField]
	private float ragdollEjectForce;

	[SerializeField]
	private LayerMask playerLayer;

	[SerializeField]
	private LayerMask bodyLayer;

	[SerializeField]
	private GameObject hitVfx;

	[SerializeField]
	private GameObject explosionVfx;

	[SerializeField]
	private AudioClip hitClip;

	[SerializeField]
	private AudioClip explosionClip;

	[SerializeField]
	private AudioClip swooshClip;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private Vector3 rotateAxis;

	[SerializeField]
	private GameObject explosionDecal;

	[SerializeField]
	private GameObject bloodSplatter;

	[SerializeField]
	private float timeBeforeExplosion;

	[SerializeField]
	private float explosionRadius;

	[SerializeField]
	private float lineDecreaseSpeed;

	[SerializeField]
	private float lineFadeSpeed;

	private float explosionTimer;

	[SerializeField]
	private float rebondForce;

	private bool isGrounded;

	[Header("Screenshake values")]
	[SerializeField]
	private float duration;

	[SerializeField]
	private float minStrength;

	[SerializeField]
	private float maxStrength;

	[SerializeField]
	private int vibrato;

	[SerializeField]
	private float randomness;

	[SerializeField]
	private Ease shakeEase;

	[SerializeField]
	private float maxDistance;

	private bool touched;

	private bool touched2;

	private GameObject _gun;

	private PlayerHealth[] ph2;

	private float _passedTime;

	private GameObject _rootObject;

	private AudioSource audio;

	[HideInInspector]
	public Weapon weapon;

	private Vector3 currentPosition;

	private Vector3 lastPosition;

	private Vector3 velocity;

	[SerializeField]
	private bool fragGrenade;

	[SerializeField]
	private float numberOfRays;

	private float safeTimer;

	private bool makeBlood;

	private bool hit;

	private bool headshot;

	private bool sendKillLog;

	private bool suicide;

	private bool increaseKillAmount;

	[SerializeField]
	private GameObject hitMarker;

	[SerializeField]
	private AudioClip hitSfx;

	private GameObject marker;

	private int maxHits;

	private int hits;

	private void Awake()
	{
	}

	public void Initialize(GameObject rootObject, GameObject gun, float passedTime)
	{
	}

	[IteratorStateMachine(typeof(_003CAction_003Ed__47))]
	private IEnumerator Action()
	{
		return null;
	}

	private void Explode()
	{
	}

	private void SendKillLog(PlayerHealth enemyHealth)
	{
	}

	private void IncreaseSuicidesAmount()
	{
	}

	public void KillShockWave()
	{
	}

	private void HitMarker(bool head)
	{
	}

	private void RenderObject(Vector3 direction, float maxDistance)
	{
	}

	private void OnCollisionEnter(Collision col)
	{
	}
}
