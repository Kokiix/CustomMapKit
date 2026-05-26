using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
	public static PlayerControls inputActions;

	private static int iteration;

	public static List<ReBindUI> rebindFields;

	public static event Action rebindComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action rebindCanceled
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<InputAction, int> rebindStarted
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public static void RestartEngine()
	{
	}

	public static void StartRebind(string actionName, int bindingIndex, TextMeshProUGUI statusText, bool excludeMouse, bool sequenceDisplay)
	{
	}

	private static void DoRebind(InputAction actionToRebind, int bindingIndex, TextMeshProUGUI statusText, bool allCompositeParts, bool excludeMouse, bool sequenceDisplay)
	{
	}

	public static string GetBindingName(string actionName, int bindingIndex)
	{
		return null;
	}

	private static void SaveBindingOverride(InputAction action)
	{
	}

	public static void LoadBindingOverride(string actionName)
	{
	}

	public static void ResetBinding(string actionName, int bindingIndex)
	{
	}
}
