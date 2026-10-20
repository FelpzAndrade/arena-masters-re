using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B85")]
	public class CSTrophyReward
	{
		[Token(Token = "0x4003A33")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x4003A34")]
		[FieldOffset(Offset = "0xC")]
		public string rankName;

		[Token(Token = "0x4003A35")]
		[FieldOffset(Offset = "0x10")]
		public string boxName;

		[Token(Token = "0x4003A36")]
		[FieldOffset(Offset = "0x14")]
		public string rankIconPath;

		[Token(Token = "0x4003A37")]
		[FieldOffset(Offset = "0x18")]
		public string boxIconPath;

		[Token(Token = "0x4003A38")]
		[FieldOffset(Offset = "0x1C")]
		public string trophyIconPath;

		[Token(Token = "0x4003A39")]
		[FieldOffset(Offset = "0x20")]
		public int tier;

		[Token(Token = "0x4003A3A")]
		[FieldOffset(Offset = "0x24")]
		public int tier_rank;

		[Token(Token = "0x4003A3B")]
		[FieldOffset(Offset = "0x28")]
		public int min_rank_score;

		[Token(Token = "0x4003A3C")]
		[FieldOffset(Offset = "0x2C")]
		public int max_rank_score;

		[Token(Token = "0x4003A3D")]
		[FieldOffset(Offset = "0x30")]
		public int needPoint;

		[Token(Token = "0x4003A3E")]
		[FieldOffset(Offset = "0x34")]
		public int minGold;

		[Token(Token = "0x4003A3F")]
		[FieldOffset(Offset = "0x38")]
		public int maxGold;

		[Token(Token = "0x4003A40")]
		[FieldOffset(Offset = "0x3C")]
		public int lotteryID_1;

		[Token(Token = "0x4003A41")]
		[FieldOffset(Offset = "0x40")]
		public int lotteryID_2;

		[Token(Token = "0x4003A42")]
		[FieldOffset(Offset = "0x44")]
		public int lotteryID_3;

		[Token(Token = "0x4003A43")]
		[FieldOffset(Offset = "0x48")]
		public int lotteryID_4;

		[Token(Token = "0x4003A44")]
		[FieldOffset(Offset = "0x4C")]
		public int show_box_id;

		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0x50")]
		[JsonIgnore]
		public TierRank tierRankEnum;

		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0x54")]
		[JsonIgnore]
		public List<int> lotteryID_List;

		[Token(Token = "0x4003A47")]
		[FieldOffset(Offset = "0x58")]
		[JsonIgnore]
		public string logRankName;

		[Token(Token = "0x600536C")]
		[Address(RVA = "0x1CD997C", Offset = "0x1CD997C", VA = "0x1CD997C")]
		public CSTrophyReward()
		{
		}

		[Token(Token = "0x600536D")]
		[Address(RVA = "0x1CC9254", Offset = "0x1CC9254", VA = "0x1CC9254")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
