using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005E0")]
public class XGameModeZombie2 : XGameModePVP
{
	[Token(Token = "0x20005E1")]
	private sealed class _003CChangeTeamSpectatorMode_003Ec__Iterator67 : IDisposable
	{
		[Token(Token = "0x4001C5F")]
		[FieldOffset(Offset = "0x8")]
		internal XZombie2State_Play _003CstatePlay_003E__0;

		[Token(Token = "0x4001C60")]
		[FieldOffset(Offset = "0xC")]
		internal int _0024PC;

		[Token(Token = "0x4001C61")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0x14")]
		internal XGameModeZombie2 _003C_003Ef__this;

		[Token(Token = "0x17000783")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003224")]
			[Address(RVA = "0x1422EFC", Offset = "0x1422EFC", VA = "0x1422EFC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000784")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003225")]
			[Address(RVA = "0x1422F04", Offset = "0x1422F04", VA = "0x1422F04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003223")]
		[Address(RVA = "0x1421D30", Offset = "0x1421D30", VA = "0x1421D30")]
		public _003CChangeTeamSpectatorMode_003Ec__Iterator67()
		{
		}

		[Token(Token = "0x6003224")]
		[Address(RVA = "0x1422EFC", Offset = "0x1422EFC", VA = "0x1422EFC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003225")]
		[Address(RVA = "0x1422F04", Offset = "0x1422F04", VA = "0x1422F04", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003226")]
		[Address(RVA = "0x1422F0C", Offset = "0x1422F0C", VA = "0x1422F0C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003227")]
		[Address(RVA = "0x1423124", Offset = "0x1423124", VA = "0x1423124", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003228")]
		[Address(RVA = "0x1423130", Offset = "0x1423130", VA = "0x1423130", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001C5E")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x17000781")]
	public int CurrentRound
	{
		[Token(Token = "0x600321F")]
		[Address(RVA = "0x1422A28", Offset = "0x1422A28", VA = "0x1422A28")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000782")]
	public float RoundRemainedTime
	{
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x1422E30", Offset = "0x1422E30", VA = "0x1422E30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600320F")]
	[Address(RVA = "0x1407424", Offset = "0x1407424", VA = "0x1407424")]
	public XGameModeZombie2(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6003210")]
	[Address(RVA = "0x14219C4", Offset = "0x14219C4", VA = "0x14219C4", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x6003211")]
	[Address(RVA = "0x1421C30", Offset = "0x1421C30", VA = "0x1421C30", Slot = "18")]
	public override void OnMyDie(XModuleEntity me, XModuleEntity attacker)
	{
	}

	[Token(Token = "0x6003212")]
	[Address(RVA = "0x1421C8C", Offset = "0x1421C8C", VA = "0x1421C8C")]
	[DebuggerHidden]
	private IEnumerator ChangeTeamSpectatorMode()
	{
		return null;
	}

	[Token(Token = "0x6003213")]
	[Address(RVA = "0x1421D38", Offset = "0x1421D38", VA = "0x1421D38", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x6003214")]
	[Address(RVA = "0x1421E0C", Offset = "0x1421E0C", VA = "0x1421E0C")]
	public void SendLoseLifePlayer()
	{
	}

	[Token(Token = "0x6003215")]
	[Address(RVA = "0x1421ED0", Offset = "0x1421ED0", VA = "0x1421ED0")]
	public void StartRound(int nRound)
	{
	}

	[Token(Token = "0x6003216")]
	[Address(RVA = "0x1421FA0", Offset = "0x1421FA0", VA = "0x1421FA0")]
	public void SyncGameTimeData(float remain_Time)
	{
	}

	[Token(Token = "0x6003217")]
	[Address(RVA = "0x142206C", Offset = "0x142206C", VA = "0x142206C")]
	public void SyncGameStateData(int state)
	{
	}

	[Token(Token = "0x6003218")]
	[Address(RVA = "0x1422138", Offset = "0x1422138", VA = "0x1422138")]
	public void OnSetRoundCount()
	{
	}

	[Token(Token = "0x6003219")]
	[Address(RVA = "0x14221FC", Offset = "0x14221FC", VA = "0x14221FC")]
	public void OnRoundResult(int nRound, CSWinlose result_TeamA, CSWinlose result_TeamB)
	{
	}

	[Token(Token = "0x600321A")]
	[Address(RVA = "0x14224DC", Offset = "0x14224DC", VA = "0x14224DC")]
	private void ShowRoundResult(CSWinlose state)
	{
	}

	[Token(Token = "0x600321B")]
	[Address(RVA = "0x1422770", Offset = "0x1422770", VA = "0x1422770", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x600321C")]
	[Address(RVA = "0x142290C", Offset = "0x142290C", VA = "0x142290C", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x600321D")]
	[Address(RVA = "0x1422910", Offset = "0x1422910", VA = "0x1422910", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x600321E")]
	[Address(RVA = "0x1422914", Offset = "0x1422914", VA = "0x1422914", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager playerManager)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x6003220")]
	[Address(RVA = "0x1422AF4", Offset = "0x1422AF4", VA = "0x1422AF4", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x6003221")]
	[Address(RVA = "0x1422B2C", Offset = "0x1422B2C", VA = "0x1422B2C", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAID)
	{
	}
}
