using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x2000437")]
	public class IsUsingSkill : Conditional
	{
		[Token(Token = "0x4001492")]
		[FieldOffset(Offset = "0x2C")]
		public int skillID;

		[Token(Token = "0x4001493")]
		[FieldOffset(Offset = "0x30")]
		public SkillSlot skillSlot;

		[Token(Token = "0x4001494")]
		[FieldOffset(Offset = "0x34")]
		public SharedInt randomedSkillID;

		[Token(Token = "0x4001495")]
		[FieldOffset(Offset = "0x38")]
		private XModuleEntity m_me;

		[Token(Token = "0x4001496")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_start;

		[Token(Token = "0x60021C6")]
		[Address(RVA = "0x1A91A48", Offset = "0x1A91A48", VA = "0x1A91A48")]
		public IsUsingSkill()
		{
		}

		[Token(Token = "0x60021C7")]
		[Address(RVA = "0x1A91A8C", Offset = "0x1A91A8C", VA = "0x1A91A8C", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021C8")]
		[Address(RVA = "0x1A91B20", Offset = "0x1A91B20", VA = "0x1A91B20", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
