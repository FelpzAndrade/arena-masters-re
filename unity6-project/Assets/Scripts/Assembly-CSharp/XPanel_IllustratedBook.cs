using System.Collections.Generic;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DEF")]
public class XPanel_IllustratedBook : XUIBasePanel
{
	[Token(Token = "0x40048CE")]
	[FieldOffset(Offset = "0x10")]
	public XUIIllustratedBookList m_illustratedBook;

	[Token(Token = "0x40048CF")]
	[FieldOffset(Offset = "0x14")]
	private EquipmentSlot equipmentType;

	[Token(Token = "0x40048D0")]
	[FieldOffset(Offset = "0x18")]
	public XWidget_ToggleTab[] mainTabs;

	[Token(Token = "0x40048D1")]
	[FieldOffset(Offset = "0x1C")]
	public XWiget_GridBuilder gridSubTab;

	[Token(Token = "0x40048D2")]
	[FieldOffset(Offset = "0x20")]
	public UILabel lblName;

	[Token(Token = "0x40048D3")]
	[FieldOffset(Offset = "0x24")]
	public UILabel lblType;

	[Token(Token = "0x40048D4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel lblGrade;

	[Token(Token = "0x40048D5")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel lblPrice;

	[Token(Token = "0x40048D6")]
	[FieldOffset(Offset = "0x30")]
	public GameObject iconParent;

	[Token(Token = "0x40048D7")]
	[FieldOffset(Offset = "0x34")]
	private XWidget_ItemDetailToolTip bookDetail;

	[Token(Token = "0x40048D8")]
	[FieldOffset(Offset = "0x38")]
	private XItem m_item;

	[Token(Token = "0x40048D9")]
	[FieldOffset(Offset = "0x3C")]
	private CSItemInfo m_itemInfo;

	[Token(Token = "0x40048DA")]
	[FieldOffset(Offset = "0x40")]
	private ItemRarity tempRarity;

	[Token(Token = "0x40048DB")]
	[FieldOffset(Offset = "0x44")]
	public GameObject objGroup;

	[Token(Token = "0x40048DC")]
	[FieldOffset(Offset = "0x48")]
	public UIButton btnClose;

	[Token(Token = "0x40048DD")]
	[FieldOffset(Offset = "0x4C")]
	public List<UIButton> btnLV;

	[Token(Token = "0x6006714")]
	[Address(RVA = "0xFF5D64", Offset = "0xFF5D64", VA = "0xFF5D64")]
	public XPanel_IllustratedBook()
	{
	}

	[Token(Token = "0x6006715")]
	[Address(RVA = "0xFF5D6C", Offset = "0xFF5D6C", VA = "0xFF5D6C", Slot = "16")]
	public override bool Back()
	{
		return default(bool);
	}

	[Token(Token = "0x6006716")]
	[Address(RVA = "0xFF5ECC", Offset = "0xFF5ECC", VA = "0xFF5ECC")]
	public void Show()
	{
	}

	[Token(Token = "0x6006717")]
	[Address(RVA = "0xFF5F00", Offset = "0xFF5F00", VA = "0xFF5F00")]
	public void Build()
	{
	}

	[Token(Token = "0x6006718")]
	[Address(RVA = "0xFF5F44", Offset = "0xFF5F44", VA = "0xFF5F44")]
	public void BuildList()
	{
	}

	[Token(Token = "0x6006719")]
	[Address(RVA = "0xFF5FC0", Offset = "0xFF5FC0", VA = "0xFF5FC0")]
	public void ShowWeaponList()
	{
	}

	[Token(Token = "0x600671A")]
	[Address(RVA = "0xFF5FC8", Offset = "0xFF5FC8", VA = "0xFF5FC8")]
	public void ShowArmorList()
	{
	}

	[Token(Token = "0x600671B")]
	[Address(RVA = "0xFF5FD0", Offset = "0xFF5FD0", VA = "0xFF5FD0")]
	public void ShowShoesList()
	{
	}

	[Token(Token = "0x600671C")]
	[Address(RVA = "0xFF5FD8", Offset = "0xFF5FD8", VA = "0xFF5FD8")]
	public void ShowGloveList()
	{
	}

	[Token(Token = "0x600671D")]
	[Address(RVA = "0xFF5FE0", Offset = "0xFF5FE0", VA = "0xFF5FE0")]
	public void ShowRingList()
	{
	}

	[Token(Token = "0x600671E")]
	[Address(RVA = "0xFF5FE8", Offset = "0xFF5FE8", VA = "0xFF5FE8")]
	public void ShowNecklaceList()
	{
	}

	[Token(Token = "0x600671F")]
	[Address(RVA = "0xFF5FF0", Offset = "0xFF5FF0", VA = "0xFF5FF0")]
	public void ShowBroochList()
	{
	}

	[Token(Token = "0x6006720")]
	[Address(RVA = "0xFF5FF8", Offset = "0xFF5FF8", VA = "0xFF5FF8")]
	public void ShowBraceletList()
	{
	}

	[Token(Token = "0x6006721")]
	[Address(RVA = "0xFF6000", Offset = "0xFF6000", VA = "0xFF6000")]
	public void ShowEarringList()
	{
	}

	[Token(Token = "0x6006722")]
	[Address(RVA = "0xFF5F4C", Offset = "0xFF5F4C", VA = "0xFF5F4C")]
	private void BuildTabList(EquipmentSlot type)
	{
	}

	[Token(Token = "0x6006723")]
	[Address(RVA = "0xFF6008", Offset = "0xFF6008", VA = "0xFF6008")]
	public void PopupOpen(CSItemInfo itemInfo)
	{
	}
}
