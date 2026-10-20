using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200078E")]
public class XNetProcess_GetClanRankingList : XNetProcess_GameBase
{
	[Token(Token = "0x17000871")]
	public override string Name
	{
		[Token(Token = "0x6003D5A")]
		[Address(RVA = "0x213B9C0", Offset = "0x213B9C0", VA = "0x213B9C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D57")]
	[Address(RVA = "0x213B7D8", Offset = "0x213B7D8", VA = "0x213B7D8")]
	public XNetProcess_GetClanRankingList()
	{
	}

	[Token(Token = "0x6003D58")]
	[Address(RVA = "0x213B7E0", Offset = "0x213B7E0", VA = "0x213B7E0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D59")]
	[Address(RVA = "0x213B89C", Offset = "0x213B89C", VA = "0x213B89C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D5B")]
	[Address(RVA = "0x213BA38", Offset = "0x213BA38", VA = "0x213BA38", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D5C")]
	[Address(RVA = "0x213BA3C", Offset = "0x213BA3C", VA = "0x213BA3C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
