using CS;
using Il2CppDummyDll;

[Token(Token = "0x20003C6")]
public class XObjectFactory_ResultPlayer : XObjectFactory_Actor
{
	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x20")]
	private XModuleActor.CreationDesc m_desc;

	[Token(Token = "0x17000532")]
	protected override string PrefabName
	{
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x16834FC", Offset = "0x16834FC", VA = "0x16834FC", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000533")]
	protected override bool IsNetworkObject
	{
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x1683574", Offset = "0x1683574", VA = "0x1683574", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000534")]
	protected override CSCharacterInfo actorInfo
	{
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x168357C", Offset = "0x168357C", VA = "0x168357C", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001EB2")]
	[Address(RVA = "0x1683488", Offset = "0x1683488", VA = "0x1683488")]
	public XObjectFactory_ResultPlayer(XModuleActor.CreationDesc desc)
	{
	}

	[Token(Token = "0x6001EB6")]
	[Address(RVA = "0x1683584", Offset = "0x1683584", VA = "0x1683584", Slot = "6")]
	public override XModuleEntity Run()
	{
		return null;
	}
}
