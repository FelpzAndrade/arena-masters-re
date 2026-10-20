using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F12")]
public class XListView_CharInven : MonoBehaviour
{
	[Token(Token = "0x2000F13")]
	public enum SortingRule
	{
		[Token(Token = "0x4004FD0")]
		None = 0,
		[Token(Token = "0x4004FD1")]
		Level = 1,
		[Token(Token = "0x4004FD2")]
		Grade = 2,
		[Token(Token = "0x4004FD3")]
		Name = 3
	}

	[Token(Token = "0x4004FC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public SortingRule sortRule;

	[Token(Token = "0x4004FC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool isSortOrderAscending;

	[Token(Token = "0x4004FC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	protected Action<object> m_actionItemClick;

	[Token(Token = "0x4004FC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Action<object> m_actionDragStart;

	[Token(Token = "0x4004FC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	protected Action m_actionDragFail;

	[Token(Token = "0x4004FC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected List<XModuleActor> m_infoList;

	[Token(Token = "0x4004FCA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected List<XModuleActor> m_ownActorList;

	[Token(Token = "0x4004FCB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected XCharacterInventory m_charInven;

	[Token(Token = "0x4004FCC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x4004FCD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected XWidget_CharacterCard[] charItems;

	[Token(Token = "0x4004FCE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public UIScrollView scrollView;

	[Token(Token = "0x17000E3E")]
	protected int InfoListCount
	{
		[Token(Token = "0x6007068")]
		[Address(RVA = "0x1E08734", Offset = "0x1E08734", VA = "0x1E08734")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6007066")]
	[Address(RVA = "0x1E0867C", Offset = "0x1E0867C", VA = "0x1E0867C")]
	public XListView_CharInven()
	{
	}

	[Token(Token = "0x6007067")]
	[Address(RVA = "0x1E08730", Offset = "0x1E08730", VA = "0x1E08730")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007069")]
	[Address(RVA = "0x1E087CC", Offset = "0x1E087CC", VA = "0x1E087CC", Slot = "4")]
	protected virtual void BuildList()
	{
	}

	[Token(Token = "0x600706A")]
	[Address(RVA = "0x1E08884", Offset = "0x1E08884", VA = "0x1E08884")]
	private void CalculatorCharacterOpenTime()
	{
	}

	[Token(Token = "0x600706B")]
	[Address(RVA = "0x1E09214", Offset = "0x1E09214", VA = "0x1E09214")]
	private void BuildCharacterCard(Action<object> onClick, Action<object> onDragStart, Action onDragFail)
	{
	}

	[Token(Token = "0x600706C")]
	[Address(RVA = "0x1E0976C", Offset = "0x1E0976C", VA = "0x1E0976C")]
	private void RefreshCharacterOpenTime()
	{
	}

	[Token(Token = "0x600706D")]
	[Address(RVA = "0x1E095DC", Offset = "0x1E095DC", VA = "0x1E095DC")]
	private bool IsSelected(XModuleActor actor)
	{
		return default(bool);
	}

	[Token(Token = "0x600706E")]
	[Address(RVA = "0x1E09B60", Offset = "0x1E09B60", VA = "0x1E09B60")]
	public void Init(XCharacterInventory charInven, Action<object> actionItemClick, [Optional] Action<object> actionDragStart, [Optional] Action actionDragFail)
	{
	}

	[Token(Token = "0x600706F")]
	[Address(RVA = "0x1E09938", Offset = "0x1E09938", VA = "0x1E09938")]
	public void RefreshCharInventory()
	{
	}
}
