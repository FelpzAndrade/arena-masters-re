using Il2CppDummyDll;

namespace CS
{
	// Reconstruido a partir do pseudo-C (Ghidra) de libil2cpp.so.
	[Token(Token = "0x20008BB")]
	public static class CSLog
	{
		[Token(Token = "0x4002A96")]
		[FieldOffset(Offset = "0x0")]
		private static CSLoggerInterface logger;

		[Token(Token = "0x60046A1")]
		[Address(RVA = "0x2236FF8", Offset = "0x2236FF8", VA = "0x2236FF8")]
		public static void Init(CSLoggerInterface logger)
		{
			CSLog.logger = logger;
		}

		[Token(Token = "0x60046A2")]
		[Address(RVA = "0x22370AC", Offset = "0x22370AC", VA = "0x22370AC")]
		public static void Debug(string text, params object[] args)
		{
			if (logger != null)
			{
				logger.Debug(string.Format(text, args));
			}
		}

		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x223729C", Offset = "0x223729C", VA = "0x223729C")]
		public static void Debug(string text)
		{
			if (logger != null)
			{
				logger.Debug(text);
			}
		}

		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x2237438", Offset = "0x2237438", VA = "0x2237438")]
		public static void Info(string text, params object[] args)
		{
			if (logger != null)
			{
				logger.Info(string.Format(text, args));
			}
		}

		[Token(Token = "0x60046A5")]
		[Address(RVA = "0x2237720", Offset = "0x2237720", VA = "0x2237720")]
		public static void Warning(string text, params object[] args)
		{
			if (logger != null)
			{
				logger.Warning(string.Format(text, args));
			}
		}

		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x222FA14", Offset = "0x222FA14", VA = "0x222FA14")]
		public static void Error(string text, params object[] args)
		{
			if (logger != null)
			{
				logger.Error(string.Format(text, args));
			}
		}
	}
}
