using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007A7")]
public class XNetProcess_CompleteGame : XNetProcess_GameBase
{
	[Token(Token = "0x1700088B")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003DF6")]
		[Address(RVA = "0x2133FBC", Offset = "0x2133FBC", VA = "0x2133FBC", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700088C")]
	public override string Name
	{
		[Token(Token = "0x6003DF8")]
		[Address(RVA = "0x21340E8", Offset = "0x21340E8", VA = "0x21340E8", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DF4")]
	[Address(RVA = "0x2133EF8", Offset = "0x2133EF8", VA = "0x2133EF8")]
	public XNetProcess_CompleteGame()
	{
	}

	[Token(Token = "0x6003DF5")]
	[Address(RVA = "0x2133F00", Offset = "0x2133F00", VA = "0x2133F00", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DF7")]
	[Address(RVA = "0x2133FC4", Offset = "0x2133FC4", VA = "0x2133FC4", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DF9")]
	[Address(RVA = "0x2134160", Offset = "0x2134160", VA = "0x2134160", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DFA")]
	[Address(RVA = "0x2134224", Offset = "0x2134224", VA = "0x2134224", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
