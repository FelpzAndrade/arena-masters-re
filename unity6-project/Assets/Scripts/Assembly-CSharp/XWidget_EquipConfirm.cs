using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000EC8")]
public class XWidget_EquipConfirm : MonoBehaviour
{
	[Token(Token = "0x4004DAD")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridStat;

	[Token(Token = "0x4004DAE")]
	[FieldOffset(Offset = "0x10")]
	public Transform curItemIconParent;

	[Token(Token = "0x4004DAF")]
	[FieldOffset(Offset = "0x14")]
	public UILabel curItemName;

	[Token(Token = "0x4004DB0")]
	[FieldOffset(Offset = "0x18")]
	public Transform newItemIconParent;

	[Token(Token = "0x4004DB1")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel newItemName;

	[Token(Token = "0x4004DB2")]
	[FieldOffset(Offset = "0x20")]
	protected Action m_action;

	[Token(Token = "0x4004DB3")]
	[FieldOffset(Offset = "0x24")]
	protected XWidget_ItemIcon m_curItemIcon;

	[Token(Token = "0x4004DB4")]
	[FieldOffset(Offset = "0x28")]
	protected XWidget_ItemIcon m_newItemIcon;

	[Token(Token = "0x6006E27")]
	[Address(RVA = "0x15F6318", Offset = "0x15F6318", VA = "0x15F6318")]
	public XWidget_EquipConfirm()
	{
	}

	[Token(Token = "0x6006E28")]
	[Address(RVA = "0x15F6320", Offset = "0x15F6320", VA = "0x15F6320")]
	public void Awake()
	{
	}

	[Token(Token = "0x6006E29")]
	[Address(RVA = "0x15F64C8", Offset = "0x15F64C8", VA = "0x15F64C8")]
	public void Show(XItem curItem, XItem newItem)
	{
	}

	[Token(Token = "0x6006E2A")]
	[Address(RVA = "0x15F69BC", Offset = "0x15F69BC", VA = "0x15F69BC")]
	public void Hide()
	{
	}
}
