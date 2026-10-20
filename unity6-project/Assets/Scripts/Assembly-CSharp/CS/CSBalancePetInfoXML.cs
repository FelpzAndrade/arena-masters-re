using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A86")]
	public sealed class CSBalancePetInfoXML
	{
		[Token(Token = "0x40030CC")]
		[FieldOffset(Offset = "0x8")]
		public List<CSBalancePetInfo> dataList;

		[Token(Token = "0x6004E17")]
		[Address(RVA = "0x23F0558", Offset = "0x23F0558", VA = "0x23F0558")]
		public CSBalancePetInfoXML()
		{
		}

		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x23F0604", Offset = "0x23F0604", VA = "0x23F0604")]
		public void Add(CSBalancePetInfo i)
		{
		}
	}
}
