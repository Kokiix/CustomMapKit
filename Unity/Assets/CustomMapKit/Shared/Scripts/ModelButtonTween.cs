using DG.Tweening;
using UnityEngine;

public class ModelButtonTween : MonoBehaviour
{
	[SerializeField]
	private float hoverAmount;

	[SerializeField]
	private float pressAmount;

	[SerializeField]
	private float tweenDuration;

	[SerializeField]
	private Ease ease;

	[SerializeField]
	private Vector3 direction;

	private Vector3 initialPosition;

	private void Start()
	{
	}

	public void Hover()
	{
	}

	public void Leave()
	{
	}

	public void Press()
	{
	}

	public void Release()
	{
	}

	private void OnDisable()
	{
	}
}
