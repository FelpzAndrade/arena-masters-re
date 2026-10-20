using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000569")]
public class XGameModeDeathMatch : XGameModePVP
{
	[Token(Token = "0x4001AC7")]
	public const int MAX_PLAYER = 6;

	[Token(Token = "0x6002E08")]
	[Address(RVA = "0x14055F4", Offset = "0x14055F4", VA = "0x14055F4")]
	public XGameModeDeathMatch(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002E09")]
	[Address(RVA = "0x1405610", Offset = "0x1405610", VA = "0x1405610", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E0A")]
	[Address(RVA = "0x1405908", Offset = "0x1405908", VA = "0x1405908", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002E0B")]
	[Address(RVA = "0x140590C", Offset = "0x140590C", VA = "0x140590C", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}

	[Token(Token = "0x6002E0C")]
	[Address(RVA = "0x1405910", Offset = "0x1405910", VA = "0x1405910", Slot = "43")]
	public override void SetGoalKillCount()
	{
	}

	[Token(Token = "0x6002E0D")]
	[Address(RVA = "0x14059DC", Offset = "0x14059DC", VA = "0x14059DC", Slot = "42")]
	public override bool IsShowMyTeamIndicator()
	{
		return default(bool);
	}
}
