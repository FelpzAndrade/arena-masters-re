using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B09")]
	public sealed class CSItemDictionaryInfoXML
	{
		[Token(Token = "0x400364D")]
		[FieldOffset(Offset = "0x8")]
		public List<CSItemDictionaryInfo> dataList;

		[Token(Token = "0x6005133")]
		[Address(RVA = "0x2235848", Offset = "0x2235848", VA = "0x2235848")]
		public CSItemDictionaryInfoXML()
		{
		}

		[Token(Token = "0x6005134")]
		[Address(RVA = "0x22358F4", Offset = "0x22358F4", VA = "0x22358F4")]
		public void Add(CSItemDictionaryInfo i)
		{
		}
	}
}
