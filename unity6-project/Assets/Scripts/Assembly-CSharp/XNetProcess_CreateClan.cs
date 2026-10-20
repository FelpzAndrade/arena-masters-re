using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000780")]
public class XNetProcess_CreateClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000862")]
	public override string Name
	{
		[Token(Token = "0x6003D04")]
		[Address(RVA = "0x21354A4", Offset = "0x21354A4", VA = "0x21354A4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D02")]
	[Address(RVA = "0x21353E0", Offset = "0x21353E0", VA = "0x21353E0")]
	public XNetProcess_CreateClan()
	{
	}

	[Token(Token = "0x6003D03")]
	[Address(RVA = "0x21353E8", Offset = "0x21353E8", VA = "0x21353E8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D05")]
	[Address(RVA = "0x213551C", Offset = "0x213551C", VA = "0x213551C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D06")]
	[Address(RVA = "0x2135640", Offset = "0x2135640", VA = "0x2135640", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D07")]
	[Address(RVA = "0x2135644", Offset = "0x2135644", VA = "0x2135644", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
