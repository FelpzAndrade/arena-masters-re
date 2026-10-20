using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AC5")]
	public sealed class CSEventInfoXML
	{
		[Token(Token = "0x400327E")]
		[FieldOffset(Offset = "0x8")]
		public List<CSEventInfo> dataList;

		[Token(Token = "0x6004F0E")]
		[Address(RVA = "0x222E684", Offset = "0x222E684", VA = "0x222E684")]
		public CSEventInfoXML()
		{
		}

		[Token(Token = "0x6004F0F")]
		[Address(RVA = "0x222E730", Offset = "0x222E730", VA = "0x222E730")]
		public void Add(CSEventInfo i)
		{
		}
	}
}
