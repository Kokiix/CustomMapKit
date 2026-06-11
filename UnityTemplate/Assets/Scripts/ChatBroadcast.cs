using FishNet.Broadcast;
using FishNet.Connection;
using TMPro;
using UnityEngine;

public class ChatBroadcast : MonoBehaviour
{
	public struct Message : IBroadcast
	{
		public string username;

		public string message;
	}

	[SerializeField]
	private Transform chatHolder;

	[SerializeField]
	private GameObject msgElement;

	[SerializeField]
	private TMP_InputField playerUsername;

	[SerializeField]
	private TMP_InputField playerMessage;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void SendMessage()
	{
	}

	private void OnMessageReceived(Message msg)
	{
	}

	private void OnClientMessageReceived(NetworkConnection networkConnection, Message msg)
	{
	}
}
