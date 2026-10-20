using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000772")]
public class XNetProcess_AchievementComplete : XNetProcess_GameBase
{
	[Token(Token = "0x17000850")]
	public override string Name
	{
		[Token(Token = "0x6003CA5")]
		[Address(RVA = "0x212DD48", Offset = "0x212DD48", VA = "0x212DD48", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CA2")]
	[Address(RVA = "0x212DB18", Offset = "0x212DB18", VA = "0x212DB18")]
	public XNetProcess_AchievementComplete()
	{
	}

	[Token(Token = "0x6003CA3")]
	[Address(RVA = "0x212DB20", Offset = "0x212DB20", VA = "0x212DB20", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CA4")]
	[Address(RVA = "0x212DBDC", Offset = "0x212DBDC", VA = "0x212DBDC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CA6")]
	[Address(RVA = "0x212DDC0", Offset = "0x212DDC0", VA = "0x212DDC0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CA7")]
	[Address(RVA = "0x212DDC4", Offset = "0x212DDC4", VA = "0x212DDC4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
