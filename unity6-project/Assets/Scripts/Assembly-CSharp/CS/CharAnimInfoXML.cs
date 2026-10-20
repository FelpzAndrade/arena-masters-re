using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A9E")]
	public sealed class CharAnimInfoXML
	{
		[Token(Token = "0x400317F")]
		[FieldOffset(Offset = "0x8")]
		public List<CharAnimInfo> dataList;

		[Token(Token = "0x6004E4D")]
		[Address(RVA = "0x23E8460", Offset = "0x23E8460", VA = "0x23E8460")]
		public CharAnimInfoXML()
		{
		}

		[Token(Token = "0x6004E4E")]
		[Address(RVA = "0x23E850C", Offset = "0x23E850C", VA = "0x23E850C")]
		public void Add(CharAnimInfo i)
		{
		}
	}
}
