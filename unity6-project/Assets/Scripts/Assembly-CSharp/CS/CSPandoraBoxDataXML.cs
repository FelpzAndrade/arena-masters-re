using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B1F")]
	public sealed class CSPandoraBoxDataXML
	{
		[Token(Token = "0x40036D8")]
		[FieldOffset(Offset = "0x8")]
		public List<CSPandoraBoxData> dataList;

		[Token(Token = "0x60051D8")]
		[Address(RVA = "0x1FC0140", Offset = "0x1FC0140", VA = "0x1FC0140")]
		public CSPandoraBoxDataXML()
		{
		}

		[Token(Token = "0x60051D9")]
		[Address(RVA = "0x1FC01EC", Offset = "0x1FC01EC", VA = "0x1FC01EC")]
		public void Add(CSPandoraBoxData i)
		{
		}
	}
}
