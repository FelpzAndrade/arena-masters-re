using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E4")]
public class XNetProcess_BuyStallShopItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008CE")]
	public override string Name
	{
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x2130640", Offset = "0x2130640", VA = "0x2130640", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F64")]
	[Address(RVA = "0x2130458", Offset = "0x2130458", VA = "0x2130458")]
	public XNetProcess_BuyStallShopItem()
	{
	}

	[Token(Token = "0x6003F65")]
	[Address(RVA = "0x2130460", Offset = "0x2130460", VA = "0x2130460", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F66")]
	[Address(RVA = "0x213051C", Offset = "0x213051C", VA = "0x213051C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F68")]
	[Address(RVA = "0x21306B8", Offset = "0x21306B8", VA = "0x21306B8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F69")]
	[Address(RVA = "0x21306BC", Offset = "0x21306BC", VA = "0x21306BC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
