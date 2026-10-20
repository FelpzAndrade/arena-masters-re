using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B33")]
	public sealed class LotteryInfoXML
	{
		[Token(Token = "0x400378B")]
		[FieldOffset(Offset = "0x8")]
		public List<QuestInfo> questList;

		[Token(Token = "0x600520D")]
		[Address(RVA = "0x233B120", Offset = "0x233B120", VA = "0x233B120")]
		public LotteryInfoXML()
		{
		}

		[Token(Token = "0x600520E")]
		[Address(RVA = "0x233B1CC", Offset = "0x233B1CC", VA = "0x233B1CC")]
		public void Add(QuestInfo i)
		{
		}
	}
}
