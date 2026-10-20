using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x200071D")]
	public class AreaData : LevelDataEntity
	{
		[Token(Token = "0x6003ABF")]
		[Address(RVA = "0x1D4013C", Offset = "0x1D4013C", VA = "0x1D4013C")]
		public AreaData()
		{
		}

		[Token(Token = "0x6003AC0")]
		[Address(RVA = "0x1D40144", Offset = "0x1D40144", VA = "0x1D40144", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}
	}
}
