using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace XJsonHelper
{
	[Token(Token = "0x20006C2")]
	public static class XJsonHelper
	{
		[Serializable]
		[Token(Token = "0x20006C3")]
		private class Wrapper<T>
		{
			[Token(Token = "0x4002053")]
			[FieldOffset(Offset = "0x0")]
			public T[] Items;

			[Token(Token = "0x6003854")]
			public Wrapper()
			{
			}
		}

		[Token(Token = "0x600384F")]
		public static T FromJson<T>(string json)
		{
			return (T)default;
		}

		[Token(Token = "0x6003850")]
		public static string ToJson<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x6003851")]
		public static T[] FromJsonArray<T>(string json)
		{
			return null;
		}

		[Token(Token = "0x6003852")]
		public static string ToJsonArray<T>(T[] array)
		{
			return null;
		}

		[Token(Token = "0x6003853")]
		public static T PatchObjectUseJsonUtility<T>(T source, JObject diffJson) where T : class
		{
			return null;
		}
	}
}
