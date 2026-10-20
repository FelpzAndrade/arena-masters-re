using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B4B")]
	public sealed class CSShopItemXML
	{
		[Token(Token = "0x4003877")]
		[FieldOffset(Offset = "0x8")]
		public List<CSShopItem> dataList;

		[Token(Token = "0x600529E")]
		[Address(RVA = "0x1CD2770", Offset = "0x1CD2770", VA = "0x1CD2770")]
		public CSShopItemXML()
		{
		}

		[Token(Token = "0x600529F")]
		[Address(RVA = "0x1CD281C", Offset = "0x1CD281C", VA = "0x1CD281C")]
		public void Add(CSShopItem i)
		{
		}
	}
}
