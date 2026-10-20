using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B24")]
	public class PremiumTicketInfo
	{
		[Token(Token = "0x40036E4")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x40036E5")]
		[FieldOffset(Offset = "0xC")]
		public string icon;

		[Token(Token = "0x40036E6")]
		[FieldOffset(Offset = "0x10")]
		public ProvideMeans provideMeans_1;

		[Token(Token = "0x40036E7")]
		[FieldOffset(Offset = "0x14")]
		public CSContentType contentType_1;

		[Token(Token = "0x40036E8")]
		[FieldOffset(Offset = "0x18")]
		public int nCount_1;

		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x1C")]
		public ProvideMeans provideMeans_2;

		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x20")]
		public CSContentType contentType_2;

		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0x24")]
		public int nCount_2;

		[Token(Token = "0x40036EC")]
		[FieldOffset(Offset = "0x28")]
		public int nDayDungeon;

		[Token(Token = "0x40036ED")]
		[FieldOffset(Offset = "0x2C")]
		public int nPvpReward;

		[Token(Token = "0x40036EE")]
		[FieldOffset(Offset = "0x30")]
		public double Day;

		[Token(Token = "0x40036EF")]
		[FieldOffset(Offset = "0x38")]
		public string localizationKey;

		[Token(Token = "0x40036F0")]
		[FieldOffset(Offset = "0x3C")]
		public int MaxPaidCrystal;

		[Token(Token = "0x40036F1")]
		[FieldOffset(Offset = "0x40")]
		public int MaxPaidGold;

		[Token(Token = "0x40036F2")]
		[FieldOffset(Offset = "0x44")]
		[XmlIgnore]
		public List<PremiumTicketContent> premiumTicketContentList;

		[Token(Token = "0x60051EC")]
		[Address(RVA = "0x21AE9C4", Offset = "0x21AE9C4", VA = "0x21AE9C4")]
		public PremiumTicketInfo()
		{
		}

		[Token(Token = "0x60051ED")]
		[Address(RVA = "0x21AEA70", Offset = "0x21AEA70", VA = "0x21AEA70")]
		public int GetMaxPaidCurrency(CSContentType ContentType)
		{
			return default(int);
		}

		[Token(Token = "0x60051EE")]
		[Address(RVA = "0x21AEA94", Offset = "0x21AEA94", VA = "0x21AEA94")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
