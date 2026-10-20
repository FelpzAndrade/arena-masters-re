using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;

namespace CS
{
	[Token(Token = "0x20008A7")]
	public static class CSCSHelper
	{
		[Token(Token = "0x20008A8")]
		public class SimpleIncrementor
		{
			[Token(Token = "0x4002A7F")]
			[FieldOffset(Offset = "0x8")]
			private int count;

			[Token(Token = "0x17000987")]
			public int Count
			{
				[Token(Token = "0x600462A")]
				[Address(RVA = "0x222BE60", Offset = "0x222BE60", VA = "0x222BE60")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6004627")]
			[Address(RVA = "0x222BE3C", Offset = "0x222BE3C", VA = "0x222BE3C")]
			public SimpleIncrementor()
			{
			}

			[Token(Token = "0x6004628")]
			[Address(RVA = "0x222BE44", Offset = "0x222BE44", VA = "0x222BE44")]
			public void Reset()
			{
			}

			[Token(Token = "0x6004629")]
			[Address(RVA = "0x222BE50", Offset = "0x222BE50", VA = "0x222BE50")]
			public void Increment()
			{
			}
		}

		[Token(Token = "0x20008A9")]
		private sealed class _003CGetCustomAttributes_003Ec__Iterator8F : IDisposable
		{
			[Token(Token = "0x4002A80")]
			[FieldOffset(Offset = "0x8")]
			internal Type assemblyType;

			[Token(Token = "0x4002A81")]
			[FieldOffset(Offset = "0xC")]
			internal Assembly _003Cassembly_003E__0;

			[Token(Token = "0x4002A82")]
			[FieldOffset(Offset = "0x10")]
			internal int _003Ct_003E__1;

			[Token(Token = "0x4002A83")]
			[FieldOffset(Offset = "0x14")]
			internal Type _003Ceach_003E__2;

			[Token(Token = "0x4002A84")]
			[FieldOffset(Offset = "0x18")]
			internal int _0024PC;

			[Token(Token = "0x4002A85")]
			[FieldOffset(Offset = "0x1C")]
			internal Type _0024current;

			[Token(Token = "0x4002A86")]
			[FieldOffset(Offset = "0x20")]
			internal Type _003C_0024_003EassemblyType;

			[Token(Token = "0x17000988")]
			private Type System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EType_003E_002ECurrent
			{
				[Token(Token = "0x600462C")]
				[Address(RVA = "0x222BAC8", Offset = "0x222BAC8", VA = "0x222BAC8", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EType_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000989")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600462D")]
				[Address(RVA = "0x222BAD0", Offset = "0x222BAD0", VA = "0x222BAD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600462B")]
			[Address(RVA = "0x222BAC0", Offset = "0x222BAC0", VA = "0x222BAC0")]
			public _003CGetCustomAttributes_003Ec__Iterator8F()
			{
			}

			[Token(Token = "0x600462C")]
			[Address(RVA = "0x222BAC8", Offset = "0x222BAC8", VA = "0x222BAC8", Slot = "10")]
			[DebuggerHidden]
			private Type System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EType_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600462D")]
			[Address(RVA = "0x222BAD0", Offset = "0x222BAD0", VA = "0x222BAD0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600462E")]
			[Address(RVA = "0x222BAD8", Offset = "0x222BAD8", VA = "0x222BAD8", Slot = "8")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600462F")]
			[Address(RVA = "0x222BADC", Offset = "0x222BADC", VA = "0x222BADC", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<Type> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EType_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6004630")]
			[Address(RVA = "0x222BBB8", Offset = "0x222BBB8", VA = "0x222BBB8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6004631")]
			[Address(RVA = "0x222BD9C", Offset = "0x222BD9C", VA = "0x222BD9C", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6004632")]
			[Address(RVA = "0x222BDA8", Offset = "0x222BDA8", VA = "0x222BDA8", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x6004624")]
		public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
		}

		[Token(Token = "0x6004625")]
		[Address(RVA = "0x222BA10", Offset = "0x222BA10", VA = "0x222BA10")]
		[DebuggerHidden]
		public static IEnumerable<Type> GetCustomAttributes(Type assemblyType)
		{
			return null;
		}

		[Token(Token = "0x6004626")]
		public static T[] ReverseArray<T>(T[] arr)
		{
			return null;
		}
	}
}
