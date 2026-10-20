using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000701")]
	public class ActionEntityTriggerData : TimeTriggerData
	{
		[Token(Token = "0x400216E")]
		[FieldOffset(Offset = "0x20")]
		public string targetActionEntity;

		[Token(Token = "0x6003A77")]
		[Address(RVA = "0x1D3FB50", Offset = "0x1D3FB50", VA = "0x1D3FB50")]
		public ActionEntityTriggerData()
		{
		}

		[Token(Token = "0x6003A78")]
		[Address(RVA = "0x1D3FB58", Offset = "0x1D3FB58", VA = "0x1D3FB58", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A79")]
		[Address(RVA = "0x1D3FC14", Offset = "0x1D3FC14", VA = "0x1D3FC14", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
