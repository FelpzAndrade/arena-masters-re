using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200078F")]
public class XNetProcess_GetMyClanRank : XNetProcess_GameBase
{
	[Token(Token = "0x17000872")]
	public override string Name
	{
		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x213E224", Offset = "0x213E224", VA = "0x213E224", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D5D")]
	[Address(RVA = "0x213E03C", Offset = "0x213E03C", VA = "0x213E03C")]
	public XNetProcess_GetMyClanRank()
	{
	}

	[Token(Token = "0x6003D5E")]
	[Address(RVA = "0x213E044", Offset = "0x213E044", VA = "0x213E044", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D5F")]
	[Address(RVA = "0x213E100", Offset = "0x213E100", VA = "0x213E100", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D61")]
	[Address(RVA = "0x213E29C", Offset = "0x213E29C", VA = "0x213E29C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D62")]
	[Address(RVA = "0x213E2A0", Offset = "0x213E2A0", VA = "0x213E2A0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
