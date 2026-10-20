using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2000066")]
	public struct TranslationRequest
	{
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x0")]
		public string Term;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x4")]
		public string Text;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x8")]
		public string LanguageCode;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0xC")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x10")]
		public string[] Results;
	}
}
