using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E6")]
public class XNetProcess_BuyItemInvenSlot : XNetProcess_GameBase
{
	[Token(Token = "0x170008D0")]
	public override string Name
	{
		[Token(Token = "0x6003F74")]
		[Address(RVA = "0x212FD0C", Offset = "0x212FD0C", VA = "0x212FD0C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F71")]
	[Address(RVA = "0x212FB24", Offset = "0x212FB24", VA = "0x212FB24")]
	public XNetProcess_BuyItemInvenSlot()
	{
	}

	[Token(Token = "0x6003F72")]
	[Address(RVA = "0x212FB2C", Offset = "0x212FB2C", VA = "0x212FB2C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F73")]
	[Address(RVA = "0x212FBE8", Offset = "0x212FBE8", VA = "0x212FBE8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F75")]
	[Address(RVA = "0x212FD84", Offset = "0x212FD84", VA = "0x212FD84", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F76")]
	[Address(RVA = "0x212FD88", Offset = "0x212FD88", VA = "0x212FD88", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
