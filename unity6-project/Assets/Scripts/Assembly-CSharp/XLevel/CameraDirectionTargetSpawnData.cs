using System;
using Il2CppDummyDll;

namespace XLevel
{
	[Token(Token = "0x20006F5")]
	public class CameraDirectionTargetSpawnData : CameraDirectionData
	{
		[Token(Token = "0x6003A5A")]
		[Address(RVA = "0x1D4059C", Offset = "0x1D4059C", VA = "0x1D4059C")]
		public CameraDirectionTargetSpawnData()
		{
		}

		[Token(Token = "0x6003A5B")]
		[Address(RVA = "0x1D405A4", Offset = "0x1D405A4", VA = "0x1D405A4", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}
	}
}
