using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000821")]
public class XNetCommand_LeaveAccount : XNetProcess_GameBase
{
	[Token(Token = "0x17000913")]
	public override string Name
	{
		[Token(Token = "0x60040F8")]
		[Address(RVA = "0x21259E0", Offset = "0x21259E0", VA = "0x21259E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040F5")]
	[Address(RVA = "0x21257F8", Offset = "0x21257F8", VA = "0x21257F8")]
	public XNetCommand_LeaveAccount()
	{
	}

	[Token(Token = "0x60040F6")]
	[Address(RVA = "0x2125808", Offset = "0x2125808", VA = "0x2125808", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040F7")]
	[Address(RVA = "0x21258BC", Offset = "0x21258BC", VA = "0x21258BC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040F9")]
	[Address(RVA = "0x2125A58", Offset = "0x2125A58", VA = "0x2125A58", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040FA")]
	[Address(RVA = "0x2125AAC", Offset = "0x2125AAC", VA = "0x2125AAC", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
