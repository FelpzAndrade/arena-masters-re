using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000422")]
	public class NPC_SetEnemyAsTarget : Action
	{
		[Token(Token = "0x400145B")]
		[FieldOffset(Offset = "0x2C")]
		private XModuleEntity m_me;

		[Token(Token = "0x6002190")]
		[Address(RVA = "0x1A929E4", Offset = "0x1A929E4", VA = "0x1A929E4")]
		public NPC_SetEnemyAsTarget()
		{
		}

		[Token(Token = "0x6002191")]
		[Address(RVA = "0x1A929EC", Offset = "0x1A929EC", VA = "0x1A929EC", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6002192")]
		[Address(RVA = "0x1A92A80", Offset = "0x1A92A80", VA = "0x1A92A80", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
