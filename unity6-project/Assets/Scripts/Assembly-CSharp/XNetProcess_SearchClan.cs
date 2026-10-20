using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000785")]
public class XNetProcess_SearchClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000867")]
	public override string Name
	{
		[Token(Token = "0x6003D22")]
		[Address(RVA = "0x1EC626C", Offset = "0x1EC626C", VA = "0x1EC626C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D20")]
	[Address(RVA = "0x1EC61A8", Offset = "0x1EC61A8", VA = "0x1EC61A8")]
	public XNetProcess_SearchClan()
	{
	}

	[Token(Token = "0x6003D21")]
	[Address(RVA = "0x1EC61B0", Offset = "0x1EC61B0", VA = "0x1EC61B0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D23")]
	[Address(RVA = "0x1EC62E4", Offset = "0x1EC62E4", VA = "0x1EC62E4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D24")]
	[Address(RVA = "0x1EC6408", Offset = "0x1EC6408", VA = "0x1EC6408", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D25")]
	[Address(RVA = "0x1EC6410", Offset = "0x1EC6410", VA = "0x1EC6410", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
