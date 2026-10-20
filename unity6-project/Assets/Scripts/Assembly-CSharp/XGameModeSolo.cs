using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000598")]
public class XGameModeSolo : XGameModePVE
{
	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x1406FD0", Offset = "0x1406FD0", VA = "0x1406FD0")]
	public XGameModeSolo(XGameModeType nGameModeType)
	{
	}

	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x14131C8", Offset = "0x14131C8", VA = "0x14131C8", Slot = "31")]
	public override bool IsMasterClient()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x14131D0", Offset = "0x14131D0", VA = "0x14131D0", Slot = "37")]
	public override bool IsFinish()
	{
		return default(bool);
	}

	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x14131D8", Offset = "0x14131D8", VA = "0x14131D8", Slot = "35")]
	public override void RefreshRecords()
	{
	}

	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x14131DC", Offset = "0x14131DC", VA = "0x14131DC", Slot = "39")]
	public override XPlayerManager GetFinalRecords()
	{
		return null;
	}
}
