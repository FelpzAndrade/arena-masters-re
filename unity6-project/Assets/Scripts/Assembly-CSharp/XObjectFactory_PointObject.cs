using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003CB")]
public class XObjectFactory_PointObject : XObjectFactory_Actor
{
	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x20")]
	private int actorId;

	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x24")]
	private int dropObjectIndex;

	[Token(Token = "0x17000541")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x1682F8C", Offset = "0x1682F8C", VA = "0x1682F8C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000542")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x1683004", Offset = "0x1683004", VA = "0x1683004", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000543")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x168300C", Offset = "0x168300C", VA = "0x168300C", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001ECC")]
	[Address(RVA = "0x1682F2C", Offset = "0x1682F2C", VA = "0x1682F2C")]
	public XObjectFactory_PointObject(Vector3 position, Vector3 rotation, int actorId, int dropObjectIndex)
	{
	}

	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x168322C", Offset = "0x168322C", VA = "0x168322C", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
