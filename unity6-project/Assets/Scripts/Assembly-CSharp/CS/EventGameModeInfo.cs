using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000ACB")]
	public class EventGameModeInfo
	{
		[Token(Token = "0x400329B")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x400329C")]
		[FieldOffset(Offset = "0xC")]
		public int groupID;

		[Token(Token = "0x400329D")]
		[FieldOffset(Offset = "0x10")]
		public int modeInstanceID;

		[Token(Token = "0x400329E")]
		[FieldOffset(Offset = "0x14")]
		public string strStartDate;

		[Token(Token = "0x400329F")]
		[FieldOffset(Offset = "0x18")]
		[XmlIgnore]
		public DateTime startDateTime;

		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x28")]
		public string strEndDate;

		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x30")]
		[XmlIgnore]
		public DateTime endDateTime;

		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x40")]
		public string strFreeAdmission;

		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x44")]
		public bool useFreeAdmission;

		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x48")]
		public Currency enterCostType;

		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x4C")]
		public int enterCostCount;

		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x50")]
		public int chance;

		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x54")]
		public int rewardGroupID;

		[Token(Token = "0x6004F2E")]
		[Address(RVA = "0x1CDE668", Offset = "0x1CDE668", VA = "0x1CDE668")]
		public EventGameModeInfo()
		{
		}

		[Token(Token = "0x6004F2F")]
		[Address(RVA = "0x1CDE760", Offset = "0x1CDE760", VA = "0x1CDE760")]
		public void Cooking(string dateFormat)
		{
		}

		[Token(Token = "0x6004F30")]
		[Address(RVA = "0x1CDEA8C", Offset = "0x1CDEA8C", VA = "0x1CDEA8C")]
		public bool IsOpend(DateTime localTime)
		{
			return default(bool);
		}
	}
}
