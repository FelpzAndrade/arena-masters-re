using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using SimpleJSON;
using UnityEngine;

[Token(Token = "0x20010D0")]
public class WWWHelper : MonoBehaviour
{
	[Token(Token = "0x20010D1")]
	public delegate void HttpRequestDelegate(int id, WWW www);

	[Token(Token = "0x20010D2")]
	private sealed class _003CWaitForRequest_003Ec__IteratorBB : IDisposable
	{
		[Token(Token = "0x4005CAB")]
		[FieldOffset(Offset = "0x8")]
		internal WWW www;

		[Token(Token = "0x4005CAC")]
		[FieldOffset(Offset = "0xC")]
		internal bool _003ChasCompleteListener_003E__0;

		[Token(Token = "0x4005CAD")]
		[FieldOffset(Offset = "0x10")]
		internal int id;

		[Token(Token = "0x4005CAE")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x4005CAF")]
		[FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x4005CB0")]
		[FieldOffset(Offset = "0x1C")]
		internal WWW _003C_0024_003Ewww;

		[Token(Token = "0x4005CB1")]
		[FieldOffset(Offset = "0x20")]
		internal int _003C_0024_003Eid;

		[Token(Token = "0x4005CB2")]
		[FieldOffset(Offset = "0x24")]
		internal WWWHelper _003C_003Ef__this;

		[Token(Token = "0x17000F9E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6007F0D")]
			[Address(RVA = "0x17B516C", Offset = "0x17B516C", VA = "0x17B516C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000F9F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007F0E")]
			[Address(RVA = "0x17B5174", Offset = "0x17B5174", VA = "0x17B5174", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6007F0C")]
		[Address(RVA = "0x17B4D20", Offset = "0x17B4D20", VA = "0x17B4D20")]
		public _003CWaitForRequest_003Ec__IteratorBB()
		{
		}

		[Token(Token = "0x6007F0D")]
		[Address(RVA = "0x17B516C", Offset = "0x17B516C", VA = "0x17B516C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007F0E")]
		[Address(RVA = "0x17B5174", Offset = "0x17B5174", VA = "0x17B5174", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007F0F")]
		[Address(RVA = "0x17B517C", Offset = "0x17B517C", VA = "0x17B517C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007F10")]
		[Address(RVA = "0x17B52CC", Offset = "0x17B52CC", VA = "0x17B52CC", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6007F11")]
		[Address(RVA = "0x17B52D8", Offset = "0x17B52D8", VA = "0x17B52D8", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005CA7")]
	[FieldOffset(Offset = "0xC")]
	private int requestId;

	[Token(Token = "0x4005CA8")]
	[FieldOffset(Offset = "0x0")]
	private static WWWHelper instace;

	[Token(Token = "0x4005CA9")]
	[FieldOffset(Offset = "0x4")]
	private static GameObject container;

	[Token(Token = "0x4005CAA")]
	[FieldOffset(Offset = "0x10")]
	private HttpRequestDelegate m_OnHttpRequest;

	[Token(Token = "0x17000F9D")]
	public static WWWHelper Instance
	{
		[Token(Token = "0x6007F03")]
		[Address(RVA = "0x17B458C", Offset = "0x17B458C", VA = "0x17B458C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000063")]
	public event HttpRequestDelegate OnHttpRequest
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6007F01")]
		[Address(RVA = "0x17B4274", Offset = "0x17B4274", VA = "0x17B4274")]
		add
		{
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[Token(Token = "0x6007F02")]
		[Address(RVA = "0x17B4400", Offset = "0x17B4400", VA = "0x17B4400")]
		remove
		{
		}
	}

	[Token(Token = "0x6007EFF")]
	[Address(RVA = "0x17B4268", Offset = "0x17B4268", VA = "0x17B4268")]
	public WWWHelper()
	{
	}

	[Token(Token = "0x6007F04")]
	[Address(RVA = "0x17B486C", Offset = "0x17B486C", VA = "0x17B486C")]
	public void get(int id, string url)
	{
	}

	[Token(Token = "0x6007F05")]
	[Address(RVA = "0x17B49E0", Offset = "0x17B49E0", VA = "0x17B49E0")]
	public void post(int id, string url, Dictionary<string, string> data)
	{
	}

	[Token(Token = "0x6007F06")]
	[Address(RVA = "0x17B4924", Offset = "0x17B4924", VA = "0x17B4924")]
	[DebuggerHidden]
	private IEnumerator WaitForRequest(int id, WWW www)
	{
		return null;
	}

	[Token(Token = "0x6007F07")]
	[Address(RVA = "0x17B4D28", Offset = "0x17B4D28", VA = "0x17B4D28")]
	private JSONClass dicToJSON(Dictionary<string, string> dic)
	{
		return null;
	}
}
