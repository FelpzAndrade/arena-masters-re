using Il2CppDummyDll;

[Token(Token = "0x2000B99")]
public static class Encrypt
{
	[Token(Token = "0x4003B26")]
	private const string initVector = "pemgail9uzpgzl88";

	[Token(Token = "0x4003B27")]
	private const int keysize = 256;

	[Token(Token = "0x4003B28")]
	private const string passPhrase = "1234512345678976";

	[Token(Token = "0x60053F9")]
	[Address(RVA = "0x1E697B0", Offset = "0x1E697B0", VA = "0x1E697B0")]
	public static byte[] EncryptByte(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60053FA")]
	[Address(RVA = "0x1E69834", Offset = "0x1E69834", VA = "0x1E69834")]
	public static byte[] EncryptByte(byte[] plainTextBytes, string passPhrase)
	{
		return null;
	}

	[Token(Token = "0x60053FB")]
	[Address(RVA = "0x1E69E68", Offset = "0x1E69E68", VA = "0x1E69E68")]
	public static byte[] DecryptByte(byte[] bytes)
	{
		return null;
	}

	[Token(Token = "0x60053FC")]
	[Address(RVA = "0x1E69EEC", Offset = "0x1E69EEC", VA = "0x1E69EEC")]
	public static byte[] DecryptByte(byte[] cipherTextBytes, string passPhrase)
	{
		return null;
	}
}
