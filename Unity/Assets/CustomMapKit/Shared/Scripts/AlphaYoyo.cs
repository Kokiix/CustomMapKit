using TMPro;
using UnityEngine;

public class AlphaYoyo : MonoBehaviour
{
	[SerializeField]
	private float speed;

	[SerializeField]
	private float floorLimit;

	[SerializeField]
	private float ceilLimit;

	private TextMeshProUGUI text;

	private float alpha;

	private float timer;

	private new bool enabled;

	private Color initialColor;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void InvertState()
	{
	}

	public void SetState(bool state)
	{
	}
}
