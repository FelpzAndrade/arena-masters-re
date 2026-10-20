using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B10")]
	public sealed class CSLotteryBoxXML
	{
		[Token(Token = "0x4003671")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, string> m_ValueMap;

		[Token(Token = "0x4003672")]
		[FieldOffset(Offset = "0xC")]
		public List<CSLotteryInfo> dataList;

		[Token(Token = "0x600514B")]
		[Address(RVA = "0x2238800", Offset = "0x2238800", VA = "0x2238800")]
		public CSLotteryBoxXML()
		{
		}

		[Token(Token = "0x600514C")]
		[Address(RVA = "0x22388E0", Offset = "0x22388E0", VA = "0x22388E0")]
		public void Add(CSLotteryInfo i)
		{
		}
	}
}
