using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

[Token(Token = "0x2000E22")]
public class XPanel_ShopBuy : XCommonBackUI
{
	[Token(Token = "0x2000E23")]
	private sealed class _003CRequestAndReceiveBuyShopItem_003Ec__AnonStorey1EA
	{
		[Token(Token = "0x2000E24")]
		private sealed class _003CRequestAndReceiveBuyShopItem_003Ec__AnonStorey1EB
		{
			[Token(Token = "0x4004A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Netdata_BuyShopItem acInfo;

			[Token(Token = "0x4004A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal Action rebuy;

			[Token(Token = "0x4004A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal _003CRequestAndReceiveBuyShopItem_003Ec__AnonStorey1EA _003C_003Ef__ref_0024490;

			[Token(Token = "0x600690F")]
			[Address(RVA = "0xAC39A8", Offset = "0xAC39A8", VA = "0xAC39A8")]
			public _003CRequestAndReceiveBuyShopItem_003Ec__AnonStorey1EB()
			{
			}

			[Token(Token = "0x6006910")]
			[Address(RVA = "0xAC39B0", Offset = "0xAC39B0", VA = "0xAC39B0")]
			internal void _003C_003Em__3C3()
			{
			}

			[Token(Token = "0x6006911")]
			[Address(RVA = "0xAC3AB4", Offset = "0xAC3AB4", VA = "0xAC3AB4")]
			internal void _003C_003Em__3C4()
			{
			}
		}

		[Token(Token = "0x4004A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal IShopItem item;

		[Token(Token = "0x4004A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal bool bBuyFree;

		[Token(Token = "0x4004A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_ShopBuy _003C_003Ef__this;

		[Token(Token = "0x600690D")]
		[Address(RVA = "0xAC2A44", Offset = "0xAC2A44", VA = "0xAC2A44")]
		public _003CRequestAndReceiveBuyShopItem_003Ec__AnonStorey1EA()
		{
		}

		[Token(Token = "0x600690E")]
		[Address(RVA = "0xAC32F4", Offset = "0xAC32F4", VA = "0xAC32F4")]
		internal void _003C_003Em__3BF(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E25")]
	private sealed class _003CRequestAndReceiveBuyStallShopItem_003Ec__AnonStorey1EC
	{
		[Token(Token = "0x4004A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal IShopItem stallItem;

		[Token(Token = "0x4004A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal bool bBuyFree;

		[Token(Token = "0x4004A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XPanel_ShopBuy _003C_003Ef__this;

		[Token(Token = "0x6006912")]
		[Address(RVA = "0xAC2DA4", Offset = "0xAC2DA4", VA = "0xAC2DA4")]
		public _003CRequestAndReceiveBuyStallShopItem_003Ec__AnonStorey1EC()
		{
		}

		[Token(Token = "0x6006913")]
		[Address(RVA = "0xAC3BB8", Offset = "0xAC3BB8", VA = "0xAC3BB8")]
		internal void _003C_003Em__3C0(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E26")]
	private sealed class _003CRequestAndReceiveBuyArenaShopItem_003Ec__AnonStorey1ED
	{
		[Token(Token = "0x4004A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal IShopItem shopItem;

		[Token(Token = "0x4004A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_ShopBuy _003C_003Ef__this;

		[Token(Token = "0x6006914")]
		[Address(RVA = "0xAC2DAC", Offset = "0xAC2DAC", VA = "0xAC2DAC")]
		public _003CRequestAndReceiveBuyArenaShopItem_003Ec__AnonStorey1ED()
		{
		}

		[Token(Token = "0x6006915")]
		[Address(RVA = "0xAC309C", Offset = "0xAC309C", VA = "0xAC309C")]
		internal void _003C_003Em__3C1(ApiReturnCode errno, string errmsg, JObject json)
		{
		}
	}

	[Token(Token = "0x2000E27")]
	private sealed class _003CSetTutorialObject_003Ec__AnonStorey1EE
	{
		[Token(Token = "0x4004A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string tutoObjKey;

		[Token(Token = "0x4004A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XPanel_ShopBuy _003C_003Ef__this;

		[Token(Token = "0x6006916")]
		[Address(RVA = "0xAC3090", Offset = "0xAC3090", VA = "0xAC3090")]
		public _003CSetTutorialObject_003Ec__AnonStorey1EE()
		{
		}

		[Token(Token = "0x6006917")]
		[Address(RVA = "0xAC4434", Offset = "0xAC4434", VA = "0xAC4434")]
		internal void _003C_003Em__3C2()
		{
		}
	}

	[Token(Token = "0x4004A1C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string Path_DetailConfirm;

	[Token(Token = "0x4004A1D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly string Path_NormalConfirm;

	[Token(Token = "0x4004A1E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string Path_BonusConfirm;

	[Token(Token = "0x4004A1F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private readonly string Path_BonusCashConfirm;

	[Token(Token = "0x4004A20")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string Path_PackageConfirm;

	[Token(Token = "0x4004A21")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private XWidget_ShopPackageBuyPopup _packagePopup;

	[Token(Token = "0x4004A22")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private XWidget_ShopNormalBuyPopup _normalPopup;

	[Token(Token = "0x4004A23")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private XWidget_ShopDetailBuyPopup _detailPopup;

	[Token(Token = "0x4004A24")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private XWidget_ShopBonusBuyPopup _bonusPopup;

	[Token(Token = "0x4004A25")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XWidget_ShopBonusBuyCashPopup _bonusCashPopup;

	[Token(Token = "0x4004A26")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool isOnButtonClick;

	[Token(Token = "0x4004A27")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool bBuyFree;

	[Token(Token = "0x4004A28")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private IShopItem m_Item;

	[Token(Token = "0x4004A29")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<int, RotationItemSet> m_rotationItemSet;

	[Token(Token = "0x4004A2A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public XTutorialObjContainer tutoContainer;

	[Token(Token = "0x4004A2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Action onBuyComplete;

	[Token(Token = "0x4004A2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XPanel_CardDirectionRoot cardDirectionRoot;

	[Token(Token = "0x4004A2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XPanel_PetDirectionRoot petDirectionRoot;

	[Token(Token = "0x4004A2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool m_buying;

	[Token(Token = "0x4004A2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool IsArenaShopItem__BackingField;

	[Token(Token = "0x17000D8C")]
	public static XPanel_ShopBuy Instance
	{
		[Token(Token = "0x60068ED")]
		[Address(RVA = "0xABEF98", Offset = "0xABEF98", VA = "0xABEF98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D8D")]
	public XWidget_ShopPackageBuyPopup PackagePopup
	{
		[Token(Token = "0x60068EE")]
		[Address(RVA = "0xABF0A4", Offset = "0xABF0A4", VA = "0xABF0A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D8E")]
	public XWidget_ShopNormalBuyPopup NormalPopup
	{
		[Token(Token = "0x60068EF")]
		[Address(RVA = "0xABF268", Offset = "0xABF268", VA = "0xABF268")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D8F")]
	public XWidget_ShopDetailBuyPopup DetailPopup
	{
		[Token(Token = "0x60068F0")]
		[Address(RVA = "0xABF42C", Offset = "0xABF42C", VA = "0xABF42C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D90")]
	public XWidget_ShopBonusBuyPopup BonusPopup
	{
		[Token(Token = "0x60068F1")]
		[Address(RVA = "0xABF5F0", Offset = "0xABF5F0", VA = "0xABF5F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D91")]
	public XWidget_ShopBonusBuyCashPopup BonusCashPopup
	{
		[Token(Token = "0x60068F2")]
		[Address(RVA = "0xABF7B4", Offset = "0xABF7B4", VA = "0xABF7B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D92")]
	public bool IsArenaShopItem
	{
		[Token(Token = "0x60068F3")]
		[Address(RVA = "0xABF978", Offset = "0xABF978", VA = "0xABF978")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60068F4")]
		[Address(RVA = "0xABF980", Offset = "0xABF980", VA = "0xABF980")]
		set
		{
		}
	}

	[Token(Token = "0x60068EC")]
	[Address(RVA = "0xABEEBC", Offset = "0xABEEBC", VA = "0xABEEBC")]
	public XPanel_ShopBuy()
	{
	}

	[Token(Token = "0x60068F5")]
	[Address(RVA = "0xABF988", Offset = "0xABF988", VA = "0xABF988")]
	private int GetShowBoxID(IShopItem item)
	{
		return default(int);
	}

	[Token(Token = "0x60068F6")]
	[Address(RVA = "0xABFAFC", Offset = "0xABFAFC", VA = "0xABFAFC")]
	private int GetRotationID(IShopItem item)
	{
		return default(int);
	}

	[Token(Token = "0x60068F7")]
	[Address(RVA = "0xABF9A8", Offset = "0xABF9A8", VA = "0xABF9A8")]
	private CSShopItem GetShopItemInfo(IShopItem item)
	{
		return null;
	}

	[Token(Token = "0x60068F8")]
	[Address(RVA = "0xABFB1C", Offset = "0xABFB1C", VA = "0xABFB1C")]
	public void Show(IShopItem item, Dictionary<int, RotationItemSet> rotationInfo, bool buyFree, Action buyAction)
	{
	}

	[Token(Token = "0x60068F9")]
	[Address(RVA = "0xAC0218", Offset = "0xAC0218", VA = "0xAC0218")]
	public void Build(IShopItem item, Dictionary<int, RotationItemSet> rotationInfo, bool buy_free, [Optional][DefaultParameterValue(false)] bool isItemDetailText, [Optional] Action onBuyComplete)
	{
	}

	[Token(Token = "0x60068FA")]
	[Address(RVA = "0xABFD2C", Offset = "0xABFD2C", VA = "0xABFD2C")]
	public void Build(IShopItem item, Dictionary<int, RotationItemSet> rotationInfo, bool buy_free, [Optional] Action buyAction, [Optional] Action closeAction, [Optional] Action completeAction)
	{
	}

	[Token(Token = "0x60068FB")]
	[Address(RVA = "0xAC0464", Offset = "0xAC0464", VA = "0xAC0464")]
	public void TryCheckShopBuyCondition(IShopItem item, bool bBuyFree, Action closeAction, out bool isStallItem, out bool isBuyavable)
	{
		isBuyavable = default;
		isStallItem = default;
	}

	[Token(Token = "0x60068FC")]
	[Address(RVA = "0xAC0FC4", Offset = "0xAC0FC4", VA = "0xAC0FC4")]
	private bool TryCheckBuyArenaShopItem(IShopItem shopItem, Action closeAction, out bool isBuyavable)
	{
		isBuyavable = default;
		return default(bool);
	}

	[Token(Token = "0x60068FD")]
	[Address(RVA = "0xAC1184", Offset = "0xAC1184", VA = "0xAC1184")]
	private void OnBuyComplete()
	{
	}

	[Token(Token = "0x60068FE")]
	[Address(RVA = "0xAC1198", Offset = "0xAC1198", VA = "0xAC1198")]
	public void OnButtonClick_Buy()
	{
	}

	[Token(Token = "0x60068FF")]
	[Address(RVA = "0xAC2600", Offset = "0xAC2600", VA = "0xAC2600")]
	private void Callback_CrystalPurchased(ApiReturnCode errno, string errmsg, JObject json)
	{
	}

	[Token(Token = "0x6006900")]
	[Address(RVA = "0xAC270C", Offset = "0xAC270C", VA = "0xAC270C")]
	private void Callback_CrystalPurchased(JObject json, string token)
	{
	}

	[Token(Token = "0x6006901")]
	[Address(RVA = "0xAC2984", Offset = "0xAC2984", VA = "0xAC2984")]
	private bool IsActor(ref Netdata_BuyShopItem acInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6006902")]
	[Address(RVA = "0xAC2200", Offset = "0xAC2200", VA = "0xAC2200")]
	private void RequestAndReceiveBuyShopItem(IShopItem item, bool bBuyFree = false)
	{
	}

	[Token(Token = "0x6006903")]
	[Address(RVA = "0xAC2A4C", Offset = "0xAC2A4C", VA = "0xAC2A4C")]
	private void BuildCharacterCardModel(CSContent reward, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6006904")]
	[Address(RVA = "0xAC2C00", Offset = "0xAC2C00", VA = "0xAC2C00")]
	private void BuildPetModel(CSContent reward, [Optional] Action directionEndAction)
	{
	}

	[Token(Token = "0x6006905")]
	[Address(RVA = "0xAC0B64", Offset = "0xAC0B64", VA = "0xAC0B64")]
	private void BuyShopItemRequestFail(ApiReturnCode errno, IShopItem item)
	{
	}

	[Token(Token = "0x6006906")]
	[Address(RVA = "0xAC1A30", Offset = "0xAC1A30", VA = "0xAC1A30")]
	private void RequestAndReceiveBuyStallShopItem(IShopItem stallItem, bool bBuyFree = false)
	{
	}

	[Token(Token = "0x6006907")]
	[Address(RVA = "0xAC1758", Offset = "0xAC1758", VA = "0xAC1758")]
	private void RequestAndReceiveBuyArenaShopItem(IShopItem shopItem)
	{
	}

	[Token(Token = "0x6006908")]
	[Address(RVA = "0xAC2DB4", Offset = "0xAC2DB4", VA = "0xAC2DB4")]
	public void OnClick_NotiPopupShow()
	{
	}

	[Token(Token = "0x6006909")]
	[Address(RVA = "0xAC212C", Offset = "0xAC212C", VA = "0xAC212C")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x600690A")]
	[Address(RVA = "0xAC2DB8", Offset = "0xAC2DB8", VA = "0xAC2DB8", Slot = "12")]
	public override void Hide()
	{
	}

	[Token(Token = "0x600690B")]
	[Address(RVA = "0xAC0348", Offset = "0xAC0348", VA = "0xAC0348")]
	private void SetTutorialObject()
	{
	}

	[Token(Token = "0x600690C")]
	[Address(RVA = "0xAC3098", Offset = "0xAC3098", VA = "0xAC3098")]
	private void _003COnButtonClick_Buy_003Em__3BE()
	{
	}
}
