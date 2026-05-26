using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HeathenEngineering.SteamworksIntegration;
using HeathenEngineering.SteamworksIntegration.UI;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HeathenEngineering.DEMO
{
	[RequireComponent(typeof(LobbyManager))]
	public class LobbyChatUILogic : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CSelectInputField_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LobbyChatUILogic _003C_003E4__this;

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
			public _003CSelectInputField_003Ed__25(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CForceScrollDown_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LobbyChatUILogic _003C_003E4__this;

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
			public _003CForceScrollDown_003Ed__26(int _003C_003E1__state)
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
		private int maxMessages;

		[SerializeField]
		private GameObject chatPanel;

		[SerializeField]
		private TMP_InputField inputField;

		[SerializeField]
		private ScrollRect scrollView;

		[SerializeField]
		private Transform messageRoot;

		[SerializeField]
		private GameObject myChatTemplate;

		[SerializeField]
		private GameObject theirChatTemplate;

		private LobbyManager lobbyManager;

		private readonly List<IChatMessage> chatMessages;

		private bool forceShowMessages;

		private Queue<float> recentMessageTimes;

		private int spamThreshold;

		private float spamWindow;

		private bool isLockedOut;

		private float lockoutEndTime;

		private float lockoutDuration;

		private string spamWarningMessage;

		public bool inQuickMatch;

		public QuickMatchLobbyControl QuickMatchScript;

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleChatMessage(LobbyChatMsg message)
		{
		}

		private void OnSendChatMessage()
		{
		}

		public void FakeChatMessage(string msg)
		{
		}

		public void SendChatMessage(string msg)
		{
		}

		[IteratorStateMachine(typeof(_003CSelectInputField_003Ed__25))]
		private IEnumerator SelectInputField()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CForceScrollDown_003Ed__26))]
		private IEnumerator ForceScrollDown()
		{
			return null;
		}

		public void EnableForceShowMessages()
		{
		}

		public void DisableForceShowMessages()
		{
		}
	}
}
