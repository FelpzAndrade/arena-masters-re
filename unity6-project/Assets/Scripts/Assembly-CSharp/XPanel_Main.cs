using System.Collections.Generic;
using CS;
using CS.Constant;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DF6")]
public class XPanel_Main : XUIBasePanel
{
	[Token(Token = "0x2000DF7")]
	private sealed class _003CBuildRightButtons_003Ec__AnonStorey1D4
	{
		[Token(Token = "0x400493C")]
		[FieldOffset(Offset = "0x8")]
		internal XLobbyButtonInfo info;

		[Token(Token = "0x60067BD")]
		[Address(RVA = "0x1003388", Offset = "0x1003388", VA = "0x1003388")]
		public _003CBuildRightButtons_003Ec__AnonStorey1D4()
		{
		}

		[Token(Token = "0x60067BE")]
		[Address(RVA = "0x100640C", Offset = "0x100640C", VA = "0x100640C")]
		internal void _003C_003Em__38C()
		{
		}
	}

	[Token(Token = "0x400490C")]
	private const int m_offsetWidth = 122;

	[Token(Token = "0x400490D")]
	private const int m_offsetHeight = 110;

	[Token(Token = "0x400490E")]
	private const string attendanceIconPath = "UI_new/icon_attendance";

	[Token(Token = "0x400490F")]
	private const string loginEventIconPath = "UI_new/icon_loginevent";

	[Token(Token = "0x4004910")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ActionOnShowKey;

	[Token(Token = "0x4004911")]
	[FieldOffset(Offset = "0x10")]
	private readonly string PATH_PANDORA_DETAILPOPUP;

	[Token(Token = "0x4004912")]
	[FieldOffset(Offset = "0x14")]
	private XWidget_PandoraboxDetailPopup m_widgetPandoraDetailPopup;

	[Token(Token = "0x4004913")]
	[FieldOffset(Offset = "0x18")]
	private readonly string PATH_PANDORA_POPUP;

	[Token(Token = "0x4004914")]
	[FieldOffset(Offset = "0x1C")]
	private XWidget_PandoraboxPopup m_widgetPandoraPopup;

	[Token(Token = "0x4004915")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_LobbyCharIllust lobbyChar;

	[Token(Token = "0x4004916")]
	[FieldOffset(Offset = "0x24")]
	public XWidget_LobbyBannerView lobbyRankView;

	[Token(Token = "0x4004917")]
	[FieldOffset(Offset = "0x28")]
	public XWidget_NewBadge teamNewBadge;

	[Token(Token = "0x4004918")]
	[FieldOffset(Offset = "0x2C")]
	public XWidget_NewBadge questNewBadge;

	[Token(Token = "0x4004919")]
	[FieldOffset(Offset = "0x30")]
	public XWidget_NewBadge shopNewBadge;

	[Token(Token = "0x400491A")]
	[FieldOffset(Offset = "0x34")]
	public XWidget_NewBadge charInventoryNewBadge;

	[Token(Token = "0x400491B")]
	[FieldOffset(Offset = "0x38")]
	public XWidget_NewBadge petInventoryNewBadge;

	[Token(Token = "0x400491C")]
	[FieldOffset(Offset = "0x3C")]
	public XWidget_NewBadge eventAttendanceNewBadge;

	[Token(Token = "0x400491D")]
	[FieldOffset(Offset = "0x40")]
	public XWidget_NewBadge rightSlideNewBadge;

	[Token(Token = "0x400491E")]
	[FieldOffset(Offset = "0x44")]
	public XWidget_NewBadge ironsMissionNewBadge;

	[Token(Token = "0x400491F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject goClanLock;

	[Token(Token = "0x4004920")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel lblPlayerCount;

	[Token(Token = "0x4004921")]
	[FieldOffset(Offset = "0x50")]
	public UILabel lblBtnTransfer;

	[Token(Token = "0x4004922")]
	[FieldOffset(Offset = "0x54")]
	private key NotiKey;

	[Token(Token = "0x4004923")]
	[FieldOffset(Offset = "0x58")]
	public XWiget_GridBuilder gridRightButtons;

	[Token(Token = "0x4004924")]
	[FieldOffset(Offset = "0x5C")]
	public UIGrid leftBottomBtnGrid;

	[Token(Token = "0x4004925")]
	[FieldOffset(Offset = "0x60")]
	public XWidget_LobbyMainButtons leftButtons;

	[Token(Token = "0x4004926")]
	[FieldOffset(Offset = "0x64")]
	public XWidget_PandoraButton btnPandorabox;

	[Token(Token = "0x4004927")]
	[FieldOffset(Offset = "0x68")]
	public XWidget_IronsButton btnIrons;

	[Token(Token = "0x4004928")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite sprSubShopSprite;

	[Token(Token = "0x4004929")]
	[FieldOffset(Offset = "0x70")]
	public XWidget_LobbyMainButton btnPackageShop;

	[Token(Token = "0x400492A")]
	[FieldOffset(Offset = "0x74")]
	public XWidget_LobbyMainButton btnMedalShop;

	[Token(Token = "0x400492B")]
	[FieldOffset(Offset = "0x78")]
	public XWidget_LobbyMainButton btnGeneralShop;

	[Token(Token = "0x400492C")]
	[FieldOffset(Offset = "0x7C")]
	public XWidget_LobbyMainButton btnArenaShop;

	[Token(Token = "0x400492D")]
	[FieldOffset(Offset = "0x80")]
	public XWidget_LobbyMainButton btnMischaShop;

	[Token(Token = "0x400492E")]
	[FieldOffset(Offset = "0x84")]
	private bool isShowingSubshop;

	[Token(Token = "0x400492F")]
	[FieldOffset(Offset = "0x88")]
	public GameObject goShopArrow;

	[Token(Token = "0x4004930")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject goSubShop;

	[Token(Token = "0x4004931")]
	[FieldOffset(Offset = "0x90")]
	public XWidget_Slide slide;

	[Token(Token = "0x4004932")]
	[FieldOffset(Offset = "0x94")]
	public UISprite sprArrow;

	[Token(Token = "0x4004933")]
	[FieldOffset(Offset = "0x98")]
	public UI2DSprite sprAttendance;

	[Token(Token = "0x4004934")]
	[FieldOffset(Offset = "0x9C")]
	public UI2DSprite sprLoginEvent;

	[Token(Token = "0x4004935")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid IronsAndMichaBtnGrid;

	[Token(Token = "0x4004936")]
	[FieldOffset(Offset = "0xA4")]
	public XUIMainCharEffect CharEffect;

	[Token(Token = "0x4004937")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject goLobbyCharRoot;

	[Token(Token = "0x4004938")]
	[FieldOffset(Offset = "0xAC")]
	private bool shopListOpen;

	[Token(Token = "0x4004939")]
	[FieldOffset(Offset = "0xAD")]
	private bool menuClick;

	[Token(Token = "0x400493A")]
	[FieldOffset(Offset = "0xAE")]
	private bool UseSocialButton__BackingField;

	[Token(Token = "0x400493B")]
	[FieldOffset(Offset = "0xAF")]
	private bool UseNaverButton__BackingField;

	[Token(Token = "0x17000D71")]
	public XWidget_PandoraboxDetailPopup WidgetPandoraDetailPopup
	{
		[Token(Token = "0x600676B")]
		[Address(RVA = "0x1000B84", Offset = "0x1000B84", VA = "0x1000B84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D72")]
	public XWidget_PandoraboxPopup WidgetPandoraPopup
	{
		[Token(Token = "0x600676C")]
		[Address(RVA = "0x1000C84", Offset = "0x1000C84", VA = "0x1000C84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D73")]
	public bool UseSocialButton
	{
		[Token(Token = "0x600676D")]
		[Address(RVA = "0x1000D84", Offset = "0x1000D84", VA = "0x1000D84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600676E")]
		[Address(RVA = "0x1000D8C", Offset = "0x1000D8C", VA = "0x1000D8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D74")]
	public bool UseNaverButton
	{
		[Token(Token = "0x600676F")]
		[Address(RVA = "0x1000D94", Offset = "0x1000D94", VA = "0x1000D94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006770")]
		[Address(RVA = "0x1000D9C", Offset = "0x1000D9C", VA = "0x1000D9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000D75")]
	public static XPanel_Main Instance
	{
		[Token(Token = "0x6006771")]
		[Address(RVA = "0x1000DA4", Offset = "0x1000DA4", VA = "0x1000DA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006769")]
	[Address(RVA = "0x1000A4C", Offset = "0x1000A4C", VA = "0x1000A4C")]
	public XPanel_Main()
	{
	}

	[Token(Token = "0x6006772")]
	[Address(RVA = "0x1000EB0", Offset = "0x1000EB0", VA = "0x1000EB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006773")]
	[Address(RVA = "0x1000EDC", Offset = "0x1000EDC", VA = "0x1000EDC")]
	public void Show(bool bShow)
	{
	}

	[Token(Token = "0x6006774")]
	[Address(RVA = "0x1002820", Offset = "0x1002820", VA = "0x1002820")]
	private void BuildRightSlideArea()
	{
	}

	[Token(Token = "0x6006775")]
	[Address(RVA = "0x10027B8", Offset = "0x10027B8", VA = "0x10027B8")]
	private void BuildSubShop()
	{
	}

	[Token(Token = "0x6006776")]
	[Address(RVA = "0x10026B4", Offset = "0x10026B4", VA = "0x10026B4")]
	private void RefreshLeftBottomGrid()
	{
	}

	[Token(Token = "0x6006777")]
	[Address(RVA = "0x1002CD8", Offset = "0x1002CD8", VA = "0x1002CD8")]
	public void RefreshPackageShopButton()
	{
	}

	[Token(Token = "0x6006778")]
	[Address(RVA = "0x10024CC", Offset = "0x10024CC", VA = "0x10024CC")]
	public void RefreshIronsButton()
	{
	}

	[Token(Token = "0x6006779")]
	[Address(RVA = "0x1001FE4", Offset = "0x1001FE4", VA = "0x1001FE4")]
	public void RefreshPandorabox()
	{
	}

	[Token(Token = "0x600677A")]
	[Address(RVA = "0x1003074", Offset = "0x1003074", VA = "0x1003074")]
	public void BuildLobbyIllust(XMyInfo myInfo)
	{
	}

	[Token(Token = "0x600677B")]
	[Address(RVA = "0x1001484", Offset = "0x1001484", VA = "0x1001484")]
	public void BuildRightButtons()
	{
	}

	[Token(Token = "0x600677C")]
	[Address(RVA = "0x1003078", Offset = "0x1003078", VA = "0x1003078")]
	private void SetLobbyButtonsAction(List<XLobbyButtonInfo> buttonInfos)
	{
	}

	[Token(Token = "0x600677D")]
	[Address(RVA = "0x1003390", Offset = "0x1003390", VA = "0x1003390")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x600677E")]
	[Address(RVA = "0x100343C", Offset = "0x100343C", VA = "0x100343C")]
	private void ResizeSubShopBackground()
	{
	}

	[Token(Token = "0x600677F")]
	[Address(RVA = "0x1003600", Offset = "0x1003600", VA = "0x1003600")]
	private void OnNetdataUpdated_ItemData(object arg)
	{
	}

	[Token(Token = "0x6006780")]
	[Address(RVA = "0x1003638", Offset = "0x1003638", VA = "0x1003638")]
	private void OnNetdataUpdated_Character(object arg)
	{
	}

	[Token(Token = "0x6006781")]
	[Address(RVA = "0x1003684", Offset = "0x1003684", VA = "0x1003684")]
	private void OnNetdataUpdated_CharacterList(object arg)
	{
	}

	[Token(Token = "0x6006782")]
	[Address(RVA = "0x10036D0", Offset = "0x10036D0", VA = "0x10036D0")]
	private void OnNetdataUpdated_PetList(object arg)
	{
	}

	[Token(Token = "0x6006783")]
	[Address(RVA = "0x10036F8", Offset = "0x10036F8", VA = "0x10036F8")]
	private void OnNetdataUpdated_Pet(object arg)
	{
	}

	[Token(Token = "0x6006784")]
	[Address(RVA = "0x10025D8", Offset = "0x10025D8", VA = "0x10025D8")]
	private void BuildLeftButtons()
	{
	}

	[Token(Token = "0x6006785")]
	[Address(RVA = "0x10029A4", Offset = "0x10029A4", VA = "0x10029A4")]
	private void RefreshRightSlideButtonsNewBadge()
	{
	}

	[Token(Token = "0x6006786")]
	[Address(RVA = "0x1003AE8", Offset = "0x1003AE8", VA = "0x1003AE8")]
	private void RefreshIronsMissionNewBadge()
	{
	}

	[Token(Token = "0x6006787")]
	[Address(RVA = "0x1003AF0", Offset = "0x1003AF0", VA = "0x1003AF0")]
	public void OnClick_EventAttendanceBook()
	{
	}

	[Token(Token = "0x6006788")]
	[Address(RVA = "0x1003820", Offset = "0x1003820", VA = "0x1003820")]
	public void RefreshFriendButton(XWidget_LobbyMainButton button, out bool isNewBadgeShow)
	{
		isNewBadgeShow = default;
	}

	[Token(Token = "0x6006789")]
	[Address(RVA = "0x1001B0C", Offset = "0x1001B0C", VA = "0x1001B0C")]
	private void RefreshCharInventoryBadge()
	{
	}

	[Token(Token = "0x600678A")]
	[Address(RVA = "0x1001B14", Offset = "0x1001B14", VA = "0x1001B14")]
	private void RefreshPetInventoryBadge()
	{
	}

	[Token(Token = "0x600678B")]
	[Address(RVA = "0x1001B04", Offset = "0x1001B04", VA = "0x1001B04")]
	private void RefreshQusetBadge()
	{
	}

	[Token(Token = "0x600678C")]
	[Address(RVA = "0x1001AFC", Offset = "0x1001AFC", VA = "0x1001AFC")]
	private void RefreshTeamManagementBadge()
	{
	}

	[Token(Token = "0x600678D")]
	[Address(RVA = "0x1003720", Offset = "0x1003720", VA = "0x1003720")]
	public void RefreshAchievementButton(XWidget_LobbyMainButton button, out bool isNewBadgeShow)
	{
		isNewBadgeShow = default;
	}

	[Token(Token = "0x600678E")]
	[Address(RVA = "0x1003814", Offset = "0x1003814", VA = "0x1003814")]
	public void RefreshInventoryButton(XWidget_LobbyMainButton button, out bool isNewBadgeShow)
	{
		isNewBadgeShow = default;
	}

	[Token(Token = "0x600678F")]
	[Address(RVA = "0x1003914", Offset = "0x1003914", VA = "0x1003914")]
	private void RefreshRankBadge(XWidget_LobbyMainButton button, out bool isNewBadgeShow)
	{
		isNewBadgeShow = default;
	}

	[Token(Token = "0x6006790")]
	[Address(RVA = "0x1001B1C", Offset = "0x1001B1C", VA = "0x1001B1C")]
	private void RefreshPlayerCount()
	{
	}

	[Token(Token = "0x6006791")]
	[Address(RVA = "0x1002CD0", Offset = "0x1002CD0", VA = "0x1002CD0")]
	private void RefreshShopBadge()
	{
	}

	[Token(Token = "0x6006792")]
	[Address(RVA = "0x1003A08", Offset = "0x1003A08", VA = "0x1003A08")]
	private bool RefreshBadge(XWidget_NewBadge badge)
	{
		return default(bool);
	}

	[Token(Token = "0x6006793")]
	[Address(RVA = "0x1003BC4", Offset = "0x1003BC4", VA = "0x1003BC4")]
	public void OnPlayingPlayerCountChanged()
	{
	}

	[Token(Token = "0x6006794")]
	[Address(RVA = "0x1003BC8", Offset = "0x1003BC8", VA = "0x1003BC8")]
	private void ShopListTweenDelay(UITweener[] listTween, bool open)
	{
	}

	[Token(Token = "0x6006795")]
	[Address(RVA = "0x1001120", Offset = "0x1001120", VA = "0x1001120")]
	private void BuildLobbyCharImage()
	{
	}

	[Token(Token = "0x6006796")]
	[Address(RVA = "0x1003C80", Offset = "0x1003C80", VA = "0x1003C80")]
	public void OnClick_Shop()
	{
	}

	[Token(Token = "0x6006797")]
	[Address(RVA = "0x1004668", Offset = "0x1004668", VA = "0x1004668")]
	public void OnClick_CharMain()
	{
	}

	[Token(Token = "0x6006798")]
	[Address(RVA = "0x100473C", Offset = "0x100473C", VA = "0x100473C")]
	public void OnClick_PetMain()
	{
	}

	[Token(Token = "0x6006799")]
	[Address(RVA = "0x1004810", Offset = "0x1004810", VA = "0x1004810")]
	public void OnClick_ShopWindow()
	{
	}

	[Token(Token = "0x600679A")]
	[Address(RVA = "0x100494C", Offset = "0x100494C", VA = "0x100494C")]
	public void OnClick_PackageShopWindow()
	{
	}

	[Token(Token = "0x600679B")]
	[Address(RVA = "0x1004A30", Offset = "0x1004A30", VA = "0x1004A30")]
	public void OnClick_DailyQuest()
	{
	}

	[Token(Token = "0x600679C")]
	[Address(RVA = "0x1004B04", Offset = "0x1004B04", VA = "0x1004B04")]
	public void OnClick_AttendanceRewards()
	{
	}

	[Token(Token = "0x600679D")]
	[Address(RVA = "0x1004BD8", Offset = "0x1004BD8", VA = "0x1004BD8")]
	public void OnClick_Achievement()
	{
	}

	[Token(Token = "0x600679E")]
	[Address(RVA = "0x1004CAC", Offset = "0x1004CAC", VA = "0x1004CAC")]
	public void OnClick_Inventory()
	{
	}

	[Token(Token = "0x600679F")]
	[Address(RVA = "0x1004DFC", Offset = "0x1004DFC", VA = "0x1004DFC")]
	public void OnClick_TeamManagement()
	{
	}

	[Token(Token = "0x60067A0")]
	[Address(RVA = "0x1004ED0", Offset = "0x1004ED0", VA = "0x1004ED0")]
	public void OnClick_MedalShop()
	{
	}

	[Token(Token = "0x60067A1")]
	[Address(RVA = "0x100500C", Offset = "0x100500C", VA = "0x100500C")]
	public void OnClick_ArenaShop()
	{
	}

	[Token(Token = "0x60067A2")]
	[Address(RVA = "0x10050E4", Offset = "0x10050E4", VA = "0x10050E4")]
	public void OnClick_ArenaShopLock()
	{
	}

	[Token(Token = "0x60067A3")]
	[Address(RVA = "0x100537C", Offset = "0x100537C", VA = "0x100537C")]
	public void OnClick_IronsMission()
	{
	}

	[Token(Token = "0x60067A4")]
	[Address(RVA = "0x10053D8", Offset = "0x10053D8", VA = "0x10053D8")]
	public void OnClick_Naver()
	{
	}

	[Token(Token = "0x60067A5")]
	[Address(RVA = "0x10054A4", Offset = "0x10054A4", VA = "0x10054A4")]
	public void OnClick_Ranking()
	{
	}

	[Token(Token = "0x60067A6")]
	[Address(RVA = "0x100557C", Offset = "0x100557C", VA = "0x100557C")]
	public void OnClick_Pandorabox()
	{
	}

	[Token(Token = "0x60067A7")]
	[Address(RVA = "0x100565C", Offset = "0x100565C", VA = "0x100565C")]
	public void OnClick_IllustratedBook()
	{
	}

	[Token(Token = "0x60067A8")]
	[Address(RVA = "0x1005730", Offset = "0x1005730", VA = "0x1005730")]
	public void OnClick_Friend()
	{
	}

	[Token(Token = "0x60067A9")]
	[Address(RVA = "0x1005804", Offset = "0x1005804", VA = "0x1005804")]
	public void OnClick_VIP()
	{
	}

	[Token(Token = "0x60067AA")]
	[Address(RVA = "0x10059DC", Offset = "0x10059DC", VA = "0x10059DC")]
	public void OnClick_ShowArchievement()
	{
	}

	[Token(Token = "0x60067AB")]
	[Address(RVA = "0x1001E24", Offset = "0x1001E24", VA = "0x1001E24")]
	private void RefreshClanLock()
	{
	}

	[Token(Token = "0x60067AC")]
	[Address(RVA = "0x1005AA8", Offset = "0x1005AA8", VA = "0x1005AA8")]
	public void OnClick_Clan()
	{
	}

	[Token(Token = "0x60067AD")]
	[Address(RVA = "0x1005DA4", Offset = "0x1005DA4", VA = "0x1005DA4")]
	public void OnButtonClick_Transfer()
	{
	}

	[Token(Token = "0x60067AE")]
	[Address(RVA = "0x10029E0", Offset = "0x10029E0", VA = "0x10029E0")]
	public void SetTextBtnTransfer()
	{
	}

	[Token(Token = "0x60067AF")]
	[Address(RVA = "0x1003DE4", Offset = "0x1003DE4", VA = "0x1003DE4")]
	private void RefreshArenaShopButton(XWidget_LobbyMainButton button)
	{
	}

	[Token(Token = "0x60067B0")]
	[Address(RVA = "0x1004018", Offset = "0x1004018", VA = "0x1004018")]
	private void RefreshGeneralShopButton(XWidget_LobbyMainButton button)
	{
	}

	[Token(Token = "0x60067B1")]
	[Address(RVA = "0x100412C", Offset = "0x100412C", VA = "0x100412C")]
	private void RefreshMischaShopButton(XWidget_LobbyMainButton button)
	{
	}

	[Token(Token = "0x60067B2")]
	[Address(RVA = "0x1005E70", Offset = "0x1005E70", VA = "0x1005E70")]
	public void ShopLockNotiShow()
	{
	}

	[Token(Token = "0x60067B3")]
	[Address(RVA = "0x10050F0", Offset = "0x10050F0", VA = "0x10050F0")]
	private bool IsFeatureLock(FeatureType featureType, bool showNoti)
	{
		return default(bool);
	}

	[Token(Token = "0x60067B4")]
	[Address(RVA = "0x1005E7C", Offset = "0x1005E7C", VA = "0x1005E7C")]
	public void OnClick_PlayMain()
	{
	}

	[Token(Token = "0x60067B5")]
	[Address(RVA = "0x1005F50", Offset = "0x1005F50", VA = "0x1005F50")]
	public void OnClick_ChallengeMain()
	{
	}

	[Token(Token = "0x60067B6")]
	[Address(RVA = "0x1006024", Offset = "0x1006024", VA = "0x1006024")]
	public void OnClick_ShowEventAttendance4Day()
	{
	}

	[Token(Token = "0x60067B7")]
	[Address(RVA = "0x10060F8", Offset = "0x10060F8", VA = "0x10060F8")]
	public void OnClick_ShowEventAttendance7Day()
	{
	}

	[Token(Token = "0x60067B8")]
	[Address(RVA = "0x10061CC", Offset = "0x10061CC", VA = "0x10061CC")]
	public void OnClick_ShowMischaShop()
	{
	}

	[Token(Token = "0x60067B9")]
	[Address(RVA = "0x10062A4", Offset = "0x10062A4", VA = "0x10062A4")]
	public void OnClick_SlideButton()
	{
	}

	[Token(Token = "0x60067BA")]
	[Address(RVA = "0x1006330", Offset = "0x1006330", VA = "0x1006330")]
	public void OnClick_DownLoad()
	{
	}

	[Token(Token = "0x60067BB")]
	[Address(RVA = "0x1006404", Offset = "0x1006404", VA = "0x1006404")]
	private void _003CSetLobbyButtonsAction_003Em__38D()
	{
	}

	[Token(Token = "0x60067BC")]
	[Address(RVA = "0x1006408", Offset = "0x1006408", VA = "0x1006408")]
	private void _003CSetLobbyButtonsAction_003Em__38E()
	{
	}
}
