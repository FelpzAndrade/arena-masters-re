using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200078D")]
public class XNetProcess_CancelJoinClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000870")]
	public override string Name
	{
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x21309BC", Offset = "0x21309BC", VA = "0x21309BC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D51")]
	[Address(RVA = "0x21308F8", Offset = "0x21308F8", VA = "0x21308F8")]
	public XNetProcess_CancelJoinClan()
	{
	}

	[Token(Token = "0x6003D52")]
	[Address(RVA = "0x2130900", Offset = "0x2130900", VA = "0x2130900", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D54")]
	[Address(RVA = "0x2130A34", Offset = "0x2130A34", VA = "0x2130A34", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D55")]
	[Address(RVA = "0x2130B58", Offset = "0x2130B58", VA = "0x2130B58", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D56")]
	[Address(RVA = "0x2130B5C", Offset = "0x2130B5C", VA = "0x2130B5C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
