using System;
using System.Collections.Generic;
using HeathenEngineering.SteamworksIntegration;
using Newtonsoft.Json.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour, ISaveable
{
	[Serializable]
	public struct SaveData
	{
		public float tauntsAmount;

		public float killsAmount;

		public float deathsAmount;

		public float suicidesAmount;

		public float bodyshotsAmount;

		public float headshotsAmount;

		public float roundsWon;

		public float roundsLost;

		public float roundsPlayed;

		public float gamesWon;

		public float gamesLost;

		public float gamesPlayed;

		public float timeSpentInGame;

		public float timeSpentInAir;

		public float timeSpentOnGround;

		public float mapsUnlocked;

		public float rocketJumps;

		public float windowsBroken;

		public float ragdollsThrownAway;

		public float taserShots;

		public float propKills;

		public float potsBroken;

		public float noscope;

		public List<string> recentlyPlayedWithPlayers;
	}

	public static Settings Instance;

	public FirstPersonController localPlayer;

	private MapsManager mapsManager;

	public List<string> recentlyPlayedWithPlayers;

	[Header("Player settings")]
	public bool toggleTwoAxis;

	public bool invertMouseX;

	public bool invertMouseY;

	public bool sprintToggle;

	public bool aimToggle;

	public bool leanToggle;

	public bool crouchToggle;

	public bool reverseSprintBind;

	public bool inverseFireBinding;

	public float mouseSensitivity;

	public float mouseAimScopeSensitivity;

	public float mouseAimSensitivity;

	public float horizontalSensitivity;

	public float verticalSensitivity;

	public float normalFovValue;

	public float brightness;

	public float damageIntensity;

	public bool disableCrosshair;

	public bool enableFixedCrosshair;

	public bool showSpeedometer;

	[Header("Audio settings")]
	public float voiceChatVolume;

	public bool enableVoiceChat;

	public VoiceChatMode voiceChatMode;

	public bool inGameMusic;

	[Header("Application settings")]
	public int useVsync;

	public bool isFullscreen;

	public bool exclusiveFullscreen;

	public bool minimalistUi;

	public bool motionBlur;

	public int targetFps;

	public bool targetFpsToggle;

	public bool reduceVFX;

	[Space]
	[SerializeField]
	private LeaderboardManager leaderboardManager;

	[Space]
	[SerializeField]
	private TMP_Dropdown qualityDropdown;

	public int resolution;

	public int qualitySetting;

	[Space]
	[Header("Stats")]
	public float tauntsAmount;

	public float killsAmount;

	public float deathsAmount;

	public float suicidesAmount;

	public float bodyshotsAmount;

	public float headshotsAmount;

	public float roundsWon;

	public float roundsLost;

	public float roundsPlayed;

	public float gamesWon;

	public float gamesLost;

	public float gamesPlayed;

	public float timeSpentInGame;

	public float timeSpentInAir;

	public float timeSpentOnGround;

	public float mapsUnlocked;

	[Header("Challenges Stats")]
	public float rocketJumps;

	public float windowsBroken;

	public float ragdollsThrownAway;

	public float taserShots;

	public float propKills;

	public float potsBroken;

	public float noscope;

	[Header("Texts")]
	[SerializeField]
	private TextMeshProUGUI tauntsAmountText;

	[SerializeField]
	private TextMeshProUGUI killsAmountText;

	[SerializeField]
	private TextMeshProUGUI deathsAmountText;

	[SerializeField]
	private TextMeshProUGUI suicidesAmountText;

	[SerializeField]
	private TextMeshProUGUI bodyshotsAmountText;

	[SerializeField]
	private TextMeshProUGUI headshotsAmountText;

	[SerializeField]
	private TextMeshProUGUI timeSpentInGameText;

	[SerializeField]
	private TextMeshProUGUI timeSpentInAirText;

	[SerializeField]
	private TextMeshProUGUI timeSpentOnGroundText;

	[SerializeField]
	private TextMeshProUGUI roundsWonText;

	[SerializeField]
	private TextMeshProUGUI roundsLostText;

	[SerializeField]
	private TextMeshProUGUI roundsPlayedText;

	[SerializeField]
	private TextMeshProUGUI gamesWonText;

	[SerializeField]
	private TextMeshProUGUI gamesLostText;

	[SerializeField]
	private TextMeshProUGUI gamesPlayedText;

	[SerializeField]
	private TextMeshProUGUI mapsUnlockedText;

	[Header("Challenges Hats")]
	public CosmeticInstance rocketJumpsHat;

	public CosmeticInstance windowsBrokenHat;

	public CosmeticInstance headshotHat;

	public CosmeticInstance ragdollsThrownAwayHat;

	public CosmeticInstance taserShotsHat;

	public CosmeticInstance noscopeHat;

	public CosmeticInstance propKillsHat;

	public CosmeticInstance potsBrokenHat;

	public CosmeticInstance fiveGamesHat;

	public CosmeticInstance killsHat;

	public AchievementObject rocketJumpsHatAch;

	public AchievementObject windowsBrokenHatAch;

	public AchievementObject headshotHatAch;

	public AchievementObject ragdollsThrownAwayHatAch;

	public AchievementObject taserShotsHatAch;

	public AchievementObject noscopeHatAch;

	public AchievementObject propKillsHatAch;

	public AchievementObject potsBrokenHatAch;

	public AchievementObject fiveGamesHatAch;

	public AchievementObject killsHatAch;

	private void Awake()
	{
	}

	public void AddPlayerToHistory(ClientInstance player)
	{
	}

	public void CopyMatchHistory()
	{
	}

	private void Start()
	{
	}

	private void FirstTimeSetup()
	{
	}

	private void Update()
	{
	}

	public void UpdateElo()
	{
	}

	public void ChangeVoiceChatVolume(Slider _slider)
	{
	}

	public void ChangeMouseSensitivity(Slider _slider)
	{
	}

	public void ChangeAimScopeMouseSensitivity(Slider _slider)
	{
	}

	public void ChangeAimMouseSensitivity(Slider _slider)
	{
	}

	public void ChangeMouseXSensitivity(Slider _slider)
	{
	}

	public void ChangeMouseYSensitivity(Slider _slider)
	{
	}

	public void ChangeFov(Slider _slider)
	{
	}

	public void ChangeBrightness(Slider _slider)
	{
	}

	public void ChangeDamageIntensity(Slider _slider)
	{
	}

	public void ToggleTwoAxisMouse(Toggle _toggle)
	{
	}

	public void ToggleVerticalInvert(Toggle _toggle)
	{
	}

	public void ToggleHorizontalInvert(Toggle _toggle)
	{
	}

	public void ToggleSprint(Toggle _toggle)
	{
	}

	public void ToggleAim(Toggle _toggle)
	{
	}

	public void ToggleLean(Toggle _toggle)
	{
	}

	public void ToggleCrouch(Toggle _toggle)
	{
	}

	public void ToggleReverseSprintBind(Toggle _toggle)
	{
	}

	public void ToggleMinimalistUi(Toggle _toggle)
	{
	}

	public void ToggleMotionBlur(Toggle _toggle)
	{
	}

	public void InverseFireBinding(Toggle _toggle)
	{
	}

	public void ChangeFullscreen(Toggle _toggle)
	{
	}

	public void ChangeVSync(Toggle _toggle)
	{
	}

	public void ChangeVoiceChat(Toggle _toggle)
	{
	}

	public void ChangePushToTalk(int _dropdown)
	{
	}

	public void EnableFixedCrosshair(Toggle _toggle)
	{
	}

	public void EnableSpeedometer(Toggle _toggle)
	{
	}

	public void DisableCrosshair(Toggle _toggle)
	{
	}

	public void InGameMusic(Toggle _toggle)
	{
	}

	public void ChangeExclusiveFullscreen(Toggle _toggle)
	{
	}

	public void ChangeResolution(int index)
	{
	}

	public void ChangeFrameRate(TMP_InputField _inputField)
	{
	}

	public void ChangeTargetFpsToggle(Toggle _toggle)
	{
	}

	public void ReduceVFX(Toggle _toggle)
	{
	}

	public void SetQualityLevelDropdown()
	{
	}

	public void SteamAchievementsCheck()
	{
	}

	public void IncreaseRoundsWon()
	{
	}

	public void IncreaseRoundsPlayed()
	{
	}

	public void IncreaseGamesPlayed()
	{
	}

	public void IncreaseGamesWon()
	{
	}

	public void IncreaseMapsUnlocked()
	{
	}

	public void IncreaseTauntsAmount()
	{
	}

	public void IncreaseKillsAmount()
	{
	}

	public void IncreaseDeathsAmount()
	{
	}

	public void IncreaseSuicidesAmount()
	{
	}

	public void IncreaseBodyshotsAmount()
	{
	}

	public void IncreaseHeadshotsAmount()
	{
	}

	public void IncreaseGamesLost()
	{
	}

	public void IncreaseRoundsLost()
	{
	}

	public object SaveState()
	{
		return null;
	}

	public void LoadState(JContainer state)
	{
	}

	public void ChangeTeammateOutline(string color)
	{
	}

	public void ChangeEnemyOutline(string color)
	{
	}

	public void SendAchievementUnlockText(string achievementName)
	{
	}
}
