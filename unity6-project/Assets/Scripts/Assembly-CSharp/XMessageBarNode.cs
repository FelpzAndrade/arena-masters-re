using System;
using CS;
using Il2CppDummyDll;

[Token(Token = "0x2000CEB")]
public class XMessageBarNode : IDisposable, CSPoolEntry
{
	[Token(Token = "0x40041DF")]
	[FieldOffset(Offset = "0x8")]
	public string strText;

	[Token(Token = "0x40041E0")]
	[FieldOffset(Offset = "0xC")]
	public bool bIcon;

	[Token(Token = "0x40041E1")]
	[FieldOffset(Offset = "0x10")]
	public string strIconName;

	[Token(Token = "0x40041E2")]
	[FieldOffset(Offset = "0x14")]
	public bool bMyKill;

	[Token(Token = "0x6005D48")]
	[Address(RVA = "0x1E31494", Offset = "0x1E31494", VA = "0x1E31494")]
	public XMessageBarNode()
	{
	}

	[Token(Token = "0x6005D49")]
	[Address(RVA = "0x1E3149C", Offset = "0x1E3149C", VA = "0x1E3149C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005D4A")]
	[Address(RVA = "0x1E31580", Offset = "0x1E31580", VA = "0x1E31580", Slot = "5")]
	public void OnCleanupInObjectPool()
	{
	}

	[Token(Token = "0x6005D4B")]
	[Address(RVA = "0x1E31584", Offset = "0x1E31584", VA = "0x1E31584", Slot = "6")]
	public virtual void Dispose()
	{
	}
}
