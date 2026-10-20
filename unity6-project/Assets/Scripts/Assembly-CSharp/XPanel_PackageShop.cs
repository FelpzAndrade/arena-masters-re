using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EEC")]
public class XPanel_PackageShop : XUIBasePanel
{
	[Token(Token = "0x2000EED")]
	private sealed class _003CBuildTab_003Ec__AnonStorey21E
	{
		[Token(Token = "0x4004F19")]
		[FieldOffset(Offset = "0x8")]
		internal KeyValuePair<PackageShopTabCategory, List<PackageShopInfo>> item;

		[Token(Token = "0x4004F1A")]
		[FieldOffset(Offset = "0x10")]
		internal PackageShopTabCategory tabCategory;

		[Token(Token = "0x4004F1B")]
		[FieldOffset(Offset = "0x14")]
		internal XPanel_PackageShop _003C_003Ef__this;

		[Token(Token = "0x6006F80")]
		[Address(RVA = "0x100FAF0", Offset = "0x100FAF0", VA = "0x100FAF0")]
		public _003CBuildTab_003Ec__AnonStorey21E()
		{
		}

		[Token(Token = "0x6006F81")]
		[Address(RVA = "0x1010254", Offset = "0x1010254", VA = "0x1010254")]
		internal void _003C_003Em__44B()
		{
		}
	}

	[Token(Token = "0x4004F0A")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ActionOnShowKey;

	[Token(Token = "0x4004F0B")]
	[FieldOffset(Offset = "0x4")]
	private static readonly string PATH_PACKAGE_DETAILPOPUP;

	[Token(Token = "0x4004F0C")]
	[FieldOffset(Offset = "0x10")]
	private XWidget_PackageDetailPopup m_widgetPackageDetailPopup;

	[Token(Token = "0x4004F0D")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView leftScrollView;

	[Token(Token = "0x4004F0E")]
	[FieldOffset(Offset = "0x18")]
	public XWiget_GridBuilder gridTab;

	[Token(Token = "0x4004F0F")]
	[FieldOffset(Offset = "0x1C")]
	public XUIPackageShopView rightShopView;

	[Token(Token = "0x4004F10")]
	[FieldOffset(Offset = "0x20")]
	public XWidget_CashBuyInfo cashBuyInfo;

	[Token(Token = "0x4004F11")]
	[FieldOffset(Offset = "0x24")]
	public GameObject goNormalProductBG;

	[Token(Token = "0x4004F12")]
	[FieldOffset(Offset = "0x28")]
	protected Dictionary<PackageShopTabCategory, List<PackageShopInfo>> m_shopList;

	[Token(Token = "0x4004F13")]
	[FieldOffset(Offset = "0x2C")]
	protected Dictionary<PackageShopTabCategory, int> m_tabIndex;

	[Token(Token = "0x4004F14")]
	[FieldOffset(Offset = "0x30")]
	protected PackageShopCategory m_category;

	[Token(Token = "0x4004F15")]
	[FieldOffset(Offset = "0x34")]
	protected PackageShopTabCategory m_tabCategory;

	[Token(Token = "0x4004F16")]
	[FieldOffset(Offset = "0x38")]
	private XWidget_ToggleTab_Btn[] m_tabs;

	[Token(Token = "0x4004F17")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<PackageShopInfo> _003C_003Ef__am_0024cacheD;

	[Token(Token = "0x4004F18")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<PackageShopInfo> _003C_003Ef__am_0024cacheE;

	[Token(Token = "0x17000E23")]
	private XWidget_PackageDetailPopup widgetPackageDetailPopup
	{
		[Token(Token = "0x6006F6E")]
		[Address(RVA = "0x100E3F4", Offset = "0x100E3F4", VA = "0x100E3F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E24")]
	public PackageShopTabCategory TabCategory
	{
		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0x100E544", Offset = "0x100E544", VA = "0x100E544")]
		get
		{
			return default(PackageShopTabCategory);
		}
	}

	[Token(Token = "0x6006F6B")]
	[Address(RVA = "0x100E100", Offset = "0x100E100", VA = "0x100E100")]
	public XPanel_PackageShop()
	{
	}

	[Token(Token = "0x6006F6D")]
	[Address(RVA = "0x100E294", Offset = "0x100E294", VA = "0x100E294", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006F70")]
	[Address(RVA = "0x100E54C", Offset = "0x100E54C", VA = "0x100E54C")]
	public void Show(PackageShopTabCategory tab = PackageShopTabCategory.None)
	{
	}

	[Token(Token = "0x6006F71")]
	[Address(RVA = "0x100E594", Offset = "0x100E594", VA = "0x100E594")]
	private void Build(PackageShopTabCategory tab)
	{
	}

	[Token(Token = "0x6006F72")]
	[Address(RVA = "0x100F98C", Offset = "0x100F98C", VA = "0x100F98C")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6006F73")]
	[Address(RVA = "0x100F86C", Offset = "0x100F86C", VA = "0x100F86C")]
	public void OnClickTab(PackageShopTabCategory tab)
	{
	}

	[Token(Token = "0x6006F74")]
	[Address(RVA = "0x100F3E4", Offset = "0x100F3E4", VA = "0x100F3E4")]
	public void BuildTab()
	{
	}

	[Token(Token = "0x6006F75")]
	[Address(RVA = "0x100E650", Offset = "0x100E650", VA = "0x100E650")]
	public void RefreshShopItemList()
	{
	}

	[Token(Token = "0x6006F76")]
	[Address(RVA = "0x100FAF8", Offset = "0x100FAF8", VA = "0x100FAF8")]
	private void OnClick_PurchaseButton(PackageShopInfo info)
	{
	}

	[Token(Token = "0x6006F77")]
	[Address(RVA = "0x100FE44", Offset = "0x100FE44", VA = "0x100FE44")]
	private bool IsNotFlaterateTab()
	{
		return default(bool);
	}

	[Token(Token = "0x6006F78")]
	[Address(RVA = "0x100FE6C", Offset = "0x100FE6C", VA = "0x100FE6C")]
	private void BuildActiveCashBuyInfo()
	{
	}

	[Token(Token = "0x6006F79")]
	[Address(RVA = "0x100FFD8", Offset = "0x100FFD8", VA = "0x100FFD8", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x6006F7A")]
	[Address(RVA = "0x10100D0", Offset = "0x10100D0", VA = "0x10100D0")]
	public void ShowPackageDetailPopup(string strTitle, int detailID)
	{
	}

	[Token(Token = "0x6006F7B")]
	[Address(RVA = "0x101010C", Offset = "0x101010C", VA = "0x101010C")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6006F7C")]
	[Address(RVA = "0x10101E0", Offset = "0x10101E0", VA = "0x10101E0")]
	private void _003CRefresh_003Em__449()
	{
	}

	[Token(Token = "0x6006F7D")]
	[Address(RVA = "0x10101E4", Offset = "0x10101E4", VA = "0x10101E4")]
	private void _003CRefresh_003Em__44A()
	{
	}

	[Token(Token = "0x6006F7E")]
	[Address(RVA = "0x10101EC", Offset = "0x10101EC", VA = "0x10101EC")]
	private static int _003CRefreshShopItemList_003Em__44C(PackageShopInfo x, PackageShopInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x6006F7F")]
	[Address(RVA = "0x1010220", Offset = "0x1010220", VA = "0x1010220")]
	private static int _003CRefreshShopItemList_003Em__44D(PackageShopInfo x, PackageShopInfo y)
	{
		return default(int);
	}
}
