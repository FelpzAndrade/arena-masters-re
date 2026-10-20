using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000781")]
public class XNetProcess_UpdateClan : XNetProcess_GameBase
{
	[Token(Token = "0x17000863")]
	public override string Name
	{
		[Token(Token = "0x6003D0A")]
		[Address(RVA = "0x1ECADD4", Offset = "0x1ECADD4", VA = "0x1ECADD4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003D08")]
	[Address(RVA = "0x1ECAD10", Offset = "0x1ECAD10", VA = "0x1ECAD10")]
	public XNetProcess_UpdateClan()
	{
	}

	[Token(Token = "0x6003D09")]
	[Address(RVA = "0x1ECAD18", Offset = "0x1ECAD18", VA = "0x1ECAD18", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D0B")]
	[Address(RVA = "0x1ECAE4C", Offset = "0x1ECAE4C", VA = "0x1ECAE4C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D0C")]
	[Address(RVA = "0x1ECAF70", Offset = "0x1ECAF70", VA = "0x1ECAF70", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D0D")]
	[Address(RVA = "0x1ECAF78", Offset = "0x1ECAF78", VA = "0x1ECAF78", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
