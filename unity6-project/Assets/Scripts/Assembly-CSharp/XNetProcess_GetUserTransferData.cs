using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007F9")]
public class XNetProcess_GetUserTransferData : XNetProcess_GameBase
{
	[Token(Token = "0x170008E3")]
	public override string Name
	{
		[Token(Token = "0x6003FE6")]
		[Address(RVA = "0x1EB6AE4", Offset = "0x1EB6AE4", VA = "0x1EB6AE4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FE3")]
	[Address(RVA = "0x1EB68FC", Offset = "0x1EB68FC", VA = "0x1EB68FC")]
	public XNetProcess_GetUserTransferData()
	{
	}

	[Token(Token = "0x6003FE4")]
	[Address(RVA = "0x1EB6904", Offset = "0x1EB6904", VA = "0x1EB6904", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FE5")]
	[Address(RVA = "0x1EB69C0", Offset = "0x1EB69C0", VA = "0x1EB69C0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FE7")]
	[Address(RVA = "0x1EB6B5C", Offset = "0x1EB6B5C", VA = "0x1EB6B5C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FE8")]
	[Address(RVA = "0x1EB6B64", Offset = "0x1EB6B64", VA = "0x1EB6B64", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
