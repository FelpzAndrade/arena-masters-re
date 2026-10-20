using Il2CppDummyDll;

[Token(Token = "0x20003A5")]
public class XShieldBuff
{
	[Token(Token = "0x40012E3")]
	[FieldOffset(Offset = "0x8")]
	public int MaxShield;

	[Token(Token = "0x40012E4")]
	[FieldOffset(Offset = "0xC")]
	public int CurrShield;

	[Token(Token = "0x40012E5")]
	[FieldOffset(Offset = "0x10")]
	public int BuffID;

	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x181C9CC", Offset = "0x181C9CC", VA = "0x181C9CC")]
	public XShieldBuff()
	{
	}

	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0x181C9D4", Offset = "0x181C9D4", VA = "0x181C9D4")]
	public XShieldBuff(int buffId, int maxShiled)
	{
	}

	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0x181CA00", Offset = "0x181CA00", VA = "0x181CA00")]
	public void SetMaxShield(int maxShield)
	{
	}
}
