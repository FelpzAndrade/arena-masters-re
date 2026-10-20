using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000553")]
public class XGameModeAnnihilation : XGameModePVP
{
	[Token(Token = "0x2000554")]
	private sealed class _003CChangeTeamSpectatorMode_003Ec__Iterator55 : IDisposable
	{
		[Token(Token = "0x4001A8B")]
		[FieldOffset(Offset = "0x8")]
		internal XAnnihilationState_Play _003CstatePlay_003E__0;

		[Token(Token = "0x4001A8C")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001A8D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001A8E")]
		[FieldOffset(Offset = "0x14")]
		internal XGameModeAnnihilation _003C_003Ef__this;

		[Token(Token = "0x17000710")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002D6F")]
			[Address(RVA = "0x14013E0", Offset = "0x14013E0", VA = "0x14013E0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000711")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002D70")]
			[Address(RVA = "0x14013E8", Offset = "0x14013E8", VA = "0x14013E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002D6E")]
		[Address(RVA = "0x13FF644", Offset = "0x13FF644", VA = "0x13FF644")]
		public _003CChangeTeamSpectatorMode_003Ec__Iterator55()
		{
		}

		[Token(Token = "0x6002D6F")]
		[Address(RVA = "0x14013E0", Offset = "0x14013E0", VA = "0x14013E0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D70")]
		[Address(RVA = "0x14013E8", Offset = "0x14013E8", VA = "0x14013E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002D71")]
		[Address(RVA = "0x14013F0", Offset = "0x14013F0", VA = "0x14013F0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002D72")]
		[Address(RVA = "0x1401608", Offset = "0x1401608", VA = "0x1401608", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002D73")]
		[Address(RVA = "0x1401614", Offset = "0x1401614", VA = "0x1401614", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001A8A")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x1700070E")]
	public int CurrentRound
	{
		[Token(Token = "0x6002D6A")]
		[Address(RVA = "0x1400F0C", Offset = "0x1400F0C", VA = "0x1400F0C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700070F")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002D6D")]
		[Address(RVA = "0x1401314", Offset = "0x1401314", VA = "0x1401314")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002D5A")]
	[Address(RVA = "0x13FEFF0", Offset = "0x13FEFF0", VA = "0x13FEFF0")]
	public XGameModeAnnihilation(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x13FF0E8", Offset = "0x13FF0E8", VA = "0x13FF0E8", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x13FF354", Offset = "0x13FF354", VA = "0x13FF354", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x13FF5A0", Offset = "0x13FF5A0", VA = "0x13FF5A0")]
	[DebuggerHidden]
	private IEnumerator ChangeTeamSpectatorMode()
	{
		return null;
	}

	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x13FF64C", Offset = "0x13FF64C", VA = "0x13FF64C", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x13FF720", Offset = "0x13FF720", VA = "0x13FF720")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002D60")]
	[Address(RVA = "0x13FF7E4", Offset = "0x13FF7E4", VA = "0x13FF7E4")]
	public void StartRound(int nRound)
	{
	}

	[Token(Token = "0x6002D61")]
	[Address(RVA = "0x13FF8B4", Offset = "0x13FF8B4", VA = "0x13FF8B4")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x13FF980", Offset = "0x13FF980", VA = "0x13FF980")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6002D63")]
	[Address(RVA = "0x13FFA4C", Offset = "0x13FFA4C", VA = "0x13FFA4C")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x6002D64")]
	[Address(RVA = "0x13FFB10", Offset = "0x13FFB10", VA = "0x13FFB10")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002D65")]
	[Address(RVA = "0x13FFDF0", Offset = "0x13FFDF0", VA = "0x13FFDF0")]
	private void ShowRoundResult(CSWinlose state)
	{
	}

	[Token(Token = "0x6002D66")]
	[Address(RVA = "0x1400084", Offset = "0x1400084", VA = "0x1400084", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002D67")]
	[Address(RVA = "0x1400220", Offset = "0x1400220", VA = "0x1400220", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002D68")]
	[Address(RVA = "0x14007E0", Offset = "0x14007E0", VA = "0x14007E0", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002D69")]
	[Address(RVA = "0x1400DF8", Offset = "0x1400DF8", VA = "0x1400DF8", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002D6B")]
	[Address(RVA = "0x1400FD8", Offset = "0x1400FD8", VA = "0x1400FD8", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0x1401010", Offset = "0x1401010", VA = "0x1401010", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAID)
	{
	}
}
