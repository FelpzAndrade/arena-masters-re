using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BD")]
public class XObjectFactory_LevelActor : XObjectFactory_Actor
{
	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x20")]
	private int actorId;

	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x24")]
	private int level;

	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x28")]
	private int grade;

	[Token(Token = "0x17000518")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001E88")]
		[Address(RVA = "0x167EED4", Offset = "0x167EED4", VA = "0x167EED4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000519")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001E89")]
		[Address(RVA = "0x167EF4C", Offset = "0x167EF4C", VA = "0x167EF4C", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700051A")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E8A")]
		[Address(RVA = "0x167EF54", Offset = "0x167EF54", VA = "0x167EF54", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E87")]
	[Address(RVA = "0x167EE64", Offset = "0x167EE64", VA = "0x167EE64")]
	public XObjectFactory_LevelActor(Vector3 position, Vector3 rotation, int actorId, int lev)
	{
	}

	[Token(Token = "0x6001E8B")]
	[Address(RVA = "0x167F174", Offset = "0x167F174", VA = "0x167F174", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
