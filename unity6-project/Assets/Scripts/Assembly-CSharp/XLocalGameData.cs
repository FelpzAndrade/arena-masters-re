using Il2CppDummyDll;

[Token(Token = "0x2000626")]
public class XLocalGameData
{
	[Token(Token = "0x4001DB7")]
	[FieldOffset(Offset = "0x8")]
	public int InstantRespawnCount;

	[Token(Token = "0x4001DB8")]
	[FieldOffset(Offset = "0xC")]
	public int NewbieConsecutiveLoseCount;

	[Token(Token = "0x60034F9")]
	[Address(RVA = "0x1E25A20", Offset = "0x1E25A20", VA = "0x1E25A20")]
	public XLocalGameData()
	{
	}

	[Token(Token = "0x60034FA")]
	[Address(RVA = "0x1E25A28", Offset = "0x1E25A28", VA = "0x1E25A28", Slot = "4")]
	public virtual void Save()
	{
	}

	[Token(Token = "0x60034FB")]
	[Address(RVA = "0x1E25BCC", Offset = "0x1E25BCC", VA = "0x1E25BCC")]
	public void Reset()
	{
	}
}
