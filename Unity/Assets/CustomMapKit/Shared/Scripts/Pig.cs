using UnityEngine;

public class Pig : MonoBehaviour
{
	private Rigidbody rb;

	private Animator anim;

	private float speed;

	private float speedLimit;

	private float walkTimeMin;

	private float walkTimeMax;

	private float walkTime;

	private float walkTimer;

	private Vector3 walkDir;

	private bool stopped;

	private float stoppedTimeMin;

	private float stoppedTimeMax;

	private float stoppedTime;

	private float stoppedTimer;

	private float sniffChance;

	private float gruntChance;

	private float walkGruntChance;

	private bool walkGrunted;

	private AudioSource sound;

	public AudioClip squeal;

	public AudioClip grunt;

	public AudioClip grunt2;

	public AudioClip sniff;

	public AudioClip fallFar;

	public AudioClip step;

	private bool fellFar;

	private Vector3 lastTrueVel;

	private float stepTimer;

	private float stepTime;

	public GameObject hat;

	public GameObject hatHeld;

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void Interact()
	{
	}

	public void Fling()
	{
	}

	public void Grunt()
	{
	}

	public void Sniff()
	{
	}

	private void FixedUpdate()
	{
	}

	public void FallFar()
	{
	}

	private void Orient(Vector3 travelDir)
	{
	}

	private void StartWalking()
	{
	}

	private void StopWalking()
	{
	}

	public void Die()
	{
	}
}
