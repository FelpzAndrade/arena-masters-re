using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E1")]
public class XNetProcess_Relic_Buy_Quick_Slot : XNetProcess_GameBase
{
	[Token(Token = "0x170008CB")]
	public override string Name
	{
		[Token(Token = "0x6003F54")]
		[Address(RVA = "0x1EC49F8", Offset = "0x1EC49F8", VA = "0x1EC49F8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F51")]
	[Address(RVA = "0x1EC4810", Offset = "0x1EC4810", VA = "0x1EC4810")]
	public XNetProcess_Relic_Buy_Quick_Slot()
	{
	}

	[Token(Token = "0x6003F52")]
	[Address(RVA = "0x1EC4818", Offset = "0x1EC4818", VA = "0x1EC4818", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F53")]
	[Address(RVA = "0x1EC48D4", Offset = "0x1EC48D4", VA = "0x1EC48D4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F55")]
	[Address(RVA = "0x1EC4A70", Offset = "0x1EC4A70", VA = "0x1EC4A70", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F56")]
	[Address(RVA = "0x1EC4A78", Offset = "0x1EC4A78", VA = "0x1EC4A78", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
