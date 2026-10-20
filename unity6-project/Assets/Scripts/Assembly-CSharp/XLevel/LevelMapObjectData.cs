using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace XLevel
{
	[Token(Token = "0x20006FB")]
	public class LevelMapObjectData : LevelObjectData
	{
		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x40")]
		[JsonIgnore]
		public int level;

		[Token(Token = "0x6003A65")]
		[Address(RVA = "0x201E1E0", Offset = "0x201E1E0", VA = "0x201E1E0")]
		public LevelMapObjectData()
		{
		}

		[Token(Token = "0x6003A66")]
		[Address(RVA = "0x201E1EC", Offset = "0x201E1EC", VA = "0x201E1EC", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x201E2A8", Offset = "0x201E2A8", VA = "0x201E2A8", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
