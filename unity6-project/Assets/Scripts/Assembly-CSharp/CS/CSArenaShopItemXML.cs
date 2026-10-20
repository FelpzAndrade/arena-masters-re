using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A7D")]
	public sealed class CSArenaShopItemXML
	{
		[Token(Token = "0x40030B2")]
		[FieldOffset(Offset = "0x8")]
		public List<CSArenaShopItem> dataList;

		[Token(Token = "0x6004DF0")]
		[Address(RVA = "0x23EEE4C", Offset = "0x23EEE4C", VA = "0x23EEE4C")]
		public CSArenaShopItemXML()
		{
		}

		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x23EEEF8", Offset = "0x23EEEF8", VA = "0x23EEEF8")]
		public void Add(CSArenaShopItem i)
		{
		}
	}
}
