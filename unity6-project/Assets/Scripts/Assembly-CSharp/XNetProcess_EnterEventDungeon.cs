using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007AF")]
public class XNetProcess_EnterEventDungeon : XNetProcess_GameBase
{
	[Token(Token = "0x4002304")]
	[FieldOffset(Offset = "0x34")]
	private XGameModeType m_game_mode;

	[Token(Token = "0x17000898")]
	public override string Name
	{
		[Token(Token = "0x6003E2C")]
		[Address(RVA = "0x2136E78", Offset = "0x2136E78", VA = "0x2136E78", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E29")]
	[Address(RVA = "0x2136BF0", Offset = "0x2136BF0", VA = "0x2136BF0")]
	public XNetProcess_EnterEventDungeon()
	{
	}

	[Token(Token = "0x6003E2A")]
	[Address(RVA = "0x2136BF8", Offset = "0x2136BF8", VA = "0x2136BF8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E2B")]
	[Address(RVA = "0x2136CB4", Offset = "0x2136CB4", VA = "0x2136CB4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E2D")]
	[Address(RVA = "0x2136EF0", Offset = "0x2136EF0", VA = "0x2136EF0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E2E")]
	[Address(RVA = "0x2136FB4", Offset = "0x2136FB4", VA = "0x2136FB4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
