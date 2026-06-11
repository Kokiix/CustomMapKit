using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using LambdaTheDev.NetworkAudioSync;
using UnityEngine;

public class ProximityChatPlayer : NetworkBehaviour
{
	[SerializeField]
	private NetworkAudioSource outputSource;

	[SerializeField]
	private AudioSource localOutputSource;

	public AudioClip clip;

	private bool NetworkInitializeEarly_ProximityChatPlayer_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_ProximityChatPlayer_Assembly_002DCSharp_002Edll;

	[ServerRpc]
	private void PlaybackServer(bool play)
	{
	}

	public override void OnStartClient()
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

	private void RpcWriter___Server_PlaybackServer_1140765316(bool play)
	{
	}

	private void RpcLogic___PlaybackServer_1140765316(bool play)
	{
	}

	private void RpcReader___Server_PlaybackServer_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
