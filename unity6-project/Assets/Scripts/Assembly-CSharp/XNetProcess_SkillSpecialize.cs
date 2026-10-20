using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007EB")]
public class XNetProcess_SkillSpecialize : XNetProcess_GameBase
{
	[Token(Token = "0x170008D5")]
	public override string Name
	{
		[Token(Token = "0x6003F92")]
		[Address(RVA = "0x1EC8228", Offset = "0x1EC8228", VA = "0x1EC8228", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F8F")]
	[Address(RVA = "0x1EC8040", Offset = "0x1EC8040", VA = "0x1EC8040")]
	public XNetProcess_SkillSpecialize()
	{
	}

	[Token(Token = "0x6003F90")]
	[Address(RVA = "0x1EC8048", Offset = "0x1EC8048", VA = "0x1EC8048", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F91")]
	[Address(RVA = "0x1EC8104", Offset = "0x1EC8104", VA = "0x1EC8104", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F93")]
	[Address(RVA = "0x1EC82A0", Offset = "0x1EC82A0", VA = "0x1EC82A0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F94")]
	[Address(RVA = "0x1EC82A8", Offset = "0x1EC82A8", VA = "0x1EC82A8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
