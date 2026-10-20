using Il2CppDummyDll;

[Token(Token = "0x2000190")]
public class GLinkStatistics
{
	[Token(Token = "0x40005C0")]
	public const string kCurrencyNone = "NONE";

	[Token(Token = "0x40005C1")]
	public const string kCurrencyWon = "WON";

	[Token(Token = "0x40005C2")]
	public const string kCurrencyDollar = "DOLLAR";

	[Token(Token = "0x40005C3")]
	public const string kMarketNone = "NONE";

	[Token(Token = "0x40005C4")]
	public const string kMarketOne = "ONE";

	[Token(Token = "0x40005C5")]
	public const string kMarketGoogle = "GOOGLE";

	[Token(Token = "0x40005C6")]
	public const string kMarketApple = "APPLE";

	[Token(Token = "0x40005C7")]
	[FieldOffset(Offset = "0x0")]
	private static IGLinkStatistics glinkStatistics;

	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x1F37D94", Offset = "0x1F37D94", VA = "0x1F37D94")]
	public GLinkStatistics()
	{
	}

	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x1F37DA0", Offset = "0x1F37DA0", VA = "0x1F37DA0")]
	public static IGLinkStatistics sharedInstance()
	{
		return null;
	}
}
