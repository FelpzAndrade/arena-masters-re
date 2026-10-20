using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BF")]
public class XObjectFactory_LevelMapObject : XObjectFactory_Actor
{
	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x20")]
	private int actorId;

	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x24")]
	private int lev;

	[Token(Token = "0x1700051E")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x167F330", Offset = "0x167F330", VA = "0x167F330", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700051F")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x167F3A8", Offset = "0x167F3A8", VA = "0x167F3A8", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000520")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x167F3B0", Offset = "0x167F3B0", VA = "0x167F3B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x167F2CC", Offset = "0x167F2CC", VA = "0x167F2CC")]
	public XObjectFactory_LevelMapObject(Vector3 position, Vector3 rotation, int actorId, int lev)
	{
	}

	[Token(Token = "0x6001E95")]
	[Address(RVA = "0x167F5D0", Offset = "0x167F5D0", VA = "0x167F5D0", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
