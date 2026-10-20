using System;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x200073C")]
	public class XLevelDataGenerator : MonoBehaviour
	{
		[Token(Token = "0x4002237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int sectorID;

		[Token(Token = "0x4002238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MissionPlayPattern playPattern;

		[Token(Token = "0x4002239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public string escortTarget;

		[Token(Token = "0x400223A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform playerStartPosition;

		[Token(Token = "0x400223B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Transform playerSpawnRotation;

		[Token(Token = "0x400223C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform playerEnterFromPosition;

		[Token(Token = "0x400223D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int areaMaxMonsterCount;

		[Token(Token = "0x400223E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public XArea readyArea;

		[Token(Token = "0x400223F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string startPosName;

		[Token(Token = "0x4002240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly string enterFromPosName;

		[Token(Token = "0x4002241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly string spawnRotName;

		[Token(Token = "0x6003B3E")]
		[Address(RVA = "0x202B880", Offset = "0x202B880", VA = "0x202B880")]
		public XLevelDataGenerator()
		{
		}

		[Token(Token = "0x6003B40")]
		[Address(RVA = "0x202B960", Offset = "0x202B960", VA = "0x202B960")]
		private Transform CreatePosition(string name)
		{
			return null;
		}

		[Token(Token = "0x6003B41")]
		[Address(RVA = "0x202BA10", Offset = "0x202BA10", VA = "0x202BA10")]
		public LevelData Generate(out XLevelDataEntity.GenerationReport meta)
		{
			meta = default;
			return null;
		}

		[Token(Token = "0x6003B42")]
		[Address(RVA = "0x202C568", Offset = "0x202C568", VA = "0x202C568")]
		private bool Validate(LevelData levelData, XLevelDataEntity.GenerationReport meta)
		{
			return default(bool);
		}

		[Token(Token = "0x6003B43")]
		[Address(RVA = "0x202CC24", Offset = "0x202CC24", VA = "0x202CC24")]
		private bool CheckActionTag(string tag, XLevelDataEntity.GenerationReport meta)
		{
			return default(bool);
		}

		[Token(Token = "0x6003B44")]
		[Address(RVA = "0x202CD40", Offset = "0x202CD40", VA = "0x202CD40")]
		public void Clear()
		{
		}

		[Token(Token = "0x6003B45")]
		[Address(RVA = "0x202CD64", Offset = "0x202CD64", VA = "0x202CD64")]
		public void LoadAll(LevelData data, [Optional] Action<LevelDataEntity> namer)
		{
		}

		[Token(Token = "0x6003B46")]
		[Address(RVA = "0x202D174", Offset = "0x202D174", VA = "0x202D174")]
		public void CreateDefaultPosition()
		{
		}

		[Token(Token = "0x6003B47")]
		[Address(RVA = "0x202D348", Offset = "0x202D348", VA = "0x202D348")]
		private void OnDrawGizmos()
		{
		}
	}
}
