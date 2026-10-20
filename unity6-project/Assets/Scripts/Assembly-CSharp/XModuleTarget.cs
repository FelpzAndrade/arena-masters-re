using Il2CppDummyDll;

[Token(Token = "0x2000490")]
public class XModuleTarget : XModuleBase
{
	[Token(Token = "0x4001700")]
	[FieldOffset(Offset = "0x10")]
	public XModuleEntity m_Target;

	[Token(Token = "0x6002750")]
	[Address(RVA = "0xB98AAC", Offset = "0xB98AAC", VA = "0xB98AAC")]
	public XModuleTarget()
	{
	}

	[Token(Token = "0x6002751")]
	[Address(RVA = "0xB98ABC", Offset = "0xB98ABC", VA = "0xB98ABC", Slot = "4")]
	public override string GetTypeStr()
	{
		return null;
	}

	[Token(Token = "0x6002752")]
	[Address(RVA = "0xB98B34", Offset = "0xB98B34", VA = "0xB98B34")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002753")]
	[Address(RVA = "0xB98B40", Offset = "0xB98B40", VA = "0xB98B40")]
	public XModuleEntity GetTarget()
	{
		return null;
	}

	[Token(Token = "0x6002754")]
	[Address(RVA = "0xB98B48", Offset = "0xB98B48", VA = "0xB98B48", Slot = "59")]
	public virtual void SetTarget(XModuleEntity target, bool isLocal = false)
	{
	}

	[Token(Token = "0x6002755")]
	[Address(RVA = "0xB98CF0", Offset = "0xB98CF0", VA = "0xB98CF0", Slot = "37")]
	public override void OnActorDie(ModuleEventArgument_Hit arg)
	{
	}
}
