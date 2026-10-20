using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000789")]
public class XNetProcess_CheckExsistsClanName : XNetProcess_GameBase
{
	[Token(Token = "0x1700086B")]
	public override string Name
	{
		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x2132978", Offset = "0x2132978", VA = "0x2132978", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086C")]
	public override bool showLoadingIcon
	{
		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x2132B14", Offset = "0x2132B14", VA = "0x2132B14", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003D38")]
	[Address(RVA = "0x21328B4", Offset = "0x21328B4", VA = "0x21328B4")]
	public XNetProcess_CheckExsistsClanName()
	{
	}

	[Token(Token = "0x6003D39")]
	[Address(RVA = "0x21328BC", Offset = "0x21328BC", VA = "0x21328BC", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003D3B")]
	[Address(RVA = "0x21329F0", Offset = "0x21329F0", VA = "0x21329F0", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003D3D")]
	[Address(RVA = "0x2132B1C", Offset = "0x2132B1C", VA = "0x2132B1C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003D3E")]
	[Address(RVA = "0x2132B20", Offset = "0x2132B20", VA = "0x2132B20", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
