using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C8")]
public class XNetProcess_FusionItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008B4")]
	public override string Name
	{
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x213938C", Offset = "0x213938C", VA = "0x213938C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EC2")]
	[Address(RVA = "0x21391A4", Offset = "0x21391A4", VA = "0x21391A4")]
	public XNetProcess_FusionItem()
	{
	}

	[Token(Token = "0x6003EC3")]
	[Address(RVA = "0x21391AC", Offset = "0x21391AC", VA = "0x21391AC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EC4")]
	[Address(RVA = "0x2139268", Offset = "0x2139268", VA = "0x2139268", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EC6")]
	[Address(RVA = "0x2139404", Offset = "0x2139404", VA = "0x2139404", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EC7")]
	[Address(RVA = "0x2139408", Offset = "0x2139408", VA = "0x2139408", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
