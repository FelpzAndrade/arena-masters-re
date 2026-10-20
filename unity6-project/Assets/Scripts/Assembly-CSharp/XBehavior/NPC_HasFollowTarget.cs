using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000438")]
	public class NPC_HasFollowTarget : Conditional
	{
		[Token(Token = "0x4001497")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021C9")]
		[Address(RVA = "0x1A92644", Offset = "0x1A92644", VA = "0x1A92644")]
		public NPC_HasFollowTarget()
		{
		}

		[Token(Token = "0x60021CA")]
		[Address(RVA = "0x1A9264C", Offset = "0x1A9264C", VA = "0x1A9264C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021CB")]
		[Address(RVA = "0x1A926E0", Offset = "0x1A926E0", VA = "0x1A926E0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
