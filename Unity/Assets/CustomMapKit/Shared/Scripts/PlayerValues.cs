using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using UnityEngine;

public class PlayerValues : NetworkBehaviour
{
	[SyncVar]
	public ClientInstance playerClient;

	private PlayerSetup setup;

	public GameObject typingIndicator;

	[SerializeField]
	private AudioSource voiceChatSource;

	[Space]
	[Header("Grab Sync Fix")]
	[SerializeField]
	private LayerMask itemLayer;

	[SerializeField]
	private float syncFixTimer;

	[SerializeField]
	private float raycastLength;

	[SerializeField]
	private Transform head;

	public Interactable currentInteractable;

	public SyncVar<ClientInstance> syncVar___playerClient;

	private bool NetworkInitializeEarly_PlayerValues_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PlayerValues_Assembly_002DCSharp_002Edll;

	public ClientInstance SyncAccessor_playerClient
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

	private void Update()
	{
	}

	private void SyncedItemRaycast()
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

	public virtual bool ReadSyncVar___PlayerValues(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake()
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
