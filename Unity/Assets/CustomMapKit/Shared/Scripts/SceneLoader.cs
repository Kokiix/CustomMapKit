using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCanStartAgain_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SceneLoader _003C_003E4__this;

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
		public _003CCanStartAgain_003Ed__15(int _003C_003E1__state)
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

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003CLoadScene_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string sceneName;

		public SceneLoader _003C_003E4__this;

		private AsyncOperation _003Cscene_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	public string[] SCENE_NAME;

	public int sceneIndex;

	private float respawnTimer;

	public string currentScene;

	private float timer;

	public bool canSwitch;

	public PlayerTracker manager;

	[SerializeField]
	public GameObject _loaderCanvas;

	[SerializeField]
	public TextMeshProUGUI sceneText;

	public static SceneLoader Instance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void LoadScene()
	{
	}

	public void LoadSceneInternal()
	{
	}

	[IteratorStateMachine(typeof(_003CCanStartAgain_003Ed__15))]
	private IEnumerator CanStartAgain()
	{
		return null;
	}

	public void LoadSceneSteam()
	{
	}

	public void LoadSceneFromMenu()
	{
	}

	public void ReturnToMenu()
	{
	}

	public void Shuffle(string[] texts)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadScene_003Ed__20))]
	public void LoadScene(string sceneName)
	{
	}
}
