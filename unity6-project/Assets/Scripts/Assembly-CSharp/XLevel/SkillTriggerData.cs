using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000714")]
	public class SkillTriggerData : TimeTriggerData
	{
		[Token(Token = "0x2000715")]
		public enum SkillType
		{
			[Token(Token = "0x4002194")]
			Start = 0,
			[Token(Token = "0x4002195")]
			Finish = 1
		}

		[Token(Token = "0x400218F")]
		[FieldOffset(Offset = "0x20")]
		public string targetTag;

		[Token(Token = "0x4002190")]
		[FieldOffset(Offset = "0x24")]
		public int skillID;

		[Token(Token = "0x4002191")]
		[FieldOffset(Offset = "0x28")]
		public SkillType type;

		[Token(Token = "0x4002192")]
		[FieldOffset(Offset = "0x2C")]
		public string actionEntity;

		[Token(Token = "0x6003AAA")]
		[Address(RVA = "0x201F6A4", Offset = "0x201F6A4", VA = "0x201F6A4")]
		public SkillTriggerData()
		{
		}

		[Token(Token = "0x6003AAB")]
		[Address(RVA = "0x201F6AC", Offset = "0x201F6AC", VA = "0x201F6AC", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AAC")]
		[Address(RVA = "0x201F768", Offset = "0x201F768", VA = "0x201F768", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
