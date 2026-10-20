using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2000F8F")]
public class XWidget_Inventory : XUIBaseWidget
{
	[Token(Token = "0x2000F90")]
	private sealed class _003CShowPromotionPopup_003Ec__AnonStorey238
	{
		[Token(Token = "0x400525E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal int beforeRandomOptionCount;

		[Token(Token = "0x400525F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_Inventory _003C_003Ef__this;

		[Token(Token = "0x600740A")]
		[Address(RVA = "0x144C724", Offset = "0x144C724", VA = "0x144C724")]
		public _003CShowPromotionPopup_003Ec__AnonStorey238()
		{
		}

		[Token(Token = "0x600740B")]
		[Address(RVA = "0x144F4E8", Offset = "0x144F4E8", VA = "0x144F4E8")]
		internal void _003C_003Em__4AB(XItem resultItem)
		{
		}
	}

	[Token(Token = "0x2000F91")]
	private sealed class _003CWarningPopupShow_003Ec__AnonStorey239
	{
		[Token(Token = "0x4005260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal XItem item;

		[Token(Token = "0x4005261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_Inventory _003C_003Ef__this;

		[Token(Token = "0x600740C")]
		[Address(RVA = "0x144D990", Offset = "0x144D990", VA = "0x144D990")]
		public _003CWarningPopupShow_003Ec__AnonStorey239()
		{
		}

		[Token(Token = "0x600740D")]
		[Address(RVA = "0x14500E0", Offset = "0x14500E0", VA = "0x14500E0")]
		internal void _003C_003Em__4B0()
		{
		}

		[Token(Token = "0x600740E")]
		[Address(RVA = "0x1450228", Offset = "0x1450228", VA = "0x1450228")]
		internal void _003C_003Em__4B1()
		{
		}
	}

	[Token(Token = "0x2000F92")]
	private sealed class _003CSellItem_003Ec__AnonStorey23A
	{
		[Token(Token = "0x4005262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string sellIID;

		[Token(Token = "0x4005263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XItem item;

		[Token(Token = "0x4005264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal XWidget_Inventory _003C_003Ef__this;

		[Token(Token = "0x600740F")]
		[Address(RVA = "0x144DC54", Offset = "0x144DC54", VA = "0x144DC54")]
		public _003CSellItem_003Ec__AnonStorey23A()
		{
		}

		[Token(Token = "0x6007410")]
		[Address(RVA = "0x144EF98", Offset = "0x144EF98", VA = "0x144EF98")]
		internal void _003C_003Em__4B2(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000F93")]
	private sealed class _003CCraft_003Ec__AnonStorey23B
	{
		[Token(Token = "0x4005265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string itemIID;

		[Token(Token = "0x4005266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_Inventory _003C_003Ef__this;

		[Token(Token = "0x6007411")]
		[Address(RVA = "0x144DF88", Offset = "0x144DF88", VA = "0x144DF88")]
		public _003CCraft_003Ec__AnonStorey23B()
		{
		}

		[Token(Token = "0x6007412")]
		[Address(RVA = "0x144E8D4", Offset = "0x144E8D4", VA = "0x144E8D4")]
		internal void _003C_003Em__4B3(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000F94")]
	private sealed class _003CUseGacha_003Ec__AnonStorey23C
	{
		[Token(Token = "0x4005267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string useItemIID;

		[Token(Token = "0x4005268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_Inventory _003C_003Ef__this;

		[Token(Token = "0x6007413")]
		[Address(RVA = "0x144E29C", Offset = "0x144E29C", VA = "0x144E29C")]
		public _003CUseGacha_003Ec__AnonStorey23C()
		{
		}

		[Token(Token = "0x6007414")]
		[Address(RVA = "0x144F524", Offset = "0x144F524", VA = "0x144F524")]
		internal void _003C_003Em__4B4(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x2000F95")]
	private sealed class _003CUsePeriodSkinCard_003Ec__AnonStorey23D
	{
		[Token(Token = "0x4005269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string useItemIID;

		[Token(Token = "0x400526A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		internal XWidget_Inventory _003C_003Ef__this;

		[Token(Token = "0x6007415")]
		[Address(RVA = "0x144E5B0", Offset = "0x144E5B0", VA = "0x144E5B0")]
		public _003CUsePeriodSkinCard_003Ec__AnonStorey23D()
		{
		}

		[Token(Token = "0x6007416")]
		[Address(RVA = "0x144FA28", Offset = "0x144FA28", VA = "0x144FA28")]
		internal void _003C_003Em__4B5(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
		{
		}
	}

	[Token(Token = "0x4005229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private readonly string Path_FusionEquip;

	[Token(Token = "0x400522A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string Path_OptChange;

	[Token(Token = "0x400522B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private readonly string Path_PromoEquip;

	[Token(Token = "0x400522C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string Path_RefineEquip;

	[Token(Token = "0x400522D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private readonly string Path_TransEquip;

	[Token(Token = "0x400522E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string Path_AutoEquip;

	[Token(Token = "0x400522F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private readonly string Path_EquipResult;

	[Token(Token = "0x4005230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string Path_InputSellbox;

	[Token(Token = "0x4005231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private readonly string Path_UseExpBox;

	[Token(Token = "0x4005232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly string Path_MultiSel;

	[Token(Token = "0x4005233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private readonly string Path_Unequip;

	[Token(Token = "0x4005234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly string Path_Warning;

	[Token(Token = "0x4005235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private readonly string Path_CraftInputBox;

	[Token(Token = "0x4005236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly string Path_UseInputBox;

	[Token(Token = "0x4005237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private XWidget_FusionEquip _fusionEquip;

	[Token(Token = "0x4005238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XWidget_OptionChange _optionChange;

	[Token(Token = "0x4005239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private XWidget_PromotionEquip _promotionEquip;

	[Token(Token = "0x400523A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private XWidget_RefineEquip _refineEquip;

	[Token(Token = "0x400523B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private XWidget_TranscendenceEquip _transcendenceEquip;

	[Token(Token = "0x400523C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private XWidget_AutoEquip _autoEquip;

	[Token(Token = "0x400523D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private XWidget_EquipmentResult _equipResult;

	[Token(Token = "0x400523E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private XWidget_SellInputBox _inputSellBox;

	[Token(Token = "0x400523F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private XWidget_MultipleSellBox _multipleSellBox;

	[Token(Token = "0x4005240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private XWidget_RefineWarning _warningPopup;

	[Token(Token = "0x4005241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private XWidget_OptionChangeCheckPopup m_optionChangeCheckPopup;

	[Token(Token = "0x4005242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private XWidget_CraftInputBox _craftInputBox;

	[Token(Token = "0x4005243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private XWidget_UseInputBox _useInputBox;

	[Token(Token = "0x4005244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly string Path_Inventory;

	[Token(Token = "0x4005245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	private Transform leftRoot;

	[Token(Token = "0x4005246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public XWidget_InvenItemDetail m_itemDetailPopup;

	[Token(Token = "0x4005247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XModuleActor m_character;

	[Token(Token = "0x4005248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public InventoryModeType inventoryModeType;

	[Token(Token = "0x4005249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private ItemGroupType m_itemGroupType;

	[Token(Token = "0x400524A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public XWidget_ToggleTab[] mainTabs;

	[Token(Token = "0x400524B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public XUIInvenItemList invenItemList;

	[Token(Token = "0x400524C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public UIButton btnInvenExtend;

	[Token(Token = "0x400524D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public UISprite sprInvenExtend;

	[Token(Token = "0x400524E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public UILabel lblSellCnt;

	[Token(Token = "0x400524F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public XWidget_TweenCost tweenSellPrice;

	[Token(Token = "0x4005250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public GameObject badgeAll;

	[Token(Token = "0x4005251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject badgeWeapon;

	[Token(Token = "0x4005252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public GameObject badgeArmor;

	[Token(Token = "0x4005253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject badgeAccessory;

	[Token(Token = "0x4005254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public GameObject badgeEtc;

	[Token(Token = "0x4005255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Action m_onRefresh;

	[Token(Token = "0x4005256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public Action<EquipmentSlot> m_onEquip;

	[Token(Token = "0x4005257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public XWidget_Button btnEnterMultiSell;

	[Token(Token = "0x4005258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public XWidget_Button btnAutoEquip;

	[Token(Token = "0x4005259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public XWidget_Button btnIllustratBook;

	[Token(Token = "0x400525A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public XWidget_Button btnConfirmMultiSell;

	[Token(Token = "0x400525B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject goSellBtns;

	[Token(Token = "0x400525C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	public UIButton ui_BtnAutoEquip;

	[Token(Token = "0x400525D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public readonly string expPotionSoundKey;

	[Token(Token = "0x17000EBF")]
	public XWidget_FusionEquip fusionEquip
	{
		[Token(Token = "0x60073BD")]
		[Address(RVA = "0x144A000", Offset = "0x144A000", VA = "0x144A000")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC0")]
	public XWidget_OptionChange optionChange
	{
		[Token(Token = "0x60073BE")]
		[Address(RVA = "0x144A0F0", Offset = "0x144A0F0", VA = "0x144A0F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC1")]
	public XWidget_PromotionEquip promotionEquip
	{
		[Token(Token = "0x60073BF")]
		[Address(RVA = "0x144A1E0", Offset = "0x144A1E0", VA = "0x144A1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC2")]
	public XWidget_RefineEquip refineEquip
	{
		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x144A2D0", Offset = "0x144A2D0", VA = "0x144A2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC3")]
	public XWidget_TranscendenceEquip transcendenceEquip
	{
		[Token(Token = "0x60073C1")]
		[Address(RVA = "0x144A3C0", Offset = "0x144A3C0", VA = "0x144A3C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC4")]
	public XWidget_AutoEquip autoEquip
	{
		[Token(Token = "0x60073C2")]
		[Address(RVA = "0x144A4B0", Offset = "0x144A4B0", VA = "0x144A4B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC5")]
	public XWidget_EquipmentResult equipResult
	{
		[Token(Token = "0x60073C3")]
		[Address(RVA = "0x144A5B0", Offset = "0x144A5B0", VA = "0x144A5B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC6")]
	public XWidget_SellInputBox inputSellBox
	{
		[Token(Token = "0x60073C4")]
		[Address(RVA = "0x144A6B0", Offset = "0x144A6B0", VA = "0x144A6B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC7")]
	public XWidget_MultipleSellBox multipleSellBox
	{
		[Token(Token = "0x60073C5")]
		[Address(RVA = "0x144A7B0", Offset = "0x144A7B0", VA = "0x144A7B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC8")]
	public XWidget_RefineWarning warningPopup
	{
		[Token(Token = "0x60073C6")]
		[Address(RVA = "0x144A8B0", Offset = "0x144A8B0", VA = "0x144A8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EC9")]
	public XWidget_OptionChangeCheckPopup optionChangeCheckPopup
	{
		[Token(Token = "0x60073C7")]
		[Address(RVA = "0x144A9B0", Offset = "0x144A9B0", VA = "0x144A9B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ECA")]
	public XWidget_CraftInputBox craftInputBox
	{
		[Token(Token = "0x60073C8")]
		[Address(RVA = "0x144AB00", Offset = "0x144AB00", VA = "0x144AB00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ECB")]
	public XWidget_UseInputBox useInputBox
	{
		[Token(Token = "0x60073C9")]
		[Address(RVA = "0x144AC00", Offset = "0x144AC00", VA = "0x144AC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60073BA")]
	[Address(RVA = "0x1449C48", Offset = "0x1449C48", VA = "0x1449C48")]
	public XWidget_Inventory()
	{
	}

	[Token(Token = "0x60073BC")]
	[Address(RVA = "0x1449E7C", Offset = "0x1449E7C", VA = "0x1449E7C", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x60073CA")]
	[Address(RVA = "0x144AD00", Offset = "0x144AD00", VA = "0x144AD00")]
	private void OnNetdataUpdated_Userdata()
	{
	}

	[Token(Token = "0x60073CB")]
	[Address(RVA = "0x144AEDC", Offset = "0x144AEDC", VA = "0x144AEDC")]
	public void SetRefreshAction(Action refresh)
	{
	}

	[Token(Token = "0x60073CC")]
	[Address(RVA = "0x144AEE4", Offset = "0x144AEE4", VA = "0x144AEE4")]
	public void SetOnEquipAction(Action<EquipmentSlot> onEquip)
	{
	}

	[Token(Token = "0x60073CD")]
	[Address(RVA = "0x144AEEC", Offset = "0x144AEEC", VA = "0x144AEEC")]
	private void OnNetdataUpdated_ItemData(object arg)
	{
	}

	[Token(Token = "0x60073CE")]
	[Address(RVA = "0x144B204", Offset = "0x144B204", VA = "0x144B204")]
	public void UnitTestAllHide()
	{
	}

	[Token(Token = "0x60073CF")]
	[Address(RVA = "0x144B4DC", Offset = "0x144B4DC", VA = "0x144B4DC")]
	public void Refresh(XModuleActor character)
	{
	}

	[Token(Token = "0x60073D0")]
	[Address(RVA = "0x144B624", Offset = "0x144B624", VA = "0x144B624")]
	public void Build(XModuleActor character, Transform leftRoot, [Optional] XWidget_InvenItemDetail detailPopup)
	{
	}

	[Token(Token = "0x60073D1")]
	[Address(RVA = "0x144BE38", Offset = "0x144BE38", VA = "0x144BE38")]
	private bool IsCharacterNotOwned()
	{
		return default(bool);
	}

	[Token(Token = "0x60073D2")]
	[Address(RVA = "0x144BE48", Offset = "0x144BE48", VA = "0x144BE48")]
	public void HideInvenDetail()
	{
	}

	[Token(Token = "0x60073D3")]
	[Address(RVA = "0x144BF48", Offset = "0x144BF48", VA = "0x144BF48")]
	public void BuildList()
	{
	}

	[Token(Token = "0x60073D4")]
	[Address(RVA = "0x144C034", Offset = "0x144C034", VA = "0x144C034")]
	public void ShowTestList()
	{
	}

	[Token(Token = "0x60073D5")]
	[Address(RVA = "0x144C114", Offset = "0x144C114", VA = "0x144C114")]
	private void BuildList(ItemGroupType type)
	{
	}

	[Token(Token = "0x60073D6")]
	[Address(RVA = "0x1449F9C", Offset = "0x1449F9C", VA = "0x1449F9C")]
	private void ChangeInventoryMode(InventoryModeType inventoryModeType)
	{
	}

	[Token(Token = "0x60073D7")]
	[Address(RVA = "0x144B4FC", Offset = "0x144B4FC", VA = "0x144B4FC")]
	private void RefreshModeBtn()
	{
	}

	[Token(Token = "0x60073D8")]
	[Address(RVA = "0x144AD38", Offset = "0x144AD38", VA = "0x144AD38")]
	private void CheckInvenSlotCount()
	{
	}

	[Token(Token = "0x60073D9")]
	[Address(RVA = "0x144B100", Offset = "0x144B100", VA = "0x144B100")]
	public void RefreshList()
	{
	}

	[Token(Token = "0x60073DA")]
	[Address(RVA = "0x144BBBC", Offset = "0x144BBBC", VA = "0x144BBBC")]
	private void RefreshMainTabBadges()
	{
	}

	[Token(Token = "0x60073DB")]
	[Address(RVA = "0x144C280", Offset = "0x144C280", VA = "0x144C280")]
	private bool RefreshItemDisappear(XItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x60073DC")]
	[Address(RVA = "0x1447994", Offset = "0x1447994", VA = "0x1447994")]
	public void ShowSellBox(XItem item)
	{
	}

	[Token(Token = "0x60073DD")]
	[Address(RVA = "0x1447C18", Offset = "0x1447C18", VA = "0x1447C18")]
	public void ShowCraftPopup(XItem item)
	{
	}

	[Token(Token = "0x60073DE")]
	[Address(RVA = "0x1447D30", Offset = "0x1447D30", VA = "0x1447D30")]
	public void ShowUseGachaPopup(XItem item)
	{
	}

	[Token(Token = "0x60073DF")]
	[Address(RVA = "0x1447E48", Offset = "0x1447E48", VA = "0x1447E48")]
	public void ShowUsePeriodSkinCardPopup(XItem item, bool isAlreadyUsed)
	{
	}

	[Token(Token = "0x60073E0")]
	[Address(RVA = "0x144C390", Offset = "0x144C390", VA = "0x144C390")]
	private void ChangeMainTab()
	{
	}

	[Token(Token = "0x60073E1")]
	[Address(RVA = "0x1447210", Offset = "0x1447210", VA = "0x1447210")]
	public void ShowRefinePopup(XItem item)
	{
	}

	[Token(Token = "0x60073E2")]
	[Address(RVA = "0x1447618", Offset = "0x1447618", VA = "0x1447618")]
	public void ShowFusionPopup([Optional] XItem item)
	{
	}

	[Token(Token = "0x60073E3")]
	[Address(RVA = "0x1446D40", Offset = "0x1446D40", VA = "0x1446D40")]
	public void ShowPromotionPopup([Optional] XItem item)
	{
	}

	[Token(Token = "0x60073E4")]
	[Address(RVA = "0x144C72C", Offset = "0x144C72C", VA = "0x144C72C")]
	public void RefreshInvenItemList()
	{
	}

	[Token(Token = "0x60073E5")]
	[Address(RVA = "0x144C764", Offset = "0x144C764", VA = "0x144C764")]
	public void ShowEquipmentResultPopup(XItem item, InventoryModeType invenType)
	{
	}

	[Token(Token = "0x60073E6")]
	[Address(RVA = "0x144C780", Offset = "0x144C780", VA = "0x144C780")]
	public void ShowEquipmentResultPopup(XItem item, InventoryModeType invenType, int beforeRandomOptionCount)
	{
	}

	[Token(Token = "0x60073E7")]
	[Address(RVA = "0x1446538", Offset = "0x1446538", VA = "0x1446538")]
	public void ShowTranscendencePopup([Optional] XItem item)
	{
	}

	[Token(Token = "0x60073E8")]
	[Address(RVA = "0x1446888", Offset = "0x1446888", VA = "0x1446888")]
	public void ShowOptionChangePopup(XItem item)
	{
	}

	[Token(Token = "0x60073E9")]
	[Address(RVA = "0x144C8D0", Offset = "0x144C8D0", VA = "0x144C8D0")]
	public void ShowOptionChangeCheck(XItem item, int changeIndex, int changeOptionID)
	{
	}

	[Token(Token = "0x60073EA")]
	[Address(RVA = "0x144CA50", Offset = "0x144CA50", VA = "0x144CA50")]
	public void ShowOptionChangeResult(XItem item, int changeIndex, List<int> prevOptions)
	{
	}

	[Token(Token = "0x60073EB")]
	[Address(RVA = "0x144CC94", Offset = "0x144CC94", VA = "0x144CC94")]
	public void ShowItemDetail(XItem item)
	{
	}

	[Token(Token = "0x60073EC")]
	[Address(RVA = "0x144CDA4", Offset = "0x144CDA4", VA = "0x144CDA4")]
	public void OnClick_IllustratedBook()
	{
	}

	[Token(Token = "0x60073ED")]
	[Address(RVA = "0x144CE78", Offset = "0x144CE78", VA = "0x144CE78")]
	public void OnClick_InvenExtend()
	{
	}

	[Token(Token = "0x60073EE")]
	[Address(RVA = "0x144CF4C", Offset = "0x144CF4C", VA = "0x144CF4C")]
	public void OnClick_ShowAllList()
	{
	}

	[Token(Token = "0x60073EF")]
	[Address(RVA = "0x144CF54", Offset = "0x144CF54", VA = "0x144CF54")]
	public void OnClick_ShowWeaponList()
	{
	}

	[Token(Token = "0x60073F0")]
	[Address(RVA = "0x144CF5C", Offset = "0x144CF5C", VA = "0x144CF5C")]
	public void OnClick_ShowArmorList()
	{
	}

	[Token(Token = "0x60073F1")]
	[Address(RVA = "0x144CF64", Offset = "0x144CF64", VA = "0x144CF64")]
	public void OnClick_ShowAccessoryList()
	{
	}

	[Token(Token = "0x60073F2")]
	[Address(RVA = "0x144CF6C", Offset = "0x144CF6C", VA = "0x144CF6C")]
	public void OnClick_ShowETCList()
	{
	}

	[Token(Token = "0x60073F3")]
	[Address(RVA = "0x144CF74", Offset = "0x144CF74", VA = "0x144CF74")]
	public void OnClick_PopupClose()
	{
	}

	[Token(Token = "0x60073F4")]
	[Address(RVA = "0x144CFA0", Offset = "0x144CFA0", VA = "0x144CFA0")]
	public void OnClick_EnterMultipleSell()
	{
	}

	[Token(Token = "0x60073F5")]
	[Address(RVA = "0x144D134", Offset = "0x144D134", VA = "0x144D134")]
	public void OnClick_CancelMultipleSell()
	{
	}

	[Token(Token = "0x60073F6")]
	[Address(RVA = "0x144D13C", Offset = "0x144D13C", VA = "0x144D13C")]
	public void OnClick_ConfirmMultipleSell()
	{
	}

	[Token(Token = "0x60073F7")]
	[Address(RVA = "0x144D3B8", Offset = "0x144D3B8", VA = "0x144D3B8")]
	public void OnClick_AutoEquip()
	{
	}

	[Token(Token = "0x60073F8")]
	[Address(RVA = "0x144D534", Offset = "0x144D534", VA = "0x144D534")]
	public void OnClick_AutoEquipForPet()
	{
	}

	[Token(Token = "0x60073F9")]
	[Address(RVA = "0x144CFFC", Offset = "0x144CFFC", VA = "0x144CFFC")]
	private void SetSellCount(int selectCnt)
	{
	}

	[Token(Token = "0x60073FA")]
	[Address(RVA = "0x144C3A8", Offset = "0x144C3A8", VA = "0x144C3A8")]
	public void RefreshModeUI()
	{
	}

	[Token(Token = "0x60073FB")]
	[Address(RVA = "0x144D2BC", Offset = "0x144D2BC", VA = "0x144D2BC")]
	public int GetTotalCost(List<XItem> sellList)
	{
		return default(int);
	}

	[Token(Token = "0x60073FC")]
	[Address(RVA = "0x144D6B0", Offset = "0x144D6B0", VA = "0x144D6B0")]
	public void WarningPopupShow(SelectRetType retType, XItem item)
	{
	}

	[Token(Token = "0x60073FD")]
	[Address(RVA = "0x144D998", Offset = "0x144D998", VA = "0x144D998")]
	public void SellItem(string sellIID, int itemID, int sellCnt)
	{
	}

	[Token(Token = "0x60073FE")]
	[Address(RVA = "0x144DC5C", Offset = "0x144DC5C", VA = "0x144DC5C")]
	public void Craft(string itemIID, int itemID, int craftCnt)
	{
	}

	[Token(Token = "0x60073FF")]
	[Address(RVA = "0x144DF90", Offset = "0x144DF90", VA = "0x144DF90")]
	public void UseGacha(string useItemIID, int itemID, int count)
	{
	}

	[Token(Token = "0x6007400")]
	[Address(RVA = "0x144E2A4", Offset = "0x144E2A4", VA = "0x144E2A4")]
	public void UsePeriodSkinCard(string useItemIID, int itemID, int count)
	{
	}

	[Token(Token = "0x6007401")]
	[Address(RVA = "0x144E5B8", Offset = "0x144E5B8", VA = "0x144E5B8")]
	private void _003CBuild_003Em__4A6()
	{
	}

	[Token(Token = "0x6007402")]
	[Address(RVA = "0x144E5BC", Offset = "0x144E5BC", VA = "0x144E5BC")]
	private void _003CBuild_003Em__4A7()
	{
	}

	[Token(Token = "0x6007403")]
	[Address(RVA = "0x144E5C0", Offset = "0x144E5C0", VA = "0x144E5C0")]
	private void _003CBuild_003Em__4A8(XItem item)
	{
	}

	[Token(Token = "0x6007404")]
	[Address(RVA = "0x144E5F8", Offset = "0x144E5F8", VA = "0x144E5F8")]
	private void _003CBuildList_003Em__4A9()
	{
	}

	[Token(Token = "0x6007405")]
	[Address(RVA = "0x144E600", Offset = "0x144E600", VA = "0x144E600")]
	private void _003CShowRefinePopup_003Em__4AA(XItem argItem)
	{
	}

	[Token(Token = "0x6007406")]
	[Address(RVA = "0x144E824", Offset = "0x144E824", VA = "0x144E824")]
	private void _003CShowTranscendencePopup_003Em__4AC(XItem resultItem)
	{
	}

	[Token(Token = "0x6007407")]
	[Address(RVA = "0x144E844", Offset = "0x144E844", VA = "0x144E844")]
	private void _003COnClick_ConfirmMultipleSell_003Em__4AD()
	{
	}

	[Token(Token = "0x6007408")]
	[Address(RVA = "0x144E864", Offset = "0x144E864", VA = "0x144E864")]
	private void _003COnClick_AutoEquip_003Em__4AE()
	{
	}

	[Token(Token = "0x6007409")]
	[Address(RVA = "0x144E89C", Offset = "0x144E89C", VA = "0x144E89C")]
	private void _003COnClick_AutoEquipForPet_003Em__4AF()
	{
	}
}
