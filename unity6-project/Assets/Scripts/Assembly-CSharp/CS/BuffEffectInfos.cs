using System.Collections.Generic;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x2000A96")]
	public class BuffEffectInfos
	{
		[Token(Token = "0x4003159")]
		[FieldOffset(Offset = "0x8")]
		private List<CSBuffEffectInfo> m_DefaultEffects;

		[Token(Token = "0x400315A")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, List<CSBuffEffectInfo>> m_SkinEffects;

		[Token(Token = "0x6004E39")]
		[Address(RVA = "0x23E7C80", Offset = "0x23E7C80", VA = "0x23E7C80")]
		public BuffEffectInfos()
		{
		}

		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x23E7C88", Offset = "0x23E7C88", VA = "0x23E7C88")]
		public void Cook(CSProtoInfoManager_BuffEffect buffEffectInfoManager, CSBuffInfo buffInfo)
		{
		}

		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x23E7E3C", Offset = "0x23E7E3C", VA = "0x23E7E3C")]
		private void AddDefaultEffectInfo(CSBuffEffectInfo buffEffectInfo)
		{
		}

		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0x23E7F28", Offset = "0x23E7F28", VA = "0x23E7F28")]
		private void AddSkinEffectInfo(CSBuffEffectInfo buffEffectInfo)
		{
		}

		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x23E80F4", Offset = "0x23E80F4", VA = "0x23E80F4")]
		public List<CSBuffEffectInfo> GetEffectInfoList(int skinID = 0)
		{
			return null;
		}
	}
}
