using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200081E")]
public class XNetProcess_CheckEventAttendance : XNetProcess_GameBase
{
	[Token(Token = "0x17000910")]
	public override string Name
	{
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x2132820", Offset = "0x2132820", VA = "0x2132820", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040E3")]
	[Address(RVA = "0x2132638", Offset = "0x2132638", VA = "0x2132638")]
	public XNetProcess_CheckEventAttendance()
	{
	}

	[Token(Token = "0x60040E4")]
	[Address(RVA = "0x2132640", Offset = "0x2132640", VA = "0x2132640", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040E5")]
	[Address(RVA = "0x21326FC", Offset = "0x21326FC", VA = "0x21326FC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040E7")]
	[Address(RVA = "0x2132898", Offset = "0x2132898", VA = "0x2132898", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040E8")]
	[Address(RVA = "0x213289C", Offset = "0x213289C", VA = "0x213289C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
