using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000ADB")]
	public sealed class CSFreeRelicSlotInfoXML
	{
		[Token(Token = "0x40032FE")]
		[FieldOffset(Offset = "0x8")]
		public List<CSFreeRelicSlotInfo> dataList;

		[Token(Token = "0x6004F76")]
		[Address(RVA = "0x222F25C", Offset = "0x222F25C", VA = "0x222F25C")]
		public CSFreeRelicSlotInfoXML()
		{
		}

		[Token(Token = "0x6004F77")]
		[Address(RVA = "0x222F308", Offset = "0x222F308", VA = "0x222F308")]
		public void Add(CSFreeRelicSlotInfo i)
		{
		}
	}
}
