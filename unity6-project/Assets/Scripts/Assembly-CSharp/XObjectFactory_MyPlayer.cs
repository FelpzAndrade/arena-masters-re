using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C2")]
public class XObjectFactory_MyPlayer : XObjectFactory_Actor
{
		protected XObjectFactory_MyPlayer()
		{
		}

	[Token(Token = "0x400131F")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc m_desc;

	[Token(Token = "0x17000528")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x1680B80", Offset = "0x1680B80", VA = "0x1680B80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000529")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x1680C38", Offset = "0x1680C38", VA = "0x1680C38", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700052A")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x1680D74", Offset = "0x1680D74", VA = "0x1680D74", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EA1")]
	[Address(RVA = "0x1680B3C", Offset = "0x1680B3C", VA = "0x1680B3C")]
	public XObjectFactory_MyPlayer(XModuleActor.CreationDesc desc, Vector3 position, Vector3 rotation)
	{
	}

	[Token(Token = "0x6001EA5")]
	[Address(RVA = "0x1680E9C", Offset = "0x1680E9C", VA = "0x1680E9C", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
