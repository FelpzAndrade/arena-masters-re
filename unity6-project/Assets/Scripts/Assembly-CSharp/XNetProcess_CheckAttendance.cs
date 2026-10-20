using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000818")]
public class XNetProcess_CheckAttendance : XNetProcess_GameBase
{
	[Token(Token = "0x17000908")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x21323CC", Offset = "0x21323CC", VA = "0x21323CC", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000909")]
	public override string Name
	{
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x21325B4", Offset = "0x21325B4", VA = "0x21325B4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040BD")]
	[Address(RVA = "0x21323C4", Offset = "0x21323C4", VA = "0x21323C4")]
	public XNetProcess_CheckAttendance()
	{
	}

	[Token(Token = "0x60040BF")]
	[Address(RVA = "0x21323D4", Offset = "0x21323D4", VA = "0x21323D4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040C0")]
	[Address(RVA = "0x2132490", Offset = "0x2132490", VA = "0x2132490", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040C2")]
	[Address(RVA = "0x213262C", Offset = "0x213262C", VA = "0x213262C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040C3")]
	[Address(RVA = "0x2132630", Offset = "0x2132630", VA = "0x2132630", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
