using Il2CppDummyDll;

[Token(Token = "0x2000BE3")]
public class UniClipboard
{
	[Token(Token = "0x4003C41")]
	[FieldOffset(Offset = "0x0")]
	private static IBoard _board;

	[Token(Token = "0x17000C94")]
	private static IBoard board
	{
		[Token(Token = "0x60055F7")]
		[Address(RVA = "0x17B1BE8", Offset = "0x17B1BE8", VA = "0x17B1BE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60055F6")]
	[Address(RVA = "0x17B1BE0", Offset = "0x17B1BE0", VA = "0x17B1BE0")]
	public UniClipboard()
	{
	}

	[Token(Token = "0x60055F8")]
	[Address(RVA = "0x17B1CB8", Offset = "0x17B1CB8", VA = "0x17B1CB8")]
	public static void SetText(string str)
	{
	}

	[Token(Token = "0x60055F9")]
	[Address(RVA = "0x17B1E24", Offset = "0x17B1E24", VA = "0x17B1E24")]
	public static string GetText()
	{
		return null;
	}
}
