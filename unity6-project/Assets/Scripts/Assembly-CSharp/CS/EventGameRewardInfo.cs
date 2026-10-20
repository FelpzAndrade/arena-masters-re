using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000AD0")]
	public class EventGameRewardInfo
	{
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x8")]
		public int ID;

		[Token(Token = "0x40032BB")]
		[FieldOffset(Offset = "0xC")]
		public int groupID;

		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0x10")]
		public RewardType rewardType;

		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x14")]
		public ConditionType condition;

		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0x18")]
		public int conditionCount;

		[Token(Token = "0x40032BF")]
		[FieldOffset(Offset = "0x1C")]
		public CSContentType contentType1;

		[Token(Token = "0x40032C0")]
		[FieldOffset(Offset = "0x20")]
		public int contentID1;

		[Token(Token = "0x40032C1")]
		[FieldOffset(Offset = "0x24")]
		public int contentCount1;

		[Token(Token = "0x40032C2")]
		[FieldOffset(Offset = "0x28")]
		public CSContentType contentType2;

		[Token(Token = "0x40032C3")]
		[FieldOffset(Offset = "0x2C")]
		public int contentID2;

		[Token(Token = "0x40032C4")]
		[FieldOffset(Offset = "0x30")]
		public int contentCount2;

		[Token(Token = "0x40032C5")]
		[FieldOffset(Offset = "0x34")]
		public CSContentType contentType3;

		[Token(Token = "0x40032C6")]
		[FieldOffset(Offset = "0x38")]
		public int contentID3;

		[Token(Token = "0x40032C7")]
		[FieldOffset(Offset = "0x3C")]
		public int contentCount3;

		[Token(Token = "0x6004F41")]
		[Address(RVA = "0x1CE02AC", Offset = "0x1CE02AC", VA = "0x1CE02AC")]
		public EventGameRewardInfo()
		{
		}

		[Token(Token = "0x6004F42")]
		[Address(RVA = "0x1CDFD80", Offset = "0x1CDFD80", VA = "0x1CDFD80")]
		public List<CSContent> GetContents()
		{
			return null;
		}
	}
}
