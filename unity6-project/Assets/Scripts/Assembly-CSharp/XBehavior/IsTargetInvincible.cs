using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000436")]
	public class IsTargetInvincible : Conditional
	{
		[Token(Token = "0x4001491")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021C3")]
		[Address(RVA = "0x1A9189C", Offset = "0x1A9189C", VA = "0x1A9189C")]
		public IsTargetInvincible()
		{
		}

		[Token(Token = "0x60021C4")]
		[Address(RVA = "0x1A918A4", Offset = "0x1A918A4", VA = "0x1A918A4", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021C5")]
		[Address(RVA = "0x1A91938", Offset = "0x1A91938", VA = "0x1A91938", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
