using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;

public class ComputeryAnnouncements : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CFetchTextFromGitHub_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ComputeryAnnouncements _003C_003E4__this;

		private UnityWebRequest _003CwebRequest_003E5__2;

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
		public _003CFetchTextFromGitHub_003Ed__4(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Configuration")]
	[Tooltip("The raw URL of the text file on GitHub")]
	public string targetUrl;

	[Header("UI References")]
	[Tooltip("The TextMeshPro UI component to display the text")]
	public TextMeshProUGUI displayTextComponent;

	[Header("Canvas Reference")]
	[Tooltip("Ttrsvegrhbdrtnjyhjnyt)")]
	public Canvas parentCanvas;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CFetchTextFromGitHub_003Ed__4))]
	private IEnumerator FetchTextFromGitHub()
	{
		return null;
	}

	public void OnPointerClick(PointerEventData pointerEventData)
	{
	}
}
