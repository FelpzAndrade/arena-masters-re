using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x200062E")]
public static class XES2
{
	[Token(Token = "0x200062F")]
	public class SaveManager
	{
		[Token(Token = "0x2000630")]
		private sealed class _003CSaveDelay_003Ec__Iterator7D : IDisposable
		{
			[Token(Token = "0x4001DC7")]
			[FieldOffset(Offset = "0x8")]
			internal string key;

			[Token(Token = "0x4001DC8")]
			[FieldOffset(Offset = "0xC")]
			internal int _0024PC;

			[Token(Token = "0x4001DC9")]
			[FieldOffset(Offset = "0x10")]
			internal object _0024current;

			[Token(Token = "0x4001DCA")]
			[FieldOffset(Offset = "0x14")]
			internal string _003C_0024_003Ekey;

			[Token(Token = "0x4001DCB")]
			[FieldOffset(Offset = "0x18")]
			internal SaveManager _003C_003Ef__this;

			[Token(Token = "0x170007BF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6003519")]
				[Address(RVA = "0x19AEE28", Offset = "0x19AEE28", VA = "0x19AEE28", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007C0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600351A")]
				[Address(RVA = "0x19AEE30", Offset = "0x19AEE30", VA = "0x19AEE30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6003518")]
			[Address(RVA = "0x19AEC14", Offset = "0x19AEC14", VA = "0x19AEC14")]
			public _003CSaveDelay_003Ec__Iterator7D()
			{
			}

			[Token(Token = "0x6003519")]
			[Address(RVA = "0x19AEE28", Offset = "0x19AEE28", VA = "0x19AEE28", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600351A")]
			[Address(RVA = "0x19AEE30", Offset = "0x19AEE30", VA = "0x19AEE30", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600351B")]
			[Address(RVA = "0x19AEE38", Offset = "0x19AEE38", VA = "0x19AEE38", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600351C")]
			[Address(RVA = "0x19AF038", Offset = "0x19AF038", VA = "0x19AF038", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600351D")]
			[Address(RVA = "0x19AF044", Offset = "0x19AF044", VA = "0x19AF044", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000631")]
		private sealed class _003CSaveStringDelay_003Ec__Iterator7E : IDisposable
		{
			[Token(Token = "0x4001DCC")]
			[FieldOffset(Offset = "0x8")]
			internal string key;

			[Token(Token = "0x4001DCD")]
			[FieldOffset(Offset = "0xC")]
			internal int _0024PC;

			[Token(Token = "0x4001DCE")]
			[FieldOffset(Offset = "0x10")]
			internal object _0024current;

			[Token(Token = "0x4001DCF")]
			[FieldOffset(Offset = "0x14")]
			internal string _003C_0024_003Ekey;

			[Token(Token = "0x4001DD0")]
			[FieldOffset(Offset = "0x18")]
			internal SaveManager _003C_003Ef__this;

			[Token(Token = "0x170007C1")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x600351F")]
				[Address(RVA = "0x19AF0D8", Offset = "0x19AF0D8", VA = "0x19AF0D8", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007C2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6003520")]
				[Address(RVA = "0x19AF0E0", Offset = "0x19AF0E0", VA = "0x19AF0E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600351E")]
			[Address(RVA = "0x19AEE20", Offset = "0x19AEE20", VA = "0x19AEE20")]
			public _003CSaveStringDelay_003Ec__Iterator7E()
			{
			}

			[Token(Token = "0x600351F")]
			[Address(RVA = "0x19AF0D8", Offset = "0x19AF0D8", VA = "0x19AF0D8", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6003520")]
			[Address(RVA = "0x19AF0E0", Offset = "0x19AF0E0", VA = "0x19AF0E0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6003521")]
			[Address(RVA = "0x19AF0E8", Offset = "0x19AF0E8", VA = "0x19AF0E8", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6003522")]
			[Address(RVA = "0x19AF2E8", Offset = "0x19AF2E8", VA = "0x19AF2E8", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6003523")]
			[Address(RVA = "0x19AF2F4", Offset = "0x19AF2F4", VA = "0x19AF2F4", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x8")]
		private HashSet<string> savingList;

		[Token(Token = "0x4001DC5")]
		[FieldOffset(Offset = "0xC")]
		private Dictionary<string, object> dic;

		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, string> dicStr;

		[Token(Token = "0x6003513")]
		[Address(RVA = "0x19AE8FC", Offset = "0x19AE8FC", VA = "0x19AE8FC")]
		public SaveManager()
		{
		}

		[Token(Token = "0x6003514")]
		[Address(RVA = "0x19AEA10", Offset = "0x19AEA10", VA = "0x19AEA10")]
		public void Save(object data, string key)
		{
		}

		[Token(Token = "0x6003515")]
		[Address(RVA = "0x19AEB64", Offset = "0x19AEB64", VA = "0x19AEB64")]
		[DebuggerHidden]
		private IEnumerator SaveDelay(string key)
		{
			return null;
		}

		[Token(Token = "0x6003516")]
		[Address(RVA = "0x19AEC1C", Offset = "0x19AEC1C", VA = "0x19AEC1C")]
		public void SaveString(string str, string key)
		{
		}

		[Token(Token = "0x6003517")]
		[Address(RVA = "0x19AED70", Offset = "0x19AED70", VA = "0x19AED70")]
		[DebuggerHidden]
		private IEnumerator SaveStringDelay(string key)
		{
			return null;
		}
	}

	[Token(Token = "0x6003510")]
	[Address(RVA = "0x19AE4DC", Offset = "0x19AE4DC", VA = "0x19AE4DC")]
	public static void SaveString(string str, string key)
	{
	}

	[Token(Token = "0x6003511")]
	[Address(RVA = "0x19AE5FC", Offset = "0x19AE5FC", VA = "0x19AE5FC")]
	public static void Save(object data, string key)
	{
	}

	[Token(Token = "0x6003512")]
	public static T Load<T>(string key) where T : new()
	{
		return (T)default;
	}
}
