using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200074B")]
	public class HittedTriggerManager
	{
		[Token(Token = "0x4002293")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<string, List<HittedTriggerData>> m_hittedActorTagDic;

		[Token(Token = "0x4002294")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<int, int> m_triggerCount;

		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, int> m_hittedCount;

		[Token(Token = "0x6003BAD")]
		[Address(RVA = "0x201CB34", Offset = "0x201CB34", VA = "0x201CB34")]
		public HittedTriggerManager()
		{
		}

		[Token(Token = "0x6003BAE")]
		[Address(RVA = "0x201CC2C", Offset = "0x201CC2C", VA = "0x201CC2C")]
		public void RegisterTrigger(HittedTriggerData triggerData)
		{
		}

		[Token(Token = "0x6003BAF")]
		[Address(RVA = "0x201CDE0", Offset = "0x201CDE0", VA = "0x201CDE0")]
		public List<int> CountUpEnd(string hittedTag)
		{
			return null;
		}
	}
}
