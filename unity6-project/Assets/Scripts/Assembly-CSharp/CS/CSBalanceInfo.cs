using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A82")]
	public sealed class CSBalanceInfo : CharStatus
	{
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0xB0")]
		public int m_nLV;

		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0xB4")]
		public int m_nSkillPoint;

		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0xB8")]
		public int m_nSoulStoneCount;

		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0xBC")]
		public int m_nLevelGold;

		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0xC0")]
		[XmlIgnore]
		public int m_nTotalSkillPoint;

		[Token(Token = "0x6004E0B")]
		[Address(RVA = "0x23F02CC", Offset = "0x23F02CC", VA = "0x23F02CC")]
		public CSBalanceInfo()
		{
		}
	}
}
