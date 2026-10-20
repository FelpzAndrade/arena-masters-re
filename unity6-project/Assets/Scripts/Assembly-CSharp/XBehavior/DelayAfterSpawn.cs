using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000414")]
	public class DelayAfterSpawn : Action
	{
		[Token(Token = "0x4001436")]
		[FieldOffset(Offset = "0x2C")]
		public float delay;

		[Token(Token = "0x4001437")]
		[FieldOffset(Offset = "0x30")]
		private float m_delayEndTime;

		[Token(Token = "0x4001438")]
		[FieldOffset(Offset = "0x34")]
		private XModuleEntity m_me;

		[Token(Token = "0x6002140")]
		[Address(RVA = "0x1EFFF68", Offset = "0x1EFFF68", VA = "0x1EFFF68")]
		public DelayAfterSpawn()
		{
		}

		[Token(Token = "0x6002141")]
		[Address(RVA = "0x1EFFF78", Offset = "0x1EFFF78", VA = "0x1EFFF78", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6002142")]
		[Address(RVA = "0x1F0000C", Offset = "0x1F0000C", VA = "0x1F0000C", Slot = "5")]
		public override void OnStart()
		{
		}

		[Token(Token = "0x6002143")]
		[Address(RVA = "0x1F00040", Offset = "0x1F00040", VA = "0x1F00040", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
