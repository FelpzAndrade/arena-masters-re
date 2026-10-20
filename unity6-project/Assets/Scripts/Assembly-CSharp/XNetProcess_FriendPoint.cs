using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200079C")]
public class XNetProcess_FriendPoint : XNetProcess_GameBase
{
	[Token(Token = "0x1700087F")]
	public override string Name
	{
		[Token(Token = "0x6003DAE")]
		[Address(RVA = "0x2139120", Offset = "0x2139120", VA = "0x2139120", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DAB")]
	[Address(RVA = "0x2138F38", Offset = "0x2138F38", VA = "0x2138F38")]
	public XNetProcess_FriendPoint()
	{
	}

	[Token(Token = "0x6003DAC")]
	[Address(RVA = "0x2138F40", Offset = "0x2138F40", VA = "0x2138F40", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DAD")]
	[Address(RVA = "0x2138FFC", Offset = "0x2138FFC", VA = "0x2138FFC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DAF")]
	[Address(RVA = "0x2139198", Offset = "0x2139198", VA = "0x2139198", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DB0")]
	[Address(RVA = "0x213919C", Offset = "0x213919C", VA = "0x213919C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
