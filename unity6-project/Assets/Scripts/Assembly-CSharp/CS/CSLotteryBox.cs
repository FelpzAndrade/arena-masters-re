using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B0F")]
	public class CSLotteryBox
	{
		[Token(Token = "0x400366C")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x400366D")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		[Token(Token = "0x400366E")]
		[FieldOffset(Offset = "0x10")]
		public string strIcon;

		[Token(Token = "0x400366F")]
		[FieldOffset(Offset = "0x14")]
		public string strDesc;

		[Token(Token = "0x4003670")]
		[FieldOffset(Offset = "0x18")]
		public List<CSLotteryInfo> Items;

		[Token(Token = "0x6005149")]
		[Address(RVA = "0x2238574", Offset = "0x2238574", VA = "0x2238574")]
		public CSLotteryBox()
		{
		}

		[Token(Token = "0x600514A")]
		[Address(RVA = "0x22386A4", Offset = "0x22386A4", VA = "0x22386A4")]
		public CSLotteryBox(CSLotteryInfo info)
		{
		}
	}
}
