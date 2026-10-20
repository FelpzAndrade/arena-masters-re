using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007DF")]
public class XNetProcess_GetTrophyReward : XNetProcess_GameBase
{
	[Token(Token = "0x170008C9")]
	public override string Name
	{
		[Token(Token = "0x6003F48")]
		[Address(RVA = "0x1EB508C", Offset = "0x1EB508C", VA = "0x1EB508C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F45")]
	[Address(RVA = "0x1EB4EAC", Offset = "0x1EB4EAC", VA = "0x1EB4EAC")]
	public XNetProcess_GetTrophyReward()
	{
	}

	[Token(Token = "0x6003F46")]
	[Address(RVA = "0x1EB4EB4", Offset = "0x1EB4EB4", VA = "0x1EB4EB4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F47")]
	[Address(RVA = "0x1EB4F68", Offset = "0x1EB4F68", VA = "0x1EB4F68", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F49")]
	[Address(RVA = "0x1EB5104", Offset = "0x1EB5104", VA = "0x1EB5104", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F4A")]
	[Address(RVA = "0x1EB510C", Offset = "0x1EB510C", VA = "0x1EB510C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
