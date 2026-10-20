using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B39")]
	public sealed class CSRankRewardXML
	{
		[Token(Token = "0x40037A6")]
		[FieldOffset(Offset = "0x8")]
		public List<CSRankRewardItem> dataList;

		[Token(Token = "0x6005225")]
		[Address(RVA = "0x1CD0478", Offset = "0x1CD0478", VA = "0x1CD0478")]
		public CSRankRewardXML()
		{
		}

		[Token(Token = "0x6005226")]
		[Address(RVA = "0x1CD0524", Offset = "0x1CD0524", VA = "0x1CD0524")]
		public void Add(CSRankRewardItem i)
		{
		}
	}
}
