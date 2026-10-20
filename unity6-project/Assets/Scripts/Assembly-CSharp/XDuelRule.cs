using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200056A")]
public class XDuelRule
{
	[Token(Token = "0x200056B")]
	private class RoundPlayerData
	{
		[Token(Token = "0x4001AD2")]
		[FieldOffset(Offset = "0x8")]
		public int PhotonID;

		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0xC")]
		public CSWinlose[] RoundResult;

		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x19AA4B8", Offset = "0x19AA4B8", VA = "0x19AA4B8")]
		public RoundPlayerData()
		{
		}
	}

	[Token(Token = "0x200056C")]
	private sealed class _003CDoRoundFinished_003Ec__Iterator5C : IDisposable
	{
		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0x8")]
		internal float fDelayTime;

		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x14")]
		internal float _003C_0024_003EfDelayTime;

		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x18")]
		internal XDuelRule _003C_003Ef__this;

		[Token(Token = "0x17000725")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002E24")]
			[Address(RVA = "0x19AC030", Offset = "0x19AC030", VA = "0x19AC030", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000726")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E25")]
			[Address(RVA = "0x19AC038", Offset = "0x19AC038", VA = "0x19AC038", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002E23")]
		[Address(RVA = "0x19AB3DC", Offset = "0x19AB3DC", VA = "0x19AB3DC")]
		public _003CDoRoundFinished_003Ec__Iterator5C()
		{
		}

		[Token(Token = "0x6002E24")]
		[Address(RVA = "0x19AC030", Offset = "0x19AC030", VA = "0x19AC030", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E25")]
		[Address(RVA = "0x19AC038", Offset = "0x19AC038", VA = "0x19AC038", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x19AC040", Offset = "0x19AC040", VA = "0x19AC040", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E27")]
		[Address(RVA = "0x19AC14C", Offset = "0x19AC14C", VA = "0x19AC14C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x19AC158", Offset = "0x19AC158", VA = "0x19AC158", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001AC8")]
	[FieldOffset(Offset = "0x8")]
	private int m_nTotalRound;

	[Token(Token = "0x4001AC9")]
	[FieldOffset(Offset = "0xC")]
	private int m_nRound;

	[Token(Token = "0x4001ACA")]
	[FieldOffset(Offset = "0x10")]
	private bool m_bRoundFinished;

	[Token(Token = "0x4001ACB")]
	[FieldOffset(Offset = "0x11")]
	private bool m_bGameFinished;

	[Token(Token = "0x4001ACC")]
	[FieldOffset(Offset = "0x12")]
	private bool m_bDied;

	[Token(Token = "0x4001ACD")]
	[FieldOffset(Offset = "0x14")]
	private XDuelState_Play m_PlayState;

	[Token(Token = "0x4001ACE")]
	[FieldOffset(Offset = "0x18")]
	private List<int> m_VictimsInRound;

	[Token(Token = "0x4001ACF")]
	[FieldOffset(Offset = "0x1C")]
	private int m_CountDown;

	[Token(Token = "0x4001AD0")]
	[FieldOffset(Offset = "0x20")]
	private int m_lastSend;

	[Token(Token = "0x4001AD1")]
	[FieldOffset(Offset = "0x24")]
	private RoundPlayerData[] m_PlayerData;

	[Token(Token = "0x17000723")]
	public int Round
	{
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x19AC020", Offset = "0x19AC020", VA = "0x19AC020")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000724")]
	public bool GameFinished
	{
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x19AC028", Offset = "0x19AC028", VA = "0x19AC028")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x19AA2F8", Offset = "0x19AA2F8", VA = "0x19AA2F8")]
	public XDuelRule()
	{
	}

	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x19AA5C0", Offset = "0x19AA5C0", VA = "0x19AA5C0")]
	public void Enter(XDuelState_Play playState, int nTotalRound, int nCountDown)
	{
	}

	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x19AA7FC", Offset = "0x19AA7FC", VA = "0x19AA7FC", Slot = "4")]
	public virtual void SendStartRound(int nRound)
	{
	}

	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x19AA96C", Offset = "0x19AA96C", VA = "0x19AA96C", Slot = "5")]
	public virtual void SendRoundResult(int nRound, int nPhotonID_0, CSWinlose result_0, int nPhotonID_1, CSWinlose result_1)
	{
	}

	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x19AAB10", Offset = "0x19AAB10", VA = "0x19AAB10")]
	private bool CheckToNextRound()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E13")]
	[Address(RVA = "0x19AAB18", Offset = "0x19AAB18", VA = "0x19AAB18")]
	private bool CheckRoundTime(float fRemainedTime)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x19AAB30", Offset = "0x19AAB30", VA = "0x19AAB30")]
	private void NextRound()
	{
	}

	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x19AAB7C", Offset = "0x19AAB7C", VA = "0x19AAB7C")]
	private bool CheckFinished(int nCurrentRound)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E16")]
	[Address(RVA = "0x19AACB4", Offset = "0x19AACB4", VA = "0x19AACB4")]
	private void RoundStart()
	{
	}

	[Token(Token = "0x6002E17")]
	[Address(RVA = "0x19AAF84", Offset = "0x19AAF84", VA = "0x19AAF84")]
	public void Update(float fRemainedTime)
	{
	}

	[Token(Token = "0x6002E18")]
	[Address(RVA = "0x19AB044", Offset = "0x19AB044", VA = "0x19AB044")]
	private void CountDownMsg(int nTimeRemaining)
	{
	}

	[Token(Token = "0x6002E19")]
	[Address(RVA = "0x19AB08C", Offset = "0x19AB08C", VA = "0x19AB08C")]
	private void SendMsg(int nCount)
	{
	}

	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x19AB22C", Offset = "0x19AB22C", VA = "0x19AB22C", Slot = "6")]
	public virtual void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0x19AB328", Offset = "0x19AB328", VA = "0x19AB328")]
	[DebuggerHidden]
	private IEnumerator DoRoundFinished(float fDelayTime)
	{
		return null;
	}

	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0x19AB010", Offset = "0x19AB010", VA = "0x19AB010")]
	private void DoRoundFinished()
	{
	}

	[Token(Token = "0x6002E1D")]
	[Address(RVA = "0x19AA5E8", Offset = "0x19AA5E8", VA = "0x19AA5E8")]
	private void InitPlayerData()
	{
	}

	[Token(Token = "0x6002E1E")]
	[Address(RVA = "0x19AB3E4", Offset = "0x19AB3E4", VA = "0x19AB3E4")]
	private void ProcessResult()
	{
	}

	[Token(Token = "0x6002E1F")]
	[Address(RVA = "0x19ABA1C", Offset = "0x19ABA1C", VA = "0x19ABA1C")]
	private XTeamEnum GetRoundWinTeam(int LoserPhotonID)
	{
		return default(XTeamEnum);
	}
}
