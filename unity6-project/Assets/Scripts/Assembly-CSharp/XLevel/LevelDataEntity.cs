using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace XLevel
{
	[Token(Token = "0x2000726")]
	public class LevelDataEntity
	{
		[Token(Token = "0x2000727")]
		private sealed class _003CToComponent_003Ec__AnonStorey134
		{
			[Token(Token = "0x40021E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal GameObject go;

			[Token(Token = "0x40021E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Action<LevelDataEntity> namer;

			[Token(Token = "0x6003AE0")]
			[Address(RVA = "0x201DD70", Offset = "0x201DD70", VA = "0x201DD70")]
			public _003CToComponent_003Ec__AnonStorey134()
			{
			}

			[Token(Token = "0x6003AE1")]
			[Address(RVA = "0x201DF44", Offset = "0x201DF44", VA = "0x201DF44")]
			internal void _003C_003Em__199(LevelDataEntity item)
			{
			}
		}

		[Token(Token = "0x40021E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x40021E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public LevelDataEntity[] children;

		[Token(Token = "0x40021E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[JsonIgnore]
		public int uid;

		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x2019E88", Offset = "0x2019E88", VA = "0x2019E88")]
		public LevelDataEntity()
		{
		}

		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x201DB70", Offset = "0x201DB70", VA = "0x201DB70")]
		public GameObject ToComponent(Transform parent, [Optional] Action<LevelDataEntity> namer)
		{
			return null;
		}

		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x201DD78", Offset = "0x201DD78", VA = "0x201DD78")]
		private XLevelDataEntity AddComponent(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x201DE84", Offset = "0x201DE84", VA = "0x201DE84", Slot = "4")]
		public virtual Type GetLevelDataType()
		{
			return null;
		}

		[Token(Token = "0x6003ADD")]
		[Address(RVA = "0x201DF40", Offset = "0x201DF40", VA = "0x201DF40", Slot = "5")]
		protected virtual void PushDataToComponent(XLevelDataEntity comp)
		{
		}

		[Token(Token = "0x6003ADE")]
		public List<T> GetChildrenRecursivelyIncludeSelf<T>() where T : LevelDataEntity
		{
			return null;
		}

		[Token(Token = "0x6003ADF")]
		public List<T> GetChildrenRecursively<T>() where T : LevelDataEntity
		{
			return null;
		}
	}
}
