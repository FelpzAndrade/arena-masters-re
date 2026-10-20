using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x200043A")]
	public class NPC_IsAggressive : Conditional
	{
		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021CF")]
		[Address(RVA = "0x1A92904", Offset = "0x1A92904", VA = "0x1A92904")]
		public NPC_IsAggressive()
		{
		}

		[Token(Token = "0x60021D0")]
		[Address(RVA = "0x1A9290C", Offset = "0x1A9290C", VA = "0x1A9290C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021D1")]
		[Address(RVA = "0x1A929A0", Offset = "0x1A929A0", VA = "0x1A929A0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
