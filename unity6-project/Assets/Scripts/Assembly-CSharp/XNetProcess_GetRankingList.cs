using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007DA")]
public class XNetProcess_GetRankingList : XNetProcess_GameBase
{
	[Token(Token = "0x170008C4")]
	public override string Name
	{
		[Token(Token = "0x6003F2A")]
		[Address(RVA = "0x2142DE4", Offset = "0x2142DE4", VA = "0x2142DE4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F27")]
	[Address(RVA = "0x2142BFC", Offset = "0x2142BFC", VA = "0x2142BFC")]
	public XNetProcess_GetRankingList()
	{
	}

	[Token(Token = "0x6003F28")]
	[Address(RVA = "0x2142C04", Offset = "0x2142C04", VA = "0x2142C04", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F29")]
	[Address(RVA = "0x2142CC0", Offset = "0x2142CC0", VA = "0x2142CC0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F2B")]
	[Address(RVA = "0x2142E5C", Offset = "0x2142E5C", VA = "0x2142E5C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F2C")]
	[Address(RVA = "0x2142E60", Offset = "0x2142E60", VA = "0x2142E60", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
