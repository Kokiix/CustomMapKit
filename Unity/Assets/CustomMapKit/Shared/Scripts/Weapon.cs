using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Weapon : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CComebackFromHoldbackAnimation_003Ed__141 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Weapon _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CComebackFromHoldbackAnimation_003Ed__141(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Header("Weapon Stats")]
	[SyncVar(WritePermissions = WritePermission.ClientUnsynchronized)]
	public int currentAmmo;

	public float timeBetweenFire;

	public float damage;

	public float headMultiplier;

	public float movementFactor;

	public int maxWallJumps;

	public float jumpFactor;

	public float wallJumpFactor;

	public bool fireSlowDown;

	public float fireSlowDownFactor;

	public float fireSlowDownDuration;

	public float minSpread;

	public float maxSpread;

	public float standingAccuracy;

	public float walkAccuracy;

	public float sprintAccuracy;

	public bool ScopeAimWeapon;

	public float notAimingAccuracy;

	public bool requireBothHands;

	public bool needsAmmo;

	public bool onePressShoot;

	public bool changePitchOnShoot;

	[SerializeField]
	private bool inHandDespawn;

	public bool burstGun;

	public bool aimBurstGun;

	public int bulletsAmount;

	public float timeBetweenBullets;

	public float additionalPrecision;

	[Header("SFX")]
	[HideInInspector]
	public AudioSource audio;

	public AudioClip fireClip;

	public AudioClip nobulletClip;

	public AudioClip headHitClip;

	public AudioClip bodyHitClip;

	public AudioClip deathClip;

	[Header("VFX")]
	public GameObject muzzleFlash;

	public float lightIntensity;

	public GameObject headImpact;

	public GameObject bodyImpact;

	public GameObject genericBodyImpact;

	public bool playGenericBodyImpactOnBody;

	public GameObject bloodSplatter;

	public GameObject genericImpact;

	public GameObject bulletHole;

	public LineRenderer bulletTrailLocal;

	public GameObject hitMarker;

	[HideInInspector]
	public GameObject marker;

	public bool SurfacesImpact;

	public GameObject concreteHitImpact;

	public GameObject sandHitImpact;

	public GameObject dirtHitImpact;

	public GameObject metalHitImpact;

	public GameObject tauleHitImpact;

	public GameObject waterHitImpact;

	public GameObject woodHitImpact;

	public GameObject softbodyHitImpact;

	public bool SurfacesVFX;

	public GameObject sandHitFx;

	public GameObject dirtHitFx;

	public GameObject metalHitFx;

	public GameObject tauleHitFx;

	public GameObject waterHitFx;

	public GameObject woodHitFx;

	public GameObject softbodyHitFx;

	public bool EjectVFX;

	public GameObject ejectCaseVfx;

	[SerializeField]
	private GameObject reloadEjectVfx;

	private Transform ejectCasePoint;

	[Header("Layers")]
	public LayerMask defaultLayer;

	public LayerMask playerLayer;

	public LayerMask supLayer;

	public float duration;

	public int vibrato;

	public Vector3 strength;

	public float randomness;

	public bool fadeOut;

	public ShakeRandomnessMode randomnessMode;

	public Ease shakeEase;

	public bool revolverShake;

	public bool akAnim;

	[SerializeField]
	private float cameraLerpSpeed;

	[SerializeField]
	private Vector3 recoil;

	[SerializeField]
	private float elasticity;

	[SerializeField]
	private bool instantPush;

	[SerializeField]
	private bool holdback;

	[SerializeField]
	private bool instantComebackOnFire;

	[SerializeField]
	private bool horizontalAnimation;

	[SerializeField]
	private bool supplementAnimator;

	public Animator animator;

	[SerializeField]
	private Vector3 animationPunch;

	[SerializeField]
	private Vector3 foreArmAnimationPunch;

	public float foreArmAnimationSpeed;

	[SerializeField]
	private float animationDuration;

	[SerializeField]
	private int animationVibrato;

	[SerializeField]
	private float animationElasticity;

	[Header("State")]
	public bool inRightHand;

	public bool inLeftHand;

	private PlayerControls playerControls;

	[HideInInspector]
	public InputAction fire1;

	[HideInInspector]
	public InputAction fire2;

	[HideInInspector]
	public InputAction reload;

	[HideInInspector]
	public InputAction jump;

	[HideInInspector]
	public ItemBehaviour behaviour;

	[HideInInspector]
	public FirstPersonController playerController;

	[HideInInspector]
	public GameObject rootObject;

	[HideInInspector]
	public GameObject lastPlayerHolder;

	[HideInInspector]
	public CameraShakeConstrains camAnimScript;

	private TextMeshProUGUI ammoDisplay;

	[HideInInspector]
	public Transform shootPoint;

	[HideInInspector]
	public Transform muzzleFlashPoint;

	[HideInInspector]
	public Camera cam;

	[HideInInspector]
	public Tween tween;

	[HideInInspector]
	public bool isClicked;

	[HideInInspector]
	public Transform fpArms;

	[HideInInspector]
	public PlayerValues playerValues;

	[HideInInspector]
	public bool shot;

	[HideInInspector]
	public bool heldOnce;

	[HideInInspector]
	public int noAmmoClicks;

	[HideInInspector]
	public Transform elbowPivot;

	private float caseSoundTimer;

	public bool reloadWeapon;

	[HideInInspector]
	public bool isReloading;

	public int ammoCharge;

	[SerializeField]
	private int ejectCaseIndex;

	[HideInInspector]
	public float chargedBullets;

	public float ragdollEjectForce;

	private PauseManager pauseManager;

	private Vector3 initialLocalPos;

	[HideInInspector]
	public bool cantTakeSafeBool;

	[HideInInspector]
	public bool invertFire;

	public SyncVar<int> syncVar___currentAmmo;

	private bool NetworkInitializeEarly_Weapon_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_Weapon_Assembly_002DCSharp_002Edll;

	public int SyncAccessor_currentAmmo
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public void WeaponUpdate()
	{
	}

	private void DespawnObject()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	private void DespawnObjectServer()
	{
	}

	private void SpawnEffect(GameObject fx)
	{
	}

	public void CameraAnimation()
	{
	}

	private void OnShoot()
	{
	}

	public void OnReload()
	{
	}

	public void CameraRevolverAnimation()
	{
	}

	public void AltCameraRevolverAnimation()
	{
	}

	public void WeaponAnimation()
	{
	}

	[IteratorStateMachine(typeof(_003CComebackFromHoldbackAnimation_003Ed__141))]
	private IEnumerator ComebackFromHoldbackAnimation()
	{
		return null;
	}

	public void KillShockWave()
	{
	}

	public void TriggerEnvironment(GameObject obj, Vector3 hitPoint, Vector3 direction, Vector3 hitNormal)
	{
	}

	public void BreakGlassServer(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	public void CmdBreakGlassServer(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void BreakGlassObservers(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	private void CmdExplodeGrenade(GameObject obj)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void ExplodeGrenadeObservers(GameObject obj)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	private void CmdKillPig(GameObject obj)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void KillPigObservers(GameObject obj)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	private void CmdDetachObject(GameObject obj, Vector3 direction, Vector3 hitNormal)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void DetachObjectObservers(GameObject obj, Vector3 direction, Vector3 hitNormal)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	private void CmdKillBird(GameObject obj)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void KillBirdObservers(GameObject obj)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	private void CmdBreakPot(GameObject obj)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void BreakPotObservers(GameObject obj)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	private void CmdDamageProp(GameObject obj)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void CmdDamagePropObservers(GameObject obj)
	{
	}

	private void OnTriggerEnter(Collider col)
	{
	}

	public void SetLayerAllChildren(Transform root, int layer)
	{
	}

	public bool StartsWithVowel(string name)
	{
		return false;
	}

	public bool FriendlyFireCheck(PlayerHealth enemyHealth)
	{
		return false;
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

	private void RpcWriter___Server_DespawnObjectServer_2166136261()
	{
	}

	private void RpcLogic___DespawnObjectServer_2166136261()
	{
	}

	private void RpcReader___Server_DespawnObjectServer_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_CmdBreakGlassServer_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	public void RpcLogic___CmdBreakGlassServer_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	private void RpcReader___Server_CmdBreakGlassServer_4203392553(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_BreakGlassObservers_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	private void RpcLogic___BreakGlassObservers_4203392553(Vector3 hitPoint, Vector3 direction, GameObject obj)
	{
	}

	private void RpcReader___Observers_BreakGlassObservers_4203392553(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_CmdExplodeGrenade_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___CmdExplodeGrenade_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_CmdExplodeGrenade_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_ExplodeGrenadeObservers_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___ExplodeGrenadeObservers_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Observers_ExplodeGrenadeObservers_1934289915(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_CmdKillPig_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___CmdKillPig_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_CmdKillPig_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_KillPigObservers_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___KillPigObservers_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Observers_KillPigObservers_1934289915(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_CmdDetachObject_3779971553(GameObject obj, Vector3 direction, Vector3 hitNormal)
	{
	}

	private void RpcLogic___CmdDetachObject_3779971553(GameObject obj, Vector3 direction, Vector3 hitNormal)
	{
	}

	private void RpcReader___Server_CmdDetachObject_3779971553(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_DetachObjectObservers_3779971553(GameObject obj, Vector3 direction, Vector3 hitNormal)
	{
	}

	private void RpcLogic___DetachObjectObservers_3779971553(GameObject obj, Vector3 direction, Vector3 hitNormal)
	{
	}

	private void RpcReader___Observers_DetachObjectObservers_3779971553(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_CmdKillBird_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___CmdKillBird_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_CmdKillBird_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_KillBirdObservers_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___KillBirdObservers_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Observers_KillBirdObservers_1934289915(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_CmdBreakPot_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___CmdBreakPot_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_CmdBreakPot_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_BreakPotObservers_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___BreakPotObservers_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Observers_BreakPotObservers_1934289915(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_CmdDamageProp_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___CmdDamageProp_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_CmdDamageProp_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_CmdDamagePropObservers_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___CmdDamagePropObservers_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Observers_CmdDamagePropObservers_1934289915(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___Weapon(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
