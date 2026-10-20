using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000788")]
public class XNetProcess_GetClanStateSequence : XNetProcess_GameBase
{
	[Token(Token = "0x1700086A")]
	public override string Name
	{
		[Token(Token = "0x6003D34")]
		[Address(RVA = "0x213BB18", Offset = "0x213BB18", VA = "0x213BB18", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D32")]
	[Address(RVA = "0x213BA54", Offset = "0x213BA54", VA = "0x213BA54")]
	public XNetProcess_GetClanStateSequence()
	{
	}

	[Token(Token = "0x6003D33")]
	[Address(RVA = "0x213BA5C", Offset = "0x213BA5C", VA = "0x213BA5C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D35")]
	[Address(RVA = "0x213BB90", Offset = "0x213BB90", VA = "0x213BB90", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D36")]
	[Address(RVA = "0x213BCB4", Offset = "0x213BCB4", VA = "0x213BCB4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D37")]
	[Address(RVA = "0x213BCB8", Offset = "0x213BCB8", VA = "0x213BCB8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
