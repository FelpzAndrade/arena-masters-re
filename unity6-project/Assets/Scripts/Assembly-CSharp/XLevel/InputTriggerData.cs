using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000710")]
	public class InputTriggerData : TimeTriggerData
	{
		[Token(Token = "0x4002187")]
		[FieldOffset(Offset = "0x20")]
		public XKeyEnum inputKey;

		[Token(Token = "0x4002188")]
		[FieldOffset(Offset = "0x24")]
		public string actionEntity;

		[Token(Token = "0x6003A9E")]
		[Address(RVA = "0x201D13C", Offset = "0x201D13C", VA = "0x201D13C")]
		public InputTriggerData()
		{
		}

		[Token(Token = "0x6003A9F")]
		[Address(RVA = "0x201D144", Offset = "0x201D144", VA = "0x201D144", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AA0")]
		[Address(RVA = "0x201D200", Offset = "0x201D200", VA = "0x201D200", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
