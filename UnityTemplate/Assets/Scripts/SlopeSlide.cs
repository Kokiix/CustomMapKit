using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using LambdaTheDev.NetworkAudioSync;
using UnityEngine;

public class SlopeSlide : NetworkBehaviour
{
	public Vector3 slopeSlideMove;

	public Vector3 steepSlopeSlideMove;

	public bool isCrouchSlopeSliding;

	public bool isSteepSlopeSliding;

	public bool sliding;

	public bool slopeSlideTrigger;

	public bool slopeSlideTrigger2;

	public bool onIce;

	public bool onSuperIce;

	public bool onSand;

	public bool onConcrete;

	public bool sprintSlideTrigger;

	private FirstPersonController controller;

	private CharacterController characterController;

	private Slope slopeScript;

	[SerializeField]
	private NetworkAudioSource networkAudio;

	[SerializeField]
	private AudioSource audio;

	[SerializeField]
	private AudioClip slideOutClip;

	private bool downRay;

	private RaycastHit slopeHit;

	private RaycastHit slopeHit1;

	private RaycastHit slopeHit2;

	private RaycastHit slopeHit3;

	private RaycastHit slopeHit4;

	private bool localSlopeSlideTrigger;

	private bool localSlopeSlideStopTrigger;

	private float slideTimer;

	private float slideCancelTimer;

	private float slideFadeInTimer;

	private float initSoundVolume;

	private bool crouchOutTrigger;

	private bool sprintInTrigger;

	private bool sprintLateTrigger;

	public float speedFactor;

	public float walkSpeedFactor;

	public float currentSpeed;

	public float currentAcceleration;

	public float currentDeceleration;

	[SerializeField]
	private float concreteSpeed;

	[SerializeField]
	private float iceSpeed;

	[SerializeField]
	private float minWalkIceSlideSpeed;

	[SerializeField]
	private float maxWalkIceSlideSpeed;

	[SerializeField]
	private float sandSpeed;

	[SerializeField]
	private float concreteFadeOutTime;

	[SerializeField]
	private float iceFadeOutTime;

	[SerializeField]
	private float sandFadeOutTime;

	[SerializeField]
	private float concreteAcceleration;

	[SerializeField]
	private float iceAcceleration;

	[SerializeField]
	private float sandAcceleration;

	[SerializeField]
	private float concreteDeceleration;

	[SerializeField]
	private float iceDeceleration;

	[SerializeField]
	private float sandDeceleration;

	[SerializeField]
	private float firstClamp;

	[SerializeField]
	private float secondClamp;

	[SerializeField]
	private float minSlopeAngle;

	[SerializeField]
	private float walkFirstClamp;

	[SerializeField]
	private float walkSecondClamp;

	[SerializeField]
	private float minimumSteepness;

	[SerializeField]
	private float steepSlopeSlideSpeed;

	[SerializeField]
	private float steepSlopeSlideAcceleration;

	[SerializeField]
	private float steepSlopeSlideDeceleration;

	private bool stopped;

	private bool NetworkInitializeEarly_SlopeSlide_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_SlopeSlide_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	private void Update()
	{
	}

	private void SlideFadeOut(float _duration)
	{
	}

	[ServerRpc]
	private void SlideAudioPlay()
	{
	}

	[ServerRpc]
	private void SlideAudioStop()
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

	private void RpcWriter___Server_SlideAudioPlay_2166136261()
	{
	}

	private void RpcLogic___SlideAudioPlay_2166136261()
	{
	}

	private void RpcReader___Server_SlideAudioPlay_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SlideAudioStop_2166136261()
	{
	}

	private void RpcLogic___SlideAudioStop_2166136261()
	{
	}

	private void RpcReader___Server_SlideAudioStop_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
