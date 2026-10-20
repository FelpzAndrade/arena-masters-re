using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B65")]
	public sealed class SkillSpecializationXML
	{
		[Token(Token = "0x4003972")]
		[FieldOffset(Offset = "0x8")]
		public List<SkillSpecializationInfo> dataList;

		[Token(Token = "0x60052FA")]
		[Address(RVA = "0x21E2618", Offset = "0x21E2618", VA = "0x21E2618")]
		public SkillSpecializationXML()
		{
		}

		[Token(Token = "0x60052FB")]
		[Address(RVA = "0x21E26C4", Offset = "0x21E26C4", VA = "0x21E26C4")]
		public void Add(SkillSpecializationInfo i)
		{
		}
	}
}
