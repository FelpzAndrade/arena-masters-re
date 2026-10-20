using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B5C")]
	public class SkillSoundInfos
	{
		[Token(Token = "0x400393A")]
		[FieldOffset(Offset = "0x8")]
		private List<SkillSoundInfo> m_DefaultSounds;

		[Token(Token = "0x400393B")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, List<SkillSoundInfo>> m_SkinSounds;

		[Token(Token = "0x60052DC")]
		[Address(RVA = "0x21E1E48", Offset = "0x21E1E48", VA = "0x21E1E48")]
		public SkillSoundInfos()
		{
		}

		[Token(Token = "0x60052DD")]
		[Address(RVA = "0x21E1E50", Offset = "0x21E1E50", VA = "0x21E1E50")]
		public void Cook(ProtoInfoManager_SkillSound skillSoundInfoManager, CSSkillInfo skillInfo)
		{
		}

		[Token(Token = "0x60052DE")]
		[Address(RVA = "0x21E2004", Offset = "0x21E2004", VA = "0x21E2004")]
		private void AddDefaultEffectInfo(SkillSoundInfo skillSoundInfo)
		{
		}

		[Token(Token = "0x60052DF")]
		[Address(RVA = "0x21E20F0", Offset = "0x21E20F0", VA = "0x21E20F0")]
		private void AddSkinEffectInfo(SkillSoundInfo skillSoundInfo)
		{
		}

		[Token(Token = "0x60052E0")]
		[Address(RVA = "0x21E22BC", Offset = "0x21E22BC", VA = "0x21E22BC")]
		public List<SkillSoundInfo> GetSoundInfoList(int skinID = 0)
		{
			return null;
		}
	}
}
