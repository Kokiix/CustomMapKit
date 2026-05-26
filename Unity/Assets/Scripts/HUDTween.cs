using DG.Tweening;
using UnityEngine;

public class HUDTween : MonoBehaviour
{
	[SerializeField]
	private Transform hudUp;

	[SerializeField]
	private Transform hudDown;

	[SerializeField]
	private float tweenTime;

	[SerializeField]
	private Ease ease;

	private bool trigger;

	private ClientInstance clientScript;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void MoveUp()
	{
	}
}
