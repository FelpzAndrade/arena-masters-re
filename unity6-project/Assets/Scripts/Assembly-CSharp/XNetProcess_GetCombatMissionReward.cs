using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x200081C")]
public class XNetProcess_GetCombatMissionReward : XNetProcess_GameBase
{
	[Token(Token = "0x1700090E")]
	public override string Name
	{
		[Token(Token = "0x60040DA")]
		[Address(RVA = "0x213C50C", Offset = "0x213C50C", VA = "0x213C50C", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60040D7")]
	[Address(RVA = "0x213C324", Offset = "0x213C324", VA = "0x213C324")]
	public XNetProcess_GetCombatMissionReward()
	{
	}

	[Token(Token = "0x60040D8")]
	[Address(RVA = "0x213C32C", Offset = "0x213C32C", VA = "0x213C32C", Slot = "8")]
	protected override Type MakeNetCommandType()
	{
		return null;
	}

	[Token(Token = "0x60040D9")]
	[Address(RVA = "0x213C3E8", Offset = "0x213C3E8", VA = "0x213C3E8", Slot = "9")]
	protected override CSNetParameters MakeNetParameters()
	{
		return null;
	}

	[Token(Token = "0x60040DB")]
	[Address(RVA = "0x213C584", Offset = "0x213C584", VA = "0x213C584", Slot = "12")]
	public override void Work()
	{
	}

	[Token(Token = "0x60040DC")]
	[Address(RVA = "0x213C588", Offset = "0x213C588", VA = "0x213C588", Slot = "10")]
	protected override bool HandleResponse_User()
	{
		return default(bool);
	}
}
