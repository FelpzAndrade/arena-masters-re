using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000717")]
	public class SwitchGroupTriggerData : TimeTriggerData
	{
		[Token(Token = "0x4002197")]
		[FieldOffset(Offset = "0x20")]
		public List<string> switchGroupEntity;

		[Token(Token = "0x6003AB0")]
		[Address(RVA = "0x201F854", Offset = "0x201F854", VA = "0x201F854")]
		public SwitchGroupTriggerData()
		{
		}

		[Token(Token = "0x6003AB1")]
		[Address(RVA = "0x201F85C", Offset = "0x201F85C", VA = "0x201F85C", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AB2")]
		[Address(RVA = "0x201F918", Offset = "0x201F918", VA = "0x201F918", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
