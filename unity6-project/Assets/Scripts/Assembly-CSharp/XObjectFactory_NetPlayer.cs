using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003C4")]
public class XObjectFactory_NetPlayer : XObjectFactory_Actor
{
	[Token(Token = "0x4001320")]
	[FieldOffset(Offset = "0x20")]
	private GameObject go;

	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0x24")]
	private XModuleActor.CreationDesc m_desc;

	[Token(Token = "0x1700052C")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x1682630", Offset = "0x1682630", VA = "0x1682630", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700052D")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x16826A8", Offset = "0x16826A8", VA = "0x16826A8", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700052E")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0x16827E4", Offset = "0x16827E4", VA = "0x16827E4", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EA8")]
	[Address(RVA = "0x16825B0", Offset = "0x16825B0", VA = "0x16825B0")]
	public XObjectFactory_NetPlayer(GameObject go, XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x6001EAC")]
	[Address(RVA = "0x16827EC", Offset = "0x16827EC", VA = "0x16827EC", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
