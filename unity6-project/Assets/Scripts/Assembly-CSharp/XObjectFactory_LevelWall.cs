using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BE")]
public class XObjectFactory_LevelWall : XObjectFactory_Actor
{
	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x20")]
	private int actorId;

	[Token(Token = "0x1700051B")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x167F7E8", Offset = "0x167F7E8", VA = "0x167F7E8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051C")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x167F860", Offset = "0x167F860", VA = "0x167F860", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700051D")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x167F868", Offset = "0x167F868", VA = "0x167F868", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E8C")]
	[Address(RVA = "0x167F794", Offset = "0x167F794", VA = "0x167F794")]
	public XObjectFactory_LevelWall(Vector3 position, Vector3 rotation, int actorId)
	{
	}

	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x167FA88", Offset = "0x167FA88", VA = "0x167FA88", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
