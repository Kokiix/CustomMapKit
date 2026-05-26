using TMPro;
using UnityEngine;

public class TabScreen : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI roundText;

	[SerializeField]
	private TextMeshProUGUI scoreOne;

	[SerializeField]
	private TextMeshProUGUI scoreTwo;

	[SerializeField]
	private TextMeshProUGUI scoreThree;

	[SerializeField]
	private TextMeshProUGUI scoreFour;

	[SerializeField]
	private TextMeshProUGUI mapText;

	private PauseManager pauseManager;

	private SteamLobby manager;

	public static TabScreen Instance;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}
}
