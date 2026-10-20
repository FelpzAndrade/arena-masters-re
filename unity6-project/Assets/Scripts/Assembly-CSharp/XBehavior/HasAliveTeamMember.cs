using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000428")]
	public class HasAliveTeamMember : Conditional
	{
		[Token(Token = "0x4001469")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021A2")]
		[Address(RVA = "0x1F01BA4", Offset = "0x1F01BA4", VA = "0x1F01BA4")]
		public HasAliveTeamMember()
		{
		}

		[Token(Token = "0x60021A3")]
		[Address(RVA = "0x1F01BAC", Offset = "0x1F01BAC", VA = "0x1F01BAC", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021A4")]
		[Address(RVA = "0x1F01C40", Offset = "0x1F01C40", VA = "0x1F01C40", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
