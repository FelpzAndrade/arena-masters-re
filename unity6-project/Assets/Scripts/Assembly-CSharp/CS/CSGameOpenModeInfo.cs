using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AF0")]
	public class CSGameOpenModeInfo
	{
		[Token(Token = "0x40035A0")]
		[FieldOffset(Offset = "0x8")]
		public int ID;

		[Token(Token = "0x40035A1")]
		[FieldOffset(Offset = "0xC")]
		public string startDate;

		[Token(Token = "0x40035A2")]
		[FieldOffset(Offset = "0x10")]
		[XmlIgnore]
		public DateTime startDateTime;

		[Token(Token = "0x40035A3")]
		[FieldOffset(Offset = "0x20")]
		public string endDate;

		[Token(Token = "0x40035A4")]
		[FieldOffset(Offset = "0x28")]
		[XmlIgnore]
		public DateTime endDateTime;

		[Token(Token = "0x40035A5")]
		[FieldOffset(Offset = "0x38")]
		public XGameModeType gameModeType;

		[Token(Token = "0x40035A6")]
		[FieldOffset(Offset = "0x3C")]
		public string strIsRank;

		[Token(Token = "0x40035A7")]
		[FieldOffset(Offset = "0x40")]
		public bool isRank;

		[Token(Token = "0x60050C8")]
		[Address(RVA = "0x2231FAC", Offset = "0x2231FAC", VA = "0x2231FAC")]
		public CSGameOpenModeInfo()
		{
		}

		[Token(Token = "0x60050C9")]
		[Address(RVA = "0x22320A4", Offset = "0x22320A4", VA = "0x22320A4")]
		public bool Cooking()
		{
			return default(bool);
		}

		[Token(Token = "0x60050CA")]
		[Address(RVA = "0x22321B0", Offset = "0x22321B0", VA = "0x22321B0")]
		private bool DateTimeCooking(string strDateTime, ref DateTime dateTime)
		{
			return default(bool);
		}
	}
}
