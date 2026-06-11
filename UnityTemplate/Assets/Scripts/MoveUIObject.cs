using DG.Tweening;
using UnityEngine;

public class MoveUIObject : MonoBehaviour
{
	private Vector3 activePosition;

	[SerializeField]
	private Vector3 offset;

	[SerializeField]
	private float duration;

	[SerializeField]
	private Ease ease;

	private bool state;

	private bool initiated;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	[ContextMenu("ChangeState")]
	public void ChangeState()
	{
	}

	public void ChooseState(bool state)
	{
	}
}
