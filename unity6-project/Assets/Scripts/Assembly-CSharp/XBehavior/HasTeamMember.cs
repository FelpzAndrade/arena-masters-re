using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x200042B")]
	public class HasTeamMember : Conditional
	{
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021AB")]
		[Address(RVA = "0x1F01FB4", Offset = "0x1F01FB4", VA = "0x1F01FB4")]
		public HasTeamMember()
		{
		}

		[Token(Token = "0x60021AC")]
		[Address(RVA = "0x1F01FBC", Offset = "0x1F01FBC", VA = "0x1F01FBC", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021AD")]
		[Address(RVA = "0x1F02050", Offset = "0x1F02050", VA = "0x1F02050", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
