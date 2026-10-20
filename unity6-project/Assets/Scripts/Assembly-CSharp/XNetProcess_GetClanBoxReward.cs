using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000791")]
public class XNetProcess_GetClanBoxReward : XNetProcess_GameBase
{
	[Token(Token = "0x17000874")]
	public override string Name
	{
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x213B754", Offset = "0x213B754", VA = "0x213B754", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D69")]
	[Address(RVA = "0x213B56C", Offset = "0x213B56C", VA = "0x213B56C")]
	public XNetProcess_GetClanBoxReward()
	{
	}

	[Token(Token = "0x6003D6A")]
	[Address(RVA = "0x213B574", Offset = "0x213B574", VA = "0x213B574", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D6B")]
	[Address(RVA = "0x213B630", Offset = "0x213B630", VA = "0x213B630", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D6D")]
	[Address(RVA = "0x213B7CC", Offset = "0x213B7CC", VA = "0x213B7CC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D6E")]
	[Address(RVA = "0x213B7D0", Offset = "0x213B7D0", VA = "0x213B7D0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
