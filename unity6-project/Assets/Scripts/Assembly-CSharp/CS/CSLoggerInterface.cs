using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008BC")]
	public interface CSLoggerInterface
	{
		[Token(Token = "0x60046A7")]
		void Debug(string text);

		[Token(Token = "0x60046A8")]
		void Info(string text);

		[Token(Token = "0x60046A9")]
		void Warning(string text);

		[Token(Token = "0x60046AA")]
		void Error(string text);
	}
}
