using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007DB")]
public class XNetProcess_GetRanker : XNetProcess_GameBase
{
	[Token(Token = "0x170008C5")]
	public override string Name
	{
		[Token(Token = "0x6003F30")]
		[Address(RVA = "0x2142B68", Offset = "0x2142B68", VA = "0x2142B68", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F2D")]
	[Address(RVA = "0x2142980", Offset = "0x2142980", VA = "0x2142980")]
	public XNetProcess_GetRanker()
	{
	}

	[Token(Token = "0x6003F2E")]
	[Address(RVA = "0x2142988", Offset = "0x2142988", VA = "0x2142988", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F2F")]
	[Address(RVA = "0x2142A44", Offset = "0x2142A44", VA = "0x2142A44", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F31")]
	[Address(RVA = "0x2142BE0", Offset = "0x2142BE0", VA = "0x2142BE0", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F32")]
	[Address(RVA = "0x2142BE4", Offset = "0x2142BE4", VA = "0x2142BE4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
