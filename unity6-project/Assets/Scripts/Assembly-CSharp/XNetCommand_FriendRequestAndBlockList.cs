using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007A2")]
internal class XNetCommand_FriendRequestAndBlockList : XNetProcessBase
{
	[Token(Token = "0x6003DCF")]
	[Address(RVA = "0xBA6D24", Offset = "0xBA6D24", VA = "0xBA6D24")]
	public XNetCommand_FriendRequestAndBlockList()
	{
	}

	[Token(Token = "0x6003DD0")]
	[Address(RVA = "0xBA6D2C", Offset = "0xBA6D2C", VA = "0xBA6D2C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003DD1")]
	[Address(RVA = "0xBA6D34", Offset = "0xBA6D34", VA = "0xBA6D34", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DD2")]
	[Address(RVA = "0xBA6DF0", Offset = "0xBA6DF0", VA = "0xBA6DF0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}
}
