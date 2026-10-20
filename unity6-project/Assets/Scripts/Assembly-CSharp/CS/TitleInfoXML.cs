using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B81")]
	public sealed class TitleInfoXML
	{
		[Token(Token = "0x4003A27")]
		[FieldOffset(Offset = "0x8")]
		public List<TitleInfo> m_talent;

		[Token(Token = "0x600535F")]
		[Address(RVA = "0x21E9498", Offset = "0x21E9498", VA = "0x21E9498")]
		public TitleInfoXML()
		{
		}

		[Token(Token = "0x6005360")]
		[Address(RVA = "0x21E9544", Offset = "0x21E9544", VA = "0x21E9544")]
		public void Add(TitleInfo val)
		{
		}
	}
}
