using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AD8")]
	public sealed class CSFirstRankRewardXML
	{
		[Token(Token = "0x40032F4")]
		[FieldOffset(Offset = "0x8")]
		public List<CSFirstRankReward> dataList;

		[Token(Token = "0x6004F69")]
		[Address(RVA = "0x222F03C", Offset = "0x222F03C", VA = "0x222F03C")]
		public CSFirstRankRewardXML()
		{
		}

		[Token(Token = "0x6004F6A")]
		[Address(RVA = "0x222F0E8", Offset = "0x222F0E8", VA = "0x222F0E8")]
		public void Add(CSFirstRankReward i)
		{
		}
	}
}
