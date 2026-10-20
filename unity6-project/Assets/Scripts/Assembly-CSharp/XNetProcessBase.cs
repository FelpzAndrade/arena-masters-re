using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x200076E")]
public abstract class XNetProcessBase : CSNetProcessBase
{
	[Token(Token = "0x200076F")]
	private sealed class _003CWWWDownload_003Ec__Iterator33 : IDisposable
	{
		[Token(Token = "0x40022EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string url;

		[Token(Token = "0x40022F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal WWW _003Cwww_003E__0;

		[Token(Token = "0x40022F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal long _003Ctick_003E__1;

		[Token(Token = "0x40022F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal string _003Ctext_003E__2;

		[Token(Token = "0x40022F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal string title;

		[Token(Token = "0x40022F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal Action<string, long> errorCallback;

		[Token(Token = "0x40022F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal Exception _003Ce_003E__3;

		[Token(Token = "0x40022F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal Action<string> callBack;

		[Token(Token = "0x40022F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x40022F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x40022F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal string _003C_0024_003Eurl;

		[Token(Token = "0x40022FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal string _003C_0024_003Etitle;

		[Token(Token = "0x40022FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal Action<string, long> _003C_0024_003EerrorCallback;

		[Token(Token = "0x40022FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Action<string> _003C_0024_003EcallBack;

		[Token(Token = "0x40022FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		internal XNetProcessBase _003C_003Ef__this;

		[Token(Token = "0x1700084B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003C8B")]
			[Address(RVA = "0x1ECC2F0", Offset = "0x1ECC2F0", VA = "0x1ECC2F0", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700084C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C8C")]
			[Address(RVA = "0x1ECC2F8", Offset = "0x1ECC2F8", VA = "0x1ECC2F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C8A")]
		[Address(RVA = "0x1ECBAC4", Offset = "0x1ECBAC4", VA = "0x1ECBAC4")]
		public _003CWWWDownload_003Ec__Iterator33()
		{
		}

		[Token(Token = "0x6003C8B")]
		[Address(RVA = "0x1ECC2F0", Offset = "0x1ECC2F0", VA = "0x1ECC2F0", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C8C")]
		[Address(RVA = "0x1ECC2F8", Offset = "0x1ECC2F8", VA = "0x1ECC2F8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C8D")]
		[Address(RVA = "0x1ECC300", Offset = "0x1ECC300", VA = "0x1ECC300", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003C8E")]
		[Address(RVA = "0x1ECCAAC", Offset = "0x1ECCAAC", VA = "0x1ECCAAC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003C8F")]
		[Address(RVA = "0x1ECCBBC", Offset = "0x1ECCBBC", VA = "0x1ECCBBC", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40022ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40022EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6003C81")]
	[Address(RVA = "0x1EBFBB0", Offset = "0x1EBFBB0", VA = "0x1EBFBB0")]
	protected XNetProcessBase()
	{
	}

	[Token(Token = "0x6003C82")]
	[Address(RVA = "0x1ECB9F4", Offset = "0x1ECB9F4", VA = "0x1ECB9F4")]
	[DebuggerHidden]
	protected IEnumerator WWWDownload(string title, string url, Action<string> callBack, [Optional] Action<string, long> errorCallback)
	{
		return null;
	}

	[Token(Token = "0x6003C83")]
	[Address(RVA = "0x1ECBACC", Offset = "0x1ECBACC", VA = "0x1ECBACC", Slot = "16")]
	protected override void RetryProcess()
	{
	}

	[Token(Token = "0x6003C84")]
	[Address(RVA = "0x1ECBC3C", Offset = "0x1ECBC3C", VA = "0x1ECBC3C")]
	protected void RetryProcessWithMessageBox(string msg, string title)
	{
	}

	[Token(Token = "0x6003C85")]
	[Address(RVA = "0x1ECBDDC", Offset = "0x1ECBDDC", VA = "0x1ECBDDC")]
	protected void NetProcessError()
	{
	}

	[Token(Token = "0x6003C86")]
	[Address(RVA = "0x1ECBF20", Offset = "0x1ECBF20", VA = "0x1ECBF20")]
	protected void NetProcessErrorReturnToTitleScene(string msg, string title)
	{
	}

	[Token(Token = "0x6003C87")]
	[Address(RVA = "0x1EBC880", Offset = "0x1EBC880", VA = "0x1EBC880")]
	protected void ErrorAccountBlock(JObject json)
	{
	}

	[Token(Token = "0x6003C88")]
	[Address(RVA = "0x1ECC14C", Offset = "0x1ECC14C", VA = "0x1ECC14C")]
	private static void _003CNetProcessErrorReturnToTitleScene_003Em__98()
	{
	}

	[Token(Token = "0x6003C89")]
	[Address(RVA = "0x1ECC218", Offset = "0x1ECC218", VA = "0x1ECC218")]
	private static void _003CErrorAccountBlock_003Em__99()
	{
	}
}
