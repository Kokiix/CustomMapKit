using TMPro;
using UnityEngine;

public class HealthTween : MonoBehaviour
{
	public float health;

	[SerializeField]
	private Color firstColor;

	[SerializeField]
	private Color lastColor;

	[Space]
	[SerializeField]
	private Vector3 sizeTween;

	[SerializeField]
	private float duration;

	[SerializeField]
	private int vibrato;

	[SerializeField]
	private TMP_Text text;

	[SerializeField]
	private Transform heart;

	[SerializeField]
	private float timeBetweenHeartBeat;

	[SerializeField]
	private float heartScale;

	[SerializeField]
	private float littleHeartScale;

	[SerializeField]
	private float heartSpeed;

	private float timeBetweenHeartBeatFunc;

	private float timer;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ChangeState()
	{
	}
}
