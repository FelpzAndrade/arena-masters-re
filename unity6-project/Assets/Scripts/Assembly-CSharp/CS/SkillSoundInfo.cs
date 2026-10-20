using System;
using Il2CppDummyDll;

namespace CS
{
	[Serializable]
	[Token(Token = "0x2000B60")]
	public sealed class SkillSoundInfo
	{
		[Token(Token = "0x4003955")]
		[FieldOffset(Offset = "0x8")]
		public int nID;

		[Token(Token = "0x4003956")]
		[FieldOffset(Offset = "0xC")]
		public int nSkinID;

		[Token(Token = "0x4003957")]
		[FieldOffset(Offset = "0x10")]
		public string m_strActSound;

		[Token(Token = "0x4003958")]
		[FieldOffset(Offset = "0x14")]
		public float m_strActSoundDelay;

		[Token(Token = "0x4003959")]
		[FieldOffset(Offset = "0x18")]
		public string m_strActSound2;

		[Token(Token = "0x400395A")]
		[FieldOffset(Offset = "0x1C")]
		public float m_strActSoundDelay2;

		[Token(Token = "0x400395B")]
		[FieldOffset(Offset = "0x20")]
		public string strActSoundPersistance;

		[Token(Token = "0x400395C")]
		[FieldOffset(Offset = "0x24")]
		public bool actSoundPersistance;

		[Token(Token = "0x400395D")]
		[FieldOffset(Offset = "0x28")]
		public string strActSoundPersistance2;

		[Token(Token = "0x400395E")]
		[FieldOffset(Offset = "0x2C")]
		public bool actSoundPersistance2;

		[Token(Token = "0x400395F")]
		[FieldOffset(Offset = "0x30")]
		public string m_strHitSound;

		[Token(Token = "0x4003960")]
		[FieldOffset(Offset = "0x34")]
		public float m_actSoundCooltime;

		[Token(Token = "0x4003961")]
		[FieldOffset(Offset = "0x38")]
		public float m_actSoundRatio;

		[Token(Token = "0x60052ED")]
		[Address(RVA = "0x21E1BD0", Offset = "0x21E1BD0", VA = "0x21E1BD0")]
		public SkillSoundInfo()
		{
		}

		[Token(Token = "0x60052EE")]
		[Address(RVA = "0x21E1CE8", Offset = "0x21E1CE8", VA = "0x21E1CE8")]
		public bool Cooking()
		{
			return default(bool);
		}
	}
}
