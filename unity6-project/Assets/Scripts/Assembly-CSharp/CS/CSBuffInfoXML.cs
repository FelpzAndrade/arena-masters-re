using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A94")]
	public sealed class CSBuffInfoXML
	{
		[Token(Token = "0x4003158")]
		[FieldOffset(Offset = "0x8")]
		public List<CSBuffInfo> dataList;

		[Token(Token = "0x6004E31")]
		[Address(RVA = "0x22266C4", Offset = "0x22266C4", VA = "0x22266C4")]
		public CSBuffInfoXML()
		{
		}

		[Token(Token = "0x6004E32")]
		[Address(RVA = "0x2226770", Offset = "0x2226770", VA = "0x2226770")]
		public void Add(CSBuffInfo i)
		{
		}
	}
}
