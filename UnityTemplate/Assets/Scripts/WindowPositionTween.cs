using DG.Tweening;
using UnityEngine;

public class WindowPositionTween : MonoBehaviour
{
	[SerializeField]
	private GameObject panel;

	[SerializeField]
	private GameObject optionsButton;

	[SerializeField]
	private GameObject resumeButton;

	[SerializeField]
	private float tweenDuration;

	[SerializeField]
	private Ease easeType;

	[SerializeField]
	private bool options;

	private void Update()
	{
	}

	public void ChangeWindowState()
	{
	}
}
