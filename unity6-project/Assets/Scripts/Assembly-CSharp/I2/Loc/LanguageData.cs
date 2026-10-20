using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Serializable]
	[Token(Token = "0x2000080")]
	public class LanguageData
	{
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0xC")]
		public string Code;

		[NonSerialized]
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x10")]
		public bool Compressed;

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD660E0", Offset = "0xD660E0", VA = "0xD660E0")]
		public LanguageData()
		{
		}
	}
}
