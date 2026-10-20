using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007D8")]
public class XNetProcess_ShowPet : XNetProcess_GameBase
{
	[Token(Token = "0x170008C2")]
	public override string Name
	{
		[Token(Token = "0x6003F1E")]
		[Address(RVA = "0x1EC7D28", Offset = "0x1EC7D28", VA = "0x1EC7D28", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F1B")]
	[Address(RVA = "0x1EC7B40", Offset = "0x1EC7B40", VA = "0x1EC7B40")]
	public XNetProcess_ShowPet()
	{
	}

	[Token(Token = "0x6003F1C")]
	[Address(RVA = "0x1EC7B48", Offset = "0x1EC7B48", VA = "0x1EC7B48", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F1D")]
	[Address(RVA = "0x1EC7C04", Offset = "0x1EC7C04", VA = "0x1EC7C04", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F1F")]
	[Address(RVA = "0x1EC7DA0", Offset = "0x1EC7DA0", VA = "0x1EC7DA0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F20")]
	[Address(RVA = "0x1EC7DA8", Offset = "0x1EC7DA8", VA = "0x1EC7DA8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
