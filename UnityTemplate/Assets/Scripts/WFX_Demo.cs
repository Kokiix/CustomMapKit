using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WFX_Demo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRandomSpawnsCoroutine_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WFX_Demo _003C_003E4__this;

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
		public _003CRandomSpawnsCoroutine_003Ed__30(int _003C_003E1__state)
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

	public float cameraSpeed;

	public bool orderedSpawns;

	public float step;

	public float range;

	private float order;

	public GameObject walls;

	public GameObject bulletholes;

	public GameObject[] ParticleExamples;

	private int exampleIndex;

	private string randomSpawnsDelay;

	private bool randomSpawns;

	private bool slowMo;

	private bool rotateCam;

	public Material wood;

	public Material concrete;

	public Material metal;

	public Material checker;

	public Material woodWall;

	public Material concreteWall;

	public Material metalWall;

	public Material checkerWall;

	private string groundTextureStr;

	private List<string> groundTextures;

	public GameObject m4;

	public GameObject m4fps;

	private bool rotate_m4;

	private void OnMouseDown()
	{
	}

	public GameObject spawnParticle()
	{
		return null;
	}

	private void SetActiveCrossVersions(GameObject obj, bool active)
	{
	}

	private void OnGUI()
	{
	}

	[IteratorStateMachine(typeof(_003CRandomSpawnsCoroutine_003Ed__30))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	private void Update()
	{
	}

	private void prevTexture()
	{
	}

	private void nextTexture()
	{
	}

	private void selectMaterial()
	{
	}

	private void prevParticle()
	{
	}

	private void nextParticle()
	{
	}

	private void showHideStuff()
	{
	}
}
