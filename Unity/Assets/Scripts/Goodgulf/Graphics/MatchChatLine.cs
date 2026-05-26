using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Goodgulf.Graphics
{
	public class MatchChatLine : MonoBehaviour
	{
		public float duration;

		public float fadeDuration;

		public bool deleteMe;

		public bool chatMsg;

		public bool destroyWhenDone;

		private bool startCounting;

		private bool startFading;

		private float currentTime;

		private float currentFadeTime;

		private float alpha;

		private float ialpha;

		private bool initialized;

		public float tweenSize;

		public Ease easeType;

		[SerializeField]
		private TMP_Text matchLine;

		[SerializeField]
		private TMP_Text nameLine;

		[SerializeField]
		private RawImage matchImg;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		private bool stop;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void EnsureInitialized()
		{
		}

		public void StartDuration()
		{
		}

		private void Update()
		{
		}

		public void ForceShow()
		{
		}

		public void DisableForceShow()
		{
		}
	}
}
