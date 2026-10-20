using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2000067")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x2000068")]
		private sealed class _003CWaitForTranslation_003Ec__Iterator11 : IDisposable
		{
			[Token(Token = "0x40001B4")]
			[FieldOffset(Offset = "0x8")]
			internal WWW www;

			[Token(Token = "0x40001B5")]
			[FieldOffset(Offset = "0xC")]
			internal Action<string> OnTranslationReady;

			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x10")]
			internal string OriginalText;

			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x14")]
			internal string _003CTranslation_003E__0;

			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x18")]
			internal int _0024PC;

			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x1C")]
			internal object _0024current;

			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x20")]
			internal WWW _003C_0024_003Ewww;

			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x24")]
			internal Action<string> _003C_0024_003EOnTranslationReady;

			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x28")]
			internal string _003C_0024_003EOriginalText;

			[Token(Token = "0x17000058")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0xD65B78", Offset = "0xD65B78", VA = "0xD65B78", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000059")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000316")]
				[Address(RVA = "0xD65B80", Offset = "0xD65B80", VA = "0xD65B80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0xD642B8", Offset = "0xD642B8", VA = "0xD642B8")]
			public _003CWaitForTranslation_003Ec__Iterator11()
			{
			}

			[Token(Token = "0x6000315")]
			[Address(RVA = "0xD65B78", Offset = "0xD65B78", VA = "0xD65B78", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0xD65B80", Offset = "0xD65B80", VA = "0xD65B80", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0xD65B88", Offset = "0xD65B88", VA = "0xD65B88", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0xD65DB4", Offset = "0xD65DB4", VA = "0xD65DB4", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0xD65DC0", Offset = "0xD65DC0", VA = "0xD65DC0", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000069")]
		private sealed class _003CWaitForTranslation_003Ec__Iterator12 : IDisposable
		{
			[Token(Token = "0x40001BD")]
			[FieldOffset(Offset = "0x8")]
			internal WWW www;

			[Token(Token = "0x40001BE")]
			[FieldOffset(Offset = "0xC")]
			internal Action<List<TranslationRequest>> OnTranslationReady;

			[Token(Token = "0x40001BF")]
			[FieldOffset(Offset = "0x10")]
			internal List<TranslationRequest> requests;

			[Token(Token = "0x40001C0")]
			[FieldOffset(Offset = "0x14")]
			internal int _0024PC;

			[Token(Token = "0x40001C1")]
			[FieldOffset(Offset = "0x18")]
			internal object _0024current;

			[Token(Token = "0x40001C2")]
			[FieldOffset(Offset = "0x1C")]
			internal WWW _003C_0024_003Ewww;

			[Token(Token = "0x40001C3")]
			[FieldOffset(Offset = "0x20")]
			internal Action<List<TranslationRequest>> _003C_0024_003EOnTranslationReady;

			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0x24")]
			internal List<TranslationRequest> _003C_0024_003Erequests;

			[Token(Token = "0x1700005A")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0xD65E54", Offset = "0xD65E54", VA = "0xD65E54", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700005B")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600031C")]
				[Address(RVA = "0xD65E5C", Offset = "0xD65E5C", VA = "0xD65E5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0xD65450", Offset = "0xD65450", VA = "0xD65450")]
			public _003CWaitForTranslation_003Ec__Iterator12()
			{
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0xD65E54", Offset = "0xD65E54", VA = "0xD65E54", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0xD65E5C", Offset = "0xD65E5C", VA = "0xD65E5C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0xD65E64", Offset = "0xD65E64", VA = "0xD65E64", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0xD66040", Offset = "0xD66040", VA = "0xD66040", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0xD6604C", Offset = "0xD6604C", VA = "0xD6604C", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xD63BFC", Offset = "0xD63BFC", VA = "0xD63BFC")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xD63DC4", Offset = "0xD63DC4", VA = "0xD63DC4")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, Action<string> OnTranslationReady)
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xD641F8", Offset = "0xD641F8", VA = "0xD641F8")]
		[DebuggerHidden]
		private static IEnumerator WaitForTranslation(WWW www, Action<string> OnTranslationReady, string OriginalText)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xD642C0", Offset = "0xD642C0", VA = "0xD642C0")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xD63E28", Offset = "0xD63E28", VA = "0xD63E28")]
		public static WWW GetTranslationWWW(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xD647DC", Offset = "0xD647DC", VA = "0xD647DC")]
		public static string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xD64D20", Offset = "0xD64D20", VA = "0xD64D20")]
		public static void Translate(List<TranslationRequest> requests, Action<List<TranslationRequest>> OnTranslationReady)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xD64D88", Offset = "0xD64D88", VA = "0xD64D88")]
		public static WWW GetTranslationWWW(List<TranslationRequest> requests)
		{
			return null;
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xD65390", Offset = "0xD65390", VA = "0xD65390")]
		[DebuggerHidden]
		private static IEnumerator WaitForTranslation(WWW www, Action<List<TranslationRequest>> OnTranslationReady, List<TranslationRequest> requests)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xD65458", Offset = "0xD65458", VA = "0xD65458")]
		public static string ParseTranslationResult(string html, List<TranslationRequest> requests)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xD659B0", Offset = "0xD659B0", VA = "0xD659B0")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xD64A28", Offset = "0xD64A28", VA = "0xD64A28")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
}
