using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x20005CF")]
public class XSoloState_Finish : XGameModeState_Finish
{
	[Token(Token = "0x20005D0")]
	private sealed class _003CProcessResult_003Ec__Iterator64 : IDisposable
	{
		[Token(Token = "0x4001C25")]
		[FieldOffset(Offset = "0x8")]
		internal float delay;

		[Token(Token = "0x4001C26")]
		[FieldOffset(Offset = "0xC")]
		internal XModuleEntity _003CmyPlayerME_003E__0;

		[Token(Token = "0x4001C27")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleSkill _003CplayerModuleSkill_003E__1;

		[Token(Token = "0x4001C28")]
		[FieldOffset(Offset = "0x14")]
		internal Transform _003CplayerPos_003E__2;

		[Token(Token = "0x4001C29")]
		[FieldOffset(Offset = "0x18")]
		internal Netdata_CompleteSkyTower response;

		[Token(Token = "0x4001C2A")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x4001C2B")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4001C2C")]
		[FieldOffset(Offset = "0x24")]
		internal float _003C_0024_003Edelay;

		[Token(Token = "0x4001C2D")]
		[FieldOffset(Offset = "0x28")]
		internal Netdata_CompleteSkyTower _003C_0024_003Eresponse;

		[Token(Token = "0x4001C2E")]
		[FieldOffset(Offset = "0x2C")]
		internal XSoloState_Finish _003C_003Ef__this;

		[Token(Token = "0x1700077B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60031AB")]
			[Address(RVA = "0x1824700", Offset = "0x1824700", VA = "0x1824700", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700077C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60031AC")]
			[Address(RVA = "0x1824708", Offset = "0x1824708", VA = "0x1824708", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60031AA")]
		[Address(RVA = "0x18223FC", Offset = "0x18223FC", VA = "0x18223FC")]
		public _003CProcessResult_003Ec__Iterator64()
		{
		}

		[Token(Token = "0x60031AB")]
		[Address(RVA = "0x1824700", Offset = "0x1824700", VA = "0x1824700", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60031AC")]
		[Address(RVA = "0x1824708", Offset = "0x1824708", VA = "0x1824708", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60031AD")]
		[Address(RVA = "0x1824710", Offset = "0x1824710", VA = "0x1824710", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60031AE")]
		[Address(RVA = "0x1824B58", Offset = "0x1824B58", VA = "0x1824B58", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60031AF")]
		[Address(RVA = "0x1824B64", Offset = "0x1824B64", VA = "0x1824B64", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001C23")]
	[FieldOffset(Offset = "0x20")]
	private new XPlayerManager m_playerManager;

	[Token(Token = "0x4001C24")]
	[FieldOffset(Offset = "0x24")]
	private Netdata_CompleteSkyTower m_response;

	[Token(Token = "0x60031A4")]
	[Address(RVA = "0x1821BA8", Offset = "0x1821BA8", VA = "0x1821BA8")]
	public XSoloState_Finish()
	{
	}

	[Token(Token = "0x60031A5")]
	[Address(RVA = "0x1821BB0", Offset = "0x1821BB0", VA = "0x1821BB0", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60031A6")]
	[Address(RVA = "0x1821DE8", Offset = "0x1821DE8", VA = "0x1821DE8")]
	private void RequestComplete(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x60031A7")]
	[Address(RVA = "0x18222B4", Offset = "0x18222B4", VA = "0x18222B4")]
	private void StartSoloResultProcess()
	{
	}

	[Token(Token = "0x60031A8")]
	[Address(RVA = "0x182233C", Offset = "0x182233C", VA = "0x182233C")]
	[DebuggerHidden]
	private IEnumerator ProcessResult(float delay, Netdata_CompleteSkyTower response, XPlayerManager playerManager)
	{
		return null;
	}

	[Token(Token = "0x60031A9")]
	[Address(RVA = "0x1822404", Offset = "0x1822404", VA = "0x1822404")]
	private void _003CRequestComplete_003Em__141(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
