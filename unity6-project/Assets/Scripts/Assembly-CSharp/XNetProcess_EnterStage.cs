using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B0")]
public class XNetProcess_EnterStage : XNetProcess_GameBase
{
	[Token(Token = "0x17000899")]
	public override string Name
	{
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x2138248", Offset = "0x2138248", VA = "0x2138248", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E2F")]
	[Address(RVA = "0x2137FC0", Offset = "0x2137FC0", VA = "0x2137FC0")]
	public XNetProcess_EnterStage()
	{
	}

	[Token(Token = "0x6003E30")]
	[Address(RVA = "0x2137FC8", Offset = "0x2137FC8", VA = "0x2137FC8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E31")]
	[Address(RVA = "0x2138084", Offset = "0x2138084", VA = "0x2138084", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E33")]
	[Address(RVA = "0x21382C0", Offset = "0x21382C0", VA = "0x21382C0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E34")]
	[Address(RVA = "0x2138384", Offset = "0x2138384", VA = "0x2138384", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
