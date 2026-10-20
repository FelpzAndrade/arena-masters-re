using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200072D")]
	public class RandomPositionData : LevelDataEntity
	{
		[Token(Token = "0x40021ED")]
		[FieldOffset(Offset = "0x14")]
		public XVector center;

		[Token(Token = "0x40021EE")]
		[FieldOffset(Offset = "0x20")]
		public float radius;

		[Token(Token = "0x40021EF")]
		[FieldOffset(Offset = "0x24")]
		public float innerRadius;

		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x201EDA8", Offset = "0x201EDA8", VA = "0x201EDA8")]
		public RandomPositionData()
		{
		}

		[Token(Token = "0x6003AF7")]
		[Address(RVA = "0x201EDB0", Offset = "0x201EDB0", VA = "0x201EDB0", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AF8")]
		[Address(RVA = "0x201EE6C", Offset = "0x201EE6C", VA = "0x201EE6C", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
