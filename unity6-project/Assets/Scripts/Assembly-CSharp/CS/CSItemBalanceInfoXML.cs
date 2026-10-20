using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B06")]
	public sealed class CSItemBalanceInfoXML
	{
		[Token(Token = "0x400364B")]
		[FieldOffset(Offset = "0x8")]
		public List<CSItemBalanceInfo> dataList;

		[Token(Token = "0x6005123")]
		[Address(RVA = "0x22356EC", Offset = "0x22356EC", VA = "0x22356EC")]
		public CSItemBalanceInfoXML()
		{
		}

		[Token(Token = "0x6005124")]
		[Address(RVA = "0x2235798", Offset = "0x2235798", VA = "0x2235798")]
		public void Add(CSItemBalanceInfo i)
		{
		}
	}
}
