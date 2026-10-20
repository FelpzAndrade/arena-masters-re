using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000424")]
	public class SelectRandomSkill : Action
	{
		[Token(Token = "0x4001460")]
		[FieldOffset(Offset = "0x2C")]
		public SharedInt randomedSkillID;

		[Token(Token = "0x4001461")]
		[FieldOffset(Offset = "0x30")]
		private XModuleEntity m_me;

		[Token(Token = "0x6002196")]
		[Address(RVA = "0x1A92F54", Offset = "0x1A92F54", VA = "0x1A92F54")]
		public SelectRandomSkill()
		{
		}

		[Token(Token = "0x6002197")]
		[Address(RVA = "0x1A92F5C", Offset = "0x1A92F5C", VA = "0x1A92F5C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6002198")]
		[Address(RVA = "0x1A92FF0", Offset = "0x1A92FF0", VA = "0x1A92FF0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
