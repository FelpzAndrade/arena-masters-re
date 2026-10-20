using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E1E")]
public class XPanel_Shop : XUIBasePanel
{
	[Token(Token = "0x2000E1F")]
	private sealed class _003CRefreshTimeOnSec_003Ec__IteratorA5 : IDisposable
	{
		[Token(Token = "0x4004A16")]
		[FieldOffset(Offset = "0x8")]
		internal int _0024PC;

		[Token(Token = "0x4004A17")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4004A18")]
		[FieldOffset(Offset = "0x10")]
		internal XPanel_Shop _003C_003Ef__this;

		[Token(Token = "0x17000D8A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x60068E3")]
			[Address(RVA = "0xABED3C", Offset = "0xABED3C", VA = "0xABED3C", Slot = "8")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000D8B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60068E4")]
			[Address(RVA = "0xABED44", Offset = "0xABED44", VA = "0xABED44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60068E2")]
		[Address(RVA = "0xABDEA0", Offset = "0xABDEA0", VA = "0xABDEA0")]
		public _003CRefreshTimeOnSec_003Ec__IteratorA5()
		{
		}

		[Token(Token = "0x60068E3")]
		[Address(RVA = "0xABED3C", Offset = "0xABED3C", VA = "0xABED3C", Slot = "8")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60068E4")]
		[Address(RVA = "0xABED44", Offset = "0xABED44", VA = "0xABED44", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60068E5")]
		[Address(RVA = "0xABED4C", Offset = "0xABED4C", VA = "0xABED4C", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60068E6")]
		[Address(RVA = "0xABEE1C", Offset = "0xABEE1C", VA = "0xABEE1C", Slot = "7")]
		[DebuggerHidden]
		public void Dispose()
		{
		}

		[Token(Token = "0x60068E7")]
		[Address(RVA = "0xABEE28", Offset = "0xABEE28", VA = "0xABEE28", Slot = "6")]
		[DebuggerHidden]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000E20")]
	private sealed class _003CBuild_003Ec__AnonStorey1D5
	{
		[Token(Token = "0x4004A19")]
		[FieldOffset(Offset = "0x8")]
		internal ShopSubCategory subCategory;

		[Token(Token = "0x4004A1A")]
		[FieldOffset(Offset = "0xC")]
		internal XPanel_Shop _003C_003Ef__this;

		[Token(Token = "0x60068E8")]
		[Address(RVA = "0xABBF28", Offset = "0xABBF28", VA = "0xABBF28")]
		public _003CBuild_003Ec__AnonStorey1D5()
		{
		}

		[Token(Token = "0x60068E9")]
		[Address(RVA = "0xABECD8", Offset = "0xABECD8", VA = "0xABECD8")]
		internal void _003C_003Em__38F()
		{
		}
	}

	[Token(Token = "0x2000E21")]
	private sealed class _003CAppendStallItemInfoToShopListIfPointShop_003Ec__AnonStorey1D6
	{
		[Token(Token = "0x4004A1B")]
		[FieldOffset(Offset = "0x8")]
		internal List<CSShopItem> removeList;

		[Token(Token = "0x60068EA")]
		[Address(RVA = "0xABCDE4", Offset = "0xABCDE4", VA = "0xABCDE4")]
		public _003CAppendStallItemInfoToShopListIfPointShop_003Ec__AnonStorey1D6()
		{
		}

		[Token(Token = "0x60068EB")]
		[Address(RVA = "0xABEC38", Offset = "0xABEC38", VA = "0xABEC38")]
		internal bool _003C_003Em__391(CSShopItem x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4004A00")]
	[FieldOffset(Offset = "0x10")]
	public XWiget_GridBuilder gridTab;

	[Token(Token = "0x4004A01")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView scrollView;

	[Token(Token = "0x4004A02")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_Button btnChargeDailyBox;

	[Token(Token = "0x4004A03")]
	[FieldOffset(Offset = "0x1C")]
	public XWidget_CashBuyInfo cashBuyInfo;

	[Token(Token = "0x4004A04")]
	[FieldOffset(Offset = "0x20")]
	private XWidget_StallChargeConfirm m_chargePopup;

	[Token(Token = "0x4004A05")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string PATH_PACKAGE_DETAILPOPUP;

	[Token(Token = "0x4004A06")]
	[FieldOffset(Offset = "0x24")]
	private XWidget_PackageDetailPopup m_widgetPackageDetailPopup;

	[Token(Token = "0x4004A07")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblDailyBoxResetTime;

	[Token(Token = "0x4004A08")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblSoldOut;

	[Token(Token = "0x4004A09")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<ShopSubCategory, List<CSShopItem>> m_shopList;

	[Token(Token = "0x4004A0A")]
	[FieldOffset(Offset = "0x34")]
	protected Dictionary<ShopSubCategory, int> m_tabIndex;

	[Token(Token = "0x4004A0B")]
	[FieldOffset(Offset = "0x38")]
	public Action<ShopSubCategory> onClickTab;

	[Token(Token = "0x4004A0C")]
	[FieldOffset(Offset = "0x3C")]
	protected ShopItemCategory m_category;

	[Token(Token = "0x4004A0D")]
	[FieldOffset(Offset = "0x40")]
	protected ShopSubCategory m_subCategory;

	[Token(Token = "0x4004A0E")]
	[FieldOffset(Offset = "0x44")]
	private XWidget_ToggleTab[] m_tabs;

	[Token(Token = "0x4004A0F")]
	[FieldOffset(Offset = "0x48")]
	public XListView_Shop listView;

	[Token(Token = "0x4004A10")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 BackupPosition;

	[Token(Token = "0x4004A11")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 BackupOffset;

	[Token(Token = "0x4004A12")]
	[FieldOffset(Offset = "0x64")]
	private StallShopLogicBase stallLogic;

	[Token(Token = "0x4004A13")]
	[FieldOffset(Offset = "0x68")]
	public XWidget_ItemDetailToolTip stallItemDetail;

	[Token(Token = "0x4004A14")]
	[FieldOffset(Offset = "0x6C")]
	private XUIShopItem SelectedItem__BackingField;

	[Token(Token = "0x4004A15")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<CSShopItem> _003C_003Ef__am_0024cache15;

	[Token(Token = "0x17000D86")]
	protected XWidget_StallChargeConfirm chargePopup
	{
		[Token(Token = "0x60068BF")]
		[Address(RVA = "0xABABB4", Offset = "0xABABB4", VA = "0xABABB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D87")]
	private XWidget_PackageDetailPopup widgetPackageDetailPopup
	{
		[Token(Token = "0x60068C0")]
		[Address(RVA = "0xABAE70", Offset = "0xABAE70", VA = "0xABAE70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D88")]
	public ShopSubCategory SubCategory
	{
		[Token(Token = "0x60068C1")]
		[Address(RVA = "0xABAFC0", Offset = "0xABAFC0", VA = "0xABAFC0")]
		get
		{
			return default(ShopSubCategory);
		}
	}

	[Token(Token = "0x17000D89")]
	public XUIShopItem SelectedItem
	{
		[Token(Token = "0x60068C2")]
		[Address(RVA = "0xABAFC8", Offset = "0xABAFC8", VA = "0xABAFC8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60068C3")]
		[Address(RVA = "0xABAFD0", Offset = "0xABAFD0", VA = "0xABAFD0")]
		private set
		{
		}
	}

	[Token(Token = "0x60068BC")]
	[Address(RVA = "0xABA7C0", Offset = "0xABA7C0", VA = "0xABA7C0")]
	public XPanel_Shop()
	{
	}

	[Token(Token = "0x60068BE")]
	[Address(RVA = "0xABA978", Offset = "0xABA978", VA = "0xABA978", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x60068C4")]
	[Address(RVA = "0xABAFD8", Offset = "0xABAFD8", VA = "0xABAFD8")]
	private void BackupScrollView()
	{
	}

	[Token(Token = "0x60068C5")]
	[Address(RVA = "0xABB19C", Offset = "0xABB19C", VA = "0xABB19C")]
	private void RestoreScrollView()
	{
	}

	[Token(Token = "0x60068C6")]
	[Address(RVA = "0xABB350", Offset = "0xABB350", VA = "0xABB350", Slot = "19")]
	protected virtual void Show()
	{
	}

	[Token(Token = "0x60068C7")]
	[Address(RVA = "0xABB4D8", Offset = "0xABB4D8", VA = "0xABB4D8")]
	public void RefreshShopList()
	{
	}

	[Token(Token = "0x60068C8")]
	[Address(RVA = "0xABB520", Offset = "0xABB520", VA = "0xABB520")]
	protected bool IsStallShop(ShopItemCategory category)
	{
		return default(bool);
	}

	[Token(Token = "0x60068C9")]
	[Address(RVA = "0xABB5D0", Offset = "0xABB5D0", VA = "0xABB5D0")]
	public void Show(ShopItemCategory category, ShopSubCategory subCategory = ShopSubCategory.None)
	{
	}

	[Token(Token = "0x60068CA")]
	[Address(RVA = "0xABB6E4", Offset = "0xABB6E4", VA = "0xABB6E4", Slot = "20")]
	public virtual void Build()
	{
	}

	[Token(Token = "0x60068CB")]
	[Address(RVA = "0xABBF30", Offset = "0xABBF30", VA = "0xABBF30")]
	public void OnClickTab(int index)
	{
	}

	[Token(Token = "0x60068CC")]
	[Address(RVA = "0xABB4FC", Offset = "0xABB4FC", VA = "0xABB4FC")]
	public void BuildListAndRetainScrollPosition()
	{
	}

	[Token(Token = "0x60068CD")]
	[Address(RVA = "0xABBF84", Offset = "0xABBF84", VA = "0xABBF84")]
	public void BuildList()
	{
	}

	[Token(Token = "0x60068CE")]
	[Address(RVA = "0xABC0E0", Offset = "0xABC0E0", VA = "0xABC0E0")]
	protected XWidget_ToggleTab GetTab(ShopSubCategory subCatecory)
	{
		return null;
	}

	[Token(Token = "0x60068CF")]
	[Address(RVA = "0xABC1F4", Offset = "0xABC1F4", VA = "0xABC1F4", Slot = "21")]
	public virtual void BuildList(ShopSubCategory subCategory, bool forced = false)
	{
	}

	[Token(Token = "0x60068D0")]
	[Address(RVA = "0xABCCAC", Offset = "0xABCCAC", VA = "0xABCCAC")]
	private void BuildActiveCashBuyInfo()
	{
	}

	[Token(Token = "0x60068D1")]
	[Address(RVA = "0xABC8E0", Offset = "0xABC8E0", VA = "0xABC8E0")]
	private void AppendStallItemInfoToShopListIfPointShop(List<CSShopItem> list)
	{
	}

	[Token(Token = "0x60068D2")]
	[Address(RVA = "0xABCDEC", Offset = "0xABCDEC", VA = "0xABCDEC")]
	private void TryGetStallItemNameAndIcon(Netdata_StallItem stall, out string name, out string icon)
	{
		icon = default;
		name = default;
	}

	[Token(Token = "0x60068D3")]
	[Address(RVA = "0xABCF18", Offset = "0xABCF18", VA = "0xABCF18", Slot = "22")]
	protected virtual void BuildItem(ShopSubCategory subCategory, List<CSShopItem> list, List<CSShopItem> listFiltered, bool hasChargeItem, bool hasChargableItem, Dictionary<int, RotationItemSet> rotationItemSet)
	{
	}

	[Token(Token = "0x60068D4")]
	[Address(RVA = "0xABD3BC", Offset = "0xABD3BC", VA = "0xABD3BC")]
	private void SortList(List<CSShopItem> listFiltered)
	{
	}

	[Token(Token = "0x60068D5")]
	[Address(RVA = "0xABD894", Offset = "0xABD894", VA = "0xABD894")]
	public void CheckTabNewBadge()
	{
	}

	[Token(Token = "0x60068D6")]
	[Address(RVA = "0xABD7F0", Offset = "0xABD7F0", VA = "0xABD7F0")]
	[DebuggerHidden]
	private IEnumerator RefreshTimeOnSec()
	{
		return null;
	}

	[Token(Token = "0x60068D7")]
	[Address(RVA = "0xABDEA8", Offset = "0xABDEA8", VA = "0xABDEA8", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x60068D8")]
	[Address(RVA = "0xABDF0C", Offset = "0xABDF0C", VA = "0xABDF0C", Slot = "23")]
	protected virtual void RefreshShopItemList()
	{
	}

	[Token(Token = "0x60068D9")]
	[Address(RVA = "0xABE5A8", Offset = "0xABE5A8", VA = "0xABE5A8")]
	private void RefreshDailyBoxResetTime()
	{
	}

	[Token(Token = "0x60068DA")]
	[Address(RVA = "0xABE888", Offset = "0xABE888", VA = "0xABE888")]
	public void OnClickShowStallItemDetail(XItem item)
	{
	}

	[Token(Token = "0x60068DB")]
	[Address(RVA = "0xABE9F8", Offset = "0xABE9F8", VA = "0xABE9F8")]
	public void OnClick_Help_NormalShop()
	{
	}

	[Token(Token = "0x60068DC")]
	[Address(RVA = "0xABEAD0", Offset = "0xABEAD0", VA = "0xABEAD0")]
	public void ShowPackageDetailPopup(string strTitle, int detailID)
	{
	}

	[Token(Token = "0x60068DD")]
	[Address(RVA = "0xABEB0C", Offset = "0xABEB0C", VA = "0xABEB0C")]
	private bool _003CBuildActiveCashBuyInfo_003Em__390()
	{
		return default(bool);
	}

	[Token(Token = "0x60068DE")]
	[Address(RVA = "0xABEB20", Offset = "0xABEB20", VA = "0xABEB20")]
	private void _003CBuildItem_003Em__392()
	{
	}

	[Token(Token = "0x60068DF")]
	[Address(RVA = "0xABEB24", Offset = "0xABEB24", VA = "0xABEB24")]
	private void _003CBuildItem_003Em__393(string strTitle, int detailID)
	{
	}

	[Token(Token = "0x60068E0")]
	[Address(RVA = "0xABEB28", Offset = "0xABEB28", VA = "0xABEB28")]
	private void _003CBuildItem_003Em__394()
	{
	}

	[Token(Token = "0x60068E1")]
	[Address(RVA = "0xABEC04", Offset = "0xABEC04", VA = "0xABEC04")]
	private static int _003CSortList_003Em__395(CSShopItem a, CSShopItem b)
	{
		return default(int);
	}
}
