using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B7E")]
	public sealed class CSTimeIntervalXML
	{
		[Token(Token = "0x4003A1E")]
		[FieldOffset(Offset = "0x8")]
		public List<CSTimeInterval> dataList;

		[Token(Token = "0x6005354")]
		[Address(RVA = "0x1CD92F4", Offset = "0x1CD92F4", VA = "0x1CD92F4")]
		public CSTimeIntervalXML()
		{
		}

		[Token(Token = "0x6005355")]
		[Address(RVA = "0x1CD93A0", Offset = "0x1CD93A0", VA = "0x1CD93A0")]
		public void Add(CSTimeInterval i)
		{
		}
	}
}
