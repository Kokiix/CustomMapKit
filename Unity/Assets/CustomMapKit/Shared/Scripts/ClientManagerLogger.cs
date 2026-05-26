using FishNet.Managing.Client;
using FishNet.Transporting;
using UnityEngine;

[RequireComponent(typeof(ClientManager))]
public class ClientManagerLogger : MonoBehaviour
{
	private ClientManager ClientManager;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnClientConnectionStateChanged(ClientConnectionStateArgs args)
	{
	}

	private void OnRemoteConnectionStateChanged(RemoteConnectionStateArgs args)
	{
	}

	private void OnAuthenticated()
	{
	}
}
