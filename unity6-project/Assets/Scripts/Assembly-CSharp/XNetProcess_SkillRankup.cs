using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000819")]
public class XNetProcess_SkillRankup : XNetProcess_GameBase
{
	[Token(Token = "0x1700090A")]
	public override string Name
	{
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x1EC7F98", Offset = "0x1EC7F98", VA = "0x1EC7F98", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040C4")]
	[Address(RVA = "0x1EC7DB0", Offset = "0x1EC7DB0", VA = "0x1EC7DB0")]
	public XNetProcess_SkillRankup()
	{
	}

	[Token(Token = "0x60040C5")]
	[Address(RVA = "0x1EC7DB8", Offset = "0x1EC7DB8", VA = "0x1EC7DB8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040C6")]
	[Address(RVA = "0x1EC7E74", Offset = "0x1EC7E74", VA = "0x1EC7E74", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040C8")]
	[Address(RVA = "0x1EC8010", Offset = "0x1EC8010", VA = "0x1EC8010", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040C9")]
	[Address(RVA = "0x1EC8018", Offset = "0x1EC8018", VA = "0x1EC8018", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
