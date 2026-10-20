using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200070C")]
	public class CombatTriggerData : TimeTriggerData
	{
		[Token(Token = "0x4002180")]
		[FieldOffset(Offset = "0x20")]
		public string targetEntity;

		[Token(Token = "0x6003A92")]
		[Address(RVA = "0x2019CF0", Offset = "0x2019CF0", VA = "0x2019CF0")]
		public CombatTriggerData()
		{
		}

		[Token(Token = "0x6003A93")]
		[Address(RVA = "0x2019CF8", Offset = "0x2019CF8", VA = "0x2019CF8", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A94")]
		[Address(RVA = "0x2019DB4", Offset = "0x2019DB4", VA = "0x2019DB4", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
