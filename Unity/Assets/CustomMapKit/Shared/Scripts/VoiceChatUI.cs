using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VoiceChatUI : MonoBehaviour
{
	public static VoiceChatUI Instance;

	public Toggle disableVoiceChatUIToggle;

	public VoiceChatUIObject voiceChatUIObject;

	private readonly List<VoiceChatUIObject> _voiceChatUIObjects;

	public bool DisableVoiceChatUI;

	private void Awake()
	{
	}

	public void CreateVoiceChatUIObject(ClientInstance clientInstance)
	{
	}

	public void SetDisableVoiceChatUI(bool disable)
	{
	}
}
