using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000783")]
public class XNetProcess_JoinClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000865")]
	public override string Name
	{
		[Token(Token = "0x6003D16")]
		[Address(RVA = "0x1EB9144", Offset = "0x1EB9144", VA = "0x1EB9144", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D14")]
	[Address(RVA = "0x1EB9080", Offset = "0x1EB9080", VA = "0x1EB9080")]
	public XNetProcess_JoinClan()
	{
	}

	[Token(Token = "0x6003D15")]
	[Address(RVA = "0x1EB9088", Offset = "0x1EB9088", VA = "0x1EB9088", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D17")]
	[Address(RVA = "0x1EB91BC", Offset = "0x1EB91BC", VA = "0x1EB91BC", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D18")]
	[Address(RVA = "0x1EB92E0", Offset = "0x1EB92E0", VA = "0x1EB92E0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D19")]
	[Address(RVA = "0x1EB92E8", Offset = "0x1EB92E8", VA = "0x1EB92E8", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
