using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B79")]
	public sealed class CSTeamLevelInfo
	{
		[Token(Token = "0x4003A0E")]
		[FieldOffset(Offset = "0x8")]
		public int m_nLV;

		[Token(Token = "0x4003A0F")]
		[FieldOffset(Offset = "0xC")]
		public int m_nNXP;

		[Token(Token = "0x4003A10")]
		[FieldOffset(Offset = "0x10")]
		public int m_MaxSTA;

		[Token(Token = "0x4003A11")]
		[FieldOffset(Offset = "0x14")]
		public int m_MaxEnergy;

		[Token(Token = "0x4003A12")]
		[FieldOffset(Offset = "0x18")]
		public int m_TalentPoint;

		[Token(Token = "0x600533B")]
		[Address(RVA = "0x1CD7530", Offset = "0x1CD7530", VA = "0x1CD7530")]
		public CSTeamLevelInfo()
		{
		}
	}
}
