using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200079E")]
public class XNetProcess_GetBlockUserList : XNetProcess_GameBase
{
	[Token(Token = "0x17000881")]
	public override string Name
	{
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x213ACB0", Offset = "0x213ACB0", VA = "0x213ACB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DB7")]
	[Address(RVA = "0x213AAC8", Offset = "0x213AAC8", VA = "0x213AAC8")]
	public XNetProcess_GetBlockUserList()
	{
	}

	[Token(Token = "0x6003DB8")]
	[Address(RVA = "0x213AAD0", Offset = "0x213AAD0", VA = "0x213AAD0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DB9")]
	[Address(RVA = "0x213AB8C", Offset = "0x213AB8C", VA = "0x213AB8C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DBB")]
	[Address(RVA = "0x213AD28", Offset = "0x213AD28", VA = "0x213AD28", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DBC")]
	[Address(RVA = "0x213AD2C", Offset = "0x213AD2C", VA = "0x213AD2C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
