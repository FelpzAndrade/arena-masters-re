using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000B5B")]
	public class SkillEffectInfos
	{
		[Token(Token = "0x4003938")]
		[FieldOffset(Offset = "0x8")]
		private List<CSSkillEffectInfo> m_DefaultEffects;

		[Token(Token = "0x4003939")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, List<CSSkillEffectInfo>> m_SkinEffects;

		[Token(Token = "0x60052D7")]
		[Address(RVA = "0x21E1654", Offset = "0x21E1654", VA = "0x21E1654")]
		public SkillEffectInfos()
		{
		}

		[Token(Token = "0x60052D8")]
		[Address(RVA = "0x21E165C", Offset = "0x21E165C", VA = "0x21E165C")]
		public void Cook(CSProtoInfoManager_SkillEffect skillEffectInfoManager, CSSkillInfo skillInfo)
		{
		}

		[Token(Token = "0x60052D9")]
		[Address(RVA = "0x21E1810", Offset = "0x21E1810", VA = "0x21E1810")]
		private void AddDefaultEffectInfo(CSSkillEffectInfo skillEffectInfo)
		{
		}

		[Token(Token = "0x60052DA")]
		[Address(RVA = "0x21E18FC", Offset = "0x21E18FC", VA = "0x21E18FC")]
		private void AddSkinEffectInfo(CSSkillEffectInfo skillEffectInfo)
		{
		}

		[Token(Token = "0x60052DB")]
		[Address(RVA = "0x21E1AC8", Offset = "0x21E1AC8", VA = "0x21E1AC8")]
		public List<CSSkillEffectInfo> GetEffectInfoList(int skinID = 0)
		{
			return null;
		}
	}
}
