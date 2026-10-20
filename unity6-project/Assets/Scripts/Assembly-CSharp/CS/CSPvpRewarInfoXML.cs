using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B29")]
	public sealed class CSPvpRewarInfoXML
	{
		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0x8")]
		public List<CSPvpRewardInfo> dataList;

		[Token(Token = "0x60051FC")]
		[Address(RVA = "0x1CCFFD4", Offset = "0x1CCFFD4", VA = "0x1CCFFD4")]
		public CSPvpRewarInfoXML()
		{
		}

		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x1CD0080", Offset = "0x1CD0080", VA = "0x1CD0080")]
		public void Add(CSPvpRewardInfo i)
		{
		}
	}
}
