using System;
using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using UnityEngine;

[Token(Token = "0x2001024")]
public class XUIInvenItem : MonoBehaviour
{
	[Token(Token = "0x4005696")]
	[FieldOffset(Offset = "0xC")]
	public string EquipmentDetailPopupSoundKey;

	[Token(Token = "0x4005697")]
	[FieldOffset(Offset = "0x10")]
	public Transform iconParent;

	[Token(Token = "0x4005698")]
	[FieldOffset(Offset = "0x14")]
	public UILabel lblItemName;

	[Token(Token = "0x4005699")]
	[FieldOffset(Offset = "0x18")]
	public GameObject badgeNew;

	[Token(Token = "0x400569A")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite sprDisable;

	[Token(Token = "0x400569B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite sprSelected;

	[Token(Token = "0x400569C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite sprCheck;

	[Token(Token = "0x400569D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject upStatRoot;

	[Token(Token = "0x400569E")]
	[FieldOffset(Offset = "0x2C")]
	public XWiget_GridBuilder gridMajorStat;

	[Token(Token = "0x400569F")]
	[FieldOffset(Offset = "0x30")]
	public Dictionary<string, XWidget_InvenItemStat> statLabels;

	[Token(Token = "0x40056A0")]
	[FieldOffset(Offset = "0x34")]
	public UISprite sprNameBG;

	[Token(Token = "0x40056A1")]
	[FieldOffset(Offset = "0x38")]
	public UISprite sprGrade;

	[Token(Token = "0x40056A2")]
	[FieldOffset(Offset = "0x3C")]
	public XItem m_item;

	[Token(Token = "0x40056A3")]
	[FieldOffset(Offset = "0x40")]
	private XWidget_ItemIcon m_icon;

	[Token(Token = "0x40056A4")]
	[FieldOffset(Offset = "0x44")]
	public int m_infoIndex;

	[Token(Token = "0x40056A5")]
	[FieldOffset(Offset = "0x48")]
	private bool m_selected;

	[Token(Token = "0x40056A6")]
	[FieldOffset(Offset = "0x4C")]
	public Action<XUIInvenItem> m_onClick;

	[Token(Token = "0x40056A7")]
	[FieldOffset(Offset = "0x50")]
	public Func<string, int> m_funcGetSelectCnt;

	[Token(Token = "0x40056A8")]
	[FieldOffset(Offset = "0x54")]
	private int limitItemNameLength;

	[Token(Token = "0x40056A9")]
	[FieldOffset(Offset = "0x58")]
	public UILabel lblUseStackCount;

	[Token(Token = "0x40056AA")]
	[FieldOffset(Offset = "0x5C")]
	private UIDragScrollView dragScrollView;

	[Token(Token = "0x40056AB")]
	[FieldOffset(Offset = "0x60")]
	private InventoryModeType InventoryModeType__BackingField;

	[Token(Token = "0x40056AC")]
	[FieldOffset(Offset = "0x0")]
	private static NetCallback _003C_003Ef__am_0024cache16;

	[Token(Token = "0x17000EFA")]
	public InventoryModeType InventoryModeType
	{
		[Token(Token = "0x600785C")]
		[Address(RVA = "0x1093630", Offset = "0x1093630", VA = "0x1093630")]
		get
		{
			return default(InventoryModeType);
		}
		[Token(Token = "0x600785D")]
		[Address(RVA = "0x1093638", Offset = "0x1093638", VA = "0x1093638")]
		private set
		{
		}
	}

	[Token(Token = "0x600785B")]
	[Address(RVA = "0x1093568", Offset = "0x1093568", VA = "0x1093568")]
	public XUIInvenItem()
	{
	}

	[Token(Token = "0x600785E")]
	[Address(RVA = "0x1093640", Offset = "0x1093640", VA = "0x1093640")]
	public void ChangeMode(InventoryModeType inventoryModeType)
	{
	}

	[Token(Token = "0x600785F")]
	[Address(RVA = "0x1093648", Offset = "0x1093648", VA = "0x1093648")]
	public bool IsSelected()
	{
		return default(bool);
	}

	[Token(Token = "0x6007860")]
	[Address(RVA = "0x1093650", Offset = "0x1093650", VA = "0x1093650")]
	public void SetGetSelectCntFunc(Func<string, int> func)
	{
	}

	[Token(Token = "0x6007861")]
	[Address(RVA = "0x1093658", Offset = "0x1093658", VA = "0x1093658")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007862")]
	[Address(RVA = "0x10936E0", Offset = "0x10936E0", VA = "0x10936E0")]
	public void Build(XItem item, int infoIndex, bool selected, Action<XUIInvenItem> onClick)
	{
	}

	[Token(Token = "0x6007863")]
	[Address(RVA = "0x10946FC", Offset = "0x10946FC", VA = "0x10946FC")]
	public void Refresh(bool isSelect)
	{
	}

	[Token(Token = "0x6007864")]
	[Address(RVA = "0x1094718", Offset = "0x1094718", VA = "0x1094718")]
	public void ClearStats()
	{
	}

	[Token(Token = "0x6007865")]
	[Address(RVA = "0x1093D74", Offset = "0x1093D74", VA = "0x1093D74")]
	private void BuildUpStat(XItem item)
	{
	}

	[Token(Token = "0x6007866")]
	[Address(RVA = "0x10944F0", Offset = "0x10944F0", VA = "0x10944F0")]
	private void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6007867")]
	[Address(RVA = "0x10945A0", Offset = "0x10945A0", VA = "0x10945A0")]
	private void SetDisable(bool isDisable)
	{
	}

	[Token(Token = "0x6007868")]
	[Address(RVA = "0x10945E4", Offset = "0x10945E4", VA = "0x10945E4")]
	private void RefreshStackCnt()
	{
	}

	[Token(Token = "0x6007869")]
	[Address(RVA = "0x10948A4", Offset = "0x10948A4", VA = "0x10948A4")]
	public void OnButtonClick_SelectItem()
	{
	}

	[Token(Token = "0x600786A")]
	[Address(RVA = "0x1094C8C", Offset = "0x1094C8C", VA = "0x1094C8C")]
	public XItem GetItem()
	{
		return null;
	}

	[Token(Token = "0x600786B")]
	[Address(RVA = "0x1094C94", Offset = "0x1094C94", VA = "0x1094C94")]
	public void OnClick()
	{
	}

	[Token(Token = "0x600786C")]
	[Address(RVA = "0x1094D38", Offset = "0x1094D38", VA = "0x1094D38")]
	public string GetMajorStatTextValue(string name)
	{
		return null;
	}

	[Token(Token = "0x600786D")]
	[Address(RVA = "0x1094E80", Offset = "0x1094E80", VA = "0x1094E80")]
	private static void _003COnButtonClick_SelectItem_003Em__504(ApiReturnCode nErrorCode, string strErrorMessage, JObject json)
	{
	}
}
