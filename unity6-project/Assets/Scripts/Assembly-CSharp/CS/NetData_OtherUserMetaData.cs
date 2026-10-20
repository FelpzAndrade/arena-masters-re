using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000969")]
	public class NetData_OtherUserMetaData : UserMetaData
	{
		[Token(Token = "0x4002E8A")]
		[FieldOffset(Offset = "0x48")]
		public string ClanName;

		[Token(Token = "0x4002E8B")]
		[FieldOffset(Offset = "0x4C")]
		public int MannerPoint;

		[Token(Token = "0x4002E8C")]
		[FieldOffset(Offset = "0x50")]
		public List<int> MostPlayedChars;

		[Token(Token = "0x4002E8D")]
		[FieldOffset(Offset = "0x54")]
		public Dictionary<RankType, int> IsPlacementTestCount;

		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<RankType, int> SeasonScore;

		[Token(Token = "0x4002E8F")]
		[FieldOffset(Offset = "0x5C")]
		public Dictionary<RankType, int> LastPlaySeason;

		[Token(Token = "0x4002E90")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<RankType, int> BestScore;

		[Token(Token = "0x4002E91")]
		[FieldOffset(Offset = "0x64")]
		public Dictionary<RankType, int> BestWinningStreak;

		[Token(Token = "0x6004BCB")]
		[Address(RVA = "0x23400A0", Offset = "0x23400A0", VA = "0x23400A0")]
		public NetData_OtherUserMetaData()
		{
		}
	}
}
