using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000750")]
	public class WallData : LevelObjectData
	{
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x201FAA0", Offset = "0x201FAA0", VA = "0x201FAA0")]
		public WallData()
		{
		}

		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x201FAA4", Offset = "0x201FAA4", VA = "0x201FAA4", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x201FB60", Offset = "0x201FB60", VA = "0x201FB60", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
