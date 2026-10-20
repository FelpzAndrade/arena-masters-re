using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000719")]
	public class XTimeTrigger : XLevelDataEntity
	{
		[Token(Token = "0x400219B")]
		[FieldOffset(Offset = "0xC")]
		public TriggerType triggerType;

		[Token(Token = "0x400219C")]
		[FieldOffset(Offset = "0x10")]
		public float delay;

		[Token(Token = "0x400219D")]
		[FieldOffset(Offset = "0x14")]
		public bool spawnWhenNoMonster;

		[Token(Token = "0x400219E")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public TimeTriggerData triggerData;

		[Token(Token = "0x400219F")]
		[FieldOffset(Offset = "0x1C")]
		private ITriggerReciever m_reciever;

		[Token(Token = "0x6003AB3")]
		[Address(RVA = "0x201FE6C", Offset = "0x201FE6C", VA = "0x201FE6C")]
		public XTimeTrigger()
		{
		}

		[Token(Token = "0x6003AB4")]
		[Address(RVA = "0x2033434", Offset = "0x2033434", VA = "0x2033434", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AB5")]
		[Address(RVA = "0x202018C", Offset = "0x202018C", VA = "0x202018C", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}

		[Token(Token = "0x6003AB6")]
		[Address(RVA = "0x2029FB4", Offset = "0x2029FB4", VA = "0x2029FB4")]
		public void TriggerEnter()
		{
		}

		[Token(Token = "0x6003AB7")]
		[Address(RVA = "0x20198E4", Offset = "0x20198E4", VA = "0x20198E4")]
		public void SetTriggerReciever(ITriggerReciever reciever)
		{
		}
	}
}
