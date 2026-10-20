using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B36")]
	public sealed class CSRandomOptionDataXML
	{
		[Token(Token = "0x4003794")]
		[FieldOffset(Offset = "0x8")]
		public List<CSRandomOptionData> dataList;

		[Token(Token = "0x6005217")]
		[Address(RVA = "0x1CD021C", Offset = "0x1CD021C", VA = "0x1CD021C")]
		public CSRandomOptionDataXML()
		{
		}

		[Token(Token = "0x6005218")]
		[Address(RVA = "0x1CD02C8", Offset = "0x1CD02C8", VA = "0x1CD02C8")]
		public void Add(CSRandomOptionData i)
		{
		}
	}
}
