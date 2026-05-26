using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgressManager : MonoBehaviour, ISaveable
{
	[Serializable]
	private struct SaveData
	{
		public float xp;

		public bool[] unlocked;
	}

	[CompilerGenerated]
	private sealed class _003CUIBootupCoroutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressManager _003C_003E4__this;

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
		public _003CUIBootupCoroutine_003Ed__19(int _003C_003E1__state)
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
	private sealed class _003CBootupPopups_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressManager _003C_003E4__this;

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
		public _003CBootupPopups_003Ed__20(int _003C_003E1__state)
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
	private sealed class _003CPopups_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<ProgressInstance> instancePopups;

		public ProgressManager _003C_003E4__this;

		private int _003Ci_003E5__2;

		private int _003Cj_003E5__3;

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
		public _003CPopups_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CGetPopup_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProgressInstance ins;

		public ProgressManager _003C_003E4__this;

		public int index;

		public int mapIndex;

		private GameObject _003CtempPopup_003E5__2;

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
		public _003CGetPopup_003Ed__25(int _003C_003E1__state)
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

	private float xpTimer;

	public float xp;

	[SerializeField]
	private GameObject xpPopupPrefab;

	public ProgressInstance[] instances;

	public bool[] unlocked;

	private PauseManager pauseManager;

	[Space]
	[SerializeField]
	private Transform parentObject;

	[SerializeField]
	private Transform contentArea;

	[SerializeField]
	private Transform firstPosition;

	[SerializeField]
	private Transform lastPosition;

	[SerializeField]
	private Image xpBarProgressImage;

	[SerializeField]
	private GameObject xpContentPrefab;

	[SerializeField]
	private GameObject verticalGroupPrefab;

	[SerializeField]
	private TextMeshProUGUI xpText;

	[HideInInspector]
	public List<XpContentInstance> xpContentInstances;

	public static ProgressManager Instance;

	public bool skipAll;

	private bool lastDLCState;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CUIBootupCoroutine_003Ed__19))]
	private IEnumerator UIBootupCoroutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBootupPopups_003Ed__20))]
	private IEnumerator BootupPopups()
	{
		return null;
	}

	private void Update()
	{
	}

	[ContextMenu("ActivatePopups")]
	public void RunAllPopups()
	{
	}

	[IteratorStateMachine(typeof(_003CPopups_003Ed__24))]
	private IEnumerator Popups(List<ProgressInstance> instancePopups)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetPopup_003Ed__25))]
	private IEnumerator GetPopup(ProgressInstance ins, int index, int mapIndex)
	{
		return null;
	}

	private void UIBootup()
	{
	}

	private void HandleUIUpdate()
	{
	}

	public object SaveState()
	{
		return null;
	}

	public void LoadState(JContainer state)
	{
	}
}
