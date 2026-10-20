using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B68")]
	public sealed class SkinInfoXML
	{
		[Token(Token = "0x4003988")]
		[FieldOffset(Offset = "0x8")]
		public List<SkinInfo> dataList;

		[Token(Token = "0x6005310")]
		[Address(RVA = "0x21E2B28", Offset = "0x21E2B28", VA = "0x21E2B28")]
		public SkinInfoXML()
		{
		}

		[Token(Token = "0x6005311")]
		[Address(RVA = "0x21E2BD4", Offset = "0x21E2BD4", VA = "0x21E2BD4")]
		public void Add(SkinInfo i)
		{
		}
	}
}
