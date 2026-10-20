using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C3")]
public class XNetProcess_SellEquipments : XNetProcess_GameBase
{
	[Token(Token = "0x170008AD")]
	public override string Name
	{
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x1EC6D80", Offset = "0x1EC6D80", VA = "0x1EC6D80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EA2")]
	[Address(RVA = "0x1EC6B98", Offset = "0x1EC6B98", VA = "0x1EC6B98")]
	public XNetProcess_SellEquipments()
	{
	}

	[Token(Token = "0x6003EA3")]
	[Address(RVA = "0x1EC6BA0", Offset = "0x1EC6BA0", VA = "0x1EC6BA0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EA4")]
	[Address(RVA = "0x1EC6C5C", Offset = "0x1EC6C5C", VA = "0x1EC6C5C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EA6")]
	[Address(RVA = "0x1EC6DF8", Offset = "0x1EC6DF8", VA = "0x1EC6DF8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EA7")]
	[Address(RVA = "0x1EC6E00", Offset = "0x1EC6E00", VA = "0x1EC6E00", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
