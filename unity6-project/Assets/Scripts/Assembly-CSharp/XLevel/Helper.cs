using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x200073E")]
	public class Helper
	{
		[Token(Token = "0x200073F")]
		public class ObjectIndexer
		{
			[Token(Token = "0x4002251")]
			[FieldOffset(Offset = "0x8")]
			private Dictionary<string, int> m_index;

			[Token(Token = "0x6003B64")]
			[Address(RVA = "0x201A41C", Offset = "0x201A41C", VA = "0x201A41C")]
			public ObjectIndexer()
			{
			}

			[Token(Token = "0x6003B65")]
			[Address(RVA = "0x201C21C", Offset = "0x201C21C", VA = "0x201C21C")]
			public void Clear()
			{
			}

			[Token(Token = "0x6003B66")]
			public string GetIndexedName<T>(string name = "", string midfix = "") where T : XLevelDataEntity
			{
				return null;
			}

			[Token(Token = "0x6003B67")]
			[Address(RVA = "0x201C2B4", Offset = "0x201C2B4", VA = "0x201C2B4")]
			public string GetIndexedName(Type type, string name, string midfix = "")
			{
				return null;
			}

			[Token(Token = "0x6003B68")]
			[Address(RVA = "0x201C45C", Offset = "0x201C45C", VA = "0x201C45C")]
			public string GetIndexedName(string key, string midfix = "")
			{
				return null;
			}

			[Token(Token = "0x6003B69")]
			[Address(RVA = "0x201C6E4", Offset = "0x201C6E4", VA = "0x201C6E4")]
			public void UpdateLastIndex(Type type, string name)
			{
			}

			[Token(Token = "0x6003B6A")]
			[Address(RVA = "0x201C2DC", Offset = "0x201C2DC", VA = "0x201C2DC")]
			private string GetKey(Type type, string name)
			{
				return null;
			}

			[Token(Token = "0x6003B6B")]
			[Address(RVA = "0x201C568", Offset = "0x201C568", VA = "0x201C568")]
			private int GetIndex(string key)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000740")]
		private class LevelObjComparer : EqualityComparer<LevelObjectData>
		{
			[Token(Token = "0x6003B6C")]
			[Address(RVA = "0x201C0E4", Offset = "0x201C0E4", VA = "0x201C0E4")]
			public LevelObjComparer()
			{
			}

			[Token(Token = "0x6003B6D")]
			[Address(RVA = "0x201C1A0", Offset = "0x201C1A0", VA = "0x201C1A0", Slot = "9")]
			public override bool Equals(LevelObjectData d1, LevelObjectData d2)
			{
				return default(bool);
			}

			[Token(Token = "0x6003B6E")]
			[Address(RVA = "0x201C1D8", Offset = "0x201C1D8", VA = "0x201C1D8", Slot = "8")]
			public override int GetHashCode(LevelObjectData d)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400224F")]
		[FieldOffset(Offset = "0x0")]
		private static XProtoInfoManagersForEditor m_proto;

		[Token(Token = "0x4002250")]
		[FieldOffset(Offset = "0x4")]
		private static ObjectIndexer m_indexer;

		[Token(Token = "0x17000833")]
		public static XProtoInfoManagers Proto
		{
			[Token(Token = "0x6003B4B")]
			[Address(RVA = "0x2019F54", Offset = "0x2019F54", VA = "0x2019F54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000834")]
		public static ObjectIndexer Indexer
		{
			[Token(Token = "0x6003B4E")]
			[Address(RVA = "0x201A350", Offset = "0x201A350", VA = "0x201A350")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B4A")]
		[Address(RVA = "0x2019F4C", Offset = "0x2019F4C", VA = "0x2019F4C")]
		public Helper()
		{
		}

		[Token(Token = "0x6003B4C")]
		[Address(RVA = "0x201A344", Offset = "0x201A344", VA = "0x201A344")]
		public static void Reload()
		{
		}

		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x2019FFC", Offset = "0x2019FFC", VA = "0x2019FFC")]
		private static void InitProto()
		{
		}

		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x201A4C8", Offset = "0x201A4C8", VA = "0x201A4C8")]
		public static XLevelObject CreateLevelObject(int id, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x201A61C", Offset = "0x201A61C", VA = "0x201A61C")]
		public static bool RefreshModel(XLevelObject lvo)
		{
			return default(bool);
		}

		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x201A718", Offset = "0x201A718", VA = "0x201A718")]
		public static GameObject AttachModel(GameObject go, int id)
		{
			return null;
		}

		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x201AA98", Offset = "0x201AA98", VA = "0x201AA98")]
		public static void RefreshName(XLevelObject obj, int id)
		{
		}

		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x201ACC0", Offset = "0x201ACC0", VA = "0x201ACC0")]
		public static void RefreshName(XTimeTrigger trigger)
		{
		}

		[Token(Token = "0x6003B54")]
		private static T CreateLevelObject<T>(CSCharacterInfo charInfo, Transform parent) where T : XLevelObject
		{
			return null;
		}

		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x201AEA4", Offset = "0x201AEA4", VA = "0x201AEA4")]
		public static XDecoration CreateDecorationRoot(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x201AFBC", Offset = "0x201AFBC", VA = "0x201AFBC")]
		public static XArea CreateArea(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x201B0D4", Offset = "0x201B0D4", VA = "0x201B0D4")]
		public static XWall CreateWall(int id, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x201B21C", Offset = "0x201B21C", VA = "0x201B21C")]
		public static XWayPoints CreateWayPoint(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B59")]
		[Address(RVA = "0x201B2B4", Offset = "0x201B2B4", VA = "0x201B2B4")]
		public static XRandomPosition CreateBattleField(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B5A")]
		[Address(RVA = "0x201B3B4", Offset = "0x201B3B4", VA = "0x201B3B4")]
		public static XCameraDirectionPlayer CreateCameraDirectionPlayer(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B5B")]
		public static XTimeTrigger CreateTrigger<T>(Transform parent) where T : XTimeTrigger
		{
			return null;
		}

		[Token(Token = "0x6003B5C")]
		[Address(RVA = "0x201B4CC", Offset = "0x201B4CC", VA = "0x201B4CC")]
		public static XLevelGroupEntity CreateGroupEntity(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x201B5E4", Offset = "0x201B5E4", VA = "0x201B5E4")]
		public static XLevelActionEntity CreateActionEntity(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x201B6FC", Offset = "0x201B6FC", VA = "0x201B6FC")]
		public static XLevelTransform CreateLevelTransform(Transform parent, float radius = 5f)
		{
			return null;
		}

		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x201B814", Offset = "0x201B814", VA = "0x201B814")]
		public static XRandomPosition CreatePositionGroup(Transform parent, float radius = 5f)
		{
			return null;
		}

		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x201B988", Offset = "0x201B988", VA = "0x201B988")]
		public static List<LevelObjectData> GetLevelObjects(LevelData data)
		{
			return null;
		}

		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x201BB0C", Offset = "0x201BB0C", VA = "0x201BB0C")]
		public static HashSet<int> GetLevelObjectIDSet(LevelData data)
		{
			return null;
		}

		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x201BCA8", Offset = "0x201BCA8", VA = "0x201BCA8")]
		public static Dictionary<int, int> GetLevelObjectsCount(LevelData data, int maximum = 1)
		{
			return null;
		}

		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x201BF28", Offset = "0x201BF28", VA = "0x201BF28")]
		public static HashSet<LevelObjectData> GetLevelObjectSet(LevelData data)
		{
			return null;
		}
	}
}
