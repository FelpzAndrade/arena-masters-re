using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007D7")]
public class XNetProcess_GetPet : XNetProcess_GameBase
{
	[Token(Token = "0x170008C1")]
	public override string Name
	{
		[Token(Token = "0x6003F18")]
		[Address(RVA = "0x2140F48", Offset = "0x2140F48", VA = "0x2140F48", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F15")]
	[Address(RVA = "0x2140D60", Offset = "0x2140D60", VA = "0x2140D60")]
	public XNetProcess_GetPet()
	{
	}

	[Token(Token = "0x6003F16")]
	[Address(RVA = "0x2140D68", Offset = "0x2140D68", VA = "0x2140D68", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F17")]
	[Address(RVA = "0x2140E24", Offset = "0x2140E24", VA = "0x2140E24", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F19")]
	[Address(RVA = "0x2140FC0", Offset = "0x2140FC0", VA = "0x2140FC0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F1A")]
	[Address(RVA = "0x2140FC4", Offset = "0x2140FC4", VA = "0x2140FC4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
