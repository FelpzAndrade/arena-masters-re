using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000776")]
public class XNetProcess_LevelupChar : XNetProcess_GameBase
{
	[Token(Token = "0x17000856")]
	public override string Name
	{
		[Token(Token = "0x6003CC3")]
		[Address(RVA = "0x1EB9A34", Offset = "0x1EB9A34", VA = "0x1EB9A34", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003CC0")]
	[Address(RVA = "0x1EB984C", Offset = "0x1EB984C", VA = "0x1EB984C")]
	public XNetProcess_LevelupChar()
	{
	}

	[Token(Token = "0x6003CC1")]
	[Address(RVA = "0x1EB9854", Offset = "0x1EB9854", VA = "0x1EB9854", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003CC2")]
	[Address(RVA = "0x1EB9910", Offset = "0x1EB9910", VA = "0x1EB9910", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003CC4")]
	[Address(RVA = "0x1EB9AAC", Offset = "0x1EB9AAC", VA = "0x1EB9AAC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003CC5")]
	[Address(RVA = "0x1EB9AB4", Offset = "0x1EB9AB4", VA = "0x1EB9AB4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
