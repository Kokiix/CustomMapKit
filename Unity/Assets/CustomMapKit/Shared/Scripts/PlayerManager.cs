using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Managing.Scened;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerManager : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForRoundStart_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerManager _003C_003E4__this;

		private double _003CelapsedTime_003E5__2;

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
		public _003CWaitForRoundStart_003Ed__17(int _003C_003E1__state)
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

	[Tooltip("Character prefab to spawn.")]
	[FormerlySerializedAs("_characterPrefab")]
	[SerializeField]
	private GameObject characterPrefab;

	private GameObject SpawnedObject;

	private SpawnPoint[] CurrentSpawnPoints;

	private SpawnPoint[] SpawnPoint1v1;

	private SpawnPoint[] SpawnPoint4v4;

	private ClientInstance ClientScript;

	[HideInInspector]
	public FirstPersonController player;

	private MapsManager mapsManager;

	private bool StartTrigger;

	public Coroutine waitForRoundStartCoroutine;

	private const float ConnectionCheckTimeout = 7.5f;

	private float CheckTimer;

	private bool NetworkInitializeEarly_PlayerManager_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_PlayerManager_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void WaitForRoundStartCoroutineStart()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForRoundStart_003Ed__17))]
	public IEnumerator WaitForRoundStart()
	{
		return null;
	}

	[ServerRpc(RequireOwnership = false)]
	public void IncrementReadyPlayers(NetworkConnection conn = null)
	{
	}

	[ServerRpc(RequireOwnership = false, RunLocally = true)]
	public void SetPlayerMove(bool state)
	{
	}

	public void OnLoadSceneStart(SceneLoadStartEventArgs args)
	{
	}

	public void PopulateSpawnPoints()
	{
	}

	public void SetActiveSpawnPoints()
	{
	}

	public void OnLoadSceneEnd(SceneLoadEndEventArgs args)
	{
	}

	public void TryRespawn()
	{
	}

	private Transform ReturnSpawnPoint()
	{
		return null;
	}

	private static void Shuffle(SpawnPoint[] spawnPoints)
	{
	}

	[ServerRpc]
	private void CmdRespawn()
	{
	}

	public void NewSceneSpawn()
	{
	}

	[ServerRpc]
	private void CmdNewSceneSpawn(int suitIndex, int cigIndex)
	{
	}

	public void RoundSpawn()
	{
	}

	[ServerRpc]
	private void CmdNewRoundSpawn(int suitIndex, int cigIndex)
	{
	}

	private void SpawnPlayer(int suitIndex, int cigIndex)
	{
	}

	private void SpawnPlayer(int suitIndex, int cigIndex, Vector3 position, Quaternion rotation)
	{
	}

	private void UnsubscribeFromInput()
	{
	}

	[ServerRpc]
	private void DespawnServer(GameObject obj)
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

	private void RpcWriter___Server_IncrementReadyPlayers_328543758(NetworkConnection conn = null)
	{
	}

	public void RpcLogic___IncrementReadyPlayers_328543758(NetworkConnection conn = null)
	{
	}

	private void RpcReader___Server_IncrementReadyPlayers_328543758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_SetPlayerMove_1140765316(bool state)
	{
	}

	public void RpcLogic___SetPlayerMove_1140765316(bool state)
	{
	}

	private void RpcReader___Server_SetPlayerMove_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_CmdRespawn_2166136261()
	{
	}

	private void RpcLogic___CmdRespawn_2166136261()
	{
	}

	private void RpcReader___Server_CmdRespawn_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_CmdNewSceneSpawn_1692629761(int suitIndex, int cigIndex)
	{
	}

	private void RpcLogic___CmdNewSceneSpawn_1692629761(int suitIndex, int cigIndex)
	{
	}

	private void RpcReader___Server_CmdNewSceneSpawn_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_CmdNewRoundSpawn_1692629761(int suitIndex, int cigIndex)
	{
	}

	private void RpcLogic___CmdNewRoundSpawn_1692629761(int suitIndex, int cigIndex)
	{
	}

	private void RpcReader___Server_CmdNewRoundSpawn_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Server_DespawnServer_1934289915(GameObject obj)
	{
	}

	private void RpcLogic___DespawnServer_1934289915(GameObject obj)
	{
	}

	private void RpcReader___Server_DespawnServer_1934289915(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
