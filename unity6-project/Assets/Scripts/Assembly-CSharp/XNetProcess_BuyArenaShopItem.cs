using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E9")]
public class XNetProcess_BuyArenaShopItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008D3")]
	public override string Name
	{
		[Token(Token = "0x6003F86")]
		[Address(RVA = "0x212F4E8", Offset = "0x212F4E8", VA = "0x212F4E8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F83")]
	[Address(RVA = "0x212F300", Offset = "0x212F300", VA = "0x212F300")]
	public XNetProcess_BuyArenaShopItem()
	{
	}

	[Token(Token = "0x6003F84")]
	[Address(RVA = "0x212F308", Offset = "0x212F308", VA = "0x212F308", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F85")]
	[Address(RVA = "0x212F3C4", Offset = "0x212F3C4", VA = "0x212F3C4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F87")]
	[Address(RVA = "0x212F560", Offset = "0x212F560", VA = "0x212F560", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F88")]
	[Address(RVA = "0x212F564", Offset = "0x212F564", VA = "0x212F564", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
