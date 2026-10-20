using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using XAssetBundle;

[Token(Token = "0x200060D")]
public class XGameFlow_Lobby : XGameFlow
{
	[Token(Token = "0x200060E")]
	private sealed class _003CLoadAsync_003Ec__Iterator74 : IDisposable
	{
		[Token(Token = "0x4001CF5")]
		[FieldOffset(Offset = "0x8")]
		internal XPanel_Chat _003CchatUI_003E__0;

		[Token(Token = "0x4001CF6")]
		[FieldOffset(Offset = "0xC")]
		internal List<ChatMessage> _003Cmessages_003E__1;

		[Token(Token = "0x4001CF7")]
		[FieldOffset(Offset = "0x10")]
		internal string _003CchatUITitle_003E__2;

		[Token(Token = "0x4001CF8")]
		[FieldOffset(Offset = "0x14")]
		internal string _003CchatUIgameTabTitle_003E__3;

		[Token(Token = "0x4001CF9")]
		[FieldOffset(Offset = "0x18")]
		internal XPanel_GroupInviteMessagePopup _003CinviteUI_003E__4;

		[Token(Token = "0x4001CFA")]
		[FieldOffset(Offset = "0x1C")]
		internal bool _003CisReserveForceRestartTutorial_003E__5;

		[Token(Token = "0x4001CFB")]
		[FieldOffset(Offset = "0x1D")]
		internal bool _003CisReserveLobbyMainStartTutorial_003E__6;

		[Token(Token = "0x4001CFC")]
		[FieldOffset(Offset = "0x20")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__7;

		[Token(Token = "0x4001CFD")]
		[FieldOffset(Offset = "0x24")]
		internal RandomOptionChangeWaitStorage _003CrandOpChangeStorage_003E__8;

		[Token(Token = "0x4001CFE")]
		[FieldOffset(Offset = "0x28")]
		internal string _003CitemIID_003E__9;

		[Token(Token = "0x4001CFF")]
		[FieldOffset(Offset = "0x2C")]
		internal XItem _003Citem_003E__10;

		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x30")]
		internal string _003CactorCID_003E__11;

		[Token(Token = "0x4001D01")]
		[FieldOffset(Offset = "0x34")]
		internal string _003Ctargetcid_003E__12;

		[Token(Token = "0x4001D02")]
		[FieldOffset(Offset = "0x38")]
		internal XModuleActor _003Cactor_003E__13;

		[Token(Token = "0x4001D03")]
		[FieldOffset(Offset = "0x3C")]
		internal int _003Cslot_003E__14;

		[Token(Token = "0x4001D04")]
		[FieldOffset(Offset = "0x40")]
		internal int _003Cslot_003E__15;

		[Token(Token = "0x4001D05")]
		[FieldOffset(Offset = "0x44")]
		internal int _0024PC;

		[Token(Token = "0x4001D06")]
		[FieldOffset(Offset = "0x48")]
		internal object _0024current;

		[Token(Token = "0x4001D07")]
		[FieldOffset(Offset = "0x4C")]
		internal XGameFlow_Lobby _003C_003Ef__this;

		[Token(Token = "0x4001D08")]
		[FieldOffset(Offset = "0x0")]
		private static NetCallback _003C_003Ef__am_0024cache13;

		[Token(Token = "0x4001D09")]
		[FieldOffset(Offset = "0x4")]
		private static NetCallback _003C_003Ef__am_0024cache14;

		[Token(Token = "0x4001D0A")]
		[FieldOffset(Offset = "0x8")]
		private static NetCallback _003C_003Ef__am_0024cache15;

		[Token(Token = "0x4001D0B")]
		[FieldOffset(Offset = "0xC")]
		private static Func<IUIBackbutton> _003C_003Ef__am_0024cache16;

		[Token(Token = "0x4001D0C")]
		[FieldOffset(Offset = "0x10")]
		private static Action _003C_003Ef__am_0024cache17;

		[Token(Token = "0x4001D0D")]
		[FieldOffset(Offset = "0x14")]
		private static Action _003C_003Ef__am_0024cache18;

		[Token(Token = "0x170007AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003420")]
			[Address(RVA = "0x13E5650", Offset = "0x13E5650", VA = "0x13E5650", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003421")]
			[Address(RVA = "0x13E5658", Offset = "0x13E5658", VA = "0x13E5658", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600341F")]
		[Address(RVA = "0x13E4ED8", Offset = "0x13E4ED8", VA = "0x13E4ED8")]
		public _003CLoadAsync_003Ec__Iterator74()
		{
		}

		[Token(Token = "0x6003420")]
		[Address(RVA = "0x13E5650", Offset = "0x13E5650", VA = "0x13E5650", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003421")]
		[Address(RVA = "0x13E5658", Offset = "0x13E5658", VA = "0x13E5658", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003422")]
		[Address(RVA = "0x13E5660", Offset = "0x13E5660", VA = "0x13E5660", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003423")]
		[Address(RVA = "0x13E7038", Offset = "0x13E7038", VA = "0x13E7038", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003424")]
		[Address(RVA = "0x13E7044", Offset = "0x13E7044", VA = "0x13E7044", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}

		[Token(Token = "0x6003425")]
		[Address(RVA = "0x13E70D8", Offset = "0x13E70D8", VA = "0x13E70D8")]
		internal IUIBackbutton _003C_003Em__166()
		{
			return null;
		}

		[Token(Token = "0x6003426")]
		[Address(RVA = "0x13E72EC", Offset = "0x13E72EC", VA = "0x13E72EC")]
		private static void _003C_003Em__167(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}

		[Token(Token = "0x6003427")]
		[Address(RVA = "0x13E72F0", Offset = "0x13E72F0", VA = "0x13E72F0")]
		internal IUIBackbutton _003C_003Em__168()
		{
			return null;
		}

		[Token(Token = "0x6003428")]
		[Address(RVA = "0x13E7504", Offset = "0x13E7504", VA = "0x13E7504")]
		private static void _003C_003Em__169(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}

		[Token(Token = "0x6003429")]
		[Address(RVA = "0x13E7508", Offset = "0x13E7508", VA = "0x13E7508")]
		internal IUIBackbutton _003C_003Em__16A()
		{
			return null;
		}

		[Token(Token = "0x600342A")]
		[Address(RVA = "0x13E771C", Offset = "0x13E771C", VA = "0x13E771C")]
		private static void _003C_003Em__16B(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}

		[Token(Token = "0x600342B")]
		[Address(RVA = "0x13E7720", Offset = "0x13E7720", VA = "0x13E7720")]
		private static IUIBackbutton _003C_003Em__16C()
		{
			return null;
		}

		[Token(Token = "0x600342C")]
		[Address(RVA = "0x13E79C8", Offset = "0x13E79C8", VA = "0x13E79C8")]
		internal void _003C_003Em__16D()
		{
		}

		[Token(Token = "0x600342D")]
		[Address(RVA = "0x13E7AB8", Offset = "0x13E7AB8", VA = "0x13E7AB8")]
		internal void _003C_003Em__16E()
		{
		}

		[Token(Token = "0x600342E")]
		[Address(RVA = "0x13E7BA8", Offset = "0x13E7BA8", VA = "0x13E7BA8")]
		internal void _003C_003Em__16F()
		{
		}

		[Token(Token = "0x600342F")]
		[Address(RVA = "0x13E7C98", Offset = "0x13E7C98", VA = "0x13E7C98")]
		private static void _003C_003Em__170()
		{
		}

		[Token(Token = "0x6003430")]
		[Address(RVA = "0x13E8160", Offset = "0x13E8160", VA = "0x13E8160")]
		private static void _003C_003Em__171()
		{
		}
	}

	[Token(Token = "0x200060F")]
	private sealed class _003COnEnd_003Ec__Iterator75 : IDisposable
	{
		[Token(Token = "0x4001D0E")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4001D0F")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x170007AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6003432")]
			[Address(RVA = "0x13E8228", Offset = "0x13E8228", VA = "0x13E8228", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170007AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003433")]
			[Address(RVA = "0x13E8230", Offset = "0x13E8230", VA = "0x13E8230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003431")]
		[Address(RVA = "0x13E5174", Offset = "0x13E5174", VA = "0x13E5174")]
		public _003COnEnd_003Ec__Iterator75()
		{
		}

		[Token(Token = "0x6003432")]
		[Address(RVA = "0x13E8228", Offset = "0x13E8228", VA = "0x13E8228", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003433")]
		[Address(RVA = "0x13E8230", Offset = "0x13E8230", VA = "0x13E8230", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003434")]
		[Address(RVA = "0x13E8238", Offset = "0x13E8238", VA = "0x13E8238", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003435")]
		[Address(RVA = "0x13E8724", Offset = "0x13E8724", VA = "0x13E8724", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6003436")]
		[Address(RVA = "0x13E8730", Offset = "0x13E8730", VA = "0x13E8730", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4001CF1")]
	[FieldOffset(Offset = "0x8")]
	private bool m_bPause;

	[Token(Token = "0x4001CF2")]
	[FieldOffset(Offset = "0x9")]
	private bool m_clearComplete;

	[Token(Token = "0x4001CF3")]
	[FieldOffset(Offset = "0xA")]
	private bool m_loadComplete;

	[Token(Token = "0x4001CF4")]
	[FieldOffset(Offset = "0x0")]
	private static bool IsInLobbyFirst;

	[Token(Token = "0x6003412")]
	[Address(RVA = "0x13E4970", Offset = "0x13E4970", VA = "0x13E4970")]
	public XGameFlow_Lobby()
	{
	}

	[Token(Token = "0x6003414")]
	[Address(RVA = "0x13E49FC", Offset = "0x13E49FC", VA = "0x13E49FC", Slot = "4")]
	public override GameFlowTypes GetFlowType()
	{
		return default(GameFlowTypes);
	}

	[Token(Token = "0x6003415")]
	[Address(RVA = "0x13E4A04", Offset = "0x13E4A04", VA = "0x13E4A04", Slot = "10")]
	public override bool IsLoadedComplete()
	{
		return default(bool);
	}

	[Token(Token = "0x6003416")]
	[Address(RVA = "0x13E4A0C", Offset = "0x13E4A0C", VA = "0x13E4A0C", Slot = "11")]
	public override void blockUpdate()
	{
	}

	[Token(Token = "0x6003417")]
	[Address(RVA = "0x13E4A18", Offset = "0x13E4A18", VA = "0x13E4A18", Slot = "5")]
	public override void OnStart()
	{
	}

	[Token(Token = "0x6003418")]
	[Address(RVA = "0x13E4E34", Offset = "0x13E4E34", VA = "0x13E4E34")]
	[DebuggerHidden]
	private IEnumerator LoadAsync()
	{
		return null;
	}

	[Token(Token = "0x6003419")]
	[Address(RVA = "0x13E4EE0", Offset = "0x13E4EE0", VA = "0x13E4EE0")]
	private void LoadCharacterModel()
	{
	}

	[Token(Token = "0x600341A")]
	[Address(RVA = "0x13E50E8", Offset = "0x13E50E8", VA = "0x13E50E8", Slot = "6")]
	[DebuggerHidden]
	public override IEnumerator OnEnd()
	{
		return null;
	}

	[Token(Token = "0x600341B")]
	[Address(RVA = "0x13E517C", Offset = "0x13E517C", VA = "0x13E517C", Slot = "7")]
	public override void OnUpdate()
	{
	}

	[Token(Token = "0x600341C")]
	[Address(RVA = "0x13E535C", Offset = "0x13E535C", VA = "0x13E535C", Slot = "9")]
	public override void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x600341D")]
	[Address(RVA = "0x13E4E30", Offset = "0x13E4E30", VA = "0x13E4E30")]
	private void SetCameraInput(bool bEnable)
	{
	}

	[Token(Token = "0x600341E")]
	[Address(RVA = "0x13E553C", Offset = "0x13E553C", VA = "0x13E553C")]
	private void SetCameraEventSource(bool bEnable)
	{
	}
}
