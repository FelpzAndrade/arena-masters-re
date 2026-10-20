using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B59")]
	public sealed class CSSkillInfoXML
	{
		[Token(Token = "0x4003937")]
		[FieldOffset(Offset = "0x8")]
		public List<CSSkillInfo> dataList;

		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x1CD41E0", Offset = "0x1CD41E0", VA = "0x1CD41E0")]
		public CSSkillInfoXML()
		{
		}

		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x1CD428C", Offset = "0x1CD428C", VA = "0x1CD428C")]
		public void Add(CSSkillInfo i)
		{
		}
	}
}
