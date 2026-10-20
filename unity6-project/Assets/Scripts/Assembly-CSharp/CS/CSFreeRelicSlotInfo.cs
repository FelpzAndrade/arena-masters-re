using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000ADA")]
	public sealed class CSFreeRelicSlotInfo
	{
		[Token(Token = "0x40032F7")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x40032F8")]
		[FieldOffset(Offset = "0xC")]
		public int m_MinTeamLevel;

		[Token(Token = "0x40032F9")]
		[FieldOffset(Offset = "0x10")]
		public int m_MaxTeamLevel;

		[Token(Token = "0x40032FA")]
		[FieldOffset(Offset = "0x14")]
		public int m_RelicID;

		[Token(Token = "0x40032FB")]
		[FieldOffset(Offset = "0x18")]
		public int m_RelicLevel;

		[Token(Token = "0x40032FC")]
		[FieldOffset(Offset = "0x1C")]
		public float m_Ratio;

		[Token(Token = "0x40032FD")]
		[FieldOffset(Offset = "0x20")]
		public string strName;

		[Token(Token = "0x6004F74")]
		[Address(RVA = "0x222F188", Offset = "0x222F188", VA = "0x222F188")]
		public CSFreeRelicSlotInfo()
		{
		}

		[Token(Token = "0x6004F75")]
		[Address(RVA = "0x222F254", Offset = "0x222F254", VA = "0x222F254")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
