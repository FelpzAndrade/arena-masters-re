using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;

namespace XBehavior
{
	[Token(Token = "0x2000423")]
	public class SelectBasicSkill : Action
	{
		[Token(Token = "0x400145C")]
		[FieldOffset(Offset = "0x2C")]
		public SharedInt randomedSkillID;

		[Token(Token = "0x400145D")]
		[FieldOffset(Offset = "0x30")]
		public int exceptSkillSlot;

		[Token(Token = "0x400145E")]
		[FieldOffset(Offset = "0x34")]
		private XModuleEntity m_me;

		[Token(Token = "0x400145F")]
		[FieldOffset(Offset = "0x38")]
		private int m_skillCount;

		[Token(Token = "0x6002193")]
		[Address(RVA = "0x1A92DE8", Offset = "0x1A92DE8", VA = "0x1A92DE8")]
		public SelectBasicSkill()
		{
		}

		[Token(Token = "0x6002194")]
		[Address(RVA = "0x1A92DF0", Offset = "0x1A92DF0", VA = "0x1A92DF0", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x6002195")]
		[Address(RVA = "0x1A92E84", Offset = "0x1A92E84", VA = "0x1A92E84", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
