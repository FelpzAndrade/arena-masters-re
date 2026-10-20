using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A83")]
	public sealed class CSBalanceInfoXML
	{
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0x8")]
		public List<CSBalanceInfo> dataList;

		[Token(Token = "0x6004E0C")]
		[Address(RVA = "0x23F036C", Offset = "0x23F036C", VA = "0x23F036C")]
		public CSBalanceInfoXML()
		{
		}

		[Token(Token = "0x6004E0D")]
		[Address(RVA = "0x23F0418", Offset = "0x23F0418", VA = "0x23F0418")]
		public void Add(CSBalanceInfo i)
		{
		}
	}
}
