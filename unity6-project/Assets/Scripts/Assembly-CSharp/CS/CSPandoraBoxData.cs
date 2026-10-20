using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B1E")]
	public class CSPandoraBoxData
	{
		[Token(Token = "0x40036C9")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x40036CA")]
		[FieldOffset(Offset = "0xC")]
		public CSContentType contentType;

		[Token(Token = "0x40036CB")]
		[FieldOffset(Offset = "0x10")]
		public int contentID;

		[Token(Token = "0x40036CC")]
		[FieldOffset(Offset = "0x14")]
		public int next_id;

		[Token(Token = "0x40036CD")]
		[FieldOffset(Offset = "0x18")]
		public int contentCount;

		[Token(Token = "0x40036CE")]
		[FieldOffset(Offset = "0x1C")]
		public int CooltimeMin;

		[Token(Token = "0x40036CF")]
		[FieldOffset(Offset = "0x20")]
		public string strContentIDForimage;

		[Token(Token = "0x40036D0")]
		[FieldOffset(Offset = "0x24")]
		public List<int> contentIDsForImg;

		[Token(Token = "0x40036D1")]
		[FieldOffset(Offset = "0x28")]
		public string strContentImagePath;

		[Token(Token = "0x40036D2")]
		[FieldOffset(Offset = "0x2C")]
		public string strContentDesc;

		[Token(Token = "0x40036D3")]
		[FieldOffset(Offset = "0x30")]
		public string strStartDate;

		[Token(Token = "0x40036D4")]
		[FieldOffset(Offset = "0x38")]
		public DateTime startDateTime;

		[Token(Token = "0x40036D5")]
		[FieldOffset(Offset = "0x48")]
		public string strEndDate;

		[Token(Token = "0x40036D6")]
		[FieldOffset(Offset = "0x50")]
		public DateTime endDateTime;

		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x60")]
		public int season;

		[Token(Token = "0x60051D5")]
		[Address(RVA = "0x1FBFBC0", Offset = "0x1FBFBC0", VA = "0x1FBFBC0")]
		public CSPandoraBoxData()
		{
		}

		[Token(Token = "0x60051D6")]
		[Address(RVA = "0x1FBFCB4", Offset = "0x1FBFCB4", VA = "0x1FBFCB4")]
		public CSContent GetContent()
		{
			return null;
		}

		[Token(Token = "0x60051D7")]
		[Address(RVA = "0x1FBFD6C", Offset = "0x1FBFD6C", VA = "0x1FBFD6C")]
		public void Cooking(string dateFormat)
		{
		}
	}
}
