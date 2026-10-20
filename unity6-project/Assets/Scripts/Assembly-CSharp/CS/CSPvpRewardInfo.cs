using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B28")]
	public sealed class CSPvpRewardInfo
	{
		[Token(Token = "0x40036F8")]
		[FieldOffset(Offset = "0x8")]
		public int nGroupId;

		[Token(Token = "0x40036F9")]
		[FieldOffset(Offset = "0xC")]
		public int nMinTeamLevel;

		[Token(Token = "0x40036FA")]
		[FieldOffset(Offset = "0x10")]
		public int nMaxTeamLevel;

		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x14")]
		public int nID;

		[Token(Token = "0x40036FC")]
		[FieldOffset(Offset = "0x18")]
		public int nPoint;

		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x1C")]
		public int nLotteryId1;

		[Token(Token = "0x40036FE")]
		[FieldOffset(Offset = "0x20")]
		public int nLotteryId2;

		[Token(Token = "0x40036FF")]
		[FieldOffset(Offset = "0x24")]
		public int nLotteryId3;

		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0x28")]
		public int nLotteryId4;

		[Token(Token = "0x4003701")]
		[FieldOffset(Offset = "0x2C")]
		public int nLotteryId5;

		[Token(Token = "0x4003702")]
		[FieldOffset(Offset = "0x30")]
		public int nShow_box_id;

		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0x34")]
		private List<int> LotteryIdList__BackingField;

		[Token(Token = "0x17000C06")]
		[XmlIgnore]
		public List<int> LotteryIdList
		{
			[Token(Token = "0x60051F9")]
			[Address(RVA = "0x1CCFFC4", Offset = "0x1CCFFC4", VA = "0x1CCFFC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60051FA")]
			[Address(RVA = "0x1CCFFCC", Offset = "0x1CCFFCC", VA = "0x1CCFFCC")]
			private set
			{
			}
		}

		[Token(Token = "0x60051F8")]
		[Address(RVA = "0x1CCFFBC", Offset = "0x1CCFFBC", VA = "0x1CCFFBC")]
		public CSPvpRewardInfo()
		{
		}

		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x1CBB0E4", Offset = "0x1CBB0E4", VA = "0x1CBB0E4")]
		public void Cooking()
		{
		}
	}
}
