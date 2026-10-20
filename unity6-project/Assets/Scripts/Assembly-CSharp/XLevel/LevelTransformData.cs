using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006FF")]
	public class LevelTransformData : LevelSpawnableData
	{
		[Token(Token = "0x400216B")]
		[FieldOffset(Offset = "0x20")]
		public XVector position;

		[Token(Token = "0x400216C")]
		[FieldOffset(Offset = "0x2C")]
		public XVector rotation;

		[Token(Token = "0x6003A71")]
		[Address(RVA = "0x201E338", Offset = "0x201E338", VA = "0x201E338")]
		public LevelTransformData()
		{
		}

		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x201E730", Offset = "0x201E730", VA = "0x201E730", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x201E3F8", Offset = "0x201E3F8", VA = "0x201E3F8", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
