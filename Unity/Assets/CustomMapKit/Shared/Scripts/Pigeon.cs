using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Object;
using UnityEngine;

public class Pigeon : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CUpdatePlayer_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Pigeon _003C_003E4__this;

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
		public _003CUpdatePlayer_003Ed__22(int _003C_003E1__state)
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
	private GameObject dieVfx;

	[SerializeField]
	private float distanceFromPlayer;

	[SerializeField]
	private float maxDistance;

	[SerializeField]
	private float flyTime;

	[SerializeField]
	private float flySpeed;

	[SerializeField]
	private float verticalMovement;

	[SerializeField]
	private float flyTimer;

	[SerializeField]
	private bool randomRot;

	[SerializeField]
	private bool animate;

	[SerializeField]
	private Animator anim;

	private GameManager gameManager;

	private float walkTimer;

	private bool fly;

	private bool walk;

	private Vector3 initPos;

	private Vector3 flyDir;

	private Vector3 rotation;

	private GameObject player;

	[SerializeField]
	private float jumpTimer;

	private float value;

	[SerializeField]
	private AudioClip flyClip;

	private bool NetworkInitializeEarly_Pigeon_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Pigeon_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdatePlayer_003Ed__22))]
	private IEnumerator UpdatePlayer()
	{
		return null;
	}

	public void Die()
	{
	}

	private void Update()
	{
	}

	public virtual void NetworkInitialize___Early()
	{
	}

	public virtual void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
