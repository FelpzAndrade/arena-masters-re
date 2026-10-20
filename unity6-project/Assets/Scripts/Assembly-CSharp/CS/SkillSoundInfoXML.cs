using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B61")]
	public sealed class SkillSoundInfoXML
	{
		[Token(Token = "0x4003962")]
		[FieldOffset(Offset = "0x8")]
		public List<SkillSoundInfo> dataList;

		[Token(Token = "0x60052EF")]
		[Address(RVA = "0x21E23A4", Offset = "0x21E23A4", VA = "0x21E23A4")]
		public SkillSoundInfoXML()
		{
		}

		[Token(Token = "0x60052F0")]
		[Address(RVA = "0x21E2450", Offset = "0x21E2450", VA = "0x21E2450")]
		public void Add(SkillSoundInfo i)
		{
		}
	}
}
