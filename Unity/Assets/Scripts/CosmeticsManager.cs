using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using UnityEngine;

public class CosmeticsManager : MonoBehaviour, ISaveable
{
	[Serializable]
	private struct SaveData
	{
		public int hatIndexSaved;

		public int suitIndexSaved;

		public int cigIndexSaved;
	}

	[CompilerGenerated]
	private sealed class _003CDressAboubi_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CosmeticsManager _003C_003E4__this;

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
		public _003CDressAboubi_003Ed__19(int _003C_003E1__state)
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

	public static CosmeticsManager Instance;

	[SerializeField]
	private Transform suitsParent;

	[SerializeField]
	private Transform hatsParent;

	[SerializeField]
	private Transform cigsParent;

	public Material[] mats;

	public Material[] fparmsMats;

	public GameObject[] hats;

	public GameObject[] cigs;

	public int suitIndex;

	public int hatIndex;

	public int cigIndex;

	private CosmeticInstance[] suitsChildren;

	private CosmeticInstance[] hatsChildren;

	private CosmeticInstance[] cigsChildren;

	private bool inMenu;

	private bool activate;

	public GameObject currenthat;

	public int currentsuitIndex;

	public int currentcigIndex;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void UpdateUnlockable()
	{
	}

	[IteratorStateMachine(typeof(_003CDressAboubi_003Ed__19))]
	private IEnumerator DressAboubi()
	{
		return null;
	}

	[ContextMenu("Load Dress")]
	private void LoadDress()
	{
	}

	private void Update()
	{
	}

	public void ChangeDress(CosmeticInstance cosmeticInstance)
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
