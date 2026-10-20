using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BC")]
public class XObjectFactory_NetLevelActor : XObjectFactory_Actor
{
	[Token(Token = "0x400130F")]
	[FieldOffset(Offset = "0x20")]
	private bool isSceneObject;

	[Token(Token = "0x4001310")]
	[FieldOffset(Offset = "0x24")]
	private int actorId;

	[Token(Token = "0x4001311")]
	[FieldOffset(Offset = "0x28")]
	private int level;

	[Token(Token = "0x4001312")]
	[FieldOffset(Offset = "0x2C")]
	private int grade;

	[Token(Token = "0x4001313")]
	[FieldOffset(Offset = "0x30")]
	private XTeamEnum team;

	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x34")]
	private GameObject gameobject;

	[Token(Token = "0x17000515")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001E82")]
		[Address(RVA = "0x1681374", Offset = "0x1681374", VA = "0x1681374", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000516")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001E83")]
		[Address(RVA = "0x16813EC", Offset = "0x16813EC", VA = "0x16813EC", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000517")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E84")]
		[Address(RVA = "0x16813F4", Offset = "0x16813F4", VA = "0x16813F4", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x168123C", Offset = "0x168123C", VA = "0x168123C")]
	public XObjectFactory_NetLevelActor(GameObject go, int actorId, int lev, XTeamEnum team)
	{
	}

	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x16812F4", Offset = "0x16812F4", VA = "0x16812F4")]
	public XObjectFactory_NetLevelActor(Vector3 position, Vector3 rotation, int actorId, int lev, XTeamEnum team)
	{
	}

	[Token(Token = "0x6001E85")]
	[Address(RVA = "0x1681614", Offset = "0x1681614", VA = "0x1681614", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}

	[Token(Token = "0x6001E86")]
	[Address(RVA = "0x168188C", Offset = "0x168188C", VA = "0x168188C", Slot = "7")]
	protected override GameObject CreateGameObject(Vector3 position, Vector3 rotation)
	{
		return null;
	}
}
