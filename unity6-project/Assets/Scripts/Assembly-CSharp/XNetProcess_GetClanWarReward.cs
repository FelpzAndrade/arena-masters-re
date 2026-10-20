using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000790")]
public class XNetProcess_GetClanWarReward : XNetProcess_GameBase
{
	[Token(Token = "0x17000873")]
	public override string Name
	{
		[Token(Token = "0x6003D66")]
		[Address(RVA = "0x213BEB8", Offset = "0x213BEB8", VA = "0x213BEB8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D63")]
	[Address(RVA = "0x213BCD0", Offset = "0x213BCD0", VA = "0x213BCD0")]
	public XNetProcess_GetClanWarReward()
	{
	}

	[Token(Token = "0x6003D64")]
	[Address(RVA = "0x213BCD8", Offset = "0x213BCD8", VA = "0x213BCD8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D65")]
	[Address(RVA = "0x213BD94", Offset = "0x213BD94", VA = "0x213BD94", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D67")]
	[Address(RVA = "0x213BF30", Offset = "0x213BF30", VA = "0x213BF30", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D68")]
	[Address(RVA = "0x213BF34", Offset = "0x213BF34", VA = "0x213BF34", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
