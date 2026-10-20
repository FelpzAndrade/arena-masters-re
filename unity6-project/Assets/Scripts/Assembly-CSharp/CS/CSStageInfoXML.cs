using System;
using System.Collections;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B73")]
	public sealed class CSStageInfoXML
	{
		[Token(Token = "0x40039FA")]
		[FieldOffset(Offset = "0x8")]
		public ArrayList dataList;

		[Token(Token = "0x600531D")]
		[Address(RVA = "0x1CD45E8", Offset = "0x1CD45E8", VA = "0x1CD45E8")]
		public CSStageInfoXML()
		{
		}

		[Token(Token = "0x600531E")]
		[Address(RVA = "0x1CD4684", Offset = "0x1CD4684", VA = "0x1CD4684")]
		public void Add(CSStageInfo i)
		{
		}
	}
}
