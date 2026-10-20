using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AC4")]
	public class CSEventInfo
	{
		[Token(Token = "0x400326E")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x400326F")]
		[FieldOffset(Offset = "0xC")]
		public string strIcon;

		[Token(Token = "0x4003270")]
		[FieldOffset(Offset = "0x10")]
		public string strName;

		[Token(Token = "0x4003271")]
		[FieldOffset(Offset = "0x14")]
		public string strDesc;

		[Token(Token = "0x4003272")]
		[FieldOffset(Offset = "0x18")]
		public string notiStart;

		[Token(Token = "0x4003273")]
		[FieldOffset(Offset = "0x1C")]
		public string notiEnd;

		[Token(Token = "0x4003274")]
		[FieldOffset(Offset = "0x20")]
		public string StartDate;

		[Token(Token = "0x4003275")]
		[FieldOffset(Offset = "0x28")]
		public DateTime eventStartTime;

		[Token(Token = "0x4003276")]
		[FieldOffset(Offset = "0x38")]
		public string EndDate;

		[Token(Token = "0x4003277")]
		[FieldOffset(Offset = "0x40")]
		public DateTime eventEndTime;

		[Token(Token = "0x4003278")]
		[FieldOffset(Offset = "0x50")]
		public int nShowOrder;

		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0x54")]
		public string strReward;

		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0x58")]
		public List<CSContent> RewardContentList;

		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x5C")]
		public string strCompleteIf;

		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x60")]
		public string strLink;

		[Token(Token = "0x400327D")]
		[FieldOffset(Offset = "0x64")]
		public string strShowIf;

		[Token(Token = "0x6004F0C")]
		[Address(RVA = "0x222E3A0", Offset = "0x222E3A0", VA = "0x222E3A0")]
		public CSEventInfo()
		{
		}

		[Token(Token = "0x6004F0D")]
		[Address(RVA = "0x222E5AC", Offset = "0x222E5AC", VA = "0x222E5AC")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
