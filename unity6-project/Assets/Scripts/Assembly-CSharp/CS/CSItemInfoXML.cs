using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B00")]
	public sealed class CSItemInfoXML
	{
		[Token(Token = "0x4003633")]
		[FieldOffset(Offset = "0x8")]
		public List<CSItemInfo> dataList;

		[Token(Token = "0x6005109")]
		[Address(RVA = "0x22361C8", Offset = "0x22361C8", VA = "0x22361C8")]
		public CSItemInfoXML()
		{
		}

		[Token(Token = "0x600510A")]
		[Address(RVA = "0x2236274", Offset = "0x2236274", VA = "0x2236274")]
		public void Add(CSItemInfo i)
		{
		}
	}
}
