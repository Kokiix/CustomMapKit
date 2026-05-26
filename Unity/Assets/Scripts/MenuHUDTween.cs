using DG.Tweening;
using UnityEngine;

public class MenuHUDTween : MonoBehaviour
{
	public bool displayed;

	[Space]
	[SerializeField]
	private Transform hiddenPosition;

	[SerializeField]
	private Transform displayedPosition;

	[Space]
	[SerializeField]
	private Ease easeType;

	[SerializeField]
	private float lerpTime;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ChangeState()
	{
	}

	public void SetEnabled()
	{
	}

	public void SetDisabled()
	{
	}
}
