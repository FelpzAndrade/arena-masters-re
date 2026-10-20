using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AB0")]
	public sealed class ClanRankRewardXML
	{
		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x8")]
		public List<ClanRankRewardItem> dataList;

		[Token(Token = "0x6004EAA")]
		[Address(RVA = "0x23EBC34", Offset = "0x23EBC34", VA = "0x23EBC34")]
		public ClanRankRewardXML()
		{
		}

		[Token(Token = "0x6004EAB")]
		[Address(RVA = "0x23EBCE0", Offset = "0x23EBCE0", VA = "0x23EBCE0")]
		public void Add(ClanRankRewardItem i)
		{
		}
	}
}
