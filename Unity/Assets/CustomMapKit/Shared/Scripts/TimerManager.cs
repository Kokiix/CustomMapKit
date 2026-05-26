using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;

public class TimerManager : MonoBehaviour, ISaveable
{
	[Serializable]
	private struct SaveData
	{
		public Dictionary<string, float> courseTimes;
	}

	[CompilerGenerated]
	private sealed class _003CBlinkTimer_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimerManager _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CBlinkTimer_003Ed__32(int _003C_003E1__state)
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
	private sealed class _003CBeepTimer_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimerManager _003C_003E4__this;

		public int nb;

		private int _003Ci_003E5__2;

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
		public _003CBeepTimer_003Ed__33(int _003C_003E1__state)
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

	public new bool enabled;

	public Material invisibleMat;

	private TextMeshProUGUI timeUI;

	private TextMeshProUGUI timeUIPrevAndPB;

	private TextMeshProUGUI courseName;

	private AudioSource beep;

	private AudioSource checkpointSound;

	private AudioSource pbSound;

	private Canvas canvas;

	private Array triggers;

	[HideInInspector]
	public FirstPersonController player;

	[HideInInspector]
	public Transform currentStartPoint;

	private float time;

	private float previousTime;

	private string previousCourse;

	private string mapAndCourse;

	public bool timerStarted;

	private Dictionary<string, float> courseTimes;

	private bool canFinish;

	private int prevCheckpoint;

	private void Start()
	{
	}

	public void Enable(bool f)
	{
	}

	private void CheckEnabled()
	{
	}

	private void Update()
	{
	}

	public void TStart(string course)
	{
	}

	public void TCheckpoint(object[] info)
	{
	}

	public void TEnd()
	{
	}

	private void AnnounceFinish(string a)
	{
	}

	private void UpdatePrevAndPB()
	{
	}

	public void LogTime()
	{
	}

	public void TShowUI(string course)
	{
	}

	public void THideUI(string course)
	{
	}

	[IteratorStateMachine(typeof(_003CBlinkTimer_003Ed__32))]
	private IEnumerator BlinkTimer()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBeepTimer_003Ed__33))]
	private IEnumerator BeepTimer(int nb)
	{
		return null;
	}

	private void HideCanvas()
	{
	}

	public static string FormatTime(float totalSeconds)
	{
		return null;
	}

	public object SaveState()
	{
		return null;
	}

	public void LoadState(JContainer state)
	{
	}
}
