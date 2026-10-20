using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E8")]
public class XNetProcess_GetRotationShopItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008D2")]
	public override string Name
	{
		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x21454F4", Offset = "0x21454F4", VA = "0x21454F4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F7D")]
	[Address(RVA = "0x214530C", Offset = "0x214530C", VA = "0x214530C")]
	public XNetProcess_GetRotationShopItem()
	{
	}

	[Token(Token = "0x6003F7E")]
	[Address(RVA = "0x2145314", Offset = "0x2145314", VA = "0x2145314", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F7F")]
	[Address(RVA = "0x21453D0", Offset = "0x21453D0", VA = "0x21453D0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F81")]
	[Address(RVA = "0x214556C", Offset = "0x214556C", VA = "0x214556C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F82")]
	[Address(RVA = "0x2145570", Offset = "0x2145570", VA = "0x2145570", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
