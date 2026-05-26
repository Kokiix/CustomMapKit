using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Vault : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLerpVault_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Vault _003C_003E4__this;

		public Vector3 targetPosition;

		public float duration;

		private float _003Ctime_003E5__2;

		private Vector3 _003CstartPosition_003E5__3;

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
		public _003CLerpVault_003Ed__11(int _003C_003E1__state)
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
	private float lerpTime;

	[SerializeField]
	private float vaultHeight;

	[SerializeField]
	private LayerMask vaultLayer;

	public bool vaulting;

	public Transform cam;

	private float playerHeight;

	private float playerRadius;

	private CharacterController controller;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void Vaulting()
	{
	}

	[IteratorStateMachine(typeof(_003CLerpVault_003Ed__11))]
	private IEnumerator LerpVault(Vector3 targetPosition, float duration)
	{
		return null;
	}

	private Vector3 Caca(Vector3 vector3, int decimalPlaces)
	{
		return default(Vector3);
	}
}
