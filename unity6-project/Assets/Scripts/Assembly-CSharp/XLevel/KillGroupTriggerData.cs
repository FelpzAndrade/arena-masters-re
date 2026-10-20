using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000712")]
	public class KillGroupTriggerData : TimeTriggerData
	{
		[Token(Token = "0x400218A")]
		[FieldOffset(Offset = "0x20")]
		public string targetEntity;

		[Token(Token = "0x6003AA4")]
		[Address(RVA = "0x201D2D4", Offset = "0x201D2D4", VA = "0x201D2D4")]
		public KillGroupTriggerData()
		{
		}

		[Token(Token = "0x6003AA5")]
		[Address(RVA = "0x201D2DC", Offset = "0x201D2DC", VA = "0x201D2DC", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AA6")]
		[Address(RVA = "0x201D398", Offset = "0x201D398", VA = "0x201D398", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
