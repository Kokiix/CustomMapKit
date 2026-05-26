using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using LambdaTheDev.NetworkAudioSync;
using UnityEngine;

public class Propeller : Weapon
{
	[Header("Weapon Specials")]
	[SerializeField]
	private float flySpeed;

	[SerializeField]
	private float decelSpeed;

	[SerializeField]
	private float maxPower;

	[SerializeField]
	private AudioClip propOutClip;

	[SerializeField]
	private Transform rotativePart;

	[SerializeField]
	private float rotationSpeed;

	[SerializeField]
	private float lerpSpeed;

	private float power;

	private float rotateSpeed;

	private NetworkAudioSource networkAudioSource;

	private bool isflying;

	private bool active3;

	private bool active4;

	private bool pressed;

	private bool released;

	private bool NetworkInitializeEarly_Propeller_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Propeller_Assembly_002DCSharp_002Edll;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[ServerRpc]
	private void AudioPlay()
	{
	}

	[ServerRpc]
	private void AudioStop()
	{
	}

	private void Fire()
	{
	}

	private void Fly()
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void PlayReleaseClipObservers()
	{
	}

	public override void NetworkInitialize___Early()
	{
	}

	public override void NetworkInitialize__Late()
	{
	}

	public override void NetworkInitializeIfDisabled()
	{
	}

	private void RpcWriter___Server_AudioPlay_2166136261()
	{
	}

	private void RpcLogic___AudioPlay_2166136261()
	{
	}

	private void RpcReader___Server_AudioPlay_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_AudioStop_2166136261()
	{
	}

	private void RpcLogic___AudioStop_2166136261()
	{
	}

	private void RpcReader___Server_AudioStop_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_PlayReleaseClipObservers_2166136261()
	{
	}

	private void RpcLogic___PlayReleaseClipObservers_2166136261()
	{
	}

	private void RpcReader___Observers_PlayReleaseClipObservers_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public override void Awake()
	{
	}

	public override void Awake___UserLogic()
	{
	}
}
