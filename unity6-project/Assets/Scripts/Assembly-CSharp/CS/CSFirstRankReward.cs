using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AD7")]
	public class CSFirstRankReward
	{
		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0x8")]
		public int id;

		[Token(Token = "0x40032E9")]
		[FieldOffset(Offset = "0xC")]
		public string rankName;

		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0x10")]
		public string iconPath;

		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0x14")]
		public RankType rankType;

		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0x18")]
		public int min_rank_score;

		[Token(Token = "0x40032ED")]
		[FieldOffset(Offset = "0x1C")]
		public int max_rank_score;

		[Token(Token = "0x40032EE")]
		[FieldOffset(Offset = "0x20")]
		public CSContentType contentType_1;

		[Token(Token = "0x40032EF")]
		[FieldOffset(Offset = "0x24")]
		public int contentId_1;

		[Token(Token = "0x40032F0")]
		[FieldOffset(Offset = "0x28")]
		public int contentCount_1;

		[Token(Token = "0x40032F1")]
		[FieldOffset(Offset = "0x2C")]
		public CSContentType contentType_2;

		[Token(Token = "0x40032F2")]
		[FieldOffset(Offset = "0x30")]
		public int contentId_2;

		[Token(Token = "0x40032F3")]
		[FieldOffset(Offset = "0x34")]
		public int contentCount_2;

		[Token(Token = "0x6004F67")]
		[Address(RVA = "0x222EF50", Offset = "0x222EF50", VA = "0x222EF50")]
		public CSFirstRankReward()
		{
		}

		[Token(Token = "0x6004F68")]
		[Address(RVA = "0x222F034", Offset = "0x222F034", VA = "0x222F034")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
