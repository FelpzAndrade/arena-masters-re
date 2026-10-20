using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000089")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0xC")]
		public Object[] Assets;

		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Object> mResourcesCache;

		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x14")]
		private bool mCleaningScheduled;

		[Token(Token = "0x1700008D")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xD75090", Offset = "0xD75090", VA = "0xD75090")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xD7E3F8", Offset = "0xD7E3F8", VA = "0xD7E3F8")]
		public ResourceManager()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xD7E4A4", Offset = "0xD7E4A4", VA = "0xD7E4A4")]
		public void OnLevelWasLoaded()
		{
		}

		[Token(Token = "0x6000493")]
		public T GetAsset<T>(string Name) where T : Object
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xD7E4A8", Offset = "0xD7E4A8", VA = "0xD7E4A8")]
		private Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xD7A224", Offset = "0xD7A224", VA = "0xD7A224")]
		public bool HasAsset(Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000496")]
		public T LoadFromResources<T>(string Path) where T : Object
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xD754B8", Offset = "0xD754B8", VA = "0xD754B8")]
		public void CleanResourceCache()
		{
		}
	}
}
