using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007DE")]
public class XNetProcess_CheckRankingReward : XNetProcess_GameBase
{
	[Token(Token = "0x170008C8")]
	public override string Name
	{
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x2132D4C", Offset = "0x2132D4C", VA = "0x2132D4C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F3F")]
	[Address(RVA = "0x2132B64", Offset = "0x2132B64", VA = "0x2132B64")]
	public XNetProcess_CheckRankingReward()
	{
	}

	[Token(Token = "0x6003F40")]
	[Address(RVA = "0x2132B6C", Offset = "0x2132B6C", VA = "0x2132B6C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F41")]
	[Address(RVA = "0x2132C28", Offset = "0x2132C28", VA = "0x2132C28", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F43")]
	[Address(RVA = "0x2132DC4", Offset = "0x2132DC4", VA = "0x2132DC4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F44")]
	[Address(RVA = "0x2132DC8", Offset = "0x2132DC8", VA = "0x2132DC8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
