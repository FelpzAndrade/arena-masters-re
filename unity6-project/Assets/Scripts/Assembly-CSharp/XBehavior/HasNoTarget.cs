using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000429")]
	public class HasNoTarget : Conditional
	{
		[Token(Token = "0x400146A")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021A5")]
		[Address(RVA = "0x1F01C84", Offset = "0x1F01C84", VA = "0x1F01C84")]
		public HasNoTarget()
		{
		}

		[Token(Token = "0x60021A6")]
		[Address(RVA = "0x1F01C8C", Offset = "0x1F01C8C", VA = "0x1F01C8C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021A7")]
		[Address(RVA = "0x1F01D20", Offset = "0x1F01D20", VA = "0x1F01D20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
