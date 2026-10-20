using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007EA")]
public class XNetProcess_ClearSkillSpecialize : XNetProcess_GameBase
{
	[Token(Token = "0x170008D4")]
	public override string Name
	{
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x2133990", Offset = "0x2133990", VA = "0x2133990", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F89")]
	[Address(RVA = "0x21337A8", Offset = "0x21337A8", VA = "0x21337A8")]
	public XNetProcess_ClearSkillSpecialize()
	{
	}

	[Token(Token = "0x6003F8A")]
	[Address(RVA = "0x21337B0", Offset = "0x21337B0", VA = "0x21337B0", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F8B")]
	[Address(RVA = "0x213386C", Offset = "0x213386C", VA = "0x213386C", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F8D")]
	[Address(RVA = "0x2133A08", Offset = "0x2133A08", VA = "0x2133A08", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F8E")]
	[Address(RVA = "0x2133A0C", Offset = "0x2133A0C", VA = "0x2133A0C", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
