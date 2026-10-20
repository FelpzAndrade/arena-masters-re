using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200071B")]
	public class TimeTriggerData : LevelDataEntity
	{
		[Token(Token = "0x40021A0")]
		[FieldOffset(Offset = "0x14")]
		public TriggerType triggerType;

		[Token(Token = "0x40021A1")]
		[FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x40021A2")]
		[FieldOffset(Offset = "0x1C")]
		public bool spawnWhenNoMonster;

		[Token(Token = "0x6003AB9")]
		[Address(RVA = "0x2019578", Offset = "0x2019578", VA = "0x2019578")]
		public TimeTriggerData()
		{
		}

		[Token(Token = "0x6003ABA")]
		[Address(RVA = "0x201F9E4", Offset = "0x201F9E4", VA = "0x201F9E4", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003ABB")]
		[Address(RVA = "0x20199B0", Offset = "0x20199B0", VA = "0x20199B0", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
