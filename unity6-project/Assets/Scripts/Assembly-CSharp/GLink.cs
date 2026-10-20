using Il2CppDummyDll;

[Token(Token = "0x200017A")]
public class GLink
{
	[Token(Token = "0x40005A5")]
	[FieldOffset(Offset = "0x0")]
	private static IGLink glink;

	[Token(Token = "0x6000DDA")]
	[Address(RVA = "0x1F33D30", Offset = "0x1F33D30", VA = "0x1F33D30")]
	public GLink()
	{
	}

	[Token(Token = "0x6000DDC")]
	[Address(RVA = "0x1F33D3C", Offset = "0x1F33D3C", VA = "0x1F33D3C")]
	public static IGLink sharedInstance()
	{
		return null;
	}
}
