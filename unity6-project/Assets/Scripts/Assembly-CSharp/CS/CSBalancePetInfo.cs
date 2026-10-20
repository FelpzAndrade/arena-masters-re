using System;
using System.Xml.Serialization;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000A85")]
	public sealed class CSBalancePetInfo : CharStatus
	{
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0xB0")]
		public int m_nLV;

		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0xB4")]
		public float m_nSkillPoint;

		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0xB8")]
		public float m_nGoldBuff;

		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0xBC")]
		public float m_nMedalOfHonrBuff;

		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0xC0")]
		public int m_nSoulDustCount;

		[Token(Token = "0x40030CA")]
		[FieldOffset(Offset = "0xC4")]
		public int m_nLevelGold;

		[Token(Token = "0x40030CB")]
		[FieldOffset(Offset = "0xC8")]
		[XmlIgnore]
		public int m_nTotalSkillPoint;

		[Token(Token = "0x6004E16")]
		[Address(RVA = "0x23F04B8", Offset = "0x23F04B8", VA = "0x23F04B8")]
		public CSBalancePetInfo()
		{
		}
	}
}
