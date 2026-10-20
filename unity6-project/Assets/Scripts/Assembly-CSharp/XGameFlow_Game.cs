using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using XAssetBundle;

[Token(Token = "0x2000610")]
public class XGameFlow_Game : XGameFlow
{
	[Token(Token = "0x2000611")]
	private sealed class _003CCoroutineSendOutgoingCommands_003Ec__Iterator76 : IDisposable
	{
		[Token(Token = "0x4001D13")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001D14")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x170007AF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003446")]
			[Address(RVA = "0x13E1A6C", Offset = "0x13E1A6C", VA = "0x13E1A6C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003447")]
			[Address(RVA = "0x13E1A74", Offset = "0x13E1A74", VA = "0x13E1A74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003445")]
		[Address(RVA = "0x13DFE14", Offset = "0x13DFE14", VA = "0x13DFE14")]
		public _003CCoroutineSendOutgoingCommands_003Ec__Iterator76()
		{
		}

		[Token(Token = "0x6003446")]
		[Address(RVA = "0x13E1A6C", Offset = "0x13E1A6C", VA = "0x13E1A6C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003447")]
		[Address(RVA = "0x13E1A74", Offset = "0x13E1A74", VA = "0x13E1A74", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003448")]
		[Address(RVA = "0x13E1A7C", Offset = "0x13E1A7C", VA = "0x13E1A7C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003449")]
		[Address(RVA = "0x13E1C34", Offset = "0x13E1C34", VA = "0x13E1C34", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600344A")]
		[Address(RVA = "0x13E1C40", Offset = "0x13E1C40", VA = "0x13E1C40", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000612")]
	private sealed class _003COnEnd_003Ec__Iterator77 : IDisposable
	{
		[Token(Token = "0x4001D15")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001D16")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4001D17")]
		[FieldOffset(Offset = "0x10")]
		internal XGameFlow_Game _003C_003Ef__this;

		[Token(Token = "0x170007B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600344C")]
			[Address(RVA = "0x13E302C", Offset = "0x13E302C", VA = "0x13E302C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600344D")]
			[Address(RVA = "0x13E3034", Offset = "0x13E3034", VA = "0x13E3034", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600344B")]
		[Address(RVA = "0x13E0DC8", Offset = "0x13E0DC8", VA = "0x13E0DC8")]
		public _003COnEnd_003Ec__Iterator77()
		{
		}

		[Token(Token = "0x600344C")]
		[Address(RVA = "0x13E302C", Offset = "0x13E302C", VA = "0x13E302C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600344D")]
		[Address(RVA = "0x13E3034", Offset = "0x13E3034", VA = "0x13E3034", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600344E")]
		[Address(RVA = "0x13E303C", Offset = "0x13E303C", VA = "0x13E303C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600344F")]
		[Address(RVA = "0x13E3C4C", Offset = "0x13E3C4C", VA = "0x13E3C4C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003450")]
		[Address(RVA = "0x13E3C58", Offset = "0x13E3C58", VA = "0x13E3C58", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000613")]
	private sealed class _003CLoadAsync_003Ec__Iterator78 : IDisposable
	{
		[Token(Token = "0x4001D18")]
		[FieldOffset(Offset = "0x8")]
		internal CSSectorInfo _003CsectorInfo_003E__0;

		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0xC")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__1;

		[Token(Token = "0x4001D1A")]
		[FieldOffset(Offset = "0x10")]
		internal bool _003CcanIngameChat_003E__2;

		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x14")]
		internal XPanel_Chat _003CchatUI_003E__3;

		[Token(Token = "0x4001D1C")]
		[FieldOffset(Offset = "0x18")]
		internal List<ChatMessage> _003Cmessages_003E__4;

		[Token(Token = "0x4001D1D")]
		[FieldOffset(Offset = "0x1C")]
		internal string _003CchatUITitle_003E__5;

		[Token(Token = "0x4001D1E")]
		[FieldOffset(Offset = "0x20")]
		internal string _003CchatUIgameTabTitle_003E__6;

		[Token(Token = "0x4001D1F")]
		[FieldOffset(Offset = "0x24")]
		internal int _0024PC;

		[Token(Token = "0x4001D20")]
		[FieldOffset(Offset = "0x28")]
		internal object _0024current;

		[Token(Token = "0x4001D21")]
		[FieldOffset(Offset = "0x2C")]
		internal XGameFlow_Game _003C_003Ef__this;

		[Token(Token = "0x170007B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003452")]
			[Address(RVA = "0x13E1CD4", Offset = "0x13E1CD4", VA = "0x13E1CD4", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003453")]
			[Address(RVA = "0x13E1CDC", Offset = "0x13E1CDC", VA = "0x13E1CDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003451")]
		[Address(RVA = "0x13E1388", Offset = "0x13E1388", VA = "0x13E1388")]
		public _003CLoadAsync_003Ec__Iterator78()
		{
		}

		[Token(Token = "0x6003452")]
		[Address(RVA = "0x13E1CD4", Offset = "0x13E1CD4", VA = "0x13E1CD4", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003453")]
		[Address(RVA = "0x13E1CDC", Offset = "0x13E1CDC", VA = "0x13E1CDC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003454")]
		[Address(RVA = "0x13E1CE4", Offset = "0x13E1CE4", VA = "0x13E1CE4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003455")]
		[Address(RVA = "0x13E2F8C", Offset = "0x13E2F8C", VA = "0x13E2F8C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003456")]
		[Address(RVA = "0x13E2F98", Offset = "0x13E2F98", VA = "0x13E2F98", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001D10")]
	[FieldOffset(Offset = "0x8")]
	private IEnumerator coroutine;

	[Token(Token = "0x4001D11")]
	[FieldOffset(Offset = "0xC")]
	private bool m_clearComplete;

	[Token(Token = "0x4001D12")]
	[FieldOffset(Offset = "0xD")]
	private bool m_loadComplete;

	[Token(Token = "0x6003437")]
	[Address(RVA = "0x13DFC28", Offset = "0x13DFC28", VA = "0x13DFC28")]
	public XGameFlow_Game()
	{
	}

	[Token(Token = "0x6003438")]
	[Address(RVA = "0x13DFC30", Offset = "0x13DFC30", VA = "0x13DFC30", Slot = "4")]
	public override GameFlowTypes GetFlowType()
	{
		return default(GameFlowTypes);
	}

	[Token(Token = "0x6003439")]
	[Address(RVA = "0x13DFC38", Offset = "0x13DFC38", VA = "0x13DFC38", Slot = "10")]
	public override bool IsLoadedComplete()
	{
		return default(bool);
	}

	[Token(Token = "0x600343A")]
	[Address(RVA = "0x13DFD7C", Offset = "0x13DFD7C", VA = "0x13DFD7C", Slot = "11")]
	public override void blockUpdate()
	{
	}

	[Token(Token = "0x600343B")]
	[Address(RVA = "0x13DFD88", Offset = "0x13DFD88", VA = "0x13DFD88")]
	[DebuggerHidden]
	private IEnumerator CoroutineSendOutgoingCommands()
	{
		return null;
	}

	[Token(Token = "0x600343C")]
	[Address(RVA = "0x13DFE1C", Offset = "0x13DFE1C", VA = "0x13DFE1C")]
	private void StopCoroutineSendOutgoingCommands()
	{
	}

	[Token(Token = "0x600343D")]
	[Address(RVA = "0x13DFE6C", Offset = "0x13DFE6C", VA = "0x13DFE6C", Slot = "5")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x600343E")]
	[Address(RVA = "0x13E0D24", Offset = "0x13E0D24", VA = "0x13E0D24", Slot = "6")]
	[DebuggerHidden]
	public override IEnumerator OnEnd()
	{
		return null;
	}

	[Token(Token = "0x600343F")]
	[Address(RVA = "0x13E0680", Offset = "0x13E0680", VA = "0x13E0680")]
	private static void ReserveObjectRepository()
	{
	}

	[Token(Token = "0x6003440")]
	[Address(RVA = "0x13E0DD0", Offset = "0x13E0DD0", VA = "0x13E0DD0")]
	private static void ClearObjectRepository()
	{
	}

	[Token(Token = "0x6003441")]
	[Address(RVA = "0x13E05DC", Offset = "0x13E05DC", VA = "0x13E05DC")]
	[DebuggerHidden]
	private IEnumerator LoadAsync()
	{
		return null;
	}

	[Token(Token = "0x6003442")]
	[Address(RVA = "0x13E1390", Offset = "0x13E1390", VA = "0x13E1390", Slot = "7")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x6003443")]
	[Address(RVA = "0x13E16E4", Offset = "0x13E16E4", VA = "0x13E16E4", Slot = "8")]
	public override void OnFixedUpdate()
	{
	}

	[Token(Token = "0x6003444")]
	[Address(RVA = "0x13E18C0", Offset = "0x13E18C0", VA = "0x13E18C0", Slot = "9")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}
}
