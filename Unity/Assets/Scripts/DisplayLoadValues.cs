using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class DisplayLoadValues : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadValues_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DisplayLoadValues _003C_003E4__this;

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
		public _003CLoadValues_003Ed__39(int _003C_003E1__state)
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
	private bool toggleTwoAxis;

	[SerializeField]
	private bool invertMouseX;

	[SerializeField]
	private bool invertMouseY;

	[SerializeField]
	private bool sprintToggle;

	[SerializeField]
	private bool aimToggle;

	[SerializeField]
	private bool leanToggle;

	[SerializeField]
	private bool crouchToggle;

	[SerializeField]
	private bool enableVoiceChat;

	[SerializeField]
	private bool voiceChatVolume;

	[SerializeField]
	private bool reverseSprintBind;

	[SerializeField]
	private bool inverseFireBinding;

	[SerializeField]
	private bool mouseSensitivity;

	[SerializeField]
	private bool mouseAimScopeSensitivity;

	[SerializeField]
	private bool mouseAimSensitivity;

	[SerializeField]
	private bool mouseXSensitivity;

	[SerializeField]
	private bool mouseYSensitivity;

	[SerializeField]
	private bool fovValue;

	[SerializeField]
	private bool brightness;

	[SerializeField]
	private bool damageIntensity;

	[SerializeField]
	private bool effectsVolume;

	[SerializeField]
	private bool ambientVolume;

	[SerializeField]
	private bool musicVolume;

	[SerializeField]
	private bool masterVolume;

	[SerializeField]
	private bool menuMusicVolume;

	[SerializeField]
	private bool targetFps;

	[SerializeField]
	private bool targetFpsToggle;

	[SerializeField]
	private bool useVsync;

	[SerializeField]
	private bool graphics;

	[SerializeField]
	private bool isFullscreen;

	[SerializeField]
	private bool minimalistUi;

	[SerializeField]
	private bool motionBlur;

	[FormerlySerializedAs("pushToTalk")]
	[SerializeField]
	private bool voiceChatMode;

	[SerializeField]
	private bool exclusiveFullscreen;

	[SerializeField]
	private bool enableFixedCrosshair;

	[SerializeField]
	private bool showSpeedometer;

	[SerializeField]
	private bool disableCrosshair;

	[SerializeField]
	private bool inGameMusic;

	[SerializeField]
	private bool reduceVFX;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadValues_003Ed__39))]
	private IEnumerator LoadValues()
	{
		return null;
	}
}
