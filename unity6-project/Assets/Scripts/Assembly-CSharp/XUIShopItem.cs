using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using GoogleMobileAds.Api;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2001035")]
public class XUIShopItem : MonoBehaviour, IAdmobListener
{
	[Token(Token = "0x2001036")]
	private enum ButtonTextType
	{
		[Token(Token = "0x4005756")]
		None = 0,
		[Token(Token = "0x4005757")]
		Normal = 1,
		[Token(Token = "0x4005758")]
		Free = 2,
		[Token(Token = "0x4005759")]
		Advertising = 3
	}

	[Token(Token = "0x2001037")]
	public enum DisableType
	{
		[Token(Token = "0x400575B")]
		None = 0,
		[Token(Token = "0x400575C")]
		NoStock = 1,
		[Token(Token = "0x400575D")]
		NotBuy = 2
	}

	[Token(Token = "0x2001038")]
	private enum RemainTimeNotiType
	{
		[Token(Token = "0x400575F")]
		LimitedTime = 0,
		[Token(Token = "0x4005760")]
		DiscountTime = 1,
		[Token(Token = "0x4005761")]
		RotationRemainTime = 2,
		[Token(Token = "0x4005762")]
		BuyFreeRemainTime = 3,
		[Token(Token = "0x4005763")]
		None = 4
	}

	[Token(Token = "0x2001039")]
	private sealed class _003CRefreshRotationItem_003Ec__AnonStorey257
	{
		[Token(Token = "0x4005764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int rotationID;

		[Token(Token = "0x4005765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XUIShopItem _003C_003Ef__this;

		[Token(Token = "0x6007915")]
		[Address(RVA = "0x19261DC", Offset = "0x19261DC", VA = "0x19261DC")]
		public _003CRefreshRotationItem_003Ec__AnonStorey257()
		{
		}

		[Token(Token = "0x6007916")]
		[Address(RVA = "0x1928DAC", Offset = "0x1928DAC", VA = "0x1928DAC")]
		internal void _003C_003Em__50B(ApiReturnCode result, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x4005723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public UILabel lblItemName;

	[Token(Token = "0x4005724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public UILabel lblDesc;

	[Token(Token = "0x4005725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public XWidget_Price widgetPrice;

	[Token(Token = "0x4005726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XWidget_Price widgetDiscountPrice;

	[Token(Token = "0x4005727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float discount_pos_x;

	[Token(Token = "0x4005728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float normal_pos_x;

	[Token(Token = "0x4005729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UI2DSprite sprItemIcon;

	[Token(Token = "0x400572A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UI2DSprite sprHeroIcon;

	[Token(Token = "0x400572B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UI2DSprite sprSoulChar;

	[Token(Token = "0x400572C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public UILabel lblBtnBuyFree;

	[Token(Token = "0x400572D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UILabel lblBtnAdvertising;

	[Token(Token = "0x400572E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject goDisable;

	[Token(Token = "0x400572F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UILabel lblDisable;

	[Token(Token = "0x4005730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject goBottomNoti;

	[Token(Token = "0x4005731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UISprite sprBottomNotiFrame;

	[Token(Token = "0x4005732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public UILabel lblBottomNotiText;

	[Token(Token = "0x4005733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public UISprite sprEvent;

	[Token(Token = "0x4005734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public UILabel lblEvent;

	[Token(Token = "0x4005735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public XWidget_Libbon productTypeLibbon;

	[Token(Token = "0x4005736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform nextRotationItemParent;

	[Token(Token = "0x4005737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public UI2DSprite sprNextRotationIcon;

	[Token(Token = "0x4005738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UILabel lblNextRotItemCount;

	[Token(Token = "0x4005739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool m_timeOutRotationItem;

	[Token(Token = "0x400573A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject goLimitedBuyOneTopBar;

	[Token(Token = "0x400573B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool m_bBuyFree;

	[Token(Token = "0x400573C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Action m_onClickRefeshTab;

	[Token(Token = "0x400573D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public UILabel lblHasAndUpgradeCnt;

	[Token(Token = "0x400573E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform stallIconParent;

	[Token(Token = "0x400573F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private XWidget_ContentIcon m_stallIcon;

	[Token(Token = "0x4005740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private XWidget_ContentIcon.Option m_option;

	[Token(Token = "0x4005741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private CSTimeInterval m_freeTimeInterval;

	[Token(Token = "0x4005742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RemainTimeNotiType curNotiType;

	[Token(Token = "0x4005743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private DateTime? rotationTime;

	[Token(Token = "0x4005744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<string> rotationlist;

	[Token(Token = "0x4005745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	protected Dictionary<int, RotationItemSet> m_rotationItemSet;

	[Token(Token = "0x4005746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public XWidget_Button btnBuy;

	[Token(Token = "0x4005747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public GameObject goBonus;

	[Token(Token = "0x4005748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public XWiget_GridBuilder bounsBuilder;

	[Token(Token = "0x4005749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public UILabel lblBuyAvailableCount;

	[Token(Token = "0x400574A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public XWidget_Button btnDetail;

	[Token(Token = "0x400574B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Action m_onRefresh;

	[Token(Token = "0x400574C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action<string, int> m_onDetailShow;

	[Token(Token = "0x400574D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public UIGrid gridBottom;

	[Token(Token = "0x400574E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int characterIconHeight;

	[Token(Token = "0x400574F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int defaultIconHeight;

	[Token(Token = "0x4005750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ButtonTextType curButtonType;

	[Token(Token = "0x4005751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Netdata_BuyShopItem adReward;

	[Token(Token = "0x4005752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private CSShopItem ShopItem__BackingField;

	[Token(Token = "0x4005753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private bool DidShowRewardAnimation__BackingField;

	[Token(Token = "0x4005754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
	private bool DidClosedAdmobBanner__BackingField;

	[Token(Token = "0x17000EFF")]
	public int ShopProductID
	{
		[Token(Token = "0x60078CE")]
		[Address(RVA = "0x1921E58", Offset = "0x1921E58", VA = "0x1921E58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000F00")]
	public CSShopItem ShopItem
	{
		[Token(Token = "0x60078CF")]
		[Address(RVA = "0x1921E70", Offset = "0x1921E70", VA = "0x1921E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60078D0")]
		[Address(RVA = "0x1921E78", Offset = "0x1921E78", VA = "0x1921E78")]
		private set
		{
		}
	}

	[Token(Token = "0x17000F01")]
	public bool IsEnableBuyFree
	{
		[Token(Token = "0x60078D1")]
		[Address(RVA = "0x1921E80", Offset = "0x1921E80", VA = "0x1921E80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000F02")]
	private bool DidShowRewardAnimation
	{
		[Token(Token = "0x6007902")]
		[Address(RVA = "0x19283E0", Offset = "0x19283E0", VA = "0x19283E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007903")]
		[Address(RVA = "0x1928114", Offset = "0x1928114", VA = "0x1928114")]
		set
		{
		}
	}

	[Token(Token = "0x17000F03")]
	private bool DidClosedAdmobBanner
	{
		[Token(Token = "0x6007904")]
		[Address(RVA = "0x19283E8", Offset = "0x19283E8", VA = "0x19283E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007905")]
		[Address(RVA = "0x192811C", Offset = "0x192811C", VA = "0x192811C")]
		set
		{
		}
	}

	[Token(Token = "0x60078CD")]
	[Address(RVA = "0x1921D70", Offset = "0x1921D70", VA = "0x1921D70")]
	public XUIShopItem()
	{
	}

	[Token(Token = "0x60078D2")]
	[Address(RVA = "0x1921E88", Offset = "0x1921E88", VA = "0x1921E88")]
	private void Awake()
	{
	}

	[Token(Token = "0x60078D3")]
	[Address(RVA = "0x1922040", Offset = "0x1922040", VA = "0x1922040")]
	public void OnClick_ShowDetail()
	{
	}

	[Token(Token = "0x60078D4")]
	[Address(RVA = "0x1922104", Offset = "0x1922104", VA = "0x1922104")]
	public void SetClickAction(Action onClickRefeshTab)
	{
	}

	[Token(Token = "0x60078D5")]
	[Address(RVA = "0x192210C", Offset = "0x192210C", VA = "0x192210C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60078D6")]
	[Address(RVA = "0x1922754", Offset = "0x1922754", VA = "0x1922754")]
	private void SetRemainTimeNotiBox(RemainTimeNotiType notiType)
	{
	}

	[Token(Token = "0x60078D7")]
	[Address(RVA = "0x192283C", Offset = "0x192283C", VA = "0x192283C")]
	private void SetRemainTimeNotiBox()
	{
	}

	[Token(Token = "0x60078D8")]
	[Address(RVA = "0x192297C", Offset = "0x192297C", VA = "0x192297C")]
	private void SetRemainTimeNotiBoxForOriginItem()
	{
	}

	[Token(Token = "0x60078D9")]
	[Address(RVA = "0x1922930", Offset = "0x1922930", VA = "0x1922930")]
	private void SetRemainTimeNotiBoxForFreeItem()
	{
	}

	[Token(Token = "0x60078DA")]
	[Address(RVA = "0x1923388", Offset = "0x1923388", VA = "0x1923388")]
	private void SetRemainTimeNotiBoxForFreeItemNormal()
	{
	}

	[Token(Token = "0x60078DB")]
	[Address(RVA = "0x1923154", Offset = "0x1923154", VA = "0x1923154")]
	private void SetRemainTimeNotiBoxForFreeItemConsecutively()
	{
	}

	[Token(Token = "0x60078DC")]
	[Address(RVA = "0x1923918", Offset = "0x1923918", VA = "0x1923918")]
	private void SetTopNotiBox(RemainTimeNotiType notiType)
	{
	}

	[Token(Token = "0x60078DD")]
	[Address(RVA = "0x1923CD8", Offset = "0x1923CD8", VA = "0x1923CD8")]
	private void BuildNotiBox(CSShopItem shopItem)
	{
	}

	[Token(Token = "0x60078DE")]
	[Address(RVA = "0x1922CF8", Offset = "0x1922CF8", VA = "0x1922CF8")]
	private int GetRemainSecondByNotiType(RemainTimeNotiType notiType)
	{
		return default(int);
	}

	[Token(Token = "0x60078DF")]
	[Address(RVA = "0x1923E88", Offset = "0x1923E88", VA = "0x1923E88")]
	public void OnButtonClick_ShowStallItemDetail()
	{
	}

	[Token(Token = "0x60078E0")]
	[Address(RVA = "0x19240B4", Offset = "0x19240B4", VA = "0x19240B4", Slot = "12")]
	protected virtual void BuildStallItem(CSShopItem item)
	{
	}

	[Token(Token = "0x60078E1")]
	[Address(RVA = "0x19246F8", Offset = "0x19246F8", VA = "0x19246F8")]
	private void BuildDisable(DisableType disableType)
	{
	}

	[Token(Token = "0x60078E2")]
	[Address(RVA = "0x19248F0", Offset = "0x19248F0", VA = "0x19248F0")]
	public void BuildBonus(CSShopItem item)
	{
	}

	[Token(Token = "0x60078E3")]
	[Address(RVA = "0x1924CF0", Offset = "0x1924CF0", VA = "0x1924CF0")]
	protected void BuildCommon(CSShopItem item)
	{
	}

	[Token(Token = "0x60078E4")]
	[Address(RVA = "0x19256F4", Offset = "0x19256F4", VA = "0x19256F4")]
	private void BuildBuyButton(bool isDisable)
	{
	}

	[Token(Token = "0x60078E5")]
	[Address(RVA = "0x1925990", Offset = "0x1925990", VA = "0x1925990")]
	private void SetBuyButton()
	{
	}

	[Token(Token = "0x60078E6")]
	[Address(RVA = "0x19259AC", Offset = "0x19259AC", VA = "0x19259AC")]
	private void SetBuyButtonDisableForFreeBuy()
	{
	}

	[Token(Token = "0x60078E7")]
	[Address(RVA = "0x1925A08", Offset = "0x1925A08", VA = "0x1925A08")]
	private void SetBuyButtonTextForAdvertising()
	{
	}

	[Token(Token = "0x60078E8")]
	[Address(RVA = "0x19237B8", Offset = "0x19237B8", VA = "0x19237B8")]
	private int GetFreeItemRemainCountWithRemainTime()
	{
		return default(int);
	}

	[Token(Token = "0x60078E9")]
	[Address(RVA = "0x1925868", Offset = "0x1925868", VA = "0x1925868")]
	private void SetDetailButton(bool isDisable)
	{
	}

	[Token(Token = "0x60078EA")]
	[Address(RVA = "0x1925C38", Offset = "0x1925C38", VA = "0x1925C38")]
	private bool CanBuyShopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x60078EB")]
	[Address(RVA = "0x1925C3C", Offset = "0x1925C3C", VA = "0x1925C3C")]
	private bool CanFreeBuyShopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x60078EC")]
	[Address(RVA = "0x1925DC0", Offset = "0x1925DC0", VA = "0x1925DC0")]
	private bool IsDiscount(CSShopItem shopItem)
	{
		return default(bool);
	}

	[Token(Token = "0x60078ED")]
	[Address(RVA = "0x19251F8", Offset = "0x19251F8", VA = "0x19251F8")]
	private void BuildCost(CSShopItem shopItem)
	{
	}

	[Token(Token = "0x60078EE")]
	[Address(RVA = "0x19255D8", Offset = "0x19255D8", VA = "0x19255D8")]
	private void RefreshReaminTime()
	{
	}

	[Token(Token = "0x60078EF")]
	[Address(RVA = "0x19224E4", Offset = "0x19224E4", VA = "0x19224E4")]
	private void BuildButtonTextOnOff(ButtonTextType buttonType)
	{
	}

	[Token(Token = "0x60078F0")]
	[Address(RVA = "0x1925F28", Offset = "0x1925F28", VA = "0x1925F28")]
	private void RefreshRotationItem()
	{
	}

	[Token(Token = "0x60078F1")]
	[Address(RVA = "0x19261E4", Offset = "0x19261E4", VA = "0x19261E4", Slot = "13")]
	public virtual void Build(CSShopItem item, Dictionary<int, RotationItemSet> rotationItemSet, [Optional][DefaultParameterValue(false)] bool isItemDetailText, [Optional][DefaultParameterValue(false)] bool buyPopup, [Optional] Action onRefresh, [Optional] Action<string, int> onDetailShow)
	{
	}

	[Token(Token = "0x60078F2")]
	[Address(RVA = "0x19264C0", Offset = "0x19264C0", VA = "0x19264C0")]
	protected void BuildNormalItem(CSShopItem item)
	{
	}

	[Token(Token = "0x60078F3")]
	[Address(RVA = "0x19268C4", Offset = "0x19268C4", VA = "0x19268C4")]
	private void BuildHeroIcon(CSShopItem item)
	{
	}

	[Token(Token = "0x60078F4")]
	[Address(RVA = "0x19244D0", Offset = "0x19244D0", VA = "0x19244D0")]
	private void BuildHasAndUpgradeText(CSShopItem item, CSItemInfo info)
	{
	}

	[Token(Token = "0x60078F5")]
	[Address(RVA = "0x1926A44", Offset = "0x1926A44", VA = "0x1926A44")]
	private void SetSoulStoneCount(UILabel lblHasAndUpgradeCnt, CSItemInfo info)
	{
	}

	[Token(Token = "0x60078F6")]
	[Address(RVA = "0x1926D5C", Offset = "0x1926D5C", VA = "0x1926D5C")]
	private void SetRelicPieceCount(UILabel lblHasAndUpgradeCnt, CSItemInfo info)
	{
	}

	[Token(Token = "0x60078F7")]
	[Address(RVA = "0x19266F4", Offset = "0x19266F4", VA = "0x19266F4")]
	private void BuildShopIcon(CSShopItem shopItem)
	{
	}

	[Token(Token = "0x60078F8")]
	[Address(RVA = "0x19270EC", Offset = "0x19270EC", VA = "0x19270EC", Slot = "14")]
	protected virtual void BuildRotationItem(CSShopItem item, Dictionary<int, RotationItemSet> rotationItemSet, bool isItemDetailText = false, bool buyPopup = false)
	{
	}

	[Token(Token = "0x60078F9")]
	[Address(RVA = "0x1927320", Offset = "0x1927320", VA = "0x1927320")]
	private CSShopItem GetNextRotationItem(int rotationID, Dictionary<int, RotationItemSet> rotationItemSet)
	{
		return null;
	}

	[Token(Token = "0x60078FA")]
	[Address(RVA = "0x1927634", Offset = "0x1927634", VA = "0x1927634")]
	private CSShopItem GetRotationItem(int rotationID, Dictionary<int, RotationItemSet> rotationItemSet)
	{
		return null;
	}

	[Token(Token = "0x60078FB")]
	[Address(RVA = "0x1927894", Offset = "0x1927894", VA = "0x1927894")]
	public void Update()
	{
	}

	[Token(Token = "0x60078FC")]
	[Address(RVA = "0x19278A4", Offset = "0x19278A4", VA = "0x19278A4")]
	private void OnNetdataUpdated_Userdata(object arg)
	{
	}

	[Token(Token = "0x60078FD")]
	[Address(RVA = "0x19278C0", Offset = "0x19278C0", VA = "0x19278C0")]
	public void OnButtonClick_ShowBuyWindow()
	{
	}

	[Token(Token = "0x60078FE")]
	[Address(RVA = "0x1927C7C", Offset = "0x1927C7C", VA = "0x1927C7C")]
	public void OnClick_Detail()
	{
	}

	[Token(Token = "0x60078FF")]
	[Address(RVA = "0x1927F5C", Offset = "0x1927F5C", VA = "0x1927F5C")]
	private void OnClickAdvertisingItem()
	{
	}

	[Token(Token = "0x6007900")]
	[Address(RVA = "0x1927FF4", Offset = "0x1927FF4", VA = "0x1927FF4")]
	private void RequestAdRewardForUnity()
	{
	}

	[Token(Token = "0x6007901")]
	[Address(RVA = "0x1928008", Offset = "0x1928008", VA = "0x1928008")]
	private void ShowRewardBasedVideoAd()
	{
	}

	[Token(Token = "0x6007906")]
	[Address(RVA = "0x19283F0", Offset = "0x19283F0", VA = "0x19283F0", Slot = "4")]
	public void OnAdRequested(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6007907")]
	[Address(RVA = "0x19284D0", Offset = "0x19284D0", VA = "0x19284D0", Slot = "5")]
	public void OnAdLoaded(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x6007908")]
	[Address(RVA = "0x19284D8", Offset = "0x19284D8", VA = "0x19284D8", Slot = "6")]
	public void OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
	{
	}

	[Token(Token = "0x6007909")]
	[Address(RVA = "0x19284DC", Offset = "0x19284DC", VA = "0x19284DC", Slot = "7")]
	public void OnAdOpening(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600790A")]
	[Address(RVA = "0x19284E0", Offset = "0x19284E0", VA = "0x19284E0", Slot = "8")]
	public void OnAdStarted(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600790B")]
	[Address(RVA = "0x19284E4", Offset = "0x19284E4", VA = "0x19284E4", Slot = "9")]
	public void OnAdRewarded(object sender, Reward args)
	{
	}

	[Token(Token = "0x600790C")]
	[Address(RVA = "0x19284E8", Offset = "0x19284E8", VA = "0x19284E8", Slot = "10")]
	public void OnAdClosed(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600790D")]
	[Address(RVA = "0x1928610", Offset = "0x1928610", VA = "0x1928610", Slot = "11")]
	public void OnAdLeavingApplication(object sender, EventArgs args)
	{
	}

	[Token(Token = "0x600790E")]
	[Address(RVA = "0x1928124", Offset = "0x1928124", VA = "0x1928124")]
	private void RequestAdReward()
	{
	}

	[Token(Token = "0x600790F")]
	[Address(RVA = "0x1928614", Offset = "0x1928614", VA = "0x1928614")]
	private void SendLocalPushForFreeItem()
	{
	}

	[Token(Token = "0x6007910")]
	[Address(RVA = "0x19284F4", Offset = "0x19284F4", VA = "0x19284F4")]
	private void ShowAdRewardIfNeed()
	{
	}

	[Token(Token = "0x6007911")]
	[Address(RVA = "0x19283F4", Offset = "0x19283F4", VA = "0x19283F4")]
	private void DisableBuyButton()
	{
	}

	[Token(Token = "0x6007912")]
	[Address(RVA = "0x19284D4", Offset = "0x19284D4", VA = "0x19284D4")]
	private void RestoreBuyButton()
	{
	}

	[Token(Token = "0x6007913")]
	[Address(RVA = "0x1928B84", Offset = "0x1928B84", VA = "0x1928B84")]
	private void _003CBuildStallItem_003Em__50A(object obj)
	{
	}

	[Token(Token = "0x6007914")]
	[Address(RVA = "0x1928B88", Offset = "0x1928B88", VA = "0x1928B88")]
	private void _003CRequestAdReward_003Em__50C(ApiReturnCode errno, string errmsg, JObject json)
	{
	}
}
