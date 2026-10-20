using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007D0")]
public class XNetProcess_PopAllMail : XNetProcess_GameBase
{
	[Token(Token = "0x170008BC")]
	public override string Name
	{
		[Token(Token = "0x6003EF5")]
		[Address(RVA = "0x1EC19EC", Offset = "0x1EC19EC", VA = "0x1EC19EC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EF2")]
	[Address(RVA = "0x1EC1804", Offset = "0x1EC1804", VA = "0x1EC1804")]
	public XNetProcess_PopAllMail()
	{
	}

	[Token(Token = "0x6003EF3")]
	[Address(RVA = "0x1EC180C", Offset = "0x1EC180C", VA = "0x1EC180C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EF4")]
	[Address(RVA = "0x1EC18C8", Offset = "0x1EC18C8", VA = "0x1EC18C8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EF6")]
	[Address(RVA = "0x1EC1A64", Offset = "0x1EC1A64", VA = "0x1EC1A64", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EF7")]
	[Address(RVA = "0x1EC1A6C", Offset = "0x1EC1A6C", VA = "0x1EC1A6C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
