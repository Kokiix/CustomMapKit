using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class SetMenuMusicVolume : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadTrack_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SetMenuMusicVolume _003C_003E4__this;

		public int trackIndex;

		public float position;

		public bool paused;

		private MusicTrack _003CmusicTrack_003E5__2;

		private UnityWebRequest _003CwebRequest_003E5__3;

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
		public _003CLoadTrack_003Ed__43(int _003C_003E1__state)
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

	private string MusicFolderPath;

	public static readonly Dictionary<string, AudioType> ExtensionToAudioType;

	[HideInInspector]
	public List<MusicTrack> MusicTracks;

	private readonly Dictionary<int, int> TrackNumberToIndex;

	private bool loadingMusic;

	private bool errorLoadingMusic;

	[SerializeField]
	private TextMeshProUGUI trackText;

	[SerializeField]
	private TextMeshProUGUI trackTextInPlayer;

	[SerializeField]
	private TextMeshProUGUI playbackTimeText;

	[SerializeField]
	private GameObject pauseButton;

	[SerializeField]
	private GameObject playButton;

	[SerializeField]
	private AudioPositionSlider audioPositionSlider;

	[Space]
	[SerializeField]
	private Transform musicPlayerTransform;

	[SerializeField]
	private Transform optionsPosition;

	[SerializeField]
	private Transform playMenuPosition;

	[SerializeField]
	private GameObject optionsMenu;

	[SerializeField]
	private GameObject mapsPanel;

	[Space]
	[HideInInspector]
	public AudioSource audio;

	private Settings settings;

	private SoundManager soundManager;

	private AudioListener customListener;

	public int currentTrackIndex;

	private bool loadingMainMenu;

	public static SetMenuMusicVolume Instance { get; private set; }

	private void Awake()
	{
	}

	private void GetAllMusic()
	{
	}

	private void Start()
	{
	}

	private void StartPlayingMusic()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void Update()
	{
	}

	private void UpdateMusic()
	{
	}

	public void NextTrack()
	{
	}

	public void PreviousTrack()
	{
	}

	public void Pause()
	{
	}

	public void Play()
	{
	}

	public void SetAudioPosition(float value)
	{
	}

	public void Shuffle()
	{
	}

	[IteratorStateMachine(typeof(_003CLoadTrack_003Ed__43))]
	private IEnumerator LoadTrack(int trackIndex, float position, bool paused)
	{
		return null;
	}

	public void OpenMusicFolder()
	{
	}
}
