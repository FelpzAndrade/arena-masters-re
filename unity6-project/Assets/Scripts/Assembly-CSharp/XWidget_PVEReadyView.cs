using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000FBC")]
public class XWidget_PVEReadyView : XUIBaseWidget
{
	[Token(Token = "0x2000FBD")]
	public enum ClearTicketUseCheckReturn
	{
		[Token(Token = "0x400539F")]
		Success = 0,
		[Token(Token = "0x40053A0")]
		NotCleared_3Star = 1,
		[Token(Token = "0x40053A1")]
		LackEnergy = 2,
		[Token(Token = "0x40053A2")]
		UseDisableStage = 3,
		[Token(Token = "0x40053A3")]
		LackClearTicket = 4,
		[Token(Token = "0x40053A4")]
		LackBonusEnterableCnt = 5,
		[Token(Token = "0x40053A5")]
		AllUseEnterableCnt = 6
	}

	[Token(Token = "0x2000FBE")]
	private sealed class _003CLoadAsyncClearTicket_x1_003Ec__IteratorAF : IDisposable
	{
		[Token(Token = "0x40053A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__0;

		[Token(Token = "0x40053A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal GameObject _003Cprefab_003E__1;

		[Token(Token = "0x40053A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal List<Netdata_CompleteMission> gameRewardList;

		[Token(Token = "0x40053A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x40053AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40053AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal List<Netdata_CompleteMission> _003C_0024_003EgameRewardList;

		[Token(Token = "0x40053AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal XWidget_PVEReadyView _003C_003Ef__this;

		[Token(Token = "0x17000ED6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6007542")]
			[Address(RVA = "0x1327A90", Offset = "0x1327A90", VA = "0x1327A90", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000ED7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007543")]
			[Address(RVA = "0x1327A98", Offset = "0x1327A98", VA = "0x1327A98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6007541")]
		[Address(RVA = "0x1326E18", Offset = "0x1326E18", VA = "0x1326E18")]
		public _003CLoadAsyncClearTicket_x1_003Ec__IteratorAF()
		{
		}

		[Token(Token = "0x6007542")]
		[Address(RVA = "0x1327A90", Offset = "0x1327A90", VA = "0x1327A90", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007543")]
		[Address(RVA = "0x1327A98", Offset = "0x1327A98", VA = "0x1327A98", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007544")]
		[Address(RVA = "0x1327AA0", Offset = "0x1327AA0", VA = "0x1327AA0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007545")]
		[Address(RVA = "0x1327C84", Offset = "0x1327C84", VA = "0x1327C84", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x6007546")]
		[Address(RVA = "0x1327C90", Offset = "0x1327C90", VA = "0x1327C90", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000FBF")]
	private sealed class _003CLoadAsyncClearTicket_x5_003Ec__IteratorB0 : IDisposable
	{
		[Token(Token = "0x40053AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__0;

		[Token(Token = "0x40053AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal GameObject _003Cprefab_003E__1;

		[Token(Token = "0x40053AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal List<Netdata_CompleteMission> gameRewardList;

		[Token(Token = "0x40053B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x40053B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal object _0024current;

		[Token(Token = "0x40053B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal List<Netdata_CompleteMission> _003C_0024_003EgameRewardList;

		[Token(Token = "0x40053B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal XWidget_PVEReadyView _003C_003Ef__this;

		[Token(Token = "0x17000ED8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6007548")]
			[Address(RVA = "0x1327D24", Offset = "0x1327D24", VA = "0x1327D24", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000ED9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007549")]
			[Address(RVA = "0x1327D2C", Offset = "0x1327D2C", VA = "0x1327D2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6007547")]
		[Address(RVA = "0x1326ED0", Offset = "0x1326ED0", VA = "0x1326ED0")]
		public _003CLoadAsyncClearTicket_x5_003Ec__IteratorB0()
		{
		}

		[Token(Token = "0x6007548")]
		[Address(RVA = "0x1327D24", Offset = "0x1327D24", VA = "0x1327D24", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6007549")]
		[Address(RVA = "0x1327D2C", Offset = "0x1327D2C", VA = "0x1327D2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600754A")]
		[Address(RVA = "0x1327D34", Offset = "0x1327D34", VA = "0x1327D34", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600754B")]
		[Address(RVA = "0x1327F18", Offset = "0x1327F18", VA = "0x1327F18", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x600754C")]
		[Address(RVA = "0x1327F24", Offset = "0x1327F24", VA = "0x1327F24", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000FC0")]
	private sealed class _003CRequestCompleteClearTicket_003Ec__AnonStorey246
	{
		[Token(Token = "0x40053B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int ticketCount;

		[Token(Token = "0x40053B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_PVEReadyView _003C_003Ef__this;

		[Token(Token = "0x600754D")]
		[Address(RVA = "0x1326D60", Offset = "0x1326D60", VA = "0x1326D60")]
		public _003CRequestCompleteClearTicket_003Ec__AnonStorey246()
		{
		}

		[Token(Token = "0x600754E")]
		[Address(RVA = "0x1327FB8", Offset = "0x1327FB8", VA = "0x1327FB8")]
		internal void _003C_003Em__4D3(ApiReturnCode errno, string errmsg, JObject json)
		{
		}

		[Token(Token = "0x600754F")]
		[Address(RVA = "0x132881C", Offset = "0x132881C", VA = "0x132881C")]
		internal void _003C_003Em__4D4()
		{
		}
	}

	[Token(Token = "0x400537F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Transform centerPopupRoot;

	[Token(Token = "0x4005380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblTitle;

	[Token(Token = "0x4005381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UILabel lblMapDesc;

	[Token(Token = "0x4005382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XWiget_GridBuilder gridRewards;

	[Token(Token = "0x4005383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UIScrollView m_rewardScrollView;

	[Token(Token = "0x4005384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject goRewardMoreArrow;

	[Token(Token = "0x4005385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private XWidget_ItemDetailToolTip itemToolTip;

	[Token(Token = "0x4005386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform toolTipTransform;

	[Token(Token = "0x4005387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int itemToolTipDepth;

	[Token(Token = "0x4005388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private XGameModeType m_mode;

	[Token(Token = "0x4005389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private CSStageInfo m_stageInfo;

	[Token(Token = "0x400538A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UserDataBase m_userData;

	[Token(Token = "0x400538B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool m_isCleared;

	[Token(Token = "0x400538C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject goClearTicketDisable;

	[Token(Token = "0x400538D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public GameObject goClearTicket;

	[Token(Token = "0x400538E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int m_clearScore;

	[Token(Token = "0x400538F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public UILabel lblTicketCount;

	[Token(Token = "0x4005390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public XWidget_Button btnClear;

	[Token(Token = "0x4005391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public XWidget_Button btnClearMulti;

	[Token(Token = "0x4005392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private XPanel_ClearTicketGameResult m_pnlClearTicketResult_x1;

	[Token(Token = "0x4005393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private XPanel_ClearTicketGameResult m_pnlClearTicketResult_x5;

	[Token(Token = "0x4005394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public XWiget_GridBuilder gridBooster;

	[Token(Token = "0x4005395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private XWidget_BoosterButton ItemBooster;

	[Token(Token = "0x4005396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private XWidget_BoosterButton GoldBooster;

	[Token(Token = "0x4005397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private XWidget_BoosterButton PromstoneBooster;

	[Token(Token = "0x4005398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private int multiClearCnt;

	[Token(Token = "0x4005399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private int totalBoosterCount;

	[Token(Token = "0x400539A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool isClickClearButton;

	[Token(Token = "0x400539B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Action<bool> _003C_003Ef__am_0024cache1C;

	[Token(Token = "0x400539C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static Action<bool> _003C_003Ef__am_0024cache1D;

	[Token(Token = "0x400539D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action<bool> _003C_003Ef__am_0024cache1E;

	[Token(Token = "0x6007521")]
	[Address(RVA = "0x13241EC", Offset = "0x13241EC", VA = "0x13241EC")]
	public XWidget_PVEReadyView()
	{
	}

	[Token(Token = "0x6007522")]
	[Address(RVA = "0x13241FC", Offset = "0x13241FC", VA = "0x13241FC", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6007523")]
	[Address(RVA = "0x13242C4", Offset = "0x13242C4", VA = "0x13242C4")]
	private void OnNetdataUpdated_UserResource(object arg)
	{
	}

	[Token(Token = "0x6007524")]
	[Address(RVA = "0x1324890", Offset = "0x1324890", VA = "0x1324890")]
	private void BuildBoosterButton()
	{
	}

	[Token(Token = "0x6007525")]
	[Address(RVA = "0x1324D8C", Offset = "0x1324D8C", VA = "0x1324D8C")]
	private bool IsMission()
	{
		return default(bool);
	}

	[Token(Token = "0x6007526")]
	[Address(RVA = "0x1324DA0", Offset = "0x1324DA0", VA = "0x1324DA0")]
	private bool IsSkytowerORSpecialMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6007527")]
	[Address(RVA = "0x1324DC4", Offset = "0x1324DC4", VA = "0x1324DC4")]
	private bool IsBounusStage()
	{
		return default(bool);
	}

	[Token(Token = "0x6007528")]
	[Address(RVA = "0x1324DF8", Offset = "0x1324DF8", VA = "0x1324DF8")]
	private bool GetClearticketDisable(int cnt)
	{
		return default(bool);
	}

	[Token(Token = "0x6007529")]
	[Address(RVA = "0x1324EA0", Offset = "0x1324EA0", VA = "0x1324EA0")]
	public void Build(CSStageInfo stageInfo, UserDataBase userData, XGameModeType gameModeType)
	{
	}

	[Token(Token = "0x600752A")]
	[Address(RVA = "0x132433C", Offset = "0x132433C", VA = "0x132433C")]
	private void RefreshTicketCount()
	{
	}

	[Token(Token = "0x600752B")]
	[Address(RVA = "0x1325398", Offset = "0x1325398", VA = "0x1325398")]
	private void LoadClearTicketResultPrefab(Transform parent)
	{
	}

	[Token(Token = "0x600752C")]
	[Address(RVA = "0x13244AC", Offset = "0x13244AC", VA = "0x13244AC")]
	private void BuildClearButton()
	{
	}

	[Token(Token = "0x600752D")]
	[Address(RVA = "0x1324E78", Offset = "0x1324E78", VA = "0x1324E78")]
	private bool IsPerfectClear()
	{
		return default(bool);
	}

	[Token(Token = "0x600752E")]
	[Address(RVA = "0x1325D88", Offset = "0x1325D88", VA = "0x1325D88")]
	public ClearTicketUseCheckReturn CheckClearTicketUseEnable(int clearCnt)
	{
		return default(ClearTicketUseCheckReturn);
	}

	[Token(Token = "0x600752F")]
	[Address(RVA = "0x1325648", Offset = "0x1325648", VA = "0x1325648")]
	private void BuildReward()
	{
	}

	[Token(Token = "0x6007530")]
	[Address(RVA = "0x1326100", Offset = "0x1326100", VA = "0x1326100")]
	private XWidget_ContentIcon.Option GetContentOption()
	{
		return default(XWidget_ContentIcon.Option);
	}

	[Token(Token = "0x6007531")]
	[Address(RVA = "0x1326484", Offset = "0x1326484", VA = "0x1326484")]
	public void Show()
	{
	}

	[Token(Token = "0x6007532")]
	[Address(RVA = "0x1325D7C", Offset = "0x1325D7C", VA = "0x1325D7C")]
	private void MakeFalseIsClickClearButton()
	{
	}

	[Token(Token = "0x6007533")]
	[Address(RVA = "0x13264D0", Offset = "0x13264D0", VA = "0x13264D0")]
	private bool GetIsClickClearButton()
	{
		return default(bool);
	}

	[Token(Token = "0x6007534")]
	[Address(RVA = "0x13264D8", Offset = "0x13264D8", VA = "0x13264D8")]
	private void ShowClearTicketDisable_Noti(ClearTicketUseCheckReturn retType)
	{
	}

	[Token(Token = "0x6007535")]
	[Address(RVA = "0x132673C", Offset = "0x132673C", VA = "0x132673C")]
	public void OnClickClearTicket()
	{
	}

	[Token(Token = "0x6007536")]
	[Address(RVA = "0x1326D10", Offset = "0x1326D10", VA = "0x1326D10")]
	public void OnClickClearTicket_Multi()
	{
	}

	[Token(Token = "0x6007537")]
	[Address(RVA = "0x132678C", Offset = "0x132678C", VA = "0x132678C")]
	private void RequestCompleteClearTicket(int ticketCount)
	{
	}

	[Token(Token = "0x6007538")]
	[Address(RVA = "0x1326D68", Offset = "0x1326D68", VA = "0x1326D68")]
	[DebuggerHidden]
	private IEnumerator LoadAsyncClearTicket_x1([Optional] List<Netdata_CompleteMission> gameRewardList)
	{
		return null;
	}

	[Token(Token = "0x6007539")]
	[Address(RVA = "0x1326E20", Offset = "0x1326E20", VA = "0x1326E20")]
	[DebuggerHidden]
	private IEnumerator LoadAsyncClearTicket_x5([Optional] List<Netdata_CompleteMission> gameRewardList)
	{
		return null;
	}

	[Token(Token = "0x600753A")]
	[Address(RVA = "0x1326ED8", Offset = "0x1326ED8", VA = "0x1326ED8")]
	private void ClearTicketInit_x1([Optional] List<Netdata_CompleteMission> gameRewardList)
	{
	}

	[Token(Token = "0x600753B")]
	[Address(RVA = "0x1327070", Offset = "0x1327070", VA = "0x1327070")]
	private void ClearTicketInit_x5([Optional] List<Netdata_CompleteMission> gameRewardList)
	{
	}

	[Token(Token = "0x600753C")]
	[Address(RVA = "0x1327208", Offset = "0x1327208", VA = "0x1327208")]
	public bool StartPVEGame(Action onStartFail)
	{
		return default(bool);
	}

	[Token(Token = "0x600753D")]
	[Address(RVA = "0x1327628", Offset = "0x1327628", VA = "0x1327628")]
	public void OnClick_Help()
	{
	}

	[Token(Token = "0x600753E")]
	[Address(RVA = "0x1327730", Offset = "0x1327730", VA = "0x1327730")]
	private static void _003CBuildBoosterButton_003Em__4D0(bool check)
	{
	}

	[Token(Token = "0x600753F")]
	[Address(RVA = "0x1327850", Offset = "0x1327850", VA = "0x1327850")]
	private static void _003CBuildBoosterButton_003Em__4D1(bool check)
	{
	}

	[Token(Token = "0x6007540")]
	[Address(RVA = "0x1327970", Offset = "0x1327970", VA = "0x1327970")]
	private static void _003CBuildBoosterButton_003Em__4D2(bool check)
	{
	}
}
