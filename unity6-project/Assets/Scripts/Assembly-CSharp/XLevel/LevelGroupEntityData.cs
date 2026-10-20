using System;
using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000729")]
	public class LevelGroupEntityData : LevelDataEntity
	{
		[Token(Token = "0x6003AE6")]
		[Address(RVA = "0x201DF90", Offset = "0x201DF90", VA = "0x201DF90")]
		public LevelGroupEntityData()
		{
		}

		[Token(Token = "0x6003AE7")]
		[Address(RVA = "0x201DF98", Offset = "0x201DF98", VA = "0x201DF98")]
		private XLevelDataEntity AddComponent(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6003AE8")]
		[Address(RVA = "0x201E0A4", Offset = "0x201E0A4", VA = "0x201E0A4", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AE9")]
		[Address(RVA = "0x201E160", Offset = "0x201E160", VA = "0x201E160", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
