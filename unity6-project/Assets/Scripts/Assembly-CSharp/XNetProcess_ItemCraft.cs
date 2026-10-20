using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007CD")]
public class XNetProcess_ItemCraft : XNetProcess_GameBase
{
	[Token(Token = "0x170008B9")]
	public override string Name
	{
		[Token(Token = "0x6003EE3")]
		[Address(RVA = "0x1EB8FD8", Offset = "0x1EB8FD8", VA = "0x1EB8FD8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EE0")]
	[Address(RVA = "0x1EB8DF0", Offset = "0x1EB8DF0", VA = "0x1EB8DF0")]
	public XNetProcess_ItemCraft()
	{
	}

	[Token(Token = "0x6003EE1")]
	[Address(RVA = "0x1EB8DF8", Offset = "0x1EB8DF8", VA = "0x1EB8DF8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EE2")]
	[Address(RVA = "0x1EB8EB4", Offset = "0x1EB8EB4", VA = "0x1EB8EB4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EE4")]
	[Address(RVA = "0x1EB9050", Offset = "0x1EB9050", VA = "0x1EB9050", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EE5")]
	[Address(RVA = "0x1EB9058", Offset = "0x1EB9058", VA = "0x1EB9058", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
