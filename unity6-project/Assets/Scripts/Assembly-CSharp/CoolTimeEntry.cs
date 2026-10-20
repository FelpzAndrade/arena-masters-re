using Il2CppDummyDll;

[Token(Token = "0x2000BA6")]
public class CoolTimeEntry
{
	[Token(Token = "0x4003B35")]
	[FieldOffset(Offset = "0x8")]
	public float remain;

	[Token(Token = "0x6005447")]
	[Address(RVA = "0x20D2D40", Offset = "0x20D2D40", VA = "0x20D2D40")]
	public CoolTimeEntry()
	{
	}

	[Token(Token = "0x6005448")]
	[Address(RVA = "0x20D2D48", Offset = "0x20D2D48", VA = "0x20D2D48")]
	public void UpdateDelta(float _delta)
	{
	}

	[Token(Token = "0x6005449")]
	[Address(RVA = "0x20D2D5C", Offset = "0x20D2D5C", VA = "0x20D2D5C")]
	public void AdjustRemain(float _remain)
	{
	}
}
