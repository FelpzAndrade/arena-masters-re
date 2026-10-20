using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C6")]
public class XNetProcess_UseExpPotion : XNetProcess_GameBase
{
	[Token(Token = "0x170008B2")]
	public override string Name
	{
		[Token(Token = "0x6003EB9")]
		[Address(RVA = "0x1ECB94C", Offset = "0x1ECB94C", VA = "0x1ECB94C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EB6")]
	[Address(RVA = "0x1ECB764", Offset = "0x1ECB764", VA = "0x1ECB764")]
	public XNetProcess_UseExpPotion()
	{
	}

	[Token(Token = "0x6003EB7")]
	[Address(RVA = "0x1ECB76C", Offset = "0x1ECB76C", VA = "0x1ECB76C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EB8")]
	[Address(RVA = "0x1ECB828", Offset = "0x1ECB828", VA = "0x1ECB828", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EBA")]
	[Address(RVA = "0x1ECB9C4", Offset = "0x1ECB9C4", VA = "0x1ECB9C4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EBB")]
	[Address(RVA = "0x1ECB9CC", Offset = "0x1ECB9CC", VA = "0x1ECB9CC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
