using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ReBindUI : MonoBehaviour
{
	[SerializeField]
	private InputActionReference inputActionReference;

	[SerializeField]
	private bool excludeMouse;

	[SerializeField]
	private bool sequenceDisplay;

	[Range(0f, 30f)]
	[SerializeField]
	private int selectedBinding;

	[SerializeField]
	private InputBinding.DisplayStringOptions displayStringOptions;

	[Header("Binding info - DO NOT EDIT")]
	[SerializeField]
	private InputBinding inputBinding;

	private int bindingIndex;

	[HideInInspector]
	public string actionName;

	[Header("UI Fields")]
	[SerializeField]
	private TextMeshProUGUI actionText;

	[SerializeField]
	private Button rebindButton;

	[SerializeField]
	private TextMeshProUGUI rebindText;

	[SerializeField]
	private Button resetButton;

	private void Start()
	{
	}

	public void OnEnable()
	{
	}

	public void Restart()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}

	private void GetBindingInfo()
	{
	}

	private void UpdateUI()
	{
	}

	private void DoRebind()
	{
	}

	public void ResetBinding()
	{
	}
}
