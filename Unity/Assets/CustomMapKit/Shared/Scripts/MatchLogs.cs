using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class MatchLogs : NetworkBehaviour
{
	private GameObject ChatBox;

	public GameObject chatLinePrefab;

	public Transform parentForChatLines;

	public float duration;

	public float fadeDuration;

	public ClientInstance localPlayer;

	private string previousLine;

	private bool NetworkInitializeEarly_MatchLogs_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_MatchLogs_Assembly_002DCSharp_002Edll;

	public static MatchLogs Instance { get; private set; }

	public virtual void Awake()
	{
	}

	public override void OnStartClient()
	{
	}

	public void WriteLog(string text)
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void RpcSendChatLine(string line)
	{
	}

	[ObserversRpc]
	private void RpcSendChatLineToAllObservers(string line)
	{
	}

	public void WriteLocalLog(string line)
	{
	}

	private void OnDisable()
	{
	}

	public virtual void NetworkInitialize___Early()
	{
	}

	public virtual void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	private void RpcWriter___Server_RpcSendChatLine_3615296227(string line)
	{
	}

	private void RpcLogic___RpcSendChatLine_3615296227(string line)
	{
	}

	private void RpcReader___Server_RpcSendChatLine_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_RpcSendChatLineToAllObservers_3615296227(string line)
	{
	}

	private void RpcLogic___RpcSendChatLineToAllObservers_3615296227(string line)
	{
	}

	private void RpcReader___Observers_RpcSendChatLineToAllObservers_3615296227(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
