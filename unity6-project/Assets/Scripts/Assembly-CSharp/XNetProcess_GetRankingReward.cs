using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007DC")]
public class XNetProcess_GetRankingReward : XNetProcess_GameBase
{
	[Token(Token = "0x170008C6")]
	public override string Name
	{
		[Token(Token = "0x6003F36")]
		[Address(RVA = "0x2143050", Offset = "0x2143050", VA = "0x2143050", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F33")]
	[Address(RVA = "0x2142E68", Offset = "0x2142E68", VA = "0x2142E68")]
	public XNetProcess_GetRankingReward()
	{
	}

	[Token(Token = "0x6003F34")]
	[Address(RVA = "0x2142E70", Offset = "0x2142E70", VA = "0x2142E70", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F35")]
	[Address(RVA = "0x2142F2C", Offset = "0x2142F2C", VA = "0x2142F2C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F37")]
	[Address(RVA = "0x21430C8", Offset = "0x21430C8", VA = "0x21430C8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F38")]
	[Address(RVA = "0x21430CC", Offset = "0x21430CC", VA = "0x21430CC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
