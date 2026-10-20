using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E2")]
public class XNetProcess_Relic_Upgrade : XNetProcess_GameBase
{
	[Token(Token = "0x170008CC")]
	public override string Name
	{
		[Token(Token = "0x6003F5A")]
		[Address(RVA = "0x1EC4EF8", Offset = "0x1EC4EF8", VA = "0x1EC4EF8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F57")]
	[Address(RVA = "0x1EC4D10", Offset = "0x1EC4D10", VA = "0x1EC4D10")]
	public XNetProcess_Relic_Upgrade()
	{
	}

	[Token(Token = "0x6003F58")]
	[Address(RVA = "0x1EC4D18", Offset = "0x1EC4D18", VA = "0x1EC4D18", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F59")]
	[Address(RVA = "0x1EC4DD4", Offset = "0x1EC4DD4", VA = "0x1EC4DD4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F5B")]
	[Address(RVA = "0x1EC4F70", Offset = "0x1EC4F70", VA = "0x1EC4F70", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F5C")]
	[Address(RVA = "0x1EC4F78", Offset = "0x1EC4F78", VA = "0x1EC4F78", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
