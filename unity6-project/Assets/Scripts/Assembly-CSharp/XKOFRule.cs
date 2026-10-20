using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000576")]
public class XKOFRule
{
	[Token(Token = "0x2000577")]
	public enum State
	{
		[Token(Token = "0x4001AFD")]
		PLAY = 0,
		[Token(Token = "0x4001AFE")]
		ENDROUND = 1,
		[Token(Token = "0x4001AFF")]
		NEXTROUND = 2,
		[Token(Token = "0x4001B00")]
		COUNTDOWN = 3,
		[Token(Token = "0x4001B01")]
		GAME_FINISH = 4
	}

	[Token(Token = "0x2000578")]
	private sealed class _003CDelayRefreshLifeUI_003Ec__Iterator5E : IDisposable
	{
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x17000730")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002E95")]
			[Address(RVA = "0x1D3ABBC", Offset = "0x1D3ABBC", VA = "0x1D3ABBC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000731")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E96")]
			[Address(RVA = "0x1D3ABC4", Offset = "0x1D3ABC4", VA = "0x1D3ABC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002E94")]
		[Address(RVA = "0x1D3AA58", Offset = "0x1D3AA58", VA = "0x1D3AA58")]
		public _003CDelayRefreshLifeUI_003Ec__Iterator5E()
		{
		}

		[Token(Token = "0x6002E95")]
		[Address(RVA = "0x1D3ABBC", Offset = "0x1D3ABBC", VA = "0x1D3ABBC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x1D3ABC4", Offset = "0x1D3ABC4", VA = "0x1D3ABC4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E97")]
		[Address(RVA = "0x1D3ABCC", Offset = "0x1D3ABCC", VA = "0x1D3ABCC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E98")]
		[Address(RVA = "0x1D3AD18", Offset = "0x1D3AD18", VA = "0x1D3AD18", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x1D3AD24", Offset = "0x1D3AD24", VA = "0x1D3AD24", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001AEC")]
	[FieldOffset(Offset = "0x8")]
	private int m_nTotalRound;

	[Token(Token = "0x4001AED")]
	[FieldOffset(Offset = "0xC")]
	private int m_nRound;

	[Token(Token = "0x4001AEE")]
	[FieldOffset(Offset = "0x10")]
	private int m_nCountDown;

	[Token(Token = "0x4001AEF")]
	[FieldOffset(Offset = "0x14")]
	private float m_DelayWaitTime;

	[Token(Token = "0x4001AF0")]
	[FieldOffset(Offset = "0x18")]
	private float m_nCountDownRemainTime;

	[Token(Token = "0x4001AF1")]
	[FieldOffset(Offset = "0x1C")]
	private float delayTime;

	[Token(Token = "0x4001AF2")]
	[FieldOffset(Offset = "0x20")]
	private float remainTime;

	[Token(Token = "0x4001AF3")]
	[FieldOffset(Offset = "0x24")]
	private CSWinlose result_TeamA;

	[Token(Token = "0x4001AF4")]
	[FieldOffset(Offset = "0x28")]
	private CSWinlose result_TeamB;

	[Token(Token = "0x4001AF5")]
	[FieldOffset(Offset = "0x2C")]
	private XKOFState_Play m_PlayState;

	[Token(Token = "0x4001AF6")]
	[FieldOffset(Offset = "0x30")]
	private float syncTime;

	[Token(Token = "0x4001AF7")]
	[FieldOffset(Offset = "0x34")]
	private XModuleActor m_myActor;

	[Token(Token = "0x4001AF8")]
	[FieldOffset(Offset = "0x38")]
	private XModuleActor m_enemyActor;

	[Token(Token = "0x4001AF9")]
	[FieldOffset(Offset = "0x3C")]
	private XTeamEnum m_myTeam;

	[Token(Token = "0x4001AFA")]
	[FieldOffset(Offset = "0x40")]
	private XTeamEnum m_enemyTeam;

	[Token(Token = "0x4001AFB")]
	[FieldOffset(Offset = "0x44")]
	private int m_nLastCountDownSend;

	[Token(Token = "0x1700072F")]
	public int Round
	{
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x1D3ABB4", Offset = "0x1D3ABB4", VA = "0x1D3ABB4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002E74")]
	[Address(RVA = "0x1D385B0", Offset = "0x1D385B0", VA = "0x1D385B0")]
	public XKOFRule()
	{
	}

	[Token(Token = "0x6002E75")]
	[Address(RVA = "0x1D385C8", Offset = "0x1D385C8", VA = "0x1D385C8")]
	public bool GetMyTeamResultWin(XTeamEnum myTeam)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E76")]
	[Address(RVA = "0x1D385FC", Offset = "0x1D385FC", VA = "0x1D385FC")]
	public void Enter(XKOFState_Play playState, int nTotalRound, int nCountDown)
	{
	}

	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x1D38884", Offset = "0x1D38884", VA = "0x1D38884")]
	private void SetActor()
	{
	}

	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x1D38A5C", Offset = "0x1D38A5C", VA = "0x1D38A5C", Slot = "4")]
	public virtual void SendStartRound(int nRound)
	{
	}

	[Token(Token = "0x6002E79")]
	[Address(RVA = "0x1D38BCC", Offset = "0x1D38BCC", VA = "0x1D38BCC", Slot = "5")]
	public virtual void SendRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x1D38D4C", Offset = "0x1D38D4C", VA = "0x1D38D4C")]
	private bool CheckRoundTimeEnd(float fRemainedTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E7B")]
	[Address(RVA = "0x1D38D78", Offset = "0x1D38D78", VA = "0x1D38D78")]
	private void CheckDrawUseHP()
	{
	}

	[Token(Token = "0x6002E7C")]
	[Address(RVA = "0x1D38E74", Offset = "0x1D38E74", VA = "0x1D38E74")]
	public void SetSyncState(int state)
	{
	}

	[Token(Token = "0x6002E7D")]
	[Address(RVA = "0x1D38FEC", Offset = "0x1D38FEC", VA = "0x1D38FEC")]
	public void SetState(int state)
	{
	}

	[Token(Token = "0x6002E7E")]
	[Address(RVA = "0x1D39174", Offset = "0x1D39174", VA = "0x1D39174")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x6002E7F")]
	[Address(RVA = "0x1D39288", Offset = "0x1D39288", VA = "0x1D39288")]
	private void NextRound()
	{
	}

	[Token(Token = "0x6002E80")]
	[Address(RVA = "0x1D392C0", Offset = "0x1D392C0", VA = "0x1D392C0")]
	private bool CheckFinished(int nCurrentRound)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E81")]
	[Address(RVA = "0x1D39440", Offset = "0x1D39440", VA = "0x1D39440")]
	private void RoundStart()
	{
	}

	[Token(Token = "0x6002E82")]
	[Address(RVA = "0x1D394CC", Offset = "0x1D394CC", VA = "0x1D394CC")]
	public void ReviveAllPlayerExceptEscaped()
	{
	}

	[Token(Token = "0x6002E83")]
	[Address(RVA = "0x1D399C8", Offset = "0x1D399C8", VA = "0x1D399C8")]
	public void ReviveTeamExceptEscaped(List<XPlayer> team)
	{
	}

	[Token(Token = "0x6002E84")]
	[Address(RVA = "0x1D39AC8", Offset = "0x1D39AC8", VA = "0x1D39AC8")]
	public void Update(float fRemainedTime)
	{
	}

	[Token(Token = "0x6002E85")]
	[Address(RVA = "0x1D3A1F0", Offset = "0x1D3A1F0", VA = "0x1D3A1F0")]
	private void CountDownMsg(int nTimeRemaining)
	{
	}

	[Token(Token = "0x6002E86")]
	[Address(RVA = "0x1D3A24C", Offset = "0x1D3A24C", VA = "0x1D3A24C")]
	private void SendMsg(int nCount)
	{
	}

	[Token(Token = "0x6002E87")]
	[Address(RVA = "0x1D3A1C8", Offset = "0x1D3A1C8", VA = "0x1D3A1C8")]
	private void RoundEnd()
	{
	}

	[Token(Token = "0x6002E88")]
	[Address(RVA = "0x1D3A58C", Offset = "0x1D3A58C", VA = "0x1D3A58C", Slot = "6")]
	public virtual void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002E89")]
	[Address(RVA = "0x1D3A854", Offset = "0x1D3A854", VA = "0x1D3A854")]
	public bool AllTeamDied(List<XPlayer> team)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E8A")]
	[Address(RVA = "0x1D39F88", Offset = "0x1D39F88", VA = "0x1D39F88")]
	public bool CheckVictimsAndResult()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E8B")]
	[Address(RVA = "0x1D3A780", Offset = "0x1D3A780", VA = "0x1D3A780")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002E8C")]
	[Address(RVA = "0x1D3A988", Offset = "0x1D3A988", VA = "0x1D3A988")]
	public void SendDelayLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002E8D")]
	[Address(RVA = "0x1D3A9CC", Offset = "0x1D3A9CC", VA = "0x1D3A9CC")]
	[DebuggerHidden]
	private IEnumerator DelayRefreshLifeUI()
	{
		return null;
	}

	[Token(Token = "0x6002E8E")]
	[Address(RVA = "0x1D3A470", Offset = "0x1D3A470", VA = "0x1D3A470")]
	private void OrderRoundEnd()
	{
	}

	[Token(Token = "0x6002E8F")]
	[Address(RVA = "0x1D3A22C", Offset = "0x1D3A22C", VA = "0x1D3A22C")]
	private void DoNextRound()
	{
	}

	[Token(Token = "0x6002E90")]
	[Address(RVA = "0x1D3A3D8", Offset = "0x1D3A3D8", VA = "0x1D3A3D8")]
	private void ProcessResult()
	{
	}

	[Token(Token = "0x6002E91")]
	[Address(RVA = "0x1D3AA60", Offset = "0x1D3AA60", VA = "0x1D3AA60")]
	public void SetRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x1D38708", Offset = "0x1D38708", VA = "0x1D38708")]
	public int GetRoundCount()
	{
		return default(int);
	}
}
