using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003CA")]
public class XObjectFactory_NetMonster : XObjectFactory_Actor
{
	[Token(Token = "0x4001329")]
	private const string PrefabPath = "Prefab/Character/NetMonster";

	[Token(Token = "0x400132A")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc m_desc;

	[Token(Token = "0x400132B")]
	[FieldOffset(Offset = "0x24")]
	private bool isSceneObject;

	[Token(Token = "0x400132C")]
	[FieldOffset(Offset = "0x28")]
	private GameObject gameobject;

	[Token(Token = "0x1700053E")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x1681F9C", Offset = "0x1681F9C", VA = "0x1681F9C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053F")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x1682014", Offset = "0x1682014", VA = "0x1682014", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000540")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x168201C", Offset = "0x168201C", VA = "0x168201C", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x1681F50", Offset = "0x1681F50", VA = "0x1681F50")]
	public XObjectFactory_NetMonster(XModuleActor.CreationDesc desc, Vector3 position, Vector3 rotation)
	{
	}

	[Token(Token = "0x6001ECA")]
	[Address(RVA = "0x1682024", Offset = "0x1682024", VA = "0x1682024", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}

	[Token(Token = "0x6001ECB")]
	[Address(RVA = "0x1682260", Offset = "0x1682260", VA = "0x1682260", Slot = "7")]
	protected override GameObject CreateGameObject(Vector3 position, Vector3 rotation)
	{
		return null;
	}
}
