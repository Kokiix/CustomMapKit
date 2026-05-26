using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using HeathenEngineering.SteamworksIntegration.UI;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
	public delegate void StartRoundAction();

	public delegate void BeforeSpawnAction();

	[CompilerGenerated]
	private sealed class _003CStartRoundDelayCoroutine_003Ed__119 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PauseManager _003C_003E4__this;

		public float timeTillMovementStarts;

		private int _003Ctake_003E5__2;

		private int _003CvisualTake_003E5__3;

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
		public _003CStartRoundDelayCoroutine_003Ed__119(int _003C_003E1__state)
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
	private sealed class _003CChangeBoolStartRound_003Ed__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PauseManager _003C_003E4__this;

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
		public _003CChangeBoolStartRound_003Ed__120(int _003C_003E1__state)
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
	private sealed class _003CShowEnemyHealthCoroutine_003Ed__122 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHealth ph;

		public PauseManager _003C_003E4__this;

		public float h;

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
		public _003CShowEnemyHealthCoroutine_003Ed__122(int _003C_003E1__state)
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
	private sealed class _003CSetActiveAfterSecondCoroutine_003Ed__125 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PauseManager _003C_003E4__this;

		public GameObject obj;

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
		public _003CSetActiveAfterSecondCoroutine_003Ed__125(int _003C_003E1__state)
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
	private sealed class _003CSetActiveOppositeAfterSecondCoroutine_003Ed__128 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject obj;

		public PauseManager _003C_003E4__this;

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
		public _003CSetActiveOppositeAfterSecondCoroutine_003Ed__128(int _003C_003E1__state)
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

	public bool pause;

	public bool gamepad;

	public bool chatting;

	public bool startRound;

	public bool rebinding;

	public bool serverStarted;

	public bool inMainMenu;

	public bool inVictoryMenu;

	public bool otherPauseBools;

	public bool gameStarted;

	[SerializeField]
	private bool canChat;

	[Space]
	[SerializeField]
	private FriendList friendListScript;

	[Space]
	[HideInInspector]
	public bool steamPlaying;

	private GameObject ChatBox;

	public GameObject sequenceDisplayGameObject;

	public static PauseManager Instance;

	[SerializeField]
	private InputAction menu;

	[SerializeField]
	private InputAction gamepadAny;

	[SerializeField]
	private InputAction keyboardAny;

	private PlayerControls _playerInput;

	[SerializeField]
	private GameObject pauseMenu;

	public GameObject tabScreen;

	[SerializeField]
	private GameObject firstInterface;

	[SerializeField]
	private GameObject secondInterface;

	[SerializeField]
	private GameObject mainMenu;

	[SerializeField]
	private GameObject resumeButton3D;

	[SerializeField]
	private GameObject optionsMenu;

	public GameObject minimalistUi;

	public TextMeshProUGUI minimalistHealthText;

	public TextMeshProUGUI minimalFpsText;

	public TextMeshProUGUI minimalPingText;

	[SerializeField]
	private MoveUIObject firstInterface3D;

	[SerializeField]
	private GameObject serverDownPopup;

	[SerializeField]
	private GameObject onePlayerLeftPopup;

	[SerializeField]
	private GameObject infoPopup;

	private List<string> TextToShow;

	public TextMeshProUGUI rightGunAmmo;

	public TextMeshProUGUI leftGunAmmo;

	public TextMeshProUGUI rightGunAmmoReload;

	public TextMeshProUGUI leftGunAmmoReload;

	public TextMeshProUGUI grabPopup;

	public TextMeshProUGUI interactPopup;

	[SerializeField]
	private Transform posRightDown;

	[SerializeField]
	private Transform posRightUp;

	[SerializeField]
	private Transform posLeftDown;

	[SerializeField]
	private Transform posLeftUp;

	public AudioClip matchChatClip;

	public AudioClip genericMenuClip;

	public AudioClip pressMenuClip;

	public AudioClip releaseMenuClip;

	public AudioClip closeMenuClip;

	public AudioClip[] deathAudioClip;

	public bool nonSteamworksTransport;

	[Space]
	public string selfNameLogColor;

	public string enemyNameLogColor;

	public static bool BetweenRounds;

	[SerializeField]
	private TextMeshProUGUI interactPromptText;

	[SerializeField]
	private TextMeshProUGUI interactPromptTextGamepad;

	public string InteractPromptLetter;

	private float serverTimer;

	[Space]
	[SerializeField]
	private TextMeshProUGUI startRoundText;

	[SerializeField]
	private TextMeshProUGUI startRoundTextTitle;

	[SerializeField]
	private TextMeshProUGUI enemyHealthText;

	[SerializeField]
	private TextMeshProUGUI deadText;

	[SerializeField]
	private AudioClip startMatchClip;

	[SerializeField]
	private GameObject crosshair;

	[Space]
	[Header("Start Round Screens")]
	[SerializeField]
	private TextMeshProUGUI setText;

	[SerializeField]
	private TextMeshProUGUI mapText;

	[Space]
	[SerializeField]
	private Transform container;

	[SerializeField]
	private Transform startRoundBackDrop;

	[SerializeField]
	private Transform startRoundImageOne;

	[SerializeField]
	private Transform startRoundImageTwo;

	[SerializeField]
	private Transform startRoundImageThree;

	[Space]
	[SerializeField]
	private Transform startRoundImageOneRestPos;

	[SerializeField]
	private Transform startRoundImageOneActivePos;

	[Space]
	[SerializeField]
	private Transform startRoundImageTwoRestPos;

	[SerializeField]
	private Transform startRoundImageTwoActivePos;

	[Space]
	[SerializeField]
	private Transform startRoundImageThreeRestPos;

	[SerializeField]
	private Transform startRoundImageThreeActivePos;

	public bool onStartRoundScreen;

	public bool onEndRoundScreen;

	private Coroutine RoundDelayCoroutine;

	private bool canShow;

	[SerializeField]
	private float time;

	[SerializeField]
	private float time2;

	[Space]
	[SerializeField]
	private GameObject voiceChatText;

	public bool isRecording;

	[Space]
	[SerializeField]
	private Transform hiddenInvitePos;

	[SerializeField]
	private Transform shownInvitePos;

	public static event StartRoundAction OnRoundStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event BeforeSpawnAction OnBeforeSpawn
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void ShowInfoPopup(string text)
	{
	}

	public void ShowNextInfoPopup()
	{
	}

	public void InvokeRoundStarted()
	{
	}

	public void InvokeBeforeSpawn()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void WriteLog(string text)
	{
	}

	public void WriteOfflineLog(string text)
	{
	}

	public void CopyLobbyID()
	{
	}

	private void Update()
	{
	}

	private void LateUpdate()
	{
	}

	private void HandleInputDetection()
	{
	}

	private void ChangeControlSchemeGamepad(InputAction.CallbackContext ctx)
	{
	}

	private void ChangeControlSchemeKeyboard(InputAction.CallbackContext ctx)
	{
	}

	public void ChangeSelectedItem(GameObject obj)
	{
	}

	private void Menu(InputAction.CallbackContext ctx)
	{
	}

	public void StartGameSteam()
	{
	}

	public void SetActiveOpposite(GameObject obj)
	{
	}

	public void SetActiveOppositeScale(Transform obj)
	{
	}

	public void QuitGame()
	{
	}

	public void MoveAmmoDisplay(bool up, bool right)
	{
	}

	public void ChangeAmmoText(string text, string reloadText, bool right)
	{
	}

	public void PlayMenuClip(AudioClip clip)
	{
	}

	private void HandleServerState()
	{
	}

	private void HandleServerStateWhenOnePlayerIsLeft()
	{
	}

	private void StoppingMapCoroutine()
	{
	}

	public void StartRoundDelay(float timeTillMovementStarts)
	{
	}

	[IteratorStateMachine(typeof(_003CStartRoundDelayCoroutine_003Ed__119))]
	private IEnumerator StartRoundDelayCoroutine(float timeTillMovementStarts)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CChangeBoolStartRound_003Ed__120))]
	private IEnumerator ChangeBoolStartRound()
	{
		return null;
	}

	public void ShowEnemyHealth(float h, PlayerHealth ph)
	{
	}

	[IteratorStateMachine(typeof(_003CShowEnemyHealthCoroutine_003Ed__122))]
	private IEnumerator ShowEnemyHealthCoroutine(float h, PlayerHealth ph)
	{
		return null;
	}

	public void SetActiveAfterSecond(GameObject obj)
	{
	}

	[IteratorStateMachine(typeof(_003CSetActiveAfterSecondCoroutine_003Ed__125))]
	private IEnumerator SetActiveAfterSecondCoroutine(GameObject obj)
	{
		return null;
	}

	public void SetActiveOppositeAfterSecond(GameObject obj)
	{
	}

	[IteratorStateMachine(typeof(_003CSetActiveOppositeAfterSecondCoroutine_003Ed__128))]
	private IEnumerator SetActiveOppositeAfterSecondCoroutine(GameObject obj)
	{
		return null;
	}

	public void DisplayServerDownPopup()
	{
	}

	private void VoiceChat()
	{
	}

	public void ShowInviteViewport(bool show, Transform viewport)
	{
	}

	public void PlaySoundWithGamepad()
	{
	}
}
