using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200070E")]
	public class HittedTriggerData : TimeTriggerData
	{
		[Token(Token = "0x4002183")]
		[FieldOffset(Offset = "0x20")]
		public string targetTag;

		[Token(Token = "0x4002184")]
		[FieldOffset(Offset = "0x24")]
		public int hittedCount;

		[Token(Token = "0x6003A98")]
		[Address(RVA = "0x201C99C", Offset = "0x201C99C", VA = "0x201C99C")]
		public HittedTriggerData()
		{
		}

		[Token(Token = "0x6003A99")]
		[Address(RVA = "0x201C9A4", Offset = "0x201C9A4", VA = "0x201C9A4", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A9A")]
		[Address(RVA = "0x201CA60", Offset = "0x201CA60", VA = "0x201CA60", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
