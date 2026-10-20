using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B8A")]
	public sealed class TutorialConditionInfoXML
	{
		[Token(Token = "0x4003A71")]
		[FieldOffset(Offset = "0x8")]
		public List<TutorialConditionInfo> dataList;

		[Token(Token = "0x600537C")]
		[Address(RVA = "0x21EA768", Offset = "0x21EA768", VA = "0x21EA768")]
		public TutorialConditionInfoXML()
		{
		}

		[Token(Token = "0x600537D")]
		[Address(RVA = "0x21EA814", Offset = "0x21EA814", VA = "0x21EA814")]
		public void Add(TutorialConditionInfo i)
		{
		}
	}
}
