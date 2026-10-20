using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200079F")]
public class XNetProcess_AddBlockFriend : XNetProcess_GameBase
{
	[Token(Token = "0x17000882")]
	public override string Name
	{
		[Token(Token = "0x6003DC0")]
		[Address(RVA = "0x212DFB4", Offset = "0x212DFB4", VA = "0x212DFB4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003DBD")]
	[Address(RVA = "0x212DDCC", Offset = "0x212DDCC", VA = "0x212DDCC")]
	public XNetProcess_AddBlockFriend()
	{
	}

	[Token(Token = "0x6003DBE")]
	[Address(RVA = "0x212DDD4", Offset = "0x212DDD4", VA = "0x212DDD4", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003DBF")]
	[Address(RVA = "0x212DE90", Offset = "0x212DE90", VA = "0x212DE90", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003DC1")]
	[Address(RVA = "0x212E02C", Offset = "0x212E02C", VA = "0x212E02C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003DC2")]
	[Address(RVA = "0x212E030", Offset = "0x212E030", VA = "0x212E030", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
