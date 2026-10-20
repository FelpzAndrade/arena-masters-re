using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C5")]
public class XObjectFactory_AIPlayer : XObjectFactory_Actor
{
	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc m_desc;

	[Token(Token = "0x1700052F")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0x167E6A4", Offset = "0x167E6A4", VA = "0x167E6A4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000530")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x167E71C", Offset = "0x167E71C", VA = "0x167E71C", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000531")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x167E724", Offset = "0x167E724", VA = "0x167E724", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EAD")]
	[Address(RVA = "0x167E660", Offset = "0x167E660", VA = "0x167E660")]
	public XObjectFactory_AIPlayer(XModuleActor.CreationDesc desc, Vector3 position, Vector3 rotation)
	{
	}

	[Token(Token = "0x6001EB1")]
	[Address(RVA = "0x167E72C", Offset = "0x167E72C", VA = "0x167E72C", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
