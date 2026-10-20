using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x200042F")]
	public class IsRunningSkill : Conditional
	{
		[Token(Token = "0x4001472")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021B7")]
		[Address(RVA = "0x1F0297C", Offset = "0x1F0297C", VA = "0x1F0297C")]
		public IsRunningSkill()
		{
		}

		[Token(Token = "0x60021B8")]
		[Address(RVA = "0x1F02984", Offset = "0x1F02984", VA = "0x1F02984", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x1F02A18", Offset = "0x1F02A18", VA = "0x1F02A18", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
