using System;
using System.Reflection;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000118")]
	internal static class CachedAttributeGetter<T> where T : Attribute
	{
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<ICustomAttributeProvider, T> TypeAttributeCache;

		[Token(Token = "0x6000AC2")]
		public static T GetAttribute(ICustomAttributeProvider type)
		{
			return null;
		}
	}
}
