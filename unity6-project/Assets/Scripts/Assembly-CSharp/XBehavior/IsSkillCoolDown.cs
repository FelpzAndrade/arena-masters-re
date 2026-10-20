using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace XBehavior
{
	[Token(Token = "0x2000430")]
	public class IsSkillCoolDown : Conditional
	{
		[Token(Token = "0x4001473")]
		[FieldOffset(Offset = "0x2C")]
		public int skillID;

		[Token(Token = "0x4001474")]
		[FieldOffset(Offset = "0x30")]
		public SkillSlot skillSlot;

		[Token(Token = "0x4001475")]
		[FieldOffset(Offset = "0x34")]
		public SharedInt randomedSkillID;

		[Token(Token = "0x4001476")]
		[FieldOffset(Offset = "0x38")]
		private XModuleEntity m_me;

		[Token(Token = "0x4001477")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 m_start;

		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x1F02A5C", Offset = "0x1F02A5C", VA = "0x1F02A5C")]
		public IsSkillCoolDown()
		{
		}

		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x1F02AA0", Offset = "0x1F02AA0", VA = "0x1F02AA0", Slot = "4")]
		public override void OnAwake()
		{
		}

		[Token(Token = "0x60021BC")]
		[Address(RVA = "0x1F02B34", Offset = "0x1F02B34", VA = "0x1F02B34", Slot = "6")]
		public override TaskStatus OnUpdate()
		{
			return default(TaskStatus);
		}
	}
}
