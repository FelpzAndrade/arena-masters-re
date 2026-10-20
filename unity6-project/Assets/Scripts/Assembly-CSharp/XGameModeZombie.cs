using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20005DA")]
public class XGameModeZombie : XGameModePVP
{
	[Token(Token = "0x4001C4B")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x4001C4C")]
	[FieldOffset(Offset = "0x7C")]
	protected bool m_bIsMasterZombie;

	[Token(Token = "0x4001C4D")]
	[FieldOffset(Offset = "0x0")]
	private static Func<XPlayer, bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60031DE")]
	[Address(RVA = "0x1406FAC", Offset = "0x1406FAC", VA = "0x1406FAC")]
	public XGameModeZombie(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x60031DF")]
	[Address(RVA = "0x141FEFC", Offset = "0x141FEFC", VA = "0x141FEFC", Slot = "17")]
	protected override void OnSetWinner(int nWinnerPhotonID)
	{
	}

	[Token(Token = "0x60031E0")]
	[Address(RVA = "0x1420168", Offset = "0x1420168", VA = "0x1420168", Slot = "19")]
	public override void OnDie(int nVictimPhotonID, int nAttackerPhotonID)
	{
	}

	[Token(Token = "0x60031E1")]
	[Address(RVA = "0x14205A0", Offset = "0x14205A0", VA = "0x14205A0")]
	public void SetMasterZombie(int nTargetPhotonID)
	{
	}

	[Token(Token = "0x60031E2")]
	[Address(RVA = "0x1420718", Offset = "0x1420718", VA = "0x1420718")]
	public void SetMasterZombie(bool b)
	{
	}

	[Token(Token = "0x60031E3")]
	[Address(RVA = "0x1420720", Offset = "0x1420720", VA = "0x1420720", Slot = "25")]
	protected override void OnSetTeam(int nTargetPhotonID, int nTeamID, bool onReconnect)
	{
	}

	[Token(Token = "0x60031E4")]
	[Address(RVA = "0x1420908", Offset = "0x1420908", VA = "0x1420908")]
	private void SetMyPlayerState(CSPlayerState state, bool onReconnect)
	{
	}

	[Token(Token = "0x60031E5")]
	[Address(RVA = "0x1420B74", Offset = "0x1420B74", VA = "0x1420B74")]
	private void UpdatePlayerState(bool onReconnect)
	{
	}

	[Token(Token = "0x60031E6")]
	[Address(RVA = "0x142104C", Offset = "0x142104C", VA = "0x142104C")]
	private void SetPlayerFullHp()
	{
	}

	[Token(Token = "0x60031E7")]
	[Address(RVA = "0x1420CDC", Offset = "0x1420CDC", VA = "0x1420CDC")]
	public void AddZombieBuffToMyPlayer(bool bMasterZombie, bool onReconnect)
	{
	}

	[Token(Token = "0x60031E8")]
	[Address(RVA = "0x1420E78", Offset = "0x1420E78", VA = "0x1420E78")]
	public void LostZombieBuffToMyPlayer()
	{
	}

	[Token(Token = "0x60031E9")]
	[Address(RVA = "0x1421164", Offset = "0x1421164", VA = "0x1421164", Slot = "13")]
	public override void InitPlayerTeam()
	{
	}

	[Token(Token = "0x60031EA")]
	[Address(RVA = "0x1421168", Offset = "0x1421168", VA = "0x1421168", Slot = "14")]
	public override void InitOnGetReady()
	{
	}

	[Token(Token = "0x60031EB")]
	[Address(RVA = "0x1421174", Offset = "0x1421174", VA = "0x1421174", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x60031EC")]
	[Address(RVA = "0x1421178", Offset = "0x1421178", VA = "0x1421178", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x60031ED")]
	[Address(RVA = "0x1421598", Offset = "0x1421598", VA = "0x1421598", Slot = "41")]
	public override void SetPlayerDisconnect(string playerAID)
	{
	}

	[Token(Token = "0x60031EE")]
	[Address(RVA = "0x142185C", Offset = "0x142185C", VA = "0x142185C", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x60031EF")]
	[Address(RVA = "0x1421864", Offset = "0x1421864", VA = "0x1421864", Slot = "38")]
	public override XTeamEnum GetWinningTeam(XPlayerManager records)
	{
		return default(XTeamEnum);
	}

	[Token(Token = "0x60031F0")]
	[Address(RVA = "0x142187C", Offset = "0x142187C", VA = "0x142187C", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}

	[Token(Token = "0x60031F1")]
	[Address(RVA = "0x1421984", Offset = "0x1421984", VA = "0x1421984")]
	private static bool _003CSetPlayerDisconnect_003Em__14C(XPlayer p)
	{
		return default(bool);
	}
}
