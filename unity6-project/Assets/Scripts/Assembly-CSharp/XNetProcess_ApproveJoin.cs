using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000786")]
public class XNetProcess_ApproveJoin : XNetProcess_GameBase
{
	[Token(Token = "0x17000868")]
	public override string Name
	{
		[Token(Token = "0x6003D28")]
		[Address(RVA = "0x212E120", Offset = "0x212E120", VA = "0x212E120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D26")]
	[Address(RVA = "0x212E05C", Offset = "0x212E05C", VA = "0x212E05C")]
	public XNetProcess_ApproveJoin()
	{
	}

	[Token(Token = "0x6003D27")]
	[Address(RVA = "0x212E064", Offset = "0x212E064", VA = "0x212E064", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D29")]
	[Address(RVA = "0x212E198", Offset = "0x212E198", VA = "0x212E198", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D2A")]
	[Address(RVA = "0x212E2BC", Offset = "0x212E2BC", VA = "0x212E2BC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D2B")]
	[Address(RVA = "0x212E2C0", Offset = "0x212E2C0", VA = "0x212E2C0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
