using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000425")]
	public class SetClosestEnemyAsTarget : Action
	{
		[Token(Token = "0x4001462")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x6002199")]
		[Address(RVA = "0x1A93154", Offset = "0x1A93154", VA = "0x1A93154")]
		public SetClosestEnemyAsTarget()
		{
		}

		[Token(Token = "0x600219A")]
		[Address(RVA = "0x1A9315C", Offset = "0x1A9315C", VA = "0x1A9315C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x600219B")]
		[Address(RVA = "0x1A931F0", Offset = "0x1A931F0", VA = "0x1A931F0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
