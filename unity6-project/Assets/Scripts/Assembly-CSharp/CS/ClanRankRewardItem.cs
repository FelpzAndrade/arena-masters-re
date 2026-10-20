using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AAF")]
	public class ClanRankRewardItem : CSRankRewardItem
	{
		[Token(Token = "0x400322E")]
		[FieldOffset(Offset = "0x40")]
		public ClanRankType clanRankType;

		[Token(Token = "0x6004EA9")]
		[Address(RVA = "0x23EBC2C", Offset = "0x23EBC2C", VA = "0x23EBC2C")]
		public ClanRankRewardItem()
		{
		}
	}
}
