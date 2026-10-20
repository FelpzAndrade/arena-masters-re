using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000793")]
public class XNetProcess_Emoticon_Buy : XNetProcess_GameBase
{
	[Token(Token = "0x17000876")]
	public override string Name
	{
		[Token(Token = "0x6003D78")]
		[Address(RVA = "0x213585C", Offset = "0x213585C", VA = "0x213585C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D75")]
	[Address(RVA = "0x2135674", Offset = "0x2135674", VA = "0x2135674")]
	public XNetProcess_Emoticon_Buy()
	{
	}

	[Token(Token = "0x6003D76")]
	[Address(RVA = "0x213567C", Offset = "0x213567C", VA = "0x213567C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D77")]
	[Address(RVA = "0x2135738", Offset = "0x2135738", VA = "0x2135738", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D79")]
	[Address(RVA = "0x21358D4", Offset = "0x21358D4", VA = "0x21358D4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D7A")]
	[Address(RVA = "0x21358D8", Offset = "0x21358D8", VA = "0x21358D8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
