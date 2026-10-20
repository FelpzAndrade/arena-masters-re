using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007FC")]
public class XNetProcess_ReqeustTransfer : XNetProcess_GameBase
{
	[Token(Token = "0x170008E6")]
	public override string Name
	{
		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x1EC56B4", Offset = "0x1EC56B4", VA = "0x1EC56B4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003FF5")]
	[Address(RVA = "0x1EC54CC", Offset = "0x1EC54CC", VA = "0x1EC54CC")]
	public XNetProcess_ReqeustTransfer()
	{
	}

	[Token(Token = "0x6003FF6")]
	[Address(RVA = "0x1EC54D4", Offset = "0x1EC54D4", VA = "0x1EC54D4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003FF7")]
	[Address(RVA = "0x1EC5590", Offset = "0x1EC5590", VA = "0x1EC5590", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003FF9")]
	[Address(RVA = "0x1EC572C", Offset = "0x1EC572C", VA = "0x1EC572C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003FFA")]
	[Address(RVA = "0x1EC5734", Offset = "0x1EC5734", VA = "0x1EC5734", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
