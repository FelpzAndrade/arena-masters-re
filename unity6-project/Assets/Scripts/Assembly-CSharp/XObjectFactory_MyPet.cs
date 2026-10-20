using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C1")]
public class XObjectFactory_MyPet : XObjectFactory_Actor
{
	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc m_desc;

	[Token(Token = "0x400131D")]
	[FieldOffset(Offset = "0x24")]
	private XModuleEntity ownerMe;

	[Token(Token = "0x400131E")]
	[FieldOffset(Offset = "0x28")]
	private int actorId;

	[Token(Token = "0x17000525")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x1680658", Offset = "0x1680658", VA = "0x1680658", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000526")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x1680700", Offset = "0x1680700", VA = "0x1680700", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000527")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x1680708", Offset = "0x1680708", VA = "0x1680708", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001E9C")]
	[Address(RVA = "0x16805D4", Offset = "0x16805D4", VA = "0x16805D4")]
	public XObjectFactory_MyPet(XModuleActor.CreationDesc desc, Vector3 position, Vector3 rotation, XModuleEntity playerMe)
	{
	}

	[Token(Token = "0x6001EA0")]
	[Address(RVA = "0x1680928", Offset = "0x1680928", VA = "0x1680928", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
