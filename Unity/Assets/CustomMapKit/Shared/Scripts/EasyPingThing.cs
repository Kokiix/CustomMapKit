using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class EasyPingThing : MonoBehaviour
{
	[SerializeField]
	private string prefix;

	[SerializeField]
	private string suffix;

	private TextMeshProUGUI textMesh;

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
