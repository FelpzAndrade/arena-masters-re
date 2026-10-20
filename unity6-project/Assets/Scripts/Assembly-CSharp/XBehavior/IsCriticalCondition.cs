using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x200042C")]
	public class IsCriticalCondition : Conditional
	{
		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021AE")]
		[Address(RVA = "0x1F02094", Offset = "0x1F02094", VA = "0x1F02094")]
		public IsCriticalCondition()
		{
		}

		[Token(Token = "0x60021AF")]
		[Address(RVA = "0x1F0209C", Offset = "0x1F0209C", VA = "0x1F0209C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021B0")]
		[Address(RVA = "0x1F02130", Offset = "0x1F02130", VA = "0x1F02130", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
