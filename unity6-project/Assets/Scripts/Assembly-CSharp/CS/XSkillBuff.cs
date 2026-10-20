using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B57")]
	public struct XSkillBuff
	{
		[Token(Token = "0x40038B8")]
		[FieldOffset(Offset = "0x0")]
		public int m_nBuffID;

		[Token(Token = "0x40038B9")]
		[FieldOffset(Offset = "0x4")]
		public HitTarget m_nSkillBuffTarget;

		[Token(Token = "0x40038BA")]
		[FieldOffset(Offset = "0x8")]
		public SkillBuffTiming m_nSkillBuffTiming;
	}
}
