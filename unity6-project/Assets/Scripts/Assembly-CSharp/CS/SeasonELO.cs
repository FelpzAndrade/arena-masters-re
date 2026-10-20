using System;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x200097B")]
	public class SeasonELO
	{
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly short SeasonInitMaxScore;

		[Token(Token = "0x4002EE7")]
		[FieldOffset(Offset = "0x2")]
		public static readonly short SeasonInitMinScore;

		[Token(Token = "0x4002EE8")]
		[FieldOffset(Offset = "0x4")]
		private static short[] pointList;

		[Token(Token = "0x4002EE9")]
		[FieldOffset(Offset = "0x8")]
		private RankType RankType__BackingField;

		[Token(Token = "0x4002EEA")]
		[FieldOffset(Offset = "0xC")]
		private int Season__BackingField;

		[Token(Token = "0x4002EEB")]
		[FieldOffset(Offset = "0x10")]
		private int PreviousSeason__BackingField;

		[Token(Token = "0x4002EEC")]
		[FieldOffset(Offset = "0x14")]
		private short Score__BackingField;

		[Token(Token = "0x4002EED")]
		[FieldOffset(Offset = "0x18")]
		private DateTime LastPlayTime__BackingField;

		[Token(Token = "0x17000ADC")]
		public RankType RankType
		{
			[Token(Token = "0x6004C2F")]
			[Address(RVA = "0x21C47BC", Offset = "0x21C47BC", VA = "0x21C47BC")]
			get
			{
				return default(RankType);
			}
			[Token(Token = "0x6004C30")]
			[Address(RVA = "0x21C46C4", Offset = "0x21C46C4", VA = "0x21C46C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADD")]
		public int Season
		{
			[Token(Token = "0x6004C31")]
			[Address(RVA = "0x21C47C4", Offset = "0x21C47C4", VA = "0x21C47C4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004C32")]
			[Address(RVA = "0x21C47CC", Offset = "0x21C47CC", VA = "0x21C47CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADE")]
		public int PreviousSeason
		{
			[Token(Token = "0x6004C33")]
			[Address(RVA = "0x21C47D4", Offset = "0x21C47D4", VA = "0x21C47D4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6004C34")]
			[Address(RVA = "0x21C47DC", Offset = "0x21C47DC", VA = "0x21C47DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000ADF")]
		public short Score
		{
			[Token(Token = "0x6004C35")]
			[Address(RVA = "0x21C47E4", Offset = "0x21C47E4", VA = "0x21C47E4")]
			get
			{
				return default(short);
			}
			[Token(Token = "0x6004C36")]
			[Address(RVA = "0x21C46CC", Offset = "0x21C46CC", VA = "0x21C46CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000AE0")]
		public DateTime LastPlayTime
		{
			[Token(Token = "0x6004C37")]
			[Address(RVA = "0x21C47EC", Offset = "0x21C47EC", VA = "0x21C47EC")]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x6004C38")]
			[Address(RVA = "0x21C47FC", Offset = "0x21C47FC", VA = "0x21C47FC")]
			set
			{
			}
		}

		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x21C469C", Offset = "0x21C469C", VA = "0x21C469C")]
		public SeasonELO()
		{
		}

		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x21C4814", Offset = "0x21C4814", VA = "0x21C4814")]
		public short ProcessScore(int TargetSeason)
		{
			return default(short);
		}

		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x21C4940", Offset = "0x21C4940", VA = "0x21C4940")]
		public void UpdateSeason(int season)
		{
		}
	}
}
