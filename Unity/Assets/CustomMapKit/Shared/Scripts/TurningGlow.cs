using TMPro;
using UnityEngine;

public class TurningGlow : MonoBehaviour
{
	[SerializeField]
	private TMP_Text textLabel;

	private float glowTimer;

	public float glowSpeed;

	public float glowAmount;

	private Color c;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
