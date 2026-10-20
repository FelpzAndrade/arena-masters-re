using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007D9")]
public class XNetProcess_LevelUPPet : XNetProcess_GameBase
{
	[Token(Token = "0x170008C3")]
	public override string Name
	{
		[Token(Token = "0x6003F24")]
		[Address(RVA = "0x1EB9D88", Offset = "0x1EB9D88", VA = "0x1EB9D88", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F21")]
	[Address(RVA = "0x1EB9BA0", Offset = "0x1EB9BA0", VA = "0x1EB9BA0")]
	public XNetProcess_LevelUPPet()
	{
	}

	[Token(Token = "0x6003F22")]
	[Address(RVA = "0x1EB9BA8", Offset = "0x1EB9BA8", VA = "0x1EB9BA8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F23")]
	[Address(RVA = "0x1EB9C64", Offset = "0x1EB9C64", VA = "0x1EB9C64", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F25")]
	[Address(RVA = "0x1EB9E00", Offset = "0x1EB9E00", VA = "0x1EB9E00", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F26")]
	[Address(RVA = "0x1EB9E08", Offset = "0x1EB9E08", VA = "0x1EB9E08", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
