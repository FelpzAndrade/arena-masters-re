using CS;
using Il2CppDummyDll;

[Token(Token = "0x20003C9")]
public class XObjectFactory_ModelPreview : XObjectFactory_Actor
{
	[Token(Token = "0x4001328")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc m_desc;

	[Token(Token = "0x1700053B")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x1680410", Offset = "0x1680410", VA = "0x1680410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700053C")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x1680488", Offset = "0x1680488", VA = "0x1680488", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700053D")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x1680490", Offset = "0x1680490", VA = "0x1680490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EC1")]
	[Address(RVA = "0x168039C", Offset = "0x168039C", VA = "0x168039C")]
	public XObjectFactory_ModelPreview(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0x1680498", Offset = "0x1680498", VA = "0x1680498", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
