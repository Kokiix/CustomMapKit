using DG.Tweening;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

public class Door : InteractEnvironment
{
	[SyncVar]
	public bool isOpen;

	[SyncVar]
	public bool previousIsOpen;

	private bool trigger;

	private bool firstSfx;

	[SerializeField]
	private AudioClip openClip;

	[SerializeField]
	private AudioClip closeClip;

	[SerializeField]
	private float maxRotation;

	[SerializeField]
	private float doorOpeningTime;

	[SerializeField]
	private string closeDoor;

	private AudioSource audio;

	private Tween tween;

	[SyncVar]
	public Transform localplayer;

	private float timerdoor;

	private AudioSource source;

	public SyncVar<bool> syncVar___isOpen;

	public SyncVar<bool> syncVar___previousIsOpen;

	public SyncVar<Transform> syncVar___localplayer;

	private bool NetworkInitializeEarly_Door_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Door_Assembly_002DCSharp_002Edll;

	public bool SyncAccessor_isOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SyncAccessor_previousIsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Transform SyncAccessor_localplayer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public override void OnFocus()
	{
	}

	public override void OnInteract(Transform player)
	{
	}

	public override void OnLoseFocus()
	{
	}

	[ServerRpc(RunLocally = true, RequireOwnership = false)]
	private void CmdInteract(Transform player)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void TriggerDoor()
	{
	}

	private void Update()
	{
	}

	public override void Awake()
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

	private void RpcWriter___Server_CmdInteract_3068987916(Transform player)
	{
	}

	private void RpcLogic___CmdInteract_3068987916(Transform player)
	{
	}

	private void RpcReader___Server_CmdInteract_3068987916(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_TriggerDoor_2166136261()
	{
	}

	private void RpcLogic___TriggerDoor_2166136261()
	{
	}

	private void RpcReader___Observers_TriggerDoor_2166136261(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___Door(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public override void Awake___UserLogic()
	{
	}
}
