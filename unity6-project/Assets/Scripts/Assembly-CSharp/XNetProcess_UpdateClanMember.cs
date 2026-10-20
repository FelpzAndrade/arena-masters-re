using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200078A")]
public class XNetProcess_UpdateClanMember : XNetProcess_GameBase
{
	[Token(Token = "0x1700086D")]
	public override string Name
	{
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x1ECB088", Offset = "0x1ECB088", VA = "0x1ECB088", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D3F")]
	[Address(RVA = "0x1ECAFC4", Offset = "0x1ECAFC4", VA = "0x1ECAFC4")]
	public XNetProcess_UpdateClanMember()
	{
	}

	[Token(Token = "0x6003D40")]
	[Address(RVA = "0x1ECAFCC", Offset = "0x1ECAFCC", VA = "0x1ECAFCC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D42")]
	[Address(RVA = "0x1ECB100", Offset = "0x1ECB100", VA = "0x1ECB100", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D43")]
	[Address(RVA = "0x1ECB224", Offset = "0x1ECB224", VA = "0x1ECB224", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D44")]
	[Address(RVA = "0x1ECB22C", Offset = "0x1ECB22C", VA = "0x1ECB22C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
