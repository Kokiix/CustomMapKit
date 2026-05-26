using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Component.Utility;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HUD _003C_003E4__this;

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
		public _003CStart_003Ed__9(int _003C_003E1__state)
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

	private PauseManager pauseManager;

	private TMP_Text text;

	[SerializeField]
	private bool ammoRight;

	[SerializeField]
	private bool ammoReloadRight;

	[SerializeField]
	private bool ammoLeft;

	[SerializeField]
	private bool ammoReloadLeft;

	[SerializeField]
	private bool pingDisplay;

	[SerializeField]
	private bool fpsDisplay;

	private PingDisplay PingDisplay;

	private float count;

	public bool display;

	[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
	private IEnumerator Start()
	{
		return null;
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
