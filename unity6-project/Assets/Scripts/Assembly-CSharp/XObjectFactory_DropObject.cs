using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003BB")]
public class XObjectFactory_DropObject : XObjectFactory_Actor
{
	[Token(Token = "0x400130E")]
	[FieldOffset(Offset = "0x20")]
	private int actorId;

	[Token(Token = "0x17000512")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001E7C")]
		[Address(RVA = "0x167E990", Offset = "0x167E990", VA = "0x167E990", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000513")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001E7D")]
		[Address(RVA = "0x167EA08", Offset = "0x167EA08", VA = "0x167EA08", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000514")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E7E")]
		[Address(RVA = "0x167EA10", Offset = "0x167EA10", VA = "0x167EA10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E7B")]
	[Address(RVA = "0x167E93C", Offset = "0x167E93C", VA = "0x167E93C")]
	public XObjectFactory_DropObject(Vector3 position, Vector3 rotation, int actorId)
	{
	}

	[Token(Token = "0x6001E7F")]
	[Address(RVA = "0x167EC30", Offset = "0x167EC30", VA = "0x167EC30", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
