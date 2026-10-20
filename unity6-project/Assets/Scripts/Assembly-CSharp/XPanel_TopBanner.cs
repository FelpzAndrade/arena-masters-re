using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E34")]
public class XPanel_TopBanner : MonoBehaviour
{
	[Token(Token = "0x2000E35")]
	private sealed class _003CShow_003Ec__AnonStorey1F3
	{
		[Token(Token = "0x4004AD9")]
		[FieldOffset(Offset = "0x8")]
		internal CSProtoInfoManager_TeamLevel teamProto;

		[Token(Token = "0x60069C0")]
		[Address(RVA = "0xAD2064", Offset = "0xAD2064", VA = "0xAD2064")]
		public _003CShow_003Ec__AnonStorey1F3()
		{
		}

		[Token(Token = "0x60069C1")]
		[Address(RVA = "0xAD4A20", Offset = "0xAD4A20", VA = "0xAD4A20")]
		internal string _003C_003Em__3CE(int val)
		{
			return null;
		}

		[Token(Token = "0x60069C2")]
		[Address(RVA = "0xAD4A6C", Offset = "0xAD4A6C", VA = "0xAD4A6C")]
		internal bool _003C_003Em__3CF(int val)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000E36")]
	private sealed class _003CGetAction_ShowTeamLevelupPopup_003Ec__AnonStorey1F4
	{
		[Token(Token = "0x4004ADA")]
		[FieldOffset(Offset = "0x8")]
		internal int beforeLev;

		[Token(Token = "0x4004ADB")]
		[FieldOffset(Offset = "0xC")]
		internal int afterLev;

		[Token(Token = "0x4004ADC")]
		[FieldOffset(Offset = "0x10")]
		internal XMyInfo myInfo;

		[Token(Token = "0x4004ADD")]
		[FieldOffset(Offset = "0x14")]
		internal XPanel_TopBanner _003C_003Ef__this;

		[Token(Token = "0x60069C3")]
		[Address(RVA = "0xAD3B94", Offset = "0xAD3B94", VA = "0xAD3B94")]
		public _003CGetAction_ShowTeamLevelupPopup_003Ec__AnonStorey1F4()
		{
		}

		[Token(Token = "0x60069C4")]
		[Address(RVA = "0xAD48A8", Offset = "0xAD48A8", VA = "0xAD48A8")]
		internal void _003C_003Em__3D2()
		{
		}
	}

	[Token(Token = "0x4004ABA")]
	[FieldOffset(Offset = "0xC")]
	public UI2DSprite sprBg;

	[Token(Token = "0x4004ABB")]
	[FieldOffset(Offset = "0x10")]
	public Transform topBannerLeft;

	[Token(Token = "0x4004ABC")]
	[FieldOffset(Offset = "0x14")]
	public Transform topBannerRight;

	[Token(Token = "0x4004ABD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject stateInfo;

	[Token(Token = "0x4004ABE")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_ResizeAndMultiLineLabel resizeAndMultiLineStateInfo;

	[Token(Token = "0x4004ABF")]
	[FieldOffset(Offset = "0x20")]
	public TweenAlpha[] stateInfoTween;

	[Token(Token = "0x4004AC0")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goTeamInfo;

	[Token(Token = "0x4004AC1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblName;

	[Token(Token = "0x4004AC2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblTeamLevel;

	[Token(Token = "0x4004AC3")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_ProgressBarWithTable prbTeamLevelExp;

	[Token(Token = "0x4004AC4")]
	[FieldOffset(Offset = "0x34")]
	private XWidget_TeamLevleUpPopup m_teamLevUPPopup;

	[Token(Token = "0x4004AC5")]
	[FieldOffset(Offset = "0x38")]
	public string UITeamLevelUpSoundKey;

	[Token(Token = "0x4004AC6")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject btnSetting;

	[Token(Token = "0x4004AC7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject btnNotice;

	[Token(Token = "0x4004AC8")]
	[FieldOffset(Offset = "0x44")]
	public XWidget_Builder currencyBuilder;

	[Token(Token = "0x4004AC9")]
	[FieldOffset(Offset = "0x48")]
	private XWidget_CurrencyInfo[] currencyWidgets;

	[Token(Token = "0x4004ACA")]
	[FieldOffset(Offset = "0x4C")]
	public UITable currencySortTable;

	[Token(Token = "0x4004ACB")]
	[FieldOffset(Offset = "0x50")]
	public UI2DSprite sprMainChar;

	[Token(Token = "0x4004ACC")]
	[FieldOffset(Offset = "0x54")]
	public UI2DSprite sprCharFrame;

	[Token(Token = "0x4004ACD")]
	[FieldOffset(Offset = "0x58")]
	private XMyInfo m_myInfo;

	[Token(Token = "0x4004ACE")]
	[FieldOffset(Offset = "0x5C")]
	private List<Currency> m_curCurrencyList;

	[Token(Token = "0x4004ACF")]
	[FieldOffset(Offset = "0x60")]
	public XTutorialObjContainer tutoContainer;

	[Token(Token = "0x4004AD0")]
	[FieldOffset(Offset = "0x64")]
	public XWiget_GridBuilder premiumTicketGrid;

	[Token(Token = "0x4004AD1")]
	[FieldOffset(Offset = "0x68")]
	public XWidget_NewBadge mailNewBadge;

	[Token(Token = "0x4004AD2")]
	[FieldOffset(Offset = "0x6C")]
	public XWidget_NewBadge chatNewBadge;

	[Token(Token = "0x4004AD3")]
	[FieldOffset(Offset = "0x70")]
	public UIPanel chatIconPanel;

	[Token(Token = "0x4004AD4")]
	[FieldOffset(Offset = "0x74")]
	private int _rootDepth;

	[Token(Token = "0x4004AD5")]
	[FieldOffset(Offset = "0x78")]
	private int _ladderChatDepth;

	[Token(Token = "0x4004AD6")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel lblClanPartyCount;

	[Token(Token = "0x4004AD7")]
	[FieldOffset(Offset = "0x0")]
	private static Action<UILabel, int> _003C_003Ef__am_0024cache1D;

	[Token(Token = "0x4004AD8")]
	[FieldOffset(Offset = "0x4")]
	private static Action<UIProgressBar, int> _003C_003Ef__am_0024cache1E;

	[Token(Token = "0x600699A")]
	[Address(RVA = "0xAD14B4", Offset = "0xAD14B4", VA = "0xAD14B4")]
	public XPanel_TopBanner()
	{
	}

	[Token(Token = "0x600699B")]
	[Address(RVA = "0xAD1574", Offset = "0xAD1574", VA = "0xAD1574")]
	public void SetLadderDepthForChatIcon()
	{
	}

	[Token(Token = "0x600699C")]
	[Address(RVA = "0xAD15A8", Offset = "0xAD15A8", VA = "0xAD15A8")]
	public void SetDefaultDepthForChatIcon()
	{
	}

	[Token(Token = "0x600699D")]
	[Address(RVA = "0xAD15DC", Offset = "0xAD15DC", VA = "0xAD15DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600699E")]
	[Address(RVA = "0xAD1928", Offset = "0xAD1928", VA = "0xAD1928")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600699F")]
	[Address(RVA = "0xAD1770", Offset = "0xAD1770", VA = "0xAD1770")]
	private void SetTutorialObject()
	{
	}

	[Token(Token = "0x60069A0")]
	[Address(RVA = "0xAD19F4", Offset = "0xAD19F4", VA = "0xAD19F4")]
	private GameObject GetCurrencyWidget(Currency currency)
	{
		return null;
	}

	[Token(Token = "0x60069A1")]
	[Address(RVA = "0xAD1AAC", Offset = "0xAD1AAC", VA = "0xAD1AAC")]
	public void Pause(bool pause)
	{
	}

	[Token(Token = "0x60069A2")]
	[Address(RVA = "0xAD1BF8", Offset = "0xAD1BF8", VA = "0xAD1BF8")]
	public void Show(XMyInfo myInfo, CSProtoInfoManager_TeamLevel teamProto, bool bShow)
	{
	}

	[Token(Token = "0x60069A3")]
	[Address(RVA = "0xAD3074", Offset = "0xAD3074", VA = "0xAD3074")]
	public void ShowTopBannerInventory(XMyInfo user, CSProtoInfoManager_TeamLevel teamProto, bool show)
	{
	}

	[Token(Token = "0x60069A4")]
	[Address(RVA = "0xAD30FC", Offset = "0xAD30FC", VA = "0xAD30FC")]
	public void ShowTeamInfo(bool bShow)
	{
	}

	[Token(Token = "0x60069A5")]
	[Address(RVA = "0xAD2254", Offset = "0xAD2254", VA = "0xAD2254")]
	public void BuildCurrency(List<Currency> currencyList)
	{
	}

	[Token(Token = "0x60069A6")]
	[Address(RVA = "0xAD2448", Offset = "0xAD2448", VA = "0xAD2448")]
	private void ShowProfileIcon()
	{
	}

	[Token(Token = "0x60069A7")]
	[Address(RVA = "0xAD25C4", Offset = "0xAD25C4", VA = "0xAD25C4")]
	private void ShowCharTitle()
	{
	}

	[Token(Token = "0x60069A8")]
	[Address(RVA = "0xAD315C", Offset = "0xAD315C", VA = "0xAD315C")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x60069A9")]
	[Address(RVA = "0xAD32D4", Offset = "0xAD32D4", VA = "0xAD32D4")]
	private void OnNetdataUpdated_UserResource(object arg)
	{
	}

	[Token(Token = "0x60069AA")]
	[Address(RVA = "0xAD2FDC", Offset = "0xAD2FDC", VA = "0xAD2FDC")]
	private void OnClanWarPartyUpdated(int clanWarPartyCount)
	{
	}

	[Token(Token = "0x60069AB")]
	[Address(RVA = "0xAD339C", Offset = "0xAD339C", VA = "0xAD339C")]
	public void ShowStateInfo(string state)
	{
	}

	[Token(Token = "0x60069AC")]
	[Address(RVA = "0xAD3624", Offset = "0xAD3624", VA = "0xAD3624")]
	public Action GetAction_ShowTeamLevelupPopup(XMyInfo myInfo, int beforeXp, int curExp)
	{
		return null;
	}

	[Token(Token = "0x60069AD")]
	[Address(RVA = "0xAD2098", Offset = "0xAD2098", VA = "0xAD2098")]
	public void RefreshTeamLvInfo(XMyInfo myInfo, bool immediately = false, bool showLvupPopup = true)
	{
	}

	[Token(Token = "0x60069AE")]
	[Address(RVA = "0xAD206C", Offset = "0xAD206C", VA = "0xAD206C")]
	private void RefreshMailNewBadge()
	{
	}

	[Token(Token = "0x60069AF")]
	[Address(RVA = "0xAD3B9C", Offset = "0xAD3B9C", VA = "0xAD3B9C")]
	public void OnUpdateChatNew()
	{
	}

	[Token(Token = "0x60069B0")]
	[Address(RVA = "0xAD2740", Offset = "0xAD2740", VA = "0xAD2740")]
	private void RefreshChatNewBadge()
	{
	}

	[Token(Token = "0x60069B1")]
	[Address(RVA = "0xAD3BA0", Offset = "0xAD3BA0", VA = "0xAD3BA0")]
	public void BuildNotiIcons(bool b)
	{
	}

	[Token(Token = "0x60069B2")]
	[Address(RVA = "0xAD276C", Offset = "0xAD276C", VA = "0xAD276C")]
	private void RefreshLobbyNotiIcons()
	{
	}

	[Token(Token = "0x60069B3")]
	[Address(RVA = "0xAD3C08", Offset = "0xAD3C08", VA = "0xAD3C08")]
	private void OnNetDataUpdated_HottimeEventList(object arg)
	{
	}

	[Token(Token = "0x60069B4")]
	[Address(RVA = "0xAD3C0C", Offset = "0xAD3C0C", VA = "0xAD3C0C")]
	public void OnButtonClick_Setting()
	{
	}

	[Token(Token = "0x60069B5")]
	[Address(RVA = "0xAD3CE0", Offset = "0xAD3CE0", VA = "0xAD3CE0")]
	public void OnButtonClick_Mail()
	{
	}

	[Token(Token = "0x60069B6")]
	[Address(RVA = "0xAD3DB4", Offset = "0xAD3DB4", VA = "0xAD3DB4")]
	public void OnButtonClick_Character()
	{
	}

	[Token(Token = "0x60069B7")]
	[Address(RVA = "0xAD3E88", Offset = "0xAD3E88", VA = "0xAD3E88")]
	public void OnButtonClick_Chat()
	{
	}

	[Token(Token = "0x60069B8")]
	[Address(RVA = "0xAD3F88", Offset = "0xAD3F88", VA = "0xAD3F88")]
	public void OnButtonClick_GoBack()
	{
	}

	[Token(Token = "0x60069B9")]
	[Address(RVA = "0xAD405C", Offset = "0xAD405C", VA = "0xAD405C")]
	public void OnButtonClick_MyInfo()
	{
	}

	[Token(Token = "0x60069BA")]
	[Address(RVA = "0xAD4130", Offset = "0xAD4130", VA = "0xAD4130")]
	public void OnButtonClick_DownLoad()
	{
	}

	[Token(Token = "0x60069BB")]
	[Address(RVA = "0xAD4204", Offset = "0xAD4204", VA = "0xAD4204")]
	private void _003CSetTutorialObject_003Em__3CB()
	{
	}

	[Token(Token = "0x60069BC")]
	[Address(RVA = "0xAD4338", Offset = "0xAD4338", VA = "0xAD4338")]
	private void _003CSetTutorialObject_003Em__3CC()
	{
	}

	[Token(Token = "0x60069BD")]
	[Address(RVA = "0xAD446C", Offset = "0xAD446C", VA = "0xAD446C")]
	private void _003CSetTutorialObject_003Em__3CD()
	{
	}

	[Token(Token = "0x60069BE")]
	[Address(RVA = "0xAD45A0", Offset = "0xAD45A0", VA = "0xAD45A0")]
	private static void _003CShow_003Em__3D0(UILabel label, int val)
	{
	}

	[Token(Token = "0x60069BF")]
	[Address(RVA = "0xAD46F8", Offset = "0xAD46F8", VA = "0xAD46F8")]
	private static void _003CShow_003Em__3D1(UIProgressBar prb, int val)
	{
	}
}
