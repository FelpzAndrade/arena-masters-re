using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000703")]
	public class CheckHPTriggerData : TimeTriggerData
	{
		[Token(Token = "0x2000704")]
		public enum Condition
		{
			[Token(Token = "0x4002176")]
			Ratio = 0,
			[Token(Token = "0x4002177")]
			Const = 1
		}

		[Token(Token = "0x4002172")]
		[FieldOffset(Offset = "0x20")]
		public string targetTag;

		[Token(Token = "0x4002173")]
		[FieldOffset(Offset = "0x24")]
		public int hp;

		[Token(Token = "0x4002174")]
		[FieldOffset(Offset = "0x28")]
		public Condition condition;

		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x1D40660", Offset = "0x1D40660", VA = "0x1D40660")]
		public CheckHPTriggerData()
		{
		}

		[Token(Token = "0x6003A7E")]
		[Address(RVA = "0x1D40668", Offset = "0x1D40668", VA = "0x1D40668", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x1D40724", Offset = "0x1D40724", VA = "0x1D40724", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
