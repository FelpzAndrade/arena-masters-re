using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007A9")]
public class XNetProcess_CompleteSkyTower : XNetProcess_GameBase
{
	[Token(Token = "0x1700088F")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003E04")]
		[Address(RVA = "0x213458C", Offset = "0x213458C", VA = "0x213458C", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000890")]
	public override string Name
	{
		[Token(Token = "0x6003E06")]
		[Address(RVA = "0x21346B8", Offset = "0x21346B8", VA = "0x21346B8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E02")]
	[Address(RVA = "0x21344C8", Offset = "0x21344C8", VA = "0x21344C8")]
	public XNetProcess_CompleteSkyTower()
	{
	}

	[Token(Token = "0x6003E03")]
	[Address(RVA = "0x21344D0", Offset = "0x21344D0", VA = "0x21344D0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E05")]
	[Address(RVA = "0x2134594", Offset = "0x2134594", VA = "0x2134594", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E07")]
	[Address(RVA = "0x2134730", Offset = "0x2134730", VA = "0x2134730", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E08")]
	[Address(RVA = "0x2134734", Offset = "0x2134734", VA = "0x2134734", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
