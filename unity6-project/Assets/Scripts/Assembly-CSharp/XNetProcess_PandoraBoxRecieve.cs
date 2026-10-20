using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007D5")]
public class XNetProcess_PandoraBoxRecieve : XNetProcess_GameBase
{
	[Token(Token = "0x170008BF")]
	public override string Name
	{
		[Token(Token = "0x6003F0C")]
		[Address(RVA = "0x1EBF874", Offset = "0x1EBF874", VA = "0x1EBF874", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F09")]
	[Address(RVA = "0x1EBF68C", Offset = "0x1EBF68C", VA = "0x1EBF68C")]
	public XNetProcess_PandoraBoxRecieve()
	{
	}

	[Token(Token = "0x6003F0A")]
	[Address(RVA = "0x1EBF694", Offset = "0x1EBF694", VA = "0x1EBF694", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F0B")]
	[Address(RVA = "0x1EBF750", Offset = "0x1EBF750", VA = "0x1EBF750", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F0D")]
	[Address(RVA = "0x1EBF8EC", Offset = "0x1EBF8EC", VA = "0x1EBF8EC", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F0E")]
	[Address(RVA = "0x1EBF8F4", Offset = "0x1EBF8F4", VA = "0x1EBF8F4", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
