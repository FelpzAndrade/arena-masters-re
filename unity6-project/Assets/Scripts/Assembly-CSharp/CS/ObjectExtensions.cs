using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008B3")]
	public static class ObjectExtensions
	{
		[Token(Token = "0x20008B4")]
		private sealed class _003CInternalCopy_003Ec__AnonStorey149
		{
			[Token(Token = "0x4002A91")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal IDictionary<object, object> visited;

			[Token(Token = "0x6004689")]
			[Address(RVA = "0x2343308", Offset = "0x2343308", VA = "0x2343308")]
			public _003CInternalCopy_003Ec__AnonStorey149()
			{
			}
		}

		[Token(Token = "0x20008B5")]
		private sealed class _003CInternalCopy_003Ec__AnonStorey148
		{
			[Token(Token = "0x4002A92")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Array clonedArray;

			[Token(Token = "0x4002A93")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal _003CInternalCopy_003Ec__AnonStorey149 _003C_003Ef__ref_0024329;

			[Token(Token = "0x600468A")]
			[Address(RVA = "0x2343310", Offset = "0x2343310", VA = "0x2343310")]
			public _003CInternalCopy_003Ec__AnonStorey148()
			{
			}

			[Token(Token = "0x600468B")]
			[Address(RVA = "0x2343878", Offset = "0x2343878", VA = "0x2343878")]
			internal void _003C_003Em__1E6(Array array, int[] indices)
			{
			}
		}

		[Token(Token = "0x4002A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly MethodInfo CloneMethod;

		[Token(Token = "0x4002A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static Func<FieldInfo, bool> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6004682")]
		[Address(RVA = "0x2342B34", Offset = "0x2342B34", VA = "0x2342B34")]
		public static bool IsPrimitive(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6004683")]
		[Address(RVA = "0x2342C38", Offset = "0x2342C38", VA = "0x2342C38")]
		public static object Copy(this object originalObject)
		{
			return null;
		}

		[Token(Token = "0x6004684")]
		[Address(RVA = "0x2342D30", Offset = "0x2342D30", VA = "0x2342D30")]
		private static object InternalCopy(object originalObject, IDictionary<object, object> visited)
		{
			return null;
		}

		[Token(Token = "0x6004685")]
		[Address(RVA = "0x23435B0", Offset = "0x23435B0", VA = "0x23435B0")]
		private static void RecursiveCopyBaseTypePrivateFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect)
		{
		}

		[Token(Token = "0x6004686")]
		[Address(RVA = "0x2343318", Offset = "0x2343318", VA = "0x2343318")]
		private static void CopyFields(object originalObject, IDictionary<object, object> visited, object cloneObject, Type typeToReflect, [Optional] BindingFlags bindingFlags, [Optional] Func<FieldInfo, bool> filter)
		{
		}

		[Token(Token = "0x6004687")]
		public static T Copy<T>(this T original)
		{
			return (T)default;
		}

		[Token(Token = "0x6004688")]
		[Address(RVA = "0x234384C", Offset = "0x234384C", VA = "0x234384C")]
		private static bool _003CRecursiveCopyBaseTypePrivateFields_003Em__1E7(FieldInfo info)
		{
			return default(bool);
		}
	}
}
