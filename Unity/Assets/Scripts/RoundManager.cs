using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using TMPro;
using UnityEngine;

public class RoundManager : NetworkBehaviour
{
	[CompilerGenerated]
	private sealed class _003CInterfaceSetup_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoundManager _003C_003E4__this;

		public int playerId;

		public bool won;

		public int winningTeamId;

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
		public _003CInterfaceSetup_003Ed__46(int _003C_003E1__state)
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

	public static RoundManager Instance;

	public string[] names;

	public int[] scores;

	public ClientInstance[] players;

	[SerializeField]
	private float tweenTime;

	[SerializeField]
	public AudioClip[] swooshClip;

	[SerializeField]
	private AudioClip winClip;

	[SerializeField]
	private AudioClip loseClip;

	[SerializeField]
	private AudioClip plusOneClip;

	[SerializeField]
	private Color winColor;

	[SerializeField]
	private Color loseColor;

	private GameObject container;

	private GameObject background;

	private GameObject selfPlusOne;

	private GameObject[] enemyPlusOne;

	private TextMeshProUGUI playerName;

	private TextMeshProUGUI[] enemyName;

	private TextMeshProUGUI playerScore;

	private TextMeshProUGUI[] enemyScore;

	private TextMeshProUGUI winText;

	private TextMeshProUGUI roundText;

	private Transform nextRoundImageOne;

	private Transform nextRoundImageTwo;

	private Transform nextRoundImageThree;

	private Transform nextRoundImageFour;

	private Transform nextRoundImageFive;

	private Transform nextRoundImageSix;

	private Transform nextRoundImageOneRestPos;

	private Transform nextRoundImageOneActivePos;

	private Transform nextRoundImageTwoRestPos;

	private Transform nextRoundImageTwoActivePos;

	private Transform nextRoundImageThreeRestPos;

	private Transform nextRoundImageThreeActivePos;

	private Transform nextRoundImageFourRestPos;

	private Transform nextRoundImageFourActivePos;

	private Transform nextRoundImageFiveRestPos;

	private Transform nextRoundImageFiveActivePos;

	private Transform nextRoundImageSixRestPos;

	private Transform nextRoundImageSixActivePos;

	public IEnumerator InterfaceSetupCoroutine;

	private bool NetworkInitializeEarly_RoundManager_Assembly_002DCSharp_002Edll;

	private bool NetworkInitializeLate_RoundManager_Assembly_002DCSharp_002Edll;

	public virtual void Awake()
	{
	}

	private void Start()
	{
	}

	public void StopCoroutine()
	{
	}

	[ServerRpc(RequireOwnership = false)]
	public void CmdEndRound(int winningTeamId)
	{
	}

	[ObserversRpc]
	public void EndRoundObservers(int winningTeamId)
	{
	}

	public void NextRoundCall(int playerId, bool won, int winningTeamId)
	{
	}

	[IteratorStateMachine(typeof(_003CInterfaceSetup_003Ed__46))]
	private IEnumerator InterfaceSetup(int playerId, bool won, int winningTeamId)
	{
		return null;
	}

	private void DynamicLoading(int playerId)
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

	private void RpcWriter___Server_CmdEndRound_3316948804(int winningTeamId)
	{
	}

	public void RpcLogic___CmdEndRound_3316948804(int winningTeamId)
	{
	}

	private void RpcReader___Server_CmdEndRound_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
	{
	}

	private void RpcWriter___Observers_EndRoundObservers_3316948804(int winningTeamId)
	{
	}

	public void RpcLogic___EndRoundObservers_3316948804(int winningTeamId)
	{
	}

	private void RpcReader___Observers_EndRoundObservers_3316948804(PooledReader PooledReader0, Channel channel)
	{
	}

	public virtual void Awake___UserLogic()
	{
	}
}
