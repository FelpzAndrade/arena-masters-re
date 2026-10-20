using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x200072B")]
	public class LevelSpawnableData : LevelDataEntity
	{
		[Token(Token = "0x40021E9")]
		[FieldOffset(Offset = "0x14")]
		public float delay;

		[Token(Token = "0x40021EA")]
		[FieldOffset(Offset = "0x18")]
		[JsonIgnore]
		public List<int> targetKGTrigger;

		[Token(Token = "0x40021EB")]
		[FieldOffset(Offset = "0x1C")]
		[JsonIgnore]
		public List<int> targetCombatTrigger;

		[Token(Token = "0x6003AEE")]
		[Address(RVA = "0x201D470", Offset = "0x201D470", VA = "0x201D470")]
		public LevelSpawnableData()
		{
		}

		[Token(Token = "0x6003AEF")]
		[Address(RVA = "0x201E568", Offset = "0x201E568", VA = "0x201E568")]
		private XLevelDataEntity AddComponent(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6003AF0")]
		[Address(RVA = "0x201E674", Offset = "0x201E674", VA = "0x201E674", Slot = "4")]
		public override Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003AF1")]
		[Address(RVA = "0x201D6F4", Offset = "0x201D6F4", VA = "0x201D6F4", Slot = "5")]
		protected override void PushDataToComponent(XLevelDataEntity comp)
		{
		}
	}
}
