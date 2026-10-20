using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x2000720")]
	public class DecorationData : LevelDataEntity
	{
		[Token(Token = "0x6003ACA")]
		[Address(RVA = "0x2019E80", Offset = "0x2019E80", VA = "0x2019E80")]
		public DecorationData()
		{
		}

		[Token(Token = "0x6003ACB")]
		[Address(RVA = "0x2019E90", Offset = "0x2019E90", VA = "0x2019E90", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}
	}
}
