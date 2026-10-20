using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007A1")]
public class XNetProcess_GetBlockedMeUserList : XNetProcess_GameBase
{
	[Token(Token = "0x17000884")]
	public override string Name
	{
		[Token(Token = "0x6003DCC")]
		[Address(RVA = "0x213AA44", Offset = "0x213AA44", VA = "0x213AA44", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DC9")]
	[Address(RVA = "0x213A85C", Offset = "0x213A85C", VA = "0x213A85C")]
	public XNetProcess_GetBlockedMeUserList()
	{
	}

	[Token(Token = "0x6003DCA")]
	[Address(RVA = "0x213A864", Offset = "0x213A864", VA = "0x213A864", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DCB")]
	[Address(RVA = "0x213A920", Offset = "0x213A920", VA = "0x213A920", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DCD")]
	[Address(RVA = "0x213AABC", Offset = "0x213AABC", VA = "0x213AABC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DCE")]
	[Address(RVA = "0x213AAC0", Offset = "0x213AAC0", VA = "0x213AAC0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
