using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B0E")]
	public sealed class CSLotteryInfo
	{
		[Token(Token = "0x4003664")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x4003665")]
		[FieldOffset(Offset = "0xC")]
		public string strName;

		[Token(Token = "0x4003666")]
		[FieldOffset(Offset = "0x10")]
		public string strIcon;

		[Token(Token = "0x4003667")]
		[FieldOffset(Offset = "0x14")]
		public string strDesc;

		[Token(Token = "0x4003668")]
		[FieldOffset(Offset = "0x18")]
		public CSContentType nType;

		[Token(Token = "0x4003669")]
		[FieldOffset(Offset = "0x1C")]
		public int nContentsID;

		[Token(Token = "0x400366A")]
		[FieldOffset(Offset = "0x20")]
		public int nAmount;

		[Token(Token = "0x400366B")]
		[FieldOffset(Offset = "0x24")]
		public float fChance;

		[Token(Token = "0x17000BD2")]
		public int nChance
		{
			[Token(Token = "0x6005146")]
			[Address(RVA = "0x2238A88", Offset = "0x2238A88", VA = "0x2238A88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6005145")]
		[Address(RVA = "0x2238980", Offset = "0x2238980", VA = "0x2238980")]
		public CSLotteryInfo()
		{
		}

		[Token(Token = "0x6005147")]
		[Address(RVA = "0x2238AE0", Offset = "0x2238AE0", VA = "0x2238AE0")]
		public CSContent GetContent()
		{
			return null;
		}

		[Token(Token = "0x6005148")]
		[Address(RVA = "0x2238B8C", Offset = "0x2238B8C", VA = "0x2238B8C")]
		public bool IsItemType()
		{
			return default(bool);
		}
	}
}
