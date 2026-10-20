using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x20007DD")]
public class XNetProcess_GetFirstRankingReward : XNetProcess_GameBase
{
	[Token(Token = "0x170008C7")]
	public override string Name
	{
		[Token(Token = "0x6003F3C")]
		[Address(RVA = "0x213CC24", Offset = "0x213CC24", VA = "0x213CC24", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003F39")]
	[Address(RVA = "0x213CA3C", Offset = "0x213CA3C", VA = "0x213CA3C")]
	public XNetProcess_GetFirstRankingReward()
	{
	}

	[Token(Token = "0x6003F3A")]
	[Address(RVA = "0x213CA44", Offset = "0x213CA44", VA = "0x213CA44", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x6003F3B")]
	[Address(RVA = "0x213CB00", Offset = "0x213CB00", VA = "0x213CB00", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x6003F3D")]
	[Address(RVA = "0x213CC9C", Offset = "0x213CC9C", VA = "0x213CC9C", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x6003F3E")]
	[Address(RVA = "0x213CCA0", Offset = "0x213CCA0", VA = "0x213CCA0", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
