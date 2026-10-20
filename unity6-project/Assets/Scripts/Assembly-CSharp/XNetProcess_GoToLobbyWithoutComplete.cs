using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007A6")]
public class XNetProcess_GoToLobbyWithoutComplete : XNetProcess_GameBase
{
	[Token(Token = "0x1700088A")]
	public override string Name
	{
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x1EB7268", Offset = "0x1EB7268", VA = "0x1EB7268", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DEE")]
	[Address(RVA = "0x1EB7080", Offset = "0x1EB7080", VA = "0x1EB7080")]
	public XNetProcess_GoToLobbyWithoutComplete()
	{
	}

	[Token(Token = "0x6003DEF")]
	[Address(RVA = "0x1EB7088", Offset = "0x1EB7088", VA = "0x1EB7088", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DF0")]
	[Address(RVA = "0x1EB7144", Offset = "0x1EB7144", VA = "0x1EB7144", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DF2")]
	[Address(RVA = "0x1EB72E0", Offset = "0x1EB72E0", VA = "0x1EB72E0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DF3")]
	[Address(RVA = "0x1EB72E8", Offset = "0x1EB72E8", VA = "0x1EB72E8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
