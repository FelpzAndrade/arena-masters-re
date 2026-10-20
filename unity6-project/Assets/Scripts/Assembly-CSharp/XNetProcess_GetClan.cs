using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200077E")]
public class XNetProcess_GetClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000860")]
	public override string Name
	{
		[Token(Token = "0x6003CF8")]
		[Address(RVA = "0x213B3B4", Offset = "0x213B3B4", VA = "0x213B3B4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CF6")]
	[Address(RVA = "0x213B2F0", Offset = "0x213B2F0", VA = "0x213B2F0")]
	public XNetProcess_GetClan()
	{
	}

	[Token(Token = "0x6003CF7")]
	[Address(RVA = "0x213B2F8", Offset = "0x213B2F8", VA = "0x213B2F8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CF9")]
	[Address(RVA = "0x213B42C", Offset = "0x213B42C", VA = "0x213B42C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CFA")]
	[Address(RVA = "0x213B550", Offset = "0x213B550", VA = "0x213B550", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CFB")]
	[Address(RVA = "0x213B554", Offset = "0x213B554", VA = "0x213B554", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
