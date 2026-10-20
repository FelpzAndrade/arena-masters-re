using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B38")]
	public class CSRankRewardItem
	{
		[Token(Token = "0x4003798")]
		[FieldOffset(Offset = "0x8")]
		public int rankType;

		[Token(Token = "0x4003799")]
		[FieldOffset(Offset = "0xC")]
		public int tierID;

		[Token(Token = "0x400379A")]
		[FieldOffset(Offset = "0x10")]
		public string tierText;

		[Token(Token = "0x400379B")]
		[FieldOffset(Offset = "0x14")]
		public string tierIconPath;

		[Token(Token = "0x400379C")]
		[FieldOffset(Offset = "0x18")]
		public string rankText;

		[Token(Token = "0x400379D")]
		[FieldOffset(Offset = "0x1C")]
		public string rank;

		[Token(Token = "0x400379E")]
		[FieldOffset(Offset = "0x20")]
		public CSContentType rewardType_1;

		[Token(Token = "0x400379F")]
		[FieldOffset(Offset = "0x24")]
		public int rewardId_1;

		[Token(Token = "0x40037A0")]
		[FieldOffset(Offset = "0x28")]
		public int rewardAmount_1;

		[Token(Token = "0x40037A1")]
		[FieldOffset(Offset = "0x2C")]
		public CSContentType rewardType_2;

		[Token(Token = "0x40037A2")]
		[FieldOffset(Offset = "0x30")]
		public int rewardId_2;

		[Token(Token = "0x40037A3")]
		[FieldOffset(Offset = "0x34")]
		public int rewardAmount_2;

		[Token(Token = "0x40037A4")]
		[FieldOffset(Offset = "0x38")]
		public int Rank;

		[Token(Token = "0x40037A5")]
		[FieldOffset(Offset = "0x3C")]
		public float Percent;

		[Token(Token = "0x17000C08")]
		public RankType RankType
		{
			[Token(Token = "0x6005223")]
			[Address(RVA = "0x1CBE094", Offset = "0x1CBE094", VA = "0x1CBE094")]
			get
			{
				return default(RankType);
			}
		}

		[Token(Token = "0x6005222")]
		[Address(RVA = "0x1CD0368", Offset = "0x1CD0368", VA = "0x1CD0368")]
		public CSRankRewardItem()
		{
		}

		[Token(Token = "0x6005224")]
		[Address(RVA = "0x1CBDD38", Offset = "0x1CBDD38", VA = "0x1CBDD38")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
