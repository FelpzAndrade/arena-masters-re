using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Facebook.Unity.Example
{
	[Token(Token = "0x2000020")]
	internal class GraphRequest : MenuBase
	{
		[Token(Token = "0x2000021")]
		private sealed class _003CTakeScreenshot_003Ec__IteratorD : IDisposable
		{
			[Token(Token = "0x40000A7")]
			[FieldOffset(Offset = "0x8")]
			internal int _003Cwidth_003E__0;

			[Token(Token = "0x40000A8")]
			[FieldOffset(Offset = "0xC")]
			internal int _003Cheight_003E__1;

			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x10")]
			internal Texture2D _003Ctex_003E__2;

			[Token(Token = "0x40000AA")]
			[FieldOffset(Offset = "0x14")]
			internal byte[] _003Cscreenshot_003E__3;

			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0x18")]
			internal WWWForm _003CwwwForm_003E__4;

			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x1C")]
			internal int _0024PC;

			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x20")]
			internal object _0024current;

			[Token(Token = "0x40000AE")]
			[FieldOffset(Offset = "0x24")]
			internal GraphRequest _003C_003Ef__this;

			[Token(Token = "0x17000026")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
			{
				[Token(Token = "0x60000B9")]
				[Address(RVA = "0x1E88AB0", Offset = "0x1E88AB0", VA = "0x1E88AB0", Slot = "8")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000027")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60000BA")]
				[Address(RVA = "0x1E88AB8", Offset = "0x1E88AB8", VA = "0x1E88AB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x1E88AA8", Offset = "0x1E88AA8", VA = "0x1E88AA8")]
			public _003CTakeScreenshot_003Ec__IteratorD()
			{
			}

			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x1E88AB0", Offset = "0x1E88AB0", VA = "0x1E88AB0", Slot = "8")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1E88AB8", Offset = "0x1E88AB8", VA = "0x1E88AB8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1E88AC0", Offset = "0x1E88AC0", VA = "0x1E88AC0", Slot = "5")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1E88DFC", Offset = "0x1E88DFC", VA = "0x1E88DFC", Slot = "7")]
			[DebuggerHidden]
			public void Dispose()
			{
			}

			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1E88E08", Offset = "0x1E88E08", VA = "0x1E88E08", Slot = "6")]
			[DebuggerHidden]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x38")]
		private string apiQuery;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x3C")]
		private Texture2D profilePic;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1E88180", Offset = "0x1E88180", VA = "0x1E88180")]
		public GraphRequest()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E88240", Offset = "0x1E88240", VA = "0x1E88240", Slot = "5")]
		protected override void GetGui()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E887E0", Offset = "0x1E887E0", VA = "0x1E887E0")]
		private void ProfilePhotoCallback(IGraphResult result)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1E8873C", Offset = "0x1E8873C", VA = "0x1E8873C")]
		[DebuggerHidden]
		private IEnumerator TakeScreenshot()
		{
			return null;
		}
	}
}
