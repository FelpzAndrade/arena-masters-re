using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AAC")]
	public sealed class CSClanBoxRewardXML
	{
		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x8")]
		public List<CSClanBoxReward> dataList;

		[Token(Token = "0x6004E9B")]
		[Address(RVA = "0x2228974", Offset = "0x2228974", VA = "0x2228974")]
		public CSClanBoxRewardXML()
		{
		}

		[Token(Token = "0x6004E9C")]
		[Address(RVA = "0x2228A20", Offset = "0x2228A20", VA = "0x2228A20")]
		public void Add(CSClanBoxReward i)
		{
		}
	}
}
