using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000144")]
	internal static class CollectionUtils
	{
		[Token(Token = "0x2000145")]
		private sealed class _003CTryGetSingleItem_003Ec__AnonStoreyCE<T>
		{
			[Token(Token = "0x400054D")]
			[FieldOffset(Offset = "0x0")]
			internal IList<T> list;

			[Token(Token = "0x400054E")]
			[FieldOffset(Offset = "0x0")]
			internal bool returnDefaultIfEmpty;

			[Token(Token = "0x6000C72")]
			public _003CTryGetSingleItem_003Ec__AnonStoreyCE()
			{
			}

			[Token(Token = "0x6000C73")]
			internal T _003C_003Em__55()
			{
				return (T)default;
			}
		}

		[Token(Token = "0x2000146")]
		private sealed class _003CCreateCollectionWrapper_003Ec__AnonStoreyCF
		{
			[Token(Token = "0x400054F")]
			[FieldOffset(Offset = "0x8")]
			internal Type collectionDefinition;

			[Token(Token = "0x4000550")]
			[FieldOffset(Offset = "0xC")]
			internal object list;

			[Token(Token = "0x6000C74")]
			[Address(RVA = "0x11942C8", Offset = "0x11942C8", VA = "0x11942C8")]
			public _003CCreateCollectionWrapper_003Ec__AnonStoreyCF()
			{
			}

			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x1196B80", Offset = "0x1196B80", VA = "0x1196B80")]
			internal object _003C_003Em__56(Type t, IList<object> a)
			{
				return null;
			}
		}

		[Token(Token = "0x2000147")]
		private sealed class _003CCreateListWrapper_003Ec__AnonStoreyD0
		{
			[Token(Token = "0x4000551")]
			[FieldOffset(Offset = "0x8")]
			internal Type listDefinition;

			[Token(Token = "0x4000552")]
			[FieldOffset(Offset = "0xC")]
			internal object list;

			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x119513C", Offset = "0x119513C", VA = "0x119513C")]
			public _003CCreateListWrapper_003Ec__AnonStoreyD0()
			{
			}

			[Token(Token = "0x6000C77")]
			[Address(RVA = "0x1196EC8", Offset = "0x1196EC8", VA = "0x1196EC8")]
			internal object _003C_003Em__57(Type t, IList<object> a)
			{
				return null;
			}
		}

		[Token(Token = "0x2000148")]
		private sealed class _003CCreateDictionaryWrapper_003Ec__AnonStoreyD1
		{
			[Token(Token = "0x4000553")]
			[FieldOffset(Offset = "0x8")]
			internal Type dictionaryDefinition;

			[Token(Token = "0x4000554")]
			[FieldOffset(Offset = "0xC")]
			internal object dictionary;

			[Token(Token = "0x6000C78")]
			[Address(RVA = "0x11956AC", Offset = "0x11956AC", VA = "0x11956AC")]
			public _003CCreateDictionaryWrapper_003Ec__AnonStoreyD1()
			{
			}

			[Token(Token = "0x6000C79")]
			[Address(RVA = "0x1196D24", Offset = "0x1196D24", VA = "0x1196D24")]
			internal object _003C_003Em__58(Type t, IList<object> a)
			{
				return null;
			}
		}

		[Token(Token = "0x6000C4B")]
		public static IEnumerable<T> CastValid<T>(this IEnumerable enumerable)
		{
			return null;
		}

		[Token(Token = "0x6000C4C")]
		public static List<T> CreateList<T>(params T[] values)
		{
			return null;
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x1193284", Offset = "0x1193284", VA = "0x1193284")]
		public static bool IsNullOrEmpty(ICollection collection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C4E")]
		public static bool IsNullOrEmpty<T>(ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C4F")]
		public static bool IsNullOrEmptyOrDefault<T>(IList<T> list)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C50")]
		public static IList<T> Slice<T>(IList<T> list, int? start, int? end)
		{
			return null;
		}

		[Token(Token = "0x6000C51")]
		public static IList<T> Slice<T>(IList<T> list, int? start, int? end, int? step)
		{
			return null;
		}

		[Token(Token = "0x6000C52")]
		public static Dictionary<K, List<V>> GroupBy<K, V>(ICollection<V> source, Func<V, K> keySelector)
		{
			return null;
		}

		[Token(Token = "0x6000C53")]
		public static void AddRange<T>(this IList<T> initial, IEnumerable<T> collection)
		{
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x1193384", Offset = "0x1193384", VA = "0x1193384")]
		public static void AddRange(this IList initial, IEnumerable collection)
		{
		}

		[Token(Token = "0x6000C55")]
		public static List<T> Distinct<T>(List<T> collection)
		{
			return null;
		}

		[Token(Token = "0x6000C56")]
		public static List<List<T>> Flatten<T>(params IList<T>[] lists)
		{
			return null;
		}

		[Token(Token = "0x6000C57")]
		private static void Recurse<T>(IList<IList<T>> global, int current, Dictionary<int, T> currentSet, List<List<T>> flattenedResult)
		{
		}

		[Token(Token = "0x6000C58")]
		public static List<T> CreateList<T>(ICollection collection)
		{
			return null;
		}

		[Token(Token = "0x6000C59")]
		public static bool ListEquals<T>(IList<T> a, IList<T> b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C5A")]
		public static bool TryGetSingleItem<T>(IList<T> list, out T value)
		{
			value = default;
			return default(bool);
		}

		[Token(Token = "0x6000C5B")]
		public static bool TryGetSingleItem<T>(IList<T> list, bool returnDefaultIfEmpty, out T value)
		{
			value = default;
			return default(bool);
		}

		[Token(Token = "0x6000C5C")]
		public static T GetSingleItem<T>(IList<T> list)
		{
			return (T)default;
		}

		[Token(Token = "0x6000C5D")]
		public static T GetSingleItem<T>(IList<T> list, bool returnDefaultIfEmpty)
		{
			return (T)default;
		}

		[Token(Token = "0x6000C5E")]
		public static IList<T> Minus<T>(IList<T> list, IList<T> minus)
		{
			return null;
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x119347C", Offset = "0x119347C", VA = "0x119347C")]
		public static IList CreateGenericList(Type listType)
		{
			return null;
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x11936B0", Offset = "0x11936B0", VA = "0x11936B0")]
		public static IDictionary CreateGenericDictionary(Type keyType, Type valueType)
		{
			return null;
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x119385C", Offset = "0x119385C", VA = "0x119385C")]
		public static bool IsListType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x1193A54", Offset = "0x1193A54", VA = "0x1193A54")]
		public static bool IsCollectionType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x1193C28", Offset = "0x1193C28", VA = "0x1193C28")]
		public static bool IsDictionaryType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x1193DD0", Offset = "0x1193DD0", VA = "0x1193DD0")]
		public static IWrappedCollection CreateCollectionWrapper(object list)
		{
			return null;
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x1194C44", Offset = "0x1194C44", VA = "0x1194C44")]
		public static IWrappedList CreateListWrapper(object list)
		{
			return null;
		}

		[Token(Token = "0x6000C66")]
		[Address(RVA = "0x1195144", Offset = "0x1195144", VA = "0x1195144")]
		public static IWrappedDictionary CreateDictionaryWrapper(object dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000C67")]
		[Address(RVA = "0x1195714", Offset = "0x1195714", VA = "0x1195714")]
		public static object CreateAndPopulateList(Type listType, Action<IList, bool> populateList)
		{
			return null;
		}

		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x1196990", Offset = "0x1196990", VA = "0x1196990")]
		public static Array ToArray(Array initial, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000C69")]
		public static bool AddDistinct<T>(this IList<T> list, T value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6A")]
		public static bool AddDistinct<T>(this IList<T> list, T value, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6B")]
		public static bool ContainsValue<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6C")]
		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6D")]
		public static bool AddRangeDistinct<T>(this IList<T> list, IEnumerable<T> values, IEqualityComparer<T> comparer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C6E")]
		public static int IndexOf<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
		{
			return default(int);
		}

		[Token(Token = "0x6000C6F")]
		public static int IndexOf<TSource>(this IEnumerable<TSource> list, TSource value) where TSource : IEquatable<TSource>
		{
			return default(int);
		}

		[Token(Token = "0x6000C70")]
		public static int IndexOf<TSource>(this IEnumerable<TSource> list, TSource value, IEqualityComparer<TSource> comparer)
		{
			return default(int);
		}

		[Token(Token = "0x6000C71")]
		private static bool _003CCastValid_00601_003Em__54<T>(object o)
		{
			return default(bool);
		}
	}
}
