using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000574")]
public class XGameModeKOF : XGameModePVP
{
	[Token(Token = "0x2000575")]
	private sealed class _003CChangeTeamSpectatorMode_003Ec__Iterator5D : IDisposable
	{
		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0x8")]
		internal XPVPGameModeState_Play _003CstatePlay_003E__0;

		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x14")]
		internal XGameModeKOF _003C_003Ef__this;

		[Token(Token = "0x1700072D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002E6F")]
			[Address(RVA = "0x140C3EC", Offset = "0x140C3EC", VA = "0x140C3EC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700072E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E70")]
			[Address(RVA = "0x140C3F4", Offset = "0x140C3F4", VA = "0x140C3F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002E6E")]
		[Address(RVA = "0x140AFFC", Offset = "0x140AFFC", VA = "0x140AFFC")]
		public _003CChangeTeamSpectatorMode_003Ec__Iterator5D()
		{
		}

		[Token(Token = "0x6002E6F")]
		[Address(RVA = "0x140C3EC", Offset = "0x140C3EC", VA = "0x140C3EC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E70")]
		[Address(RVA = "0x140C3F4", Offset = "0x140C3F4", VA = "0x140C3F4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E71")]
		[Address(RVA = "0x140C3FC", Offset = "0x140C3FC", VA = "0x140C3FC", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E72")]
		[Address(RVA = "0x140C63C", Offset = "0x140C63C", VA = "0x140C63C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002E73")]
		[Address(RVA = "0x140C648", Offset = "0x140C648", VA = "0x140C648", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x1700072B")]
	public int CurrentRound
	{
		[Token(Token = "0x6002E6A")]
		[Address(RVA = "0x140BECC", Offset = "0x140BECC", VA = "0x140BECC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700072C")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002E6D")]
		[Address(RVA = "0x140C2D4", Offset = "0x140C2D4", VA = "0x140C2D4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002E59")]
	[Address(RVA = "0x1407440", Offset = "0x1407440", VA = "0x1407440")]
	public XGameModeKOF(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002E5A")]
	[Address(RVA = "0x140AC90", Offset = "0x140AC90", VA = "0x140AC90", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002E5B")]
	[Address(RVA = "0x140AEFC", Offset = "0x140AEFC", VA = "0x140AEFC", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002E5C")]
	[Address(RVA = "0x140AF58", Offset = "0x140AF58", VA = "0x140AF58")]
	[DebuggerHidden]
	private IEnumerator ChangeTeamSpectatorMode()
	{
		return null;
	}

	[Token(Token = "0x6002E5D")]
	[Address(RVA = "0x140B004", Offset = "0x140B004", VA = "0x140B004", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002E5E")]
	[Address(RVA = "0x140B0D8", Offset = "0x140B0D8", VA = "0x140B0D8")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002E5F")]
	[Address(RVA = "0x140B19C", Offset = "0x140B19C", VA = "0x140B19C")]
	public void StartRound(int nRound)
	{
	}

	[Token(Token = "0x6002E60")]
	[Address(RVA = "0x140B26C", Offset = "0x140B26C", VA = "0x140B26C")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6002E61")]
	[Address(RVA = "0x140B338", Offset = "0x140B338", VA = "0x140B338")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6002E62")]
	[Address(RVA = "0x140B404", Offset = "0x140B404", VA = "0x140B404")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x6002E63")]
	[Address(RVA = "0x140B4C8", Offset = "0x140B4C8", VA = "0x140B4C8")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002E64")]
	[Address(RVA = "0x140B7B0", Offset = "0x140B7B0", VA = "0x140B7B0")]
	private void ShowRoundResult(CSWinlose state)
	{
	}

	[Token(Token = "0x6002E65")]
	[Address(RVA = "0x140B980", Offset = "0x140B980", VA = "0x140B980")]
	private void CustonRoundResult(CSWinlose state)
	{
	}

	[Token(Token = "0x6002E66")]
	[Address(RVA = "0x140BC14", Offset = "0x140BC14", VA = "0x140BC14", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E67")]
	[Address(RVA = "0x140BDB0", Offset = "0x140BDB0", VA = "0x140BDB0", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002E68")]
	[Address(RVA = "0x140BDB4", Offset = "0x140BDB4", VA = "0x140BDB4", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002E69")]
	[Address(RVA = "0x140BDB8", Offset = "0x140BDB8", VA = "0x140BDB8", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002E6B")]
	[Address(RVA = "0x140BF98", Offset = "0x140BF98", VA = "0x140BF98", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E6C")]
	[Address(RVA = "0x140BFD0", Offset = "0x140BFD0", VA = "0x140BFD0", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAID)
	{
	}
}
