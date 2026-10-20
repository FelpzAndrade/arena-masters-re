using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006EF")]
	public class CameraDirectionData : LevelDataEntity
	{
		[Token(Token = "0x6003A4A")]
		[Address(RVA = "0x1D40208", Offset = "0x1D40208", VA = "0x1D40208")]
		public CameraDirectionData()
		{
		}

		[Token(Token = "0x6003A4B")]
		[Address(RVA = "0x1D40210", Offset = "0x1D40210", VA = "0x1D40210", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}
	}
}
