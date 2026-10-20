using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007A3")]
public class XNetCommand_SnsFriendInvite : XNetProcessBase
{
	[Token(Token = "0x17000885")]
	public override string Name
	{
		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x2126828", Offset = "0x2126828", VA = "0x2126828", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DD3")]
	[Address(RVA = "0x2126820", Offset = "0x2126820", VA = "0x2126820")]
	public XNetCommand_SnsFriendInvite()
	{
	}

	[Token(Token = "0x6003DD5")]
	[Address(RVA = "0x21268A0", Offset = "0x21268A0", VA = "0x21268A0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DD6")]
	[Address(RVA = "0x212695C", Offset = "0x212695C", VA = "0x212695C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DD7")]
	[Address(RVA = "0x2126A80", Offset = "0x2126A80", VA = "0x2126A80", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
