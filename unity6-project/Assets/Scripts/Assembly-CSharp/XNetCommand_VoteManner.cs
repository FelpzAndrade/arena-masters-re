using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007BE")]
internal class XNetCommand_VoteManner : XNetProcessBase
{
	[Token(Token = "0x6003E86")]
	[Address(RVA = "0x2126A88", Offset = "0x2126A88", VA = "0x2126A88")]
	public XNetCommand_VoteManner()
	{
	}

	[Token(Token = "0x6003E87")]
	[Address(RVA = "0x2126A90", Offset = "0x2126A90", VA = "0x2126A90", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003E88")]
	[Address(RVA = "0x2126A98", Offset = "0x2126A98", VA = "0x2126A98", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E89")]
	[Address(RVA = "0x2126B54", Offset = "0x2126B54", VA = "0x2126B54", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}
}
