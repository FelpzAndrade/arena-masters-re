using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using BestHTTP;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000826")]
public class XHttpNetwork
{
	[Token(Token = "0x2000827")]
	private sealed class _003CWaitForPostRequest_003Ec__Iterator88 : IDisposable
	{
		[Token(Token = "0x400233D")]
		[FieldOffset(Offset = "0x8")]
		internal WWW www;

		[Token(Token = "0x400233E")]
		[FieldOffset(Offset = "0xC")]
		internal string _003Cerrmsg_003E__0;

		[Token(Token = "0x400233F")]
		[FieldOffset(Offset = "0x10")]
		internal int _0024PC;

		[Token(Token = "0x4002340")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x4002341")]
		[FieldOffset(Offset = "0x18")]
		internal WWW _003C_0024_003Ewww;

		[Token(Token = "0x1700091E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600412B")]
			[Address(RVA = "0x1D277FC", Offset = "0x1D277FC", VA = "0x1D277FC", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700091F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600412C")]
			[Address(RVA = "0x1D27804", Offset = "0x1D27804", VA = "0x1D27804", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600412A")]
		[Address(RVA = "0x1D2682C", Offset = "0x1D2682C", VA = "0x1D2682C")]
		public _003CWaitForPostRequest_003Ec__Iterator88()
		{
		}

		[Token(Token = "0x600412B")]
		[Address(RVA = "0x1D277FC", Offset = "0x1D277FC", VA = "0x1D277FC", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600412C")]
		[Address(RVA = "0x1D27804", Offset = "0x1D27804", VA = "0x1D27804", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600412D")]
		[Address(RVA = "0x1D2780C", Offset = "0x1D2780C", VA = "0x1D2780C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600412E")]
		[Address(RVA = "0x1D27A04", Offset = "0x1D27A04", VA = "0x1D27A04", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600412F")]
		[Address(RVA = "0x1D27A10", Offset = "0x1D27A10", VA = "0x1D27A10", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000828")]
	private sealed class _003CRunCommand_003Ec__AnonStorey141
	{
		[Token(Token = "0x4002342")]
		[FieldOffset(Offset = "0x8")]
		internal CSNetCommand cmd;

		[Token(Token = "0x4002343")]
		[FieldOffset(Offset = "0xC")]
		internal string url;

		[Token(Token = "0x4002344")]
		[FieldOffset(Offset = "0x10")]
		internal XHttpNetwork _003C_003Ef__this;

		[Token(Token = "0x6004130")]
		[Address(RVA = "0x1D24C10", Offset = "0x1D24C10", VA = "0x1D24C10")]
		public _003CRunCommand_003Ec__AnonStorey141()
		{
		}

		[Token(Token = "0x6004131")]
		[Address(RVA = "0x1D26B70", Offset = "0x1D26B70", VA = "0x1D26B70")]
		internal void _003C_003Em__1CD(HTTPRequest request, HTTPResponse response)
		{
		}
	}

	[Token(Token = "0x400233A")]
	[FieldOffset(Offset = "0x8")]
	public Queue<string> quDebugCommand;

	[Token(Token = "0x400233B")]
	[FieldOffset(Offset = "0xC")]
	public Queue<string> quRquestFailCommand;

	[Token(Token = "0x400233C")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024mapD;

	[Token(Token = "0x600411E")]
	[Address(RVA = "0x1D24608", Offset = "0x1D24608", VA = "0x1D24608")]
	public XHttpNetwork()
	{
	}

	[Token(Token = "0x600411F")]
	[Address(RVA = "0x1D24790", Offset = "0x1D24790", VA = "0x1D24790")]
	public void RunCommand(CSNetCommand cmd)
	{
	}

	[Token(Token = "0x6004120")]
	[Address(RVA = "0x1D25020", Offset = "0x1D25020", VA = "0x1D25020")]
	private void AddPostParam(HTTPRequest http, CSNetCommand cmd)
	{
	}

	[Token(Token = "0x6004121")]
	[Address(RVA = "0x1D24D88", Offset = "0x1D24D88", VA = "0x1D24D88")]
	private HTTPMethods ToHttpMethodType(string method)
	{
		return default(HTTPMethods);
	}

	[Token(Token = "0x6004122")]
	[Address(RVA = "0x1D2520C", Offset = "0x1D2520C", VA = "0x1D2520C")]
	private ApiReturnCode ToApiReturnCode(HTTPRequestStates state)
	{
		return default(ApiReturnCode);
	}

	[Token(Token = "0x6004123")]
	[Address(RVA = "0x1D2521C", Offset = "0x1D2521C", VA = "0x1D2521C")]
	public void HandleResponse(string text, CSNetCommand cmd)
	{
	}

	[Token(Token = "0x6004124")]
	[Address(RVA = "0x1D2654C", Offset = "0x1D2654C", VA = "0x1D2654C")]
	public WWW Post(string url, Dictionary<string, string> postData)
	{
		return null;
	}

	[Token(Token = "0x6004125")]
	[Address(RVA = "0x1D26784", Offset = "0x1D26784", VA = "0x1D26784")]
	[DebuggerHidden]
	private IEnumerator WaitForPostRequest(WWW www)
	{
		return null;
	}

	[Token(Token = "0x6004126")]
	[Address(RVA = "0x1D24C18", Offset = "0x1D24C18", VA = "0x1D24C18")]
	private void PushRequestCommandLog(CSNetCommand cmd)
	{
	}

	[Token(Token = "0x6004127")]
	[Address(RVA = "0x1D26900", Offset = "0x1D26900", VA = "0x1D26900")]
	private void PushResponseCommandLog(CSNetCommand cmd)
	{
	}

	[Token(Token = "0x6004128")]
	[Address(RVA = "0x1D26834", Offset = "0x1D26834", VA = "0x1D26834")]
	private void UpdateCommandLogCount()
	{
	}

	[Token(Token = "0x6004129")]
	[Address(RVA = "0x1D26A70", Offset = "0x1D26A70", VA = "0x1D26A70")]
	private void PushRquestFailCommandLog(string info)
	{
	}
}
