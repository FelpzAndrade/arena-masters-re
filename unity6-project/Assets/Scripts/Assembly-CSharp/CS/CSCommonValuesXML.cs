using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AB6")]
	public sealed class CSCommonValuesXML
	{
		[Token(Token = "0x4003239")]
		[FieldOffset(Offset = "0x8")]
		public List<CSCommonValues> dataList;

		[Token(Token = "0x6004EBD")]
		[Address(RVA = "0x2228BA4", Offset = "0x2228BA4", VA = "0x2228BA4")]
		public CSCommonValuesXML()
		{
		}

		[Token(Token = "0x6004EBE")]
		[Address(RVA = "0x2228C50", Offset = "0x2228C50", VA = "0x2228C50")]
		public void Add(CSCommonValues i)
		{
		}
	}
}
