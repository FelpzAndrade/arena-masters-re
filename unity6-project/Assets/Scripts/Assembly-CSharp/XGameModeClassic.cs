using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000562")]
public class XGameModeClassic : XGameModePVP
{
	[Token(Token = "0x2000563")]
	private sealed class _003CChangeTeamSpectatorMode_003Ec__Iterator5B : IDisposable
	{
		[Token(Token = "0x4001AC1")]
		[FieldOffset(Offset = "0x8")]
		internal XClassicState_Play _003CstatePlay_003E__0;

		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001AC4")]
		[FieldOffset(Offset = "0x14")]
		internal XGameModeClassic _003C_003Ef__this;

		[Token(Token = "0x17000721")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6002DFB")]
			[Address(RVA = "0x1404014", Offset = "0x1404014", VA = "0x1404014", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000722")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DFC")]
			[Address(RVA = "0x140401C", Offset = "0x140401C", VA = "0x140401C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x1402FDC", Offset = "0x1402FDC", VA = "0x1402FDC")]
		public _003CChangeTeamSpectatorMode_003Ec__Iterator5B()
		{
		}

		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x1404014", Offset = "0x1404014", VA = "0x1404014", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x140401C", Offset = "0x140401C", VA = "0x140401C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x1404024", Offset = "0x1404024", VA = "0x1404024", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x140423C", Offset = "0x140423C", VA = "0x140423C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x1404248", Offset = "0x1404248", VA = "0x1404248", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001AC0")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x1700071F")]
	public int CurrentRound
	{
		[Token(Token = "0x6002DF6")]
		[Address(RVA = "0x1403B40", Offset = "0x1403B40", VA = "0x1403B40")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000720")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x1403F48", Offset = "0x1403F48", VA = "0x1403F48")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x1402C54", Offset = "0x1402C54", VA = "0x1402C54")]
	public XGameModeClassic(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x1402C70", Offset = "0x1402C70", VA = "0x1402C70", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x1402EDC", Offset = "0x1402EDC", VA = "0x1402EDC", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x1402F38", Offset = "0x1402F38", VA = "0x1402F38")]
	[DebuggerHidden]
	private IEnumerator ChangeTeamSpectatorMode()
	{
		return null;
	}

	[Token(Token = "0x6002DEA")]
	[Address(RVA = "0x1402FE4", Offset = "0x1402FE4", VA = "0x1402FE4", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6002DEB")]
	[Address(RVA = "0x14030B8", Offset = "0x14030B8", VA = "0x14030B8")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6002DEC")]
	[Address(RVA = "0x140317C", Offset = "0x140317C", VA = "0x140317C")]
	public void StartRound(int nRound)
	{
	}

	[Token(Token = "0x6002DED")]
	[Address(RVA = "0x140324C", Offset = "0x140324C", VA = "0x140324C")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6002DEE")]
	[Address(RVA = "0x1403318", Offset = "0x1403318", VA = "0x1403318")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6002DEF")]
	[Address(RVA = "0x14033E4", Offset = "0x14033E4", VA = "0x14033E4")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x6002DF0")]
	[Address(RVA = "0x14034A8", Offset = "0x14034A8", VA = "0x14034A8")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x6002DF1")]
	[Address(RVA = "0x1403788", Offset = "0x1403788", VA = "0x1403788")]
	private void ShowRoundResult(CSWinlose state)
	{
	}

	[Token(Token = "0x6002DF2")]
	[Address(RVA = "0x1403A1C", Offset = "0x1403A1C", VA = "0x1403A1C", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002DF3")]
	[Address(RVA = "0x1403A24", Offset = "0x1403A24", VA = "0x1403A24", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x1403A28", Offset = "0x1403A28", VA = "0x1403A28", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x1403A2C", Offset = "0x1403A2C", VA = "0x1403A2C", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x1403C0C", Offset = "0x1403C0C", VA = "0x1403C0C", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x1403C44", Offset = "0x1403C44", VA = "0x1403C44", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAID)
	{
	}
}
