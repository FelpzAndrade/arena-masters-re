using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007CE")]
public class XNetProcess_UseConsumableItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008BA")]
	public override string Name
	{
		[Token(Token = "0x6003EE9")]
		[Address(RVA = "0x1ECB41C", Offset = "0x1ECB41C", VA = "0x1ECB41C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EE6")]
	[Address(RVA = "0x1ECB234", Offset = "0x1ECB234", VA = "0x1ECB234")]
	public XNetProcess_UseConsumableItem()
	{
	}

	[Token(Token = "0x6003EE7")]
	[Address(RVA = "0x1ECB23C", Offset = "0x1ECB23C", VA = "0x1ECB23C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EE8")]
	[Address(RVA = "0x1ECB2F8", Offset = "0x1ECB2F8", VA = "0x1ECB2F8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EEA")]
	[Address(RVA = "0x1ECB494", Offset = "0x1ECB494", VA = "0x1ECB494", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EEB")]
	[Address(RVA = "0x1ECB49C", Offset = "0x1ECB49C", VA = "0x1ECB49C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
