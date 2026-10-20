using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B7A")]
	public sealed class CSTeamLevelInfoXML
	{
		[Token(Token = "0x4003A13")]
		[FieldOffset(Offset = "0x8")]
		public List<CSTeamLevelInfo> dataList;

		[Token(Token = "0x600533C")]
		[Address(RVA = "0x1CD7538", Offset = "0x1CD7538", VA = "0x1CD7538")]
		public CSTeamLevelInfoXML()
		{
		}

		[Token(Token = "0x600533D")]
		[Address(RVA = "0x1CD75E4", Offset = "0x1CD75E4", VA = "0x1CD75E4")]
		public void Add(CSTeamLevelInfo i)
		{
		}
	}
}
