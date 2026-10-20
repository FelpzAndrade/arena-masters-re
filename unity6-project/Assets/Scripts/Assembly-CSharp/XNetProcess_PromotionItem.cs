using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C9")]
public class XNetProcess_PromotionItem : XNetProcess_GameBase
{
	[Token(Token = "0x170008B5")]
	public override string Name
	{
		[Token(Token = "0x6003ECB")]
		[Address(RVA = "0x1EC1EEC", Offset = "0x1EC1EEC", VA = "0x1EC1EEC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EC8")]
	[Address(RVA = "0x1EC1D04", Offset = "0x1EC1D04", VA = "0x1EC1D04")]
	public XNetProcess_PromotionItem()
	{
	}

	[Token(Token = "0x6003EC9")]
	[Address(RVA = "0x1EC1D0C", Offset = "0x1EC1D0C", VA = "0x1EC1D0C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003ECA")]
	[Address(RVA = "0x1EC1DC8", Offset = "0x1EC1DC8", VA = "0x1EC1DC8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003ECC")]
	[Address(RVA = "0x1EC1F64", Offset = "0x1EC1F64", VA = "0x1EC1F64", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003ECD")]
	[Address(RVA = "0x1EC1F6C", Offset = "0x1EC1F6C", VA = "0x1EC1F6C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
