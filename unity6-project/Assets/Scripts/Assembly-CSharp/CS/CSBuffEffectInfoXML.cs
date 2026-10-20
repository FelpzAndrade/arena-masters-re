using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A9A")]
	public sealed class CSBuffEffectInfoXML
	{
		[Token(Token = "0x4003171")]
		[FieldOffset(Offset = "0x8")]
		public List<CSBuffEffectInfo> dataList;

		[Token(Token = "0x6004E44")]
		[Address(RVA = "0x222508C", Offset = "0x222508C", VA = "0x222508C")]
		public CSBuffEffectInfoXML()
		{
		}

		[Token(Token = "0x6004E45")]
		[Address(RVA = "0x2225138", Offset = "0x2225138", VA = "0x2225138")]
		public void Add(CSBuffEffectInfo i)
		{
		}
	}
}
