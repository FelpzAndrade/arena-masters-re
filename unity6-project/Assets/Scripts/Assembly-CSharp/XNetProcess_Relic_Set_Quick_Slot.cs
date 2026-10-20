using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007E0")]
public class XNetProcess_Relic_Set_Quick_Slot : XNetProcess_GameBase
{
	[Token(Token = "0x170008CA")]
	public override string Name
	{
		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x1EC4C78", Offset = "0x1EC4C78", VA = "0x1EC4C78", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F4B")]
	[Address(RVA = "0x1EC4A90", Offset = "0x1EC4A90", VA = "0x1EC4A90")]
	public XNetProcess_Relic_Set_Quick_Slot()
	{
	}

	[Token(Token = "0x6003F4C")]
	[Address(RVA = "0x1EC4A98", Offset = "0x1EC4A98", VA = "0x1EC4A98", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F4D")]
	[Address(RVA = "0x1EC4B54", Offset = "0x1EC4B54", VA = "0x1EC4B54", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F4F")]
	[Address(RVA = "0x1EC4CF0", Offset = "0x1EC4CF0", VA = "0x1EC4CF0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F50")]
	[Address(RVA = "0x1EC4CF8", Offset = "0x1EC4CF8", VA = "0x1EC4CF8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
