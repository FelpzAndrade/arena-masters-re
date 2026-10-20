using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B76")]
	public class TalentInfo
	{
		[Token(Token = "0x4003A04")]
		[FieldOffset(Offset = "0x8")]
		public int m_id;

		[Token(Token = "0x4003A05")]
		[FieldOffset(Offset = "0xC")]
		public TalentType m_type;

		[Token(Token = "0x4003A06")]
		[FieldOffset(Offset = "0x10")]
		public int m_group_number;

		[Token(Token = "0x4003A07")]
		[FieldOffset(Offset = "0x14")]
		public int m_level;

		[Token(Token = "0x4003A08")]
		[FieldOffset(Offset = "0x18")]
		public string m_name;

		[Token(Token = "0x4003A09")]
		[FieldOffset(Offset = "0x1C")]
		public int m_precede_learn_group_number;

		[Token(Token = "0x4003A0A")]
		[FieldOffset(Offset = "0x20")]
		public int m_precede_learn_team_level;

		[Token(Token = "0x4003A0B")]
		[FieldOffset(Offset = "0x24")]
		public int m_precede_learn_ltp;

		[Token(Token = "0x4003A0C")]
		[FieldOffset(Offset = "0x28")]
		public int m_skill_pvp_id;

		[Token(Token = "0x600532E")]
		[Address(RVA = "0x21E5CA0", Offset = "0x21E5CA0", VA = "0x21E5CA0")]
		public TalentInfo()
		{
		}
	}
}
