using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20009CF")]
	public class Netdata_CompleteGame
	{
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string String;

		[Token(Token = "0x4002F8F")]
		[FieldOffset(Offset = "0x8")]
		public CSExpReward teamExp;

		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0xC")]
		public CSPointReward combatPoint;

		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x10")]
		public CSPointReward trophyPoint;

		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x14")]
		public int beforeELO;

		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x18")]
		public int deltaELO;

		[Token(Token = "0x4002F94")]
		[FieldOffset(Offset = "0x1C")]
		public bool friendlyMatch;

		[Token(Token = "0x4002F95")]
		[FieldOffset(Offset = "0x1D")]
		public bool isPrivateRoom;

		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x20")]
		public int rank;

		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x24")]
		public List<CSContentReward> lotteryRewards;

		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x28")]
		public List<CSContentReward> bonusRewards;

		[Token(Token = "0x4002F99")]
		[FieldOffset(Offset = "0x2C")]
		public List<CSContentReward> eventModeWinRewards;

		[Token(Token = "0x4002F9A")]
		[FieldOffset(Offset = "0x30")]
		public bool toMail;

		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x31")]
		public bool isEvent;

		[Token(Token = "0x4002F9C")]
		[FieldOffset(Offset = "0x32")]
		public bool isPremiumTicket;

		[Token(Token = "0x4002F9D")]
		[FieldOffset(Offset = "0x34")]
		public int gameTimeStamp;

		[Token(Token = "0x4002F9E")]
		[FieldOffset(Offset = "0x38")]
		public List<CSWinlose> liPlacementTest;

		[Token(Token = "0x4002F9F")]
		[FieldOffset(Offset = "0x3C")]
		public int beforeClanScore;

		[Token(Token = "0x4002FA0")]
		[FieldOffset(Offset = "0x40")]
		public int getClanWarPoint;

		[Token(Token = "0x4002FA1")]
		[FieldOffset(Offset = "0x44")]
		public bool isKickedClan;

		[Token(Token = "0x6004D0B")]
		[Address(RVA = "0x233F84C", Offset = "0x233F84C", VA = "0x233F84C")]
		public Netdata_CompleteGame()
		{
		}

		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0x233FA34", Offset = "0x233FA34", VA = "0x233FA34")]
		public static Netdata_CompleteGame MakeEmptyCompleteGame()
		{
			return null;
		}
	}
}
