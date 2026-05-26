using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Animations.Rigging;
using UnityEngine.InputSystem;

public class PlayerPickup : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBuildOnDrop_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CBuildOnDrop_003Ed__78(int _003C_003E1__state)
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

	private PlayerControls playerControls;

	private FirstPersonController playerController;

	private InputAction interact;

	private InputAction drop;

	private InputAction change;

	[Header("Interaction")]
	[SerializeField]
	private float interactionDistance;

	[SerializeField]
	private LayerMask interactionLayer;

	[SerializeField]
	private LayerMask environmentInteractionLayer;

	[SerializeField]
	private LayerMask bodyInteractionLayer;

	[SerializeField]
	private LayerMask ragdollInteractionLayer;

	[SerializeField]
	private float sphereRadius;

	[SerializeField]
	private float maxSphereDistance;

	[SerializeField]
	private float maxInteractionDistance;

	[SerializeField]
	private float currentHitDistance;

	[SerializeField]
	private LayerMask landLayer;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	public Animator globalAnimator;

	public Transform fpArms;

	public Interactable currentInteractable;

	public InteractEnvironment currentEnvironmentInteractable;

	public InteractEnvironment heldEnvironmentInteractable;

	public GameObject currentObject;

	public GameObject currentHitObject;

	public GameObject currentEnvironmentObject;

	private bool interactionSphere;

	[HideInInspector]
	public PlayerValues playerValues;

	public Transform[] pickupPositionRightHand;

	public Transform[] pickupPositionBothHand;

	public Transform[] pickupPositionLeftHand;

	public Transform[] aimPositionBothHand;

	public Transform[] aimPositionRightHand;

	public Transform[] pickupPositionOnline;

	public Transform RightHandIKTarget;

	public Transform LeftHandIKTarget;

	private Transform TargetForRightIK;

	private Transform TargetForLeftIK;

	[SerializeField]
	private Transform LeftIdlePosition;

	[SerializeField]
	private Transform RightIdlePosition;

	[SerializeField]
	private RigBuilder RigBuilder;

	[Space]
	[SerializeField]
	private AudioClip pickupClip;

	[SerializeField]
	private AudioClip dropClip;

	[SerializeField]
	private AudioClip switchWeaponsClip;

	[Space]
	private Camera cam;

	[SerializeField]
	private GameObject graphics;

	[SerializeField]
	private GameObject RightHandPositions;

	[SerializeField]
	private GameObject BothHandPositions;

	[SerializeField]
	private GameObject LeftHandPositions;

	[SerializeField]
	private GameObject AimBothHandPositions;

	[SerializeField]
	private GameObject AimRightHandPositions;

	[SerializeField]
	private GameObject OnlinePositions;

	private GameObject camHolder;

	public CameraShakeConstrains camAnimScript;

	[SyncVar]
	public bool hasObjectInHand;

	[SyncVar]
	public GameObject objInHand;

	private Weapon weaponInHand;

	private ItemBehaviour behaviourInHand;

	[SyncVar]
	public bool hasObjectInLeftHand;

	[SyncVar]
	public GameObject objInLeftHand;

	private Weapon weaponInLeftHand;

	private ItemBehaviour behaviourInLeftHand;

	private PauseManager pauseManager;

	private float dropTimer;

	private float interactTimer;

	private PlayerHealth enemyBody;

	private Transform ragdoll;

	private Transform hips;

	[SerializeField]
	private Transform camPoint;

	public SyncVar<bool> syncVar___hasObjectInHand;

	public SyncVar<GameObject> syncVar___objInHand;

	public SyncVar<bool> syncVar___hasObjectInLeftHand;

	public SyncVar<GameObject> syncVar___objInLeftHand;

	private bool NetworkInitializeEarly_PlayerPickup_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PlayerPickup_Assembly_002DCSharp_002Edll;

	public bool SyncAccessor_hasObjectInHand
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObject SyncAccessor_objInHand
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool SyncAccessor_hasObjectInLeftHand
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObject SyncAccessor_objInLeftHand
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetRightIKTarget(Transform transform)
	{
	}

	public void SetLeftIKTarget(Transform transform)
	{
	}

	public void UpdateIKPoistion()
	{
	}

	public override void OnStartClient()
	{
	}

	public virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void RightHandPickup()
	{
	}

	private void LeftHandPickup()
	{
	}

	public void RightHandDrop()
	{
	}

	public void LeftHandDrop()
	{
	}

	public void RightHandFix()
	{
	}

	public void LeftHandFix()
	{
	}

	public void HandsReconstruct()
	{
	}

	[IteratorStateMachine(typeof(_003CBuildOnDrop_003Ed__78))]
	private IEnumerator BuildOnDrop()
	{
		return null;
	}

	[ServerRpc]
	private void GiveOwnerToObj(GameObject obj)
	{
	}

	private void HandleInteraction(InputAction.CallbackContext ctx)
	{
	}

	private void HandleDrop(InputAction.CallbackContext ctx)
	{
	}

	private void SwitchWeapons()
	{
	}

	[ServerRpc(RunLocally = true)]
	private void SetObjectInHandServer(GameObject obj, Vector3 position, Quaternion rotation, GameObject player, bool rightHand)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void SetObjectInHandObserver(GameObject obj, Vector3 position, Quaternion rotation, GameObject player, bool rightHand)
	{
	}

	[ServerRpc(RunLocally = true)]
	private void DropObjectServer(GameObject obj, bool rightHand)
	{
	}

	[ObserversRpc(RunLocally = true, ExcludeOwner = true)]
	private void DropObjectObserver(GameObject obj, bool rightHand)
	{
	}

	private void HandleInteractEnvironment()
	{
	}

	private void HandleInteractionCheck()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void PlayerGrab()
	{
	}

	private Transform FindRecursive(string name, Transform root)
	{
		return null;
	}

	private void HandleAboubiGrab()
	{
	}

	[ServerRpc]
	private void BumpPlayerServer(Vector3 direction, float force, PlayerHealth ph)
	{
	}

	[ServerRpc]
	private void SetEnemyParent(bool set, Transform t, PlayerHealth ph)
	{
	}

	[ObserversRpc]
	private void SetEnemyParentObservers(bool set)
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

	private void RpcWriter___Server_GiveOwnerToObj_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___GiveOwnerToObj_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_GiveOwnerToObj_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SetObjectInHandServer_46969756(GameObject obj, Vector3 position, Quaternion rotation, GameObject player, bool rightHand)
	{
	}

	private void RpcLogic___SetObjectInHandServer_46969756(GameObject obj, Vector3 position, Quaternion rotation, GameObject player, bool rightHand)
	{
	}

	private void RpcReader___Server_SetObjectInHandServer_46969756(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SetObjectInHandObserver_46969756(GameObject obj, Vector3 position, Quaternion rotation, GameObject player, bool rightHand)
	{
	}

	private void RpcLogic___SetObjectInHandObserver_46969756(GameObject obj, Vector3 position, Quaternion rotation, GameObject player, bool rightHand)
	{
	}

	private void RpcReader___Observers_SetObjectInHandObserver_46969756(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_DropObjectServer_2127535046(GameObject obj, bool rightHand)
	{
	}

	private void RpcLogic___DropObjectServer_2127535046(GameObject obj, bool rightHand)
	{
	}

	private void RpcReader___Server_DropObjectServer_2127535046(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_DropObjectObserver_2127535046(GameObject obj, bool rightHand)
	{
	}

	private void RpcLogic___DropObjectObserver_2127535046(GameObject obj, bool rightHand)
	{
	}

	private void RpcReader___Observers_DropObjectObserver_2127535046(PooledReader PooledReader0, Channel channel)
	{
	}

	private void RpcWriter___Server_BumpPlayerServer_1076951378(Vector3 direction, float force, PlayerHealth ph)
	{
	}

	private void RpcLogic___BumpPlayerServer_1076951378(Vector3 direction, float force, PlayerHealth ph)
	{
	}

	private void RpcReader___Server_BumpPlayerServer_1076951378(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SetEnemyParent_3492863138(bool set, Transform t, PlayerHealth ph)
	{
	}

	private void RpcLogic___SetEnemyParent_3492863138(bool set, Transform t, PlayerHealth ph)
	{
	}

	private void RpcReader___Server_SetEnemyParent_3492863138(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_SetEnemyParentObservers_1140765316(bool set)
	{
	}

	private void RpcLogic___SetEnemyParentObservers_1140765316(bool set)
	{
	}

	private void RpcReader___Observers_SetEnemyParentObservers_1140765316(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual bool ReadSyncVar___PlayerPickup(PooledReader PooledReader0, uint UInt321, bool Boolean2)
	{
		return false;
	}

	public virtual void Awake___UserLogic()
	{
	}
}
