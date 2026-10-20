using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200078C")]
public class XNetProcess_RejectJoinClan : XNetProcess_GameBase
{
	[Token(Token = "0x1700086F")]
	public override string Name
	{
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x1EC4664", Offset = "0x1EC4664", VA = "0x1EC4664", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D4B")]
	[Address(RVA = "0x1EC45A0", Offset = "0x1EC45A0", VA = "0x1EC45A0")]
	public XNetProcess_RejectJoinClan()
	{
	}

	[Token(Token = "0x6003D4C")]
	[Address(RVA = "0x1EC45A8", Offset = "0x1EC45A8", VA = "0x1EC45A8", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D4E")]
	[Address(RVA = "0x1EC46DC", Offset = "0x1EC46DC", VA = "0x1EC46DC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D4F")]
	[Address(RVA = "0x1EC4800", Offset = "0x1EC4800", VA = "0x1EC4800", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D50")]
	[Address(RVA = "0x1EC4808", Offset = "0x1EC4808", VA = "0x1EC4808", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
