using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B77")]
	public sealed class TalentInfoXML
	{
		[Token(Token = "0x4003A0D")]
		[FieldOffset(Offset = "0x8")]
		public List<TalentInfo> m_talent;

		[Token(Token = "0x600532F")]
		[Address(RVA = "0x21E5D64", Offset = "0x21E5D64", VA = "0x21E5D64")]
		public TalentInfoXML()
		{
		}

		[Token(Token = "0x6005330")]
		[Address(RVA = "0x21E5E10", Offset = "0x21E5E10", VA = "0x21E5E10")]
		public void Add(TalentInfo val)
		{
		}
	}
}
