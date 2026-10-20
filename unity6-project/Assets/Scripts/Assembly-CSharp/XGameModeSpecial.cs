using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000599")]
public class XGameModeSpecial : XGameModePVE
{
	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x1406FF0", Offset = "0x1406FF0", VA = "0x1406FF0")]
	public XGameModeSpecial(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x14135F0", Offset = "0x14135F0", VA = "0x14135F0", Slot = "49")]
	protected override void OnObjDie(XModuleLevelObject obj)
	{
	}

	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x14137DC", Offset = "0x14137DC", VA = "0x14137DC", Slot = "31")]
	public override bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FF4")]
	[Address(RVA = "0x14137E4", Offset = "0x14137E4", VA = "0x14137E4", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FF5")]
	[Address(RVA = "0x14137EC", Offset = "0x14137EC", VA = "0x14137EC", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002FF6")]
	[Address(RVA = "0x14137F0", Offset = "0x14137F0", VA = "0x14137F0", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}
}
