using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200080A")]
public class XNetCommand_RecoverUser : XNetProcessLoginBase
{
	[Token(Token = "0x170008F6")]
	public override string Name
	{
		[Token(Token = "0x600405D")]
		[Address(RVA = "0x2126060", Offset = "0x2126060", VA = "0x2126060", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600405A")]
	[Address(RVA = "0x2125AC8", Offset = "0x2125AC8", VA = "0x2125AC8")]
	public XNetCommand_RecoverUser()
	{
	}

	[Token(Token = "0x600405B")]
	[Address(RVA = "0x2125AD0", Offset = "0x2125AD0", VA = "0x2125AD0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x600405C")]
	[Address(RVA = "0x2125B8C", Offset = "0x2125B8C", VA = "0x2125B8C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x600405E")]
	[Address(RVA = "0x21260D8", Offset = "0x21260D8", VA = "0x21260D8", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x600405F")]
	[Address(RVA = "0x212617C", Offset = "0x212617C", VA = "0x212617C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}

	[Token(Token = "0x6004060")]
	[Address(RVA = "0x21265F0", Offset = "0x21265F0", VA = "0x21265F0")]
	private bool TryShowMessageForLeaveUser()
	{
		return default(bool);
	}
}
