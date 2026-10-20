using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B5")]
public class XNetProcess_CloseMatch : XNetProcess_GameBase
{
	[Token(Token = "0x1700089E")]
	public override string Name
	{
		[Token(Token = "0x6003E50")]
		[Address(RVA = "0x2133BFC", Offset = "0x2133BFC", VA = "0x2133BFC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E4D")]
	[Address(RVA = "0x2133A14", Offset = "0x2133A14", VA = "0x2133A14")]
	public XNetProcess_CloseMatch()
	{
	}

	[Token(Token = "0x6003E4E")]
	[Address(RVA = "0x2133A1C", Offset = "0x2133A1C", VA = "0x2133A1C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E4F")]
	[Address(RVA = "0x2133AD8", Offset = "0x2133AD8", VA = "0x2133AD8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E51")]
	[Address(RVA = "0x2133C74", Offset = "0x2133C74", VA = "0x2133C74", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E52")]
	[Address(RVA = "0x2133C78", Offset = "0x2133C78", VA = "0x2133C78", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
