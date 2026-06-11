using Newtonsoft.Json.Linq;
using UnityEngine;

public class SaveableEntity : MonoBehaviour
{
	[SerializeField]
	private string id;

	public string Id => null;

	[ContextMenu("Generate Id")]
	private void GenerateId()
	{
	}

	public object SaveState()
	{
		return null;
	}

	public void LoadState(JContainer state)
	{
	}
}
