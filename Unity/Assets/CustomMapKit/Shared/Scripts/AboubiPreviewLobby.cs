using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AboubiPreviewLobby : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRunIntoLobby_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AboubiPreviewLobby _003C_003E4__this;

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
		public _003CRunIntoLobby_003Ed__15(int _003C_003E1__state)
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
	private float rotateSpeed;

	[SerializeField]
	public GameObject previewObject;

	[SerializeField]
	private GameObject[] meshesToChange;

	[SerializeField]
	private Transform hatToWearPosition;

	private GameObject currentHat;

	private GameObject currentCig;

	private SteamLobby steamLobbyScript;

	public GameObject parentObj;

	private Vector3 initialPosition;

	private Vector3 initialDirection;

	private bool isRunning;

	private void Start()
	{
	}

	public void ChangeDress(GameObject hat, Material mat, GameObject cig)
	{
	}

	private void SetGameLayerRecursive(GameObject _go, int _layer)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CRunIntoLobby_003Ed__15))]
	public IEnumerator RunIntoLobby()
	{
		return null;
	}
}
