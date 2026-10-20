using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000814")]
public class XNetProcess_Logout : XNetProcessLoginBase
{
	[Token(Token = "0x17000904")]
	public override string Name
	{
		[Token(Token = "0x60040A7")]
		[Address(RVA = "0x1EBDDC0", Offset = "0x1EBDDC0", VA = "0x1EBDDC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040A4")]
	[Address(RVA = "0x1EBDDA8", Offset = "0x1EBDDA8", VA = "0x1EBDDA8")]
	public XNetProcess_Logout()
	{
	}

	[Token(Token = "0x60040A5")]
	[Address(RVA = "0x1EBDDB0", Offset = "0x1EBDDB0", VA = "0x1EBDDB0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040A6")]
	[Address(RVA = "0x1EBDDB8", Offset = "0x1EBDDB8", VA = "0x1EBDDB8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040A8")]
	[Address(RVA = "0x1EBDE38", Offset = "0x1EBDE38", VA = "0x1EBDE38", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040A9")]
	[Address(RVA = "0x1EBDE3C", Offset = "0x1EBDE3C", VA = "0x1EBDE3C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
