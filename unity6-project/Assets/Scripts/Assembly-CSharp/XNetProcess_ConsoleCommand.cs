using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007F6")]
public class XNetProcess_ConsoleCommand : XNetProcess_GameBase
{
	[Token(Token = "0x170008E0")]
	public override string Name
	{
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0x2134BB0", Offset = "0x2134BB0", VA = "0x2134BB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FD1")]
	[Address(RVA = "0x21349C8", Offset = "0x21349C8", VA = "0x21349C8")]
	public XNetProcess_ConsoleCommand()
	{
	}

	[Token(Token = "0x6003FD2")]
	[Address(RVA = "0x21349D0", Offset = "0x21349D0", VA = "0x21349D0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FD3")]
	[Address(RVA = "0x2134A8C", Offset = "0x2134A8C", VA = "0x2134A8C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FD5")]
	[Address(RVA = "0x2134C28", Offset = "0x2134C28", VA = "0x2134C28", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FD6")]
	[Address(RVA = "0x2134C2C", Offset = "0x2134C2C", VA = "0x2134C2C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
