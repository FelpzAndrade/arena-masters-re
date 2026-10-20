using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007AD")]
public class XNetProcess_PayEvnetModeOpenCost : XNetProcess_GameBase
{
	[Token(Token = "0x17000896")]
	public override string Name
	{
		[Token(Token = "0x6003E20")]
		[Address(RVA = "0x1EBFB10", Offset = "0x1EBFB10", VA = "0x1EBFB10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E1D")]
	[Address(RVA = "0x1EBF928", Offset = "0x1EBF928", VA = "0x1EBF928")]
	public XNetProcess_PayEvnetModeOpenCost()
	{
	}

	[Token(Token = "0x6003E1E")]
	[Address(RVA = "0x1EBF930", Offset = "0x1EBF930", VA = "0x1EBF930", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E1F")]
	[Address(RVA = "0x1EBF9EC", Offset = "0x1EBF9EC", VA = "0x1EBF9EC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E21")]
	[Address(RVA = "0x1EBFB88", Offset = "0x1EBFB88", VA = "0x1EBFB88", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E22")]
	[Address(RVA = "0x1EBFB90", Offset = "0x1EBFB90", VA = "0x1EBFB90", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
