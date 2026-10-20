using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C0")]
public class XNetProcess_EquipItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008AA")]
	public override string Name
	{
		[Token(Token = "0x6003E93")]
		[Address(RVA = "0x2138584", Offset = "0x2138584", VA = "0x2138584", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E90")]
	[Address(RVA = "0x213839C", Offset = "0x213839C", VA = "0x213839C")]
	public XNetProcess_EquipItem()
	{
	}

	[Token(Token = "0x6003E91")]
	[Address(RVA = "0x21383A4", Offset = "0x21383A4", VA = "0x21383A4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E92")]
	[Address(RVA = "0x2138460", Offset = "0x2138460", VA = "0x2138460", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E94")]
	[Address(RVA = "0x21385FC", Offset = "0x21385FC", VA = "0x21385FC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E95")]
	[Address(RVA = "0x2138600", Offset = "0x2138600", VA = "0x2138600", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
