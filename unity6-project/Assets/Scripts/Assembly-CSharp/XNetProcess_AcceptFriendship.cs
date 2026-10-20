using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000799")]
public class XNetProcess_AcceptFriendship : XNetProcess_GameBase
{
	[Token(Token = "0x1700087C")]
	public override string Name
	{
		[Token(Token = "0x6003D9C")]
		[Address(RVA = "0x212DA74", Offset = "0x212DA74", VA = "0x212DA74", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D99")]
	[Address(RVA = "0x212D88C", Offset = "0x212D88C", VA = "0x212D88C")]
	public XNetProcess_AcceptFriendship()
	{
	}

	[Token(Token = "0x6003D9A")]
	[Address(RVA = "0x212D894", Offset = "0x212D894", VA = "0x212D894", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D9B")]
	[Address(RVA = "0x212D950", Offset = "0x212D950", VA = "0x212D950", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D9D")]
	[Address(RVA = "0x212DAEC", Offset = "0x212DAEC", VA = "0x212DAEC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D9E")]
	[Address(RVA = "0x212DAF0", Offset = "0x212DAF0", VA = "0x212DAF0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
