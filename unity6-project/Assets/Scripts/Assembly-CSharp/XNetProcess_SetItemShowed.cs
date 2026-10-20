using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007C4")]
public class XNetProcess_SetItemShowed : XNetProcess_GameBase
{
	[Token(Token = "0x170008AE")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003EA9")]
		[Address(RVA = "0x1EC73D8", Offset = "0x1EC73D8", VA = "0x1EC73D8", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008AF")]
	public override string Name
	{
		[Token(Token = "0x6003EAC")]
		[Address(RVA = "0x1EC75C0", Offset = "0x1EC75C0", VA = "0x1EC75C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003EA8")]
	[Address(RVA = "0x1EC73D0", Offset = "0x1EC73D0", VA = "0x1EC73D0")]
	public XNetProcess_SetItemShowed()
	{
	}

	[Token(Token = "0x6003EAA")]
	[Address(RVA = "0x1EC73E0", Offset = "0x1EC73E0", VA = "0x1EC73E0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003EAB")]
	[Address(RVA = "0x1EC749C", Offset = "0x1EC749C", VA = "0x1EC749C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003EAD")]
	[Address(RVA = "0x1EC7638", Offset = "0x1EC7638", VA = "0x1EC7638", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003EAE")]
	[Address(RVA = "0x1EC7640", Offset = "0x1EC7640", VA = "0x1EC7640", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
