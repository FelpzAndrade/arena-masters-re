using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000427")]
	public class UseSkill : Action
	{
		[Token(Token = "0x4001464")]
		[FieldOffset(Offset = "0x2C")]
		public int skillID;

		[Token(Token = "0x4001465")]
		[FieldOffset(Offset = "0x30")]
		public SkillSlot skillSlot;

		[Token(Token = "0x4001466")]
		[FieldOffset(Offset = "0x34")]
		public SharedInt randomedSkillID;

		[Token(Token = "0x4001467")]
		[FieldOffset(Offset = "0x38")]
		public SharedFloat restTime;

		[Token(Token = "0x4001468")]
		[FieldOffset(Offset = "0x3C")]
		private XModuleEntity m_me;

		[Token(Token = "0x600219F")]
		[Address(RVA = "0x1A93830", Offset = "0x1A93830", VA = "0x1A93830")]
		public UseSkill()
		{
		}

		[Token(Token = "0x60021A0")]
		[Address(RVA = "0x1A93838", Offset = "0x1A93838", VA = "0x1A93838", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021A1")]
		[Address(RVA = "0x1A938CC", Offset = "0x1A938CC", VA = "0x1A938CC", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
