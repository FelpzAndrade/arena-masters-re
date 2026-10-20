using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007D6")]
public class XNetProcess_InsertPet : XNetProcess_GameBase
{
	[Token(Token = "0x170008C0")]
	public override string Name
	{
		[Token(Token = "0x6003F12")]
		[Address(RVA = "0x1EB8894", Offset = "0x1EB8894", VA = "0x1EB8894", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F0F")]
	[Address(RVA = "0x1EB86AC", Offset = "0x1EB86AC", VA = "0x1EB86AC")]
	public XNetProcess_InsertPet()
	{
	}

	[Token(Token = "0x6003F10")]
	[Address(RVA = "0x1EB86B4", Offset = "0x1EB86B4", VA = "0x1EB86B4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F11")]
	[Address(RVA = "0x1EB8770", Offset = "0x1EB8770", VA = "0x1EB8770", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F13")]
	[Address(RVA = "0x1EB890C", Offset = "0x1EB890C", VA = "0x1EB890C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F14")]
	[Address(RVA = "0x1EB8914", Offset = "0x1EB8914", VA = "0x1EB8914", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
