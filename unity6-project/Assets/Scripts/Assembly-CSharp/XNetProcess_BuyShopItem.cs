using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E3")]
public class XNetProcess_BuyShopItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008CD")]
	public override string Name
	{
		[Token(Token = "0x6003F60")]
		[Address(RVA = "0x212FF78", Offset = "0x212FF78", VA = "0x212FF78", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F5D")]
	[Address(RVA = "0x212FD90", Offset = "0x212FD90", VA = "0x212FD90")]
	public XNetProcess_BuyShopItem()
	{
	}

	[Token(Token = "0x6003F5E")]
	[Address(RVA = "0x212FD98", Offset = "0x212FD98", VA = "0x212FD98", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F5F")]
	[Address(RVA = "0x212FE54", Offset = "0x212FE54", VA = "0x212FE54", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F61")]
	[Address(RVA = "0x212FFF0", Offset = "0x212FFF0", VA = "0x212FFF0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F62")]
	[Address(RVA = "0x212FFF4", Offset = "0x212FFF4", VA = "0x212FFF4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6003F63")]
	[Address(RVA = "0x2130230", Offset = "0x2130230", VA = "0x2130230")]
	private void ShowDefaultErrorMessageBox()
	{
	}
}
