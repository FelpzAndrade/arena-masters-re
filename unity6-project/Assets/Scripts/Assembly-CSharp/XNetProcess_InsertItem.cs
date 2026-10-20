using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007BF")]
public class XNetProcess_InsertItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008A9")]
	public override string Name
	{
		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0x1EB8624", Offset = "0x1EB8624", VA = "0x1EB8624", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E8A")]
	[Address(RVA = "0x1EB843C", Offset = "0x1EB843C", VA = "0x1EB843C")]
	public XNetProcess_InsertItem()
	{
	}

	[Token(Token = "0x6003E8B")]
	[Address(RVA = "0x1EB8444", Offset = "0x1EB8444", VA = "0x1EB8444", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E8C")]
	[Address(RVA = "0x1EB8500", Offset = "0x1EB8500", VA = "0x1EB8500", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E8E")]
	[Address(RVA = "0x1EB869C", Offset = "0x1EB869C", VA = "0x1EB869C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E8F")]
	[Address(RVA = "0x1EB86A4", Offset = "0x1EB86A4", VA = "0x1EB86A4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
