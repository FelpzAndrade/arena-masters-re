using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200077F")]
public class XNetProcess_GetRecommandedClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000861")]
	public override string Name
	{
		[Token(Token = "0x6003CFE")]
		[Address(RVA = "0x21431B8", Offset = "0x21431B8", VA = "0x21431B8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CFC")]
	[Address(RVA = "0x21430F4", Offset = "0x21430F4", VA = "0x21430F4")]
	public XNetProcess_GetRecommandedClan()
	{
	}

	[Token(Token = "0x6003CFD")]
	[Address(RVA = "0x21430FC", Offset = "0x21430FC", VA = "0x21430FC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CFF")]
	[Address(RVA = "0x2143230", Offset = "0x2143230", VA = "0x2143230", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D00")]
	[Address(RVA = "0x2143354", Offset = "0x2143354", VA = "0x2143354", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D01")]
	[Address(RVA = "0x2143358", Offset = "0x2143358", VA = "0x2143358", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
