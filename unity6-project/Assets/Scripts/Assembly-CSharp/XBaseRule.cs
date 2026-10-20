using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000555")]
public class XBaseRule
{
	[Token(Token = "0x2000556")]
	public enum State
	{
		[Token(Token = "0x4001A9B")]
		PLAY = 0,
		[Token(Token = "0x4001A9C")]
		ENDROUND = 1,
		[Token(Token = "0x4001A9D")]
		NEXTROUND = 2,
		[Token(Token = "0x4001A9E")]
		COUNTDOWN = 3,
		[Token(Token = "0x4001A9F")]
		GAME_FINISH = 4
	}

	[Token(Token = "0x2000557")]
	private sealed class _003CDelayRefreshLifeUI_003Ec__Iterator56 : IDisposable
	{
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x17000713")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002D94")]
			[Address(RVA = "0x1EFF0F4", Offset = "0x1EFF0F4", VA = "0x1EFF0F4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000714")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D95")]
			[Address(RVA = "0x1EFF0FC", Offset = "0x1EFF0FC", VA = "0x1EFF0FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D93")]
		[Address(RVA = "0x1EFF0EC", Offset = "0x1EFF0EC", VA = "0x1EFF0EC")]
		public _003CDelayRefreshLifeUI_003Ec__Iterator56()
		{
		}

		[Token(Token = "0x6002D94")]
		[Address(RVA = "0x1EFF0F4", Offset = "0x1EFF0F4", VA = "0x1EFF0F4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D95")]
		[Address(RVA = "0x1EFF0FC", Offset = "0x1EFF0FC", VA = "0x1EFF0FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D96")]
		[Address(RVA = "0x1EFF104", Offset = "0x1EFF104", VA = "0x1EFF104", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D97")]
		[Address(RVA = "0x1EFF250", Offset = "0x1EFF250", VA = "0x1EFF250", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002D98")]
		[Address(RVA = "0x1EFF25C", Offset = "0x1EFF25C", VA = "0x1EFF25C", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001A8F")]
	[FieldOffset(Offset = "0x8")]
	protected int m_nTotalRound;

	[Token(Token = "0x4001A90")]
	[FieldOffset(Offset = "0xC")]
	protected int m_nRound;

	[Token(Token = "0x4001A91")]
	[FieldOffset(Offset = "0x10")]
	protected int m_nCountDown;

	[Token(Token = "0x4001A92")]
	[FieldOffset(Offset = "0x14")]
	protected int m_nLastCountDownSend;

	[Token(Token = "0x4001A93")]
	[FieldOffset(Offset = "0x18")]
	protected float m_DelayWaitTime;

	[Token(Token = "0x4001A94")]
	[FieldOffset(Offset = "0x1C")]
	protected float m_nCountDownRemainTime;

	[Token(Token = "0x4001A95")]
	[FieldOffset(Offset = "0x20")]
	protected float delayTime;

	[Token(Token = "0x4001A96")]
	[FieldOffset(Offset = "0x24")]
	protected float remainTime;

	[Token(Token = "0x4001A97")]
	[FieldOffset(Offset = "0x28")]
	protected CSWinlose result_TeamA;

	[Token(Token = "0x4001A98")]
	[FieldOffset(Offset = "0x2C")]
	protected CSWinlose result_TeamB;

	[Token(Token = "0x4001A99")]
	[FieldOffset(Offset = "0x30")]
	protected float syncTime;

	[Token(Token = "0x17000712")]
	public int Round
	{
		[Token(Token = "0x6002D7D")]
		[Address(RVA = "0x1EFDE10", Offset = "0x1EFDE10", VA = "0x1EFDE10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002D74")]
	[Address(RVA = "0x1EFD5F4", Offset = "0x1EFD5F4", VA = "0x1EFD5F4")]
	public XBaseRule()
	{
	}

	[Token(Token = "0x6002D75")]
	[Address(RVA = "0x1EFD60C", Offset = "0x1EFD60C", VA = "0x1EFD60C", Slot = "4")]
	protected virtual void OnEnter(int nTotalRound, int nCountDown)
	{
	}

	[Token(Token = "0x6002D76")]
	[Address(RVA = "0x1EFD7B0", Offset = "0x1EFD7B0", VA = "0x1EFD7B0", Slot = "5")]
	public virtual void SendStartRound(int nRound)
	{
	}

	[Token(Token = "0x6002D77")]
	[Address(RVA = "0x1EFD920", Offset = "0x1EFD920", VA = "0x1EFD920", Slot = "6")]
	public virtual void SendRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002D78")]
	[Address(RVA = "0x1EFDAA0", Offset = "0x1EFDAA0", VA = "0x1EFDAA0")]
	protected bool CheckRoundTimeEnd(float fRemainedTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D79")]
	[Address(RVA = "0x1EFDAC4", Offset = "0x1EFDAC4", VA = "0x1EFDAC4")]
	public void SetState(int state)
	{
	}

	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0x1EFDC14", Offset = "0x1EFDC14", VA = "0x1EFDC14", Slot = "7")]
	protected virtual void OnSetState(int state)
	{
	}

	[Token(Token = "0x6002D7B")]
	[Address(RVA = "0x1EFDCFC", Offset = "0x1EFDCFC", VA = "0x1EFDCFC")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x6002D7C")]
	[Address(RVA = "0x1EFD634", Offset = "0x1EFD634", VA = "0x1EFD634")]
	public int GetRoundCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002D7E")]
	[Address(RVA = "0x1EFDE18", Offset = "0x1EFDE18", VA = "0x1EFDE18")]
	public void SetSyncState(int state)
	{
	}

	[Token(Token = "0x6002D7F")]
	[Address(RVA = "0x1EFDF98", Offset = "0x1EFDF98", VA = "0x1EFDF98")]
	protected void NextRound()
	{
	}

	[Token(Token = "0x6002D80")]
	[Address(RVA = "0x1EFE098", Offset = "0x1EFE098", VA = "0x1EFE098", Slot = "8")]
	protected virtual bool CheckFinished(int nCurrentRound)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D81")]
	[Address(RVA = "0x1EFDFFC", Offset = "0x1EFDFFC", VA = "0x1EFDFFC")]
	protected void RoundStart()
	{
	}

	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x1EFE408", Offset = "0x1EFE408", VA = "0x1EFE408", Slot = "9")]
	protected virtual void OnRoundStart(int nRound)
	{
	}

	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x1EFE218", Offset = "0x1EFE218", VA = "0x1EFE218")]
	public void ReviveAllPlayerExceptEscaped()
	{
	}

	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x1EFE40C", Offset = "0x1EFE40C", VA = "0x1EFE40C")]
	public void ReviveTeamExceptEscaped(List<XPlayer> team)
	{
	}

	[Token(Token = "0x6002D85")]
	[Address(RVA = "0x1EFE50C", Offset = "0x1EFE50C", VA = "0x1EFE50C", Slot = "10")]
	protected virtual void OnUpdate(float fDeltaTime, float fRemainedTime)
	{
	}

	[Token(Token = "0x6002D86")]
	[Address(RVA = "0x1EFE510", Offset = "0x1EFE510", VA = "0x1EFE510")]
	public void Update(float fDeltaTime, float fRemainedTime)
	{
	}

	[Token(Token = "0x6002D87")]
	[Address(RVA = "0x1EFE820", Offset = "0x1EFE820", VA = "0x1EFE820")]
	protected void CountDownMsg(int nTimeRemaining)
	{
	}

	[Token(Token = "0x6002D88")]
	[Address(RVA = "0x1EFE8A4", Offset = "0x1EFE8A4", VA = "0x1EFE8A4", Slot = "11")]
	protected virtual void SendMsg(int nCount)
	{
	}

	[Token(Token = "0x6002D89")]
	[Address(RVA = "0x1EFE7F8", Offset = "0x1EFE7F8", VA = "0x1EFE7F8")]
	protected void RoundEnd()
	{
	}

	[Token(Token = "0x6002D8A")]
	[Address(RVA = "0x1EFEAC8", Offset = "0x1EFEAC8", VA = "0x1EFEAC8")]
	private void OrderRoundEnd()
	{
	}

	[Token(Token = "0x6002D8B")]
	[Address(RVA = "0x1EFE884", Offset = "0x1EFE884", VA = "0x1EFE884")]
	private void DoNextRound()
	{
	}

	[Token(Token = "0x6002D8C")]
	[Address(RVA = "0x1EFEC0C", Offset = "0x1EFEC0C", VA = "0x1EFEC0C", Slot = "12")]
	public virtual void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002D8D")]
	[Address(RVA = "0x1EFEED4", Offset = "0x1EFEED4", VA = "0x1EFEED4", Slot = "13")]
	public virtual CSWinlose CheckRoundVictimsAndResult()
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x6002D8E")]
	[Address(RVA = "0x1EFEE00", Offset = "0x1EFEE00", VA = "0x1EFEE00")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002D8F")]
	[Address(RVA = "0x1EFEA30", Offset = "0x1EFEA30", VA = "0x1EFEA30")]
	private void ProcessResult()
	{
	}

	[Token(Token = "0x6002D90")]
	[Address(RVA = "0x1EFEEDC", Offset = "0x1EFEEDC", VA = "0x1EFEEDC")]
	public void SetRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002D91")]
	[Address(RVA = "0x1EFF01C", Offset = "0x1EFF01C", VA = "0x1EFF01C")]
	public void SendDelayLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002D92")]
	[Address(RVA = "0x1EFF060", Offset = "0x1EFF060", VA = "0x1EFF060")]
	[DebuggerHidden]
	private IEnumerator DelayRefreshLifeUI()
	{
		return null;
	}
}
