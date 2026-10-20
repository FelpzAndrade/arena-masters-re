using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AF5")]
	public sealed class CSGameModeRewardInfoXML
	{
		[Token(Token = "0x40035C1")]
		[FieldOffset(Offset = "0x8")]
		public List<CSGameModeRewardInfo> dataList;

		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x2231E60", Offset = "0x2231E60", VA = "0x2231E60")]
		public CSGameModeRewardInfoXML()
		{
		}

		[Token(Token = "0x60050DF")]
		[Address(RVA = "0x2231F0C", Offset = "0x2231F0C", VA = "0x2231F0C")]
		public void Add(CSGameModeRewardInfo i)
		{
		}
	}
}
