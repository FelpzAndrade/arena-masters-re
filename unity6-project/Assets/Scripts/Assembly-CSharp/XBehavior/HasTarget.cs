using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x200042A")]
	public class HasTarget : Conditional
	{
		[Token(Token = "0x400146B")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021A8")]
		[Address(RVA = "0x1F01E08", Offset = "0x1F01E08", VA = "0x1F01E08")]
		public HasTarget()
		{
		}

		[Token(Token = "0x60021A9")]
		[Address(RVA = "0x1F01E10", Offset = "0x1F01E10", VA = "0x1F01E10", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021AA")]
		[Address(RVA = "0x1F01EA4", Offset = "0x1F01EA4", VA = "0x1F01EA4", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
