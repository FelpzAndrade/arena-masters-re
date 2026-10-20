using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200074A")]
	public class ActionEntityTriggerManager
	{
		[Token(Token = "0x4002292")]
		[FieldOffset(Offset = "0x8")]
		private Dictionary<int, List<int>> m_entityCount;

		[Token(Token = "0x6003BAA")]
		[Address(RVA = "0x1D3FCE4", Offset = "0x1D3FCE4", VA = "0x1D3FCE4")]
		public ActionEntityTriggerManager()
		{
		}

		[Token(Token = "0x6003BAB")]
		[Address(RVA = "0x1D3FD90", Offset = "0x1D3FD90", VA = "0x1D3FD90")]
		public void RegisterTrigger(int triggerUID, int entityUID)
		{
		}

		[Token(Token = "0x6003BAC")]
		[Address(RVA = "0x1D3FF0C", Offset = "0x1D3FF0C", VA = "0x1D3FF0C")]
		public bool CountUpEnd(int entityUID, out int endTriggerUID)
		{
			endTriggerUID = default;
			return default(bool);
		}
	}
}
