using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using UnityEngine;
using XAssetBundle;

[Token(Token = "0x2000D54")]
public class XPanel_ClearTicketGameResult : XUIBaseWidget
{
	[Token(Token = "0x2000D55")]
	public delegate bool GetDelegate();

	[Token(Token = "0x2000D56")]
	private sealed class _003CLoadAsync_003Ec__Iterator9F : IDisposable
	{
		[Token(Token = "0x40044AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int ui;

		[Token(Token = "0x40044AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XAssetBundleLoadAssetOperation _003Creq_003E__0;

		[Token(Token = "0x40044AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal GameObject _003Cprefab_003E__1;

		[Token(Token = "0x40044AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal int _003Ci_003E__2;

		[Token(Token = "0x40044B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal GameObject _003Cobj_003E__3;

		[Token(Token = "0x40044B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal XUIRewardList _003Clist_003E__4;

		[Token(Token = "0x40044B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal GameObject _003Cobj_003E__5;

		[Token(Token = "0x40044B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		internal XUIRewardList _003Clist_003E__6;

		[Token(Token = "0x40044B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal List<Netdata_CompleteMission> gameRewardList;

		[Token(Token = "0x40044B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		internal int _0024PC;

		[Token(Token = "0x40044B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		internal object _0024current;

		[Token(Token = "0x40044B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		internal int _003C_0024_003Eui;

		[Token(Token = "0x40044B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal List<Netdata_CompleteMission> _003C_0024_003EgameRewardList;

		[Token(Token = "0x40044B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		internal XPanel_ClearTicketGameResult _003C_003Ef__this;

		[Token(Token = "0x17000D2D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60061EF")]
			[Address(RVA = "0x16B3114", Offset = "0x16B3114", VA = "0x16B3114", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D2E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60061F0")]
			[Address(RVA = "0x16B311C", Offset = "0x16B311C", VA = "0x16B311C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60061EE")]
		[Address(RVA = "0x16B20D4", Offset = "0x16B20D4", VA = "0x16B20D4")]
		public _003CLoadAsync_003Ec__Iterator9F()
		{
		}

		[Token(Token = "0x60061EF")]
		[Address(RVA = "0x16B3114", Offset = "0x16B3114", VA = "0x16B3114", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60061F0")]
		[Address(RVA = "0x16B311C", Offset = "0x16B311C", VA = "0x16B311C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60061F1")]
		[Address(RVA = "0x16B3124", Offset = "0x16B3124", VA = "0x16B3124", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60061F2")]
		[Address(RVA = "0x16B3484", Offset = "0x16B3484", VA = "0x16B3484", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60061F3")]
		[Address(RVA = "0x16B3490", Offset = "0x16B3490", VA = "0x16B3490", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000D57")]
	private sealed class _003CAddDirectionTeamLvUpSeq_003Ec__AnonStorey19C
	{
		[Token(Token = "0x40044BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int curLevel;

		[Token(Token = "0x40044BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int targetLevel;

		[Token(Token = "0x40044BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal int earnEnergy;

		[Token(Token = "0x40044BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XPanel_ClearTicketGameResult _003C_003Ef__this;

		[Token(Token = "0x60061F4")]
		[Address(RVA = "0x16B20C4", Offset = "0x16B20C4", VA = "0x16B20C4")]
		public _003CAddDirectionTeamLvUpSeq_003Ec__AnonStorey19C()
		{
		}

		[Token(Token = "0x60061F5")]
		[Address(RVA = "0x16B2CA4", Offset = "0x16B2CA4", VA = "0x16B2CA4")]
		internal void _003C_003Em__2C2()
		{
		}

		[Token(Token = "0x60061F6")]
		[Address(RVA = "0x16B2DB0", Offset = "0x16B2DB0", VA = "0x16B2DB0")]
		internal void _003C_003Em__2C3()
		{
		}
	}

	[Token(Token = "0x2000D58")]
	private sealed class _003CBuildRewardList_003Ec__AnonStorey19D
	{
		[Token(Token = "0x40044BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal Vector3 toPos;

		[Token(Token = "0x40044BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		internal XPanel_ClearTicketGameResult _003C_003Ef__this;

		[Token(Token = "0x60061F7")]
		[Address(RVA = "0x16B20CC", Offset = "0x16B20CC", VA = "0x16B20CC")]
		public _003CBuildRewardList_003Ec__AnonStorey19D()
		{
		}

		[Token(Token = "0x60061F8")]
		[Address(RVA = "0x16B2E10", Offset = "0x16B2E10", VA = "0x16B2E10")]
		internal void _003C_003Em__2C4()
		{
		}

		[Token(Token = "0x60061F9")]
		[Address(RVA = "0x16B2EE8", Offset = "0x16B2EE8", VA = "0x16B2EE8")]
		internal void _003C_003Em__2C5()
		{
		}
	}

	[Token(Token = "0x2000D59")]
	private sealed class _003CBuildTeamLevel_003Ec__AnonStorey19E
	{
		[Token(Token = "0x40044C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int beforeLv;

		[Token(Token = "0x40044C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal int nowLv;

		[Token(Token = "0x40044C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal CSProtoInfoManager_TeamLevel teamProto;

		[Token(Token = "0x60061FA")]
		[Address(RVA = "0x16B20DC", Offset = "0x16B20DC", VA = "0x16B20DC")]
		public _003CBuildTeamLevel_003Ec__AnonStorey19E()
		{
		}

		[Token(Token = "0x60061FB")]
		[Address(RVA = "0x16B2FC0", Offset = "0x16B2FC0", VA = "0x16B2FC0")]
		internal string _003C_003Em__2C7(int val)
		{
			return null;
		}

		[Token(Token = "0x60061FC")]
		[Address(RVA = "0x16B30D4", Offset = "0x16B30D4", VA = "0x16B30D4")]
		internal bool _003C_003Em__2C9(int val)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string Path_RewardList_1;

	[Token(Token = "0x400448A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static readonly string Path_RewardList_5;

	[Token(Token = "0x400448B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public GameObject panelRoot;

	[Token(Token = "0x400448C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UIButton btnSkip;

	[Token(Token = "0x400448D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public XWidget_ProgressBarWithTable prbTeamLv;

	[Token(Token = "0x400448E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UILabel lblTeamLevelIncreased;

	[Token(Token = "0x400448F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UI2DSprite sprCharIcon;

	[Token(Token = "0x4004490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UI2DSprite sprTitle;

	[Token(Token = "0x4004491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UILabel lblName;

	[Token(Token = "0x4004492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject btn;

	[Token(Token = "0x4004493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public XUIRewardList[] rewardList;

	[Token(Token = "0x4004494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform rewardListParent;

	[Token(Token = "0x4004495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UIGrid uiGrid;

	[Token(Token = "0x4004496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private XWidget_ItemDetailToolTip itemToolTip;

	[Token(Token = "0x4004497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int toolTipDepth;

	[Token(Token = "0x4004498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TweenPosition tweenPos;

	[Token(Token = "0x4004499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UIScrollView scrollView;

	[Token(Token = "0x400449A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 m_originalTweenPos;

	[Token(Token = "0x400449B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float tweenPosOffset_four;

	[Token(Token = "0x400449C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float tweenPosOffset_five;

	[Token(Token = "0x400449D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private UIDirector m_directions;

	[Token(Token = "0x400449E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float m_labelIncreaseSpeed;

	[Token(Token = "0x400449F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public UILabel lblRewarToMail;

	[Token(Token = "0x40044A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject preventClickCollider;

	[Token(Token = "0x40044A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Action action;

	[Token(Token = "0x40044A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GetDelegate m_getFunc;

	[Token(Token = "0x40044A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float upDuration;

	[Token(Token = "0x40044A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float itemBuildDelay;

	[Token(Token = "0x40044A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float listUpDelay;

	[Token(Token = "0x40044A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XWidget_TeamLevleUpPopup m_teamLvPopup;

	[Token(Token = "0x40044A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	protected string UITeamLevelUpSoundKey;

	[Token(Token = "0x40044A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action<int> _003C_003Ef__am_0024cache1F;

	[Token(Token = "0x40044A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static Action<UILabel, int> _003C_003Ef__am_0024cache20;

	[Token(Token = "0x40044AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Action<UIProgressBar, int> _003C_003Ef__am_0024cache21;

	[Token(Token = "0x40044AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Action _003C_003Ef__am_0024cache22;

	[Token(Token = "0x60061D6")]
	[Address(RVA = "0x16AFE54", Offset = "0x16AFE54", VA = "0x16AFE54")]
	public XPanel_ClearTicketGameResult()
	{
	}

	[Token(Token = "0x60061D8")]
	[Address(RVA = "0x16B0030", Offset = "0x16B0030", VA = "0x16B0030", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x60061D9")]
	[Address(RVA = "0x16B0188", Offset = "0x16B0188", VA = "0x16B0188")]
	public void SetAction(Action action, GetDelegate getFunc)
	{
	}

	[Token(Token = "0x60061DA")]
	[Address(RVA = "0x16B0194", Offset = "0x16B0194", VA = "0x16B0194")]
	private void ResultPanelShow()
	{
	}

	[Token(Token = "0x60061DB")]
	[Address(RVA = "0x16B01D4", Offset = "0x16B01D4", VA = "0x16B01D4")]
	public void Show([Optional] List<Netdata_CompleteMission> gameRewardList)
	{
	}

	[Token(Token = "0x60061DC")]
	[Address(RVA = "0x16B1374", Offset = "0x16B1374", VA = "0x16B1374")]
	protected void AddDirectionTeamLvUpSeq(int beforeXp, int earnXp, int earnEnergy)
	{
	}

	[Token(Token = "0x60061DD")]
	[Address(RVA = "0x16B1A30", Offset = "0x16B1A30", VA = "0x16B1A30")]
	private void BuildRewardList([Optional] List<Netdata_CompleteMission> gameRewardList)
	{
	}

	[Token(Token = "0x60061DE")]
	[Address(RVA = "0x16B1974", Offset = "0x16B1974", VA = "0x16B1974")]
	[DebuggerHidden]
	private IEnumerator LoadAsync(int ui, List<Netdata_CompleteMission> gameRewardList)
	{
		return null;
	}

	[Token(Token = "0x60061DF")]
	[Address(RVA = "0x16B0D04", Offset = "0x16B0D04", VA = "0x16B0D04")]
	private void BuildTeamLevel(int beforeXp, int earnXp, UIDirectionPararell pararell)
	{
	}

	[Token(Token = "0x60061E0")]
	[Address(RVA = "0x16B20E4", Offset = "0x16B20E4", VA = "0x16B20E4")]
	private UIDirectionSequence GetProgressBarDirectionSequenceSet(int initValue, int valueIncreased, bool isPercentText, bool useDecimalPoint, XWidget_ProgressBarWithTable prb, UILabel lblIncreased, List<int> table, Func<int, string> levCalc, Action<int> onChangeFloor, Func<int, bool> labelException, Action<UILabel, int> labelExceptionSetter, Action<UIProgressBar, int> prbExceptionSetter)
	{
		return null;
	}

	[Token(Token = "0x60061E1")]
	[Address(RVA = "0x16B257C", Offset = "0x16B257C", VA = "0x16B257C", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60061E2")]
	[Address(RVA = "0x16B013C", Offset = "0x16B013C", VA = "0x16B013C")]
	public void OnClickSkip()
	{
	}

	[Token(Token = "0x60061E3")]
	[Address(RVA = "0x16B273C", Offset = "0x16B273C", VA = "0x16B273C")]
	public void OnExitButtonClick()
	{
	}

	[Token(Token = "0x60061E4")]
	[Address(RVA = "0x16B2780", Offset = "0x16B2780", VA = "0x16B2780")]
	private void Update()
	{
	}

	[Token(Token = "0x60061E5")]
	[Address(RVA = "0x16B27AC", Offset = "0x16B27AC", VA = "0x16B27AC")]
	private void _003CBuildRewardList_003Em__2C6()
	{
	}

	[Token(Token = "0x60061E6")]
	[Address(RVA = "0x16B28B0", Offset = "0x16B28B0", VA = "0x16B28B0")]
	private static void _003CBuildTeamLevel_003Em__2C8(int val)
	{
	}

	[Token(Token = "0x60061E7")]
	[Address(RVA = "0x16B28B4", Offset = "0x16B28B4", VA = "0x16B28B4")]
	private static void _003CBuildTeamLevel_003Em__2CA(UILabel label, int val)
	{
	}

	[Token(Token = "0x60061E8")]
	[Address(RVA = "0x16B2A0C", Offset = "0x16B2A0C", VA = "0x16B2A0C")]
	private static void _003CBuildTeamLevel_003Em__2CB(UIProgressBar prb, int val)
	{
	}

	[Token(Token = "0x60061E9")]
	[Address(RVA = "0x16B2BBC", Offset = "0x16B2BBC", VA = "0x16B2BBC")]
	private static void _003CGetProgressBarDirectionSequenceSet_003Em__2CC()
	{
	}
}
