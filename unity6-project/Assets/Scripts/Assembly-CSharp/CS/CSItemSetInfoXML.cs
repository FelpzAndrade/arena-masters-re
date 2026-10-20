using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B0C")]
	public sealed class CSItemSetInfoXML
	{
		[Token(Token = "0x4003663")]
		[FieldOffset(Offset = "0x8")]
		public List<ItemSetInfo> dataList;

		[Token(Token = "0x600513C")]
		[Address(RVA = "0x2236314", Offset = "0x2236314", VA = "0x2236314")]
		public CSItemSetInfoXML()
		{
		}

		[Token(Token = "0x600513D")]
		[Address(RVA = "0x22363C0", Offset = "0x22363C0", VA = "0x22363C0")]
		public void Add(ItemSetInfo i)
		{
		}
	}
}
