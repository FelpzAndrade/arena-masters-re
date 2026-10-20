using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000547")]
public class XAnnihilationRule
{
	[Token(Token = "0x2000548")]
	public enum State
	{
		[Token(Token = "0x4001A63")]
		PLAY = 0,
		[Token(Token = "0x4001A64")]
		ENDROUND = 1,
		[Token(Token = "0x4001A65")]
		NEXTROUND = 2,
		[Token(Token = "0x4001A66")]
		COUNTDOWN = 3,
		[Token(Token = "0x4001A67")]
		GAME_FINISH = 4
	}

	[Token(Token = "0x2000549")]
	private sealed class _003CDelayRefreshLifeUI_003Ec__Iterator50 : IDisposable
	{
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x17000702")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002D0F")]
			[Address(RVA = "0x1EE50E4", Offset = "0x1EE50E4", VA = "0x1EE50E4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000703")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D10")]
			[Address(RVA = "0x1EE50EC", Offset = "0x1EE50EC", VA = "0x1EE50EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x1EE4F94", Offset = "0x1EE4F94", VA = "0x1EE4F94")]
		public _003CDelayRefreshLifeUI_003Ec__Iterator50()
		{
		}

		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x1EE50E4", Offset = "0x1EE50E4", VA = "0x1EE50E4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x1EE50EC", Offset = "0x1EE50EC", VA = "0x1EE50EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D11")]
		[Address(RVA = "0x1EE50F4", Offset = "0x1EE50F4", VA = "0x1EE50F4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x1EE5240", Offset = "0x1EE5240", VA = "0x1EE5240", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x1EE524C", Offset = "0x1EE524C", VA = "0x1EE524C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001A56")]
	[FieldOffset(Offset = "0x8")]
	private int m_nTotalRound;

	[Token(Token = "0x4001A57")]
	[FieldOffset(Offset = "0xC")]
	private int m_nRound;

	[Token(Token = "0x4001A58")]
	[FieldOffset(Offset = "0x10")]
	private int m_nCountDown;

	[Token(Token = "0x4001A59")]
	[FieldOffset(Offset = "0x14")]
	private int m_nLastCountDownSend;

	[Token(Token = "0x4001A5A")]
	[FieldOffset(Offset = "0x18")]
	private float m_DelayWaitTime;

	[Token(Token = "0x4001A5B")]
	[FieldOffset(Offset = "0x1C")]
	private float m_nCountDownRemainTime;

	[Token(Token = "0x4001A5C")]
	[FieldOffset(Offset = "0x20")]
	private float delayTime;

	[Token(Token = "0x4001A5D")]
	[FieldOffset(Offset = "0x24")]
	private float remainTime;

	[Token(Token = "0x4001A5E")]
	[FieldOffset(Offset = "0x28")]
	private CSWinlose result_TeamA;

	[Token(Token = "0x4001A5F")]
	[FieldOffset(Offset = "0x2C")]
	private CSWinlose result_TeamB;

	[Token(Token = "0x4001A60")]
	[FieldOffset(Offset = "0x30")]
	private XAnnihilationState_Play m_PlayState;

	[Token(Token = "0x4001A61")]
	[FieldOffset(Offset = "0x34")]
	private float syncTime;

	[Token(Token = "0x17000701")]
	public int Round
	{
		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0x1EE50DC", Offset = "0x1EE50DC", VA = "0x1EE50DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x1EE3098", Offset = "0x1EE3098", VA = "0x1EE3098")]
	public XAnnihilationRule()
	{
	}

	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x1EE30B0", Offset = "0x1EE30B0", VA = "0x1EE30B0")]
	public void Enter(XAnnihilationState_Play playState, int nTotalRound, int nCountDown)
	{
	}

	[Token(Token = "0x6002CF3")]
	[Address(RVA = "0x1EE3258", Offset = "0x1EE3258", VA = "0x1EE3258", Slot = "4")]
	public virtual void SendStartRound(int nRound)
	{
	}

	[Token(Token = "0x6002CF4")]
	[Address(RVA = "0x1EE33C8", Offset = "0x1EE33C8", VA = "0x1EE33C8", Slot = "5")]
	public virtual void SendRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002CF5")]
	[Address(RVA = "0x1EE3548", Offset = "0x1EE3548", VA = "0x1EE3548")]
	private bool CheckRoundTimeEnd(float fRemainedTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x1EE356C", Offset = "0x1EE356C", VA = "0x1EE356C")]
	public void SetSyncState(int state)
	{
	}

	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x1EE36E4", Offset = "0x1EE36E4", VA = "0x1EE36E4")]
	public void SetState(int state)
	{
	}

	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x1EE386C", Offset = "0x1EE386C", VA = "0x1EE386C")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x6002CF9")]
	[Address(RVA = "0x1EE3980", Offset = "0x1EE3980", VA = "0x1EE3980")]
	private void NextRound()
	{
	}

	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x1EE39B8", Offset = "0x1EE39B8", VA = "0x1EE39B8")]
	private bool CheckFinished(int nCurrentRound)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x1EE3B38", Offset = "0x1EE3B38", VA = "0x1EE3B38")]
	private void RoundStart()
	{
	}

	[Token(Token = "0x6002CFC")]
	[Address(RVA = "0x1EE3BC4", Offset = "0x1EE3BC4", VA = "0x1EE3BC4")]
	public void ReviveAllPlayerExceptEscaped()
	{
	}

	[Token(Token = "0x6002CFD")]
	[Address(RVA = "0x1EE40A8", Offset = "0x1EE40A8", VA = "0x1EE40A8")]
	public void ReviveTeamExceptEscaped(List<XPlayer> team)
	{
	}

	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x1EE41A8", Offset = "0x1EE41A8", VA = "0x1EE41A8")]
	public void Update(float fRemainedTime)
	{
	}

	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x1EE472C", Offset = "0x1EE472C", VA = "0x1EE472C")]
	private void CountDownMsg(int nTimeRemaining)
	{
	}

	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x1EE4788", Offset = "0x1EE4788", VA = "0x1EE4788")]
	private void SendMsg(int nCount)
	{
	}

	[Token(Token = "0x6002D01")]
	[Address(RVA = "0x1EE4704", Offset = "0x1EE4704", VA = "0x1EE4704")]
	private void RoundEnd()
	{
	}

	[Token(Token = "0x6002D02")]
	[Address(RVA = "0x1EE4AC8", Offset = "0x1EE4AC8", VA = "0x1EE4AC8", Slot = "6")]
	public virtual void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002D03")]
	[Address(RVA = "0x1EE4D90", Offset = "0x1EE4D90", VA = "0x1EE4D90")]
	public bool AllTeamDied(List<XPlayer> team)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D04")]
	[Address(RVA = "0x1EE4478", Offset = "0x1EE4478", VA = "0x1EE4478")]
	public CSWinlose CheckVictimsAndResult()
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x6002D05")]
	[Address(RVA = "0x1EE4CBC", Offset = "0x1EE4CBC", VA = "0x1EE4CBC")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002D06")]
	[Address(RVA = "0x1EE4EC4", Offset = "0x1EE4EC4", VA = "0x1EE4EC4")]
	public void SendDelayLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002D07")]
	[Address(RVA = "0x1EE4F08", Offset = "0x1EE4F08", VA = "0x1EE4F08")]
	[DebuggerHidden]
	private IEnumerator DelayRefreshLifeUI()
	{
		return null;
	}

	[Token(Token = "0x6002D08")]
	[Address(RVA = "0x1EE49AC", Offset = "0x1EE49AC", VA = "0x1EE49AC")]
	private void OrderRoundEnd()
	{
	}

	[Token(Token = "0x6002D09")]
	[Address(RVA = "0x1EE4768", Offset = "0x1EE4768", VA = "0x1EE4768")]
	private void DoNextRound()
	{
	}

	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x1EE4914", Offset = "0x1EE4914", VA = "0x1EE4914")]
	private void ProcessResult()
	{
	}

	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x1EE4F9C", Offset = "0x1EE4F9C", VA = "0x1EE4F9C")]
	public void SetRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x1EE30DC", Offset = "0x1EE30DC", VA = "0x1EE30DC")]
	public int GetRoundCount()
	{
		return default(int);
	}
}
