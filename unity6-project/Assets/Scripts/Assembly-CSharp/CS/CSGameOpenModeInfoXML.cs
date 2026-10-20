using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AF2")]
	public sealed class CSGameOpenModeInfoXML
	{
		[Token(Token = "0x40035A8")]
		[FieldOffset(Offset = "0x8")]
		public List<CSGameOpenModeInfo> dataList;

		[Token(Token = "0x60050CD")]
		[Address(RVA = "0x2232464", Offset = "0x2232464", VA = "0x2232464")]
		public CSGameOpenModeInfoXML()
		{
		}

		[Token(Token = "0x60050CE")]
		[Address(RVA = "0x2232510", Offset = "0x2232510", VA = "0x2232510")]
		public void Add(CSGameOpenModeInfo i)
		{
		}
	}
}
