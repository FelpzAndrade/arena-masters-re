using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x2000433")]
	public class IsTargetInSkillRange : Conditional
	{
		[Token(Token = "0x2000434")]
		public enum Range
		{
			[Token(Token = "0x4001488")]
			Min = 0,
			[Token(Token = "0x4001489")]
			Max = 1
		}

		[Token(Token = "0x400147F")]
		[FieldOffset(Offset = "0x2C")]
		public Range range;

		[Token(Token = "0x4001480")]
		[FieldOffset(Offset = "0x30")]
		public int skillID;

		[Token(Token = "0x4001481")]
		[FieldOffset(Offset = "0x34")]
		public SkillSlot skillSlot;

		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x38")]
		public SharedInt randomedSkillID;

		[Token(Token = "0x4001483")]
		[FieldOffset(Offset = "0x3C")]
		public SharedFloat sharedDistance;

		[Token(Token = "0x4001484")]
		[FieldOffset(Offset = "0x40")]
		public SharedFloat sharedDuration;

		[Token(Token = "0x4001485")]
		[FieldOffset(Offset = "0x44")]
		private XModuleEntity m_me;

		[Token(Token = "0x4001486")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 m_start;

		[Token(Token = "0x60021C0")]
		[Address(RVA = "0x1A9144C", Offset = "0x1A9144C", VA = "0x1A9144C")]
		public IsTargetInSkillRange()
		{
		}

		[Token(Token = "0x60021C1")]
		[Address(RVA = "0x1A91490", Offset = "0x1A91490", VA = "0x1A91490", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021C2")]
		[Address(RVA = "0x1A9151C", Offset = "0x1A9151C", VA = "0x1A9151C", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
