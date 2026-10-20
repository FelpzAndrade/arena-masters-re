using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x20005D4")]
public class XSpecialState_Finish : XPVEGameModeState_Finish
{
	[Token(Token = "0x20005D5")]
	private sealed class _003CProcessResult_003Ec__Iterator65 : IDisposable
	{
		[Token(Token = "0x4001C32")]
		[FieldOffset(Offset = "0x8")]
		internal float delay;

		[Token(Token = "0x4001C33")]
		[FieldOffset(Offset = "0xC")]
		internal XModuleEntity _003CmyPlayerME_003E__0;

		[Token(Token = "0x4001C34")]
		[FieldOffset(Offset = "0x10")]
		internal XModuleSkill _003CplayerModuleSkill_003E__1;

		[Token(Token = "0x4001C35")]
		[FieldOffset(Offset = "0x14")]
		internal Transform _003CplayerPos_003E__2;

		[Token(Token = "0x4001C36")]
		[FieldOffset(Offset = "0x18")]
		internal Netdata_CompleteSpecial response;

		[Token(Token = "0x4001C37")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x4001C38")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x4001C39")]
		[FieldOffset(Offset = "0x24")]
		internal float _003C_0024_003Edelay;

		[Token(Token = "0x4001C3A")]
		[FieldOffset(Offset = "0x28")]
		internal Netdata_CompleteSpecial _003C_0024_003Eresponse;

		[Token(Token = "0x4001C3B")]
		[FieldOffset(Offset = "0x2C")]
		internal XSpecialState_Finish _003C_003Ef__this;

		[Token(Token = "0x1700077D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60031BF")]
			[Address(RVA = "0x182C488", Offset = "0x182C488", VA = "0x182C488", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700077E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60031C0")]
			[Address(RVA = "0x182C490", Offset = "0x182C490", VA = "0x182C490", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60031BE")]
		[Address(RVA = "0x182C0B4", Offset = "0x182C0B4", VA = "0x182C0B4")]
		public _003CProcessResult_003Ec__Iterator65()
		{
		}

		[Token(Token = "0x60031BF")]
		[Address(RVA = "0x182C488", Offset = "0x182C488", VA = "0x182C488", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60031C0")]
		[Address(RVA = "0x182C490", Offset = "0x182C490", VA = "0x182C490", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60031C1")]
		[Address(RVA = "0x182C498", Offset = "0x182C498", VA = "0x182C498", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60031C2")]
		[Address(RVA = "0x182C94C", Offset = "0x182C94C", VA = "0x182C94C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60031C3")]
		[Address(RVA = "0x182C958", Offset = "0x182C958", VA = "0x182C958", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001C30")]
	[FieldOffset(Offset = "0x20")]
	private new XPlayerManager m_playerManager;

	[Token(Token = "0x4001C31")]
	[FieldOffset(Offset = "0x24")]
	private Netdata_CompleteSpecial m_response;

	[Token(Token = "0x60031B8")]
	[Address(RVA = "0x182B7A0", Offset = "0x182B7A0", VA = "0x182B7A0")]
	public XSpecialState_Finish()
	{
	}

	[Token(Token = "0x60031B9")]
	[Address(RVA = "0x182B7A8", Offset = "0x182B7A8", VA = "0x182B7A8", Slot = "5")]
	public override void Enter()
	{
	}

	[Token(Token = "0x60031BA")]
	[Address(RVA = "0x182B9E0", Offset = "0x182B9E0", VA = "0x182B9E0")]
	private void RequestCompleteSpecialGame(XPlayerManager playerManager)
	{
	}

	[Token(Token = "0x60031BB")]
	[Address(RVA = "0x182BF6C", Offset = "0x182BF6C", VA = "0x182BF6C")]
	private void StartSpecialResultProcess()
	{
	}

	[Token(Token = "0x60031BC")]
	[Address(RVA = "0x182BFF4", Offset = "0x182BFF4", VA = "0x182BFF4")]
	[DebuggerHidden]
	private IEnumerator ProcessResult(float delay, Netdata_CompleteSpecial response, XPlayerManager playerManager)
	{
		return null;
	}

	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x182C0BC", Offset = "0x182C0BC", VA = "0x182C0BC")]
	private void _003CRequestCompleteSpecialGame_003Em__142(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
