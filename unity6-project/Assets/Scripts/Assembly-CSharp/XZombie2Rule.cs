using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005E2")]
public class XZombie2Rule
{
	[Token(Token = "0x20005E3")]
	public enum State
	{
		[Token(Token = "0x4001C70")]
		PLAY = 0,
		[Token(Token = "0x4001C71")]
		ENDROUND = 1,
		[Token(Token = "0x4001C72")]
		NEXTROUND = 2,
		[Token(Token = "0x4001C73")]
		COUNTDOWN = 3,
		[Token(Token = "0x4001C74")]
		GAME_FINISH = 4
	}

	[Token(Token = "0x20005E4")]
	private sealed class _003CDelayRefreshLifeUI_003Ec__Iterator68 : IDisposable
	{
		[Token(Token = "0x4001C75")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001C76")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x17000786")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003247")]
			[Address(RVA = "0x1B36A50", Offset = "0x1B36A50", VA = "0x1B36A50", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000787")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003248")]
			[Address(RVA = "0x1B36A58", Offset = "0x1B36A58", VA = "0x1B36A58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003246")]
		[Address(RVA = "0x1B36900", Offset = "0x1B36900", VA = "0x1B36900")]
		public _003CDelayRefreshLifeUI_003Ec__Iterator68()
		{
		}

		[Token(Token = "0x6003247")]
		[Address(RVA = "0x1B36A50", Offset = "0x1B36A50", VA = "0x1B36A50", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003248")]
		[Address(RVA = "0x1B36A58", Offset = "0x1B36A58", VA = "0x1B36A58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003249")]
		[Address(RVA = "0x1B36A60", Offset = "0x1B36A60", VA = "0x1B36A60", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600324A")]
		[Address(RVA = "0x1B36BAC", Offset = "0x1B36BAC", VA = "0x1B36BAC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600324B")]
		[Address(RVA = "0x1B36BB8", Offset = "0x1B36BB8", VA = "0x1B36BB8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001C63")]
	[FieldOffset(Offset = "0x8")]
	private int m_nTotalRound;

	[Token(Token = "0x4001C64")]
	[FieldOffset(Offset = "0xC")]
	private int m_nRound;

	[Token(Token = "0x4001C65")]
	[FieldOffset(Offset = "0x10")]
	private int m_nCountDown;

	[Token(Token = "0x4001C66")]
	[FieldOffset(Offset = "0x14")]
	private int m_nLastCountDownSend;

	[Token(Token = "0x4001C67")]
	[FieldOffset(Offset = "0x18")]
	private float m_DelayWaitTime;

	[Token(Token = "0x4001C68")]
	[FieldOffset(Offset = "0x1C")]
	private float m_nCountDownRemainTime;

	[Token(Token = "0x4001C69")]
	[FieldOffset(Offset = "0x20")]
	private float delayTime;

	[Token(Token = "0x4001C6A")]
	[FieldOffset(Offset = "0x24")]
	private float remainTime;

	[Token(Token = "0x4001C6B")]
	[FieldOffset(Offset = "0x28")]
	private CSWinlose result_TeamA;

	[Token(Token = "0x4001C6C")]
	[FieldOffset(Offset = "0x2C")]
	private CSWinlose result_TeamB;

	[Token(Token = "0x4001C6D")]
	[FieldOffset(Offset = "0x30")]
	private XZombie2State_Play m_PlayState;

	[Token(Token = "0x4001C6E")]
	[FieldOffset(Offset = "0x34")]
	private float syncTime;

	[Token(Token = "0x17000785")]
	public int Round
	{
		[Token(Token = "0x6003245")]
		[Address(RVA = "0x1B36A48", Offset = "0x1B36A48", VA = "0x1B36A48")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6003229")]
	[Address(RVA = "0x1B34CF4", Offset = "0x1B34CF4", VA = "0x1B34CF4")]
	public XZombie2Rule()
	{
	}

	[Token(Token = "0x600322A")]
	[Address(RVA = "0x1B34D0C", Offset = "0x1B34D0C", VA = "0x1B34D0C")]
	public void Enter(XZombie2State_Play playState, int nTotalRound, int nCountDown)
	{
	}

	[Token(Token = "0x600322B")]
	[Address(RVA = "0x1B34EB4", Offset = "0x1B34EB4", VA = "0x1B34EB4", Slot = "4")]
	public virtual void SendStartRound(int nRound)
	{
	}

	[Token(Token = "0x600322C")]
	[Address(RVA = "0x1B35024", Offset = "0x1B35024", VA = "0x1B35024", Slot = "5")]
	public virtual void SendRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x600322D")]
	[Address(RVA = "0x1B351A4", Offset = "0x1B351A4", VA = "0x1B351A4")]
	private bool CheckRoundTimeEnd(float fRemainedTime)
	{
		return default(bool);
	}

	[Token(Token = "0x600322E")]
	[Address(RVA = "0x1B351C8", Offset = "0x1B351C8", VA = "0x1B351C8")]
	public void SetSyncState(int state)
	{
	}

	[Token(Token = "0x600322F")]
	[Address(RVA = "0x1B35340", Offset = "0x1B35340", VA = "0x1B35340")]
	public void SetState(int state)
	{
	}

	[Token(Token = "0x6003230")]
	[Address(RVA = "0x1B354C8", Offset = "0x1B354C8", VA = "0x1B354C8")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x6003231")]
	[Address(RVA = "0x1B355DC", Offset = "0x1B355DC", VA = "0x1B355DC")]
	private void NextRound()
	{
	}

	[Token(Token = "0x6003232")]
	[Address(RVA = "0x1B35614", Offset = "0x1B35614", VA = "0x1B35614")]
	private bool CheckFinished(int nCurrentRound)
	{
		return default(bool);
	}

	[Token(Token = "0x6003233")]
	[Address(RVA = "0x1B35794", Offset = "0x1B35794", VA = "0x1B35794")]
	private void RoundStart()
	{
	}

	[Token(Token = "0x6003234")]
	[Address(RVA = "0x1B35824", Offset = "0x1B35824", VA = "0x1B35824")]
	public void ReviveAllPlayerExceptEscaped()
	{
	}

	[Token(Token = "0x6003235")]
	[Address(RVA = "0x1B35A14", Offset = "0x1B35A14", VA = "0x1B35A14")]
	public void ReviveTeamExceptEscaped(List<XPlayer> team)
	{
	}

	[Token(Token = "0x6003236")]
	[Address(RVA = "0x1B35B14", Offset = "0x1B35B14", VA = "0x1B35B14")]
	public void Update(float fRemainedTime)
	{
	}

	[Token(Token = "0x6003237")]
	[Address(RVA = "0x1B36098", Offset = "0x1B36098", VA = "0x1B36098")]
	private void CountDownMsg(int nTimeRemaining)
	{
	}

	[Token(Token = "0x6003238")]
	[Address(RVA = "0x1B360F4", Offset = "0x1B360F4", VA = "0x1B360F4")]
	private void SendMsg(int nCount)
	{
	}

	[Token(Token = "0x6003239")]
	[Address(RVA = "0x1B36070", Offset = "0x1B36070", VA = "0x1B36070")]
	private void RoundEnd()
	{
	}

	[Token(Token = "0x600323A")]
	[Address(RVA = "0x1B36434", Offset = "0x1B36434", VA = "0x1B36434", Slot = "6")]
	public virtual void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x600323B")]
	[Address(RVA = "0x1B366FC", Offset = "0x1B366FC", VA = "0x1B366FC")]
	public bool AllTeamDied(List<XPlayer> team)
	{
		return default(bool);
	}

	[Token(Token = "0x600323C")]
	[Address(RVA = "0x1B35DE4", Offset = "0x1B35DE4", VA = "0x1B35DE4")]
	public CSWinlose CheckVictimsAndResult()
	{
		return default(CSWinlose);
	}

	[Token(Token = "0x600323D")]
	[Address(RVA = "0x1B36628", Offset = "0x1B36628", VA = "0x1B36628")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x600323E")]
	[Address(RVA = "0x1B36830", Offset = "0x1B36830", VA = "0x1B36830")]
	public void SendDelayLoseLifePlayer()
	{
	}

	[Token(Token = "0x600323F")]
	[Address(RVA = "0x1B36874", Offset = "0x1B36874", VA = "0x1B36874")]
	[DebuggerHidden]
	private IEnumerator DelayRefreshLifeUI()
	{
		return null;
	}

	[Token(Token = "0x6003240")]
	[Address(RVA = "0x1B36318", Offset = "0x1B36318", VA = "0x1B36318")]
	private void OrderRoundEnd()
	{
	}

	[Token(Token = "0x6003241")]
	[Address(RVA = "0x1B360D4", Offset = "0x1B360D4", VA = "0x1B360D4")]
	private void DoNextRound()
	{
	}

	[Token(Token = "0x6003242")]
	[Address(RVA = "0x1B36280", Offset = "0x1B36280", VA = "0x1B36280")]
	private void ProcessResult()
	{
	}

	[Token(Token = "0x6003243")]
	[Address(RVA = "0x1B36908", Offset = "0x1B36908", VA = "0x1B36908")]
	public void SetRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6003244")]
	[Address(RVA = "0x1B34D38", Offset = "0x1B34D38", VA = "0x1B34D38")]
	public int GetRoundCount()
	{
		return default(int);
	}
}
