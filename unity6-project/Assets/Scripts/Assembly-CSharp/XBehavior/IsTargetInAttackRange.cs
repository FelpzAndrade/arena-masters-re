using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000431")]
	public class IsTargetInAttackRange : Conditional
	{
		[Token(Token = "0x2000432")]
		public enum Range
		{
			[Token(Token = "0x400147D")]
			Min = 0,
			[Token(Token = "0x400147E")]
			Max = 1
		}

		[Token(Token = "0x4001478")]
		[FieldOffset(Offset = "0x2C")]
		public Range range;

		[Token(Token = "0x4001479")]
		[FieldOffset(Offset = "0x30")]
		public SharedFloat sharedDistance;

		[Token(Token = "0x400147A")]
		[FieldOffset(Offset = "0x34")]
		public SharedFloat sharedDuration;

		[Token(Token = "0x400147B")]
		[FieldOffset(Offset = "0x38")]
		private XModuleEntity m_me;

		[Token(Token = "0x60021BD")]
		[Address(RVA = "0x1F02D34", Offset = "0x1F02D34", VA = "0x1F02D34")]
		public IsTargetInAttackRange()
		{
		}

		[Token(Token = "0x60021BE")]
		[Address(RVA = "0x1F02D3C", Offset = "0x1F02D3C", VA = "0x1F02D3C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021BF")]
		[Address(RVA = "0x1F02DD0", Offset = "0x1F02DD0", VA = "0x1F02DD0", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
