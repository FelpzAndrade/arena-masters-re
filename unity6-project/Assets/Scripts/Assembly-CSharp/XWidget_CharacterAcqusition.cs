using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F71")]
public class XWidget_CharacterAcqusition : XUIBaseWidget
{
	[Token(Token = "0x400515D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UILabel lblTitle;

	[Token(Token = "0x400515E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UILabel lblComment;

	[Token(Token = "0x400515F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UIButton btnOk;

	[Token(Token = "0x4005160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform charIconParent;

	[Token(Token = "0x4005161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private XWidget_ContentIcon _characterIcon;

	[Token(Token = "0x4005162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject firstPlus;

	[Token(Token = "0x4005163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GameObject secondPlus;

	[Token(Token = "0x4005164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform itemIconParent;

	[Token(Token = "0x4005165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private XWidget_ContentIcon _itemIcon;

	[Token(Token = "0x4005166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UILabel lblQuantity;

	[Token(Token = "0x4005167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public UIGrid grid;

	[Token(Token = "0x4005168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject getCharCostObj;

	[Token(Token = "0x4005169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GameObject getCharGoldIconObj;

	[Token(Token = "0x400516A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject getCharCrystalIconObj;

	[Token(Token = "0x400516B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public UILabel lblGetCharQuantity;

	[Token(Token = "0x400516C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected Action m_onClick;

	[Token(Token = "0x400516D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected XModuleActor m_character;

	[Token(Token = "0x17000EA0")]
	protected XWidget_ContentIcon characterIcon
	{
		[Token(Token = "0x60072E8")]
		[Address(RVA = "0x15C7CDC", Offset = "0x15C7CDC", VA = "0x15C7CDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA1")]
	protected XWidget_ContentIcon itemIcon
	{
		[Token(Token = "0x60072E9")]
		[Address(RVA = "0x15C7EAC", Offset = "0x15C7EAC", VA = "0x15C7EAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60072E7")]
	[Address(RVA = "0x15C7CD4", Offset = "0x15C7CD4", VA = "0x15C7CD4")]
	public XWidget_CharacterAcqusition()
	{
	}

	[Token(Token = "0x60072EA")]
	[Address(RVA = "0x15C807C", Offset = "0x15C807C", VA = "0x15C807C", Slot = "18")]
	public virtual void Show(XModuleActor character, bool isEvolution, [Optional] Action onClickOk)
	{
	}

	[Token(Token = "0x60072EB")]
	[Address(RVA = "0x15C8254", Offset = "0x15C8254", VA = "0x15C8254", Slot = "19")]
	protected virtual void BuildUI(bool isEvolution, XModuleActor character)
	{
	}

	[Token(Token = "0x60072EC")]
	[Address(RVA = "0x15C8B64", Offset = "0x15C8B64", VA = "0x15C8B64")]
	public void OnOKButtonClick()
	{
	}

	[Token(Token = "0x60072ED")]
	[Address(RVA = "0x15C8BF0", Offset = "0x15C8BF0", VA = "0x15C8BF0", Slot = "20")]
	protected virtual bool CheckCost()
	{
		return default(bool);
	}

	[Token(Token = "0x60072EE")]
	[Address(RVA = "0x15C8F0C", Offset = "0x15C8F0C", VA = "0x15C8F0C")]
	private bool IsOwnedCharacter(string charUID)
	{
		return default(bool);
	}

	[Token(Token = "0x60072EF")]
	[Address(RVA = "0x15C8FD0", Offset = "0x15C8FD0", VA = "0x15C8FD0")]
	private void _003CShow_003Em__4A0()
	{
	}
}
