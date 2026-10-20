using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007AB")]
public class XNetProcess_FailureMission : XNetProcess_GameBase
{
	[Token(Token = "0x17000893")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x2138B10", Offset = "0x2138B10", VA = "0x2138B10", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000894")]
	public override string Name
	{
		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x2138C3C", Offset = "0x2138C3C", VA = "0x2138C3C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E10")]
	[Address(RVA = "0x2138A4C", Offset = "0x2138A4C", VA = "0x2138A4C")]
	public XNetProcess_FailureMission()
	{
	}

	[Token(Token = "0x6003E11")]
	[Address(RVA = "0x2138A54", Offset = "0x2138A54", VA = "0x2138A54", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E13")]
	[Address(RVA = "0x2138B18", Offset = "0x2138B18", VA = "0x2138B18", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E15")]
	[Address(RVA = "0x2138CB4", Offset = "0x2138CB4", VA = "0x2138CB4", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E16")]
	[Address(RVA = "0x2138CB8", Offset = "0x2138CB8", VA = "0x2138CB8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
