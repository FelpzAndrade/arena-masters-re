using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006FD")]
	public class LevelObjectData : LevelTransformData
	{
		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x38")]
		public int id;

		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x3C")]
		public string randomPosition;

		[Token(Token = "0x6003A6B")]
		[Address(RVA = "0x201D7DC", Offset = "0x201D7DC", VA = "0x201D7DC")]
		public LevelObjectData()
		{
		}

		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x201E33C", Offset = "0x201E33C", VA = "0x201E33C", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x201D988", Offset = "0x201D988", VA = "0x201D988", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
