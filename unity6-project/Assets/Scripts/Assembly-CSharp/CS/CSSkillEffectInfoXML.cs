using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B5E")]
	public sealed class CSSkillEffectInfoXML
	{
		[Token(Token = "0x4003954")]
		[FieldOffset(Offset = "0x8")]
		public List<CSSkillEffectInfo> dataList;

		[Token(Token = "0x60052E6")]
		[Address(RVA = "0x1CD2A94", Offset = "0x1CD2A94", VA = "0x1CD2A94")]
		public CSSkillEffectInfoXML()
		{
		}

		[Token(Token = "0x60052E7")]
		[Address(RVA = "0x1CD2B40", Offset = "0x1CD2B40", VA = "0x1CD2B40")]
		public void Add(CSSkillEffectInfo i)
		{
		}
	}
}
