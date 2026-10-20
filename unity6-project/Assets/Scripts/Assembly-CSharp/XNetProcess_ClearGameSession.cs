using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007B9")]
public class XNetProcess_ClearGameSession : XNetProcess_GameBase
{
	[Token(Token = "0x170008A3")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x213353C", Offset = "0x213353C", VA = "0x213353C", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170008A4")]
	public override string Name
	{
		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0x2133724", Offset = "0x2133724", VA = "0x2133724", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003E67")]
	[Address(RVA = "0x2133534", Offset = "0x2133534", VA = "0x2133534")]
	public XNetProcess_ClearGameSession()
	{
	}

	[Token(Token = "0x6003E69")]
	[Address(RVA = "0x2133544", Offset = "0x2133544", VA = "0x2133544", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003E6A")]
	[Address(RVA = "0x2133600", Offset = "0x2133600", VA = "0x2133600", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003E6C")]
	[Address(RVA = "0x213379C", Offset = "0x213379C", VA = "0x213379C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003E6D")]
	[Address(RVA = "0x21337A0", Offset = "0x21337A0", VA = "0x21337A0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
