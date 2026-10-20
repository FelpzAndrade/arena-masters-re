using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000713")]
	public class XSkillTrigger : XTimeTrigger
	{
		[Token(Token = "0x400218B")]
		[FieldOffset(Offset = "0x20")]
		public string targetTag;

		[Token(Token = "0x400218C")]
		[FieldOffset(Offset = "0x24")]
		public int skillID;

		[Token(Token = "0x400218D")]
		[FieldOffset(Offset = "0x28")]
		public SkillTriggerData.SkillType type;

		[Token(Token = "0x400218E")]
		[FieldOffset(Offset = "0x2C")]
		public string actionEntity;

		[Token(Token = "0x6003AA7")]
		[Address(RVA = "0x2032EC4", Offset = "0x2032EC4", VA = "0x2032EC4")]
		public XSkillTrigger()
		{
		}

		[Token(Token = "0x6003AA8")]
		[Address(RVA = "0x2032ECC", Offset = "0x2032ECC", VA = "0x2032ECC", Slot = "6")]
		protected override LevelDataEntity GetDataInstance()
		{
			return null;
		}

		[Token(Token = "0x6003AA9")]
		[Address(RVA = "0x2032F58", Offset = "0x2032F58", VA = "0x2032F58", Slot = "5")]
		protected override void PushData(LevelDataEntity data, GenerationReport meta)
		{
		}
	}
}
