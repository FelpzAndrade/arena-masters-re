using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AB9")]
	public sealed class CSCraftInfoXML
	{
		[Token(Token = "0x4003246")]
		[FieldOffset(Offset = "0x8")]
		public List<CraftInfo> dataList;

		[Token(Token = "0x6004ED6")]
		[Address(RVA = "0x222B8C4", Offset = "0x222B8C4", VA = "0x222B8C4")]
		public CSCraftInfoXML()
		{
		}

		[Token(Token = "0x6004ED7")]
		[Address(RVA = "0x222B970", Offset = "0x222B970", VA = "0x222B970")]
		public void Add(CraftInfo i)
		{
		}
	}
}
