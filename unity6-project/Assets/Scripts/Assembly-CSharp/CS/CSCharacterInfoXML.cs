using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000AA6")]
	public sealed class CSCharacterInfoXML
	{
		[Token(Token = "0x4003210")]
		[FieldOffset(Offset = "0x8")]
		public List<CSCharacterInfo> dataList;

		[Token(Token = "0x6004E7C")]
		[Address(RVA = "0x222862C", Offset = "0x222862C", VA = "0x222862C")]
		public CSCharacterInfoXML()
		{
		}

		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x22286D8", Offset = "0x22286D8", VA = "0x22286D8")]
		public void Add(CSCharacterInfo i)
		{
		}
	}
}
