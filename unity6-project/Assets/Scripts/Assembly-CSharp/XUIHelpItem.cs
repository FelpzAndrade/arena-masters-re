using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2001022")]
public class XUIHelpItem : MonoBehaviour
{
	[Token(Token = "0x400567F")]
	[FieldOffset(Offset = "0xC")]
	public XWiget_GridBuilder gridBuilder;

	[Token(Token = "0x4005680")]
	[FieldOffset(Offset = "0x10")]
	public UILabel lblTitle;

	[Token(Token = "0x4005681")]
	[FieldOffset(Offset = "0x14")]
	public GameObject bgActive;

	[Token(Token = "0x4005682")]
	[FieldOffset(Offset = "0x18")]
	public UIButton btnThis;

	[Token(Token = "0x4005683")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject goSub;

	[Token(Token = "0x4005684")]
	[FieldOffset(Offset = "0x20")]
	public TweenScale tweenScale;

	[Token(Token = "0x4005685")]
	[FieldOffset(Offset = "0x24")]
	public UIPlayTween playTween;

	[Token(Token = "0x4005686")]
	[FieldOffset(Offset = "0x28")]
	private XHelpInfo m_helpInfo;

	[Token(Token = "0x4005687")]
	[FieldOffset(Offset = "0x2C")]
	private Action<XHelpInfo, int> m_clickAction;

	[Token(Token = "0x4005688")]
	[FieldOffset(Offset = "0x30")]
	private List<XHelpInfo> m_subList;

	[Token(Token = "0x4005689")]
	[FieldOffset(Offset = "0x34")]
	private int m_selectID;

	[Token(Token = "0x400568A")]
	[FieldOffset(Offset = "0x38")]
	private XUIHelpSubItem[] m_subItem;

	[Token(Token = "0x400568B")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_noneStart;

	[Token(Token = "0x400568C")]
	[FieldOffset(Offset = "0x40")]
	private int m_index;

	[Token(Token = "0x400568D")]
	[FieldOffset(Offset = "0x44")]
	private int currIndex;

	[Token(Token = "0x400568E")]
	[FieldOffset(Offset = "0x48")]
	private bool start;

	[Token(Token = "0x6007844")]
	[Address(RVA = "0x10895F8", Offset = "0x10895F8", VA = "0x10895F8")]
	public XUIHelpItem()
	{
	}

	[Token(Token = "0x6007845")]
	[Address(RVA = "0x1089600", Offset = "0x1089600", VA = "0x1089600")]
	public void Build(XHelpInfo helpInfo, Action<XHelpInfo, int> clickAction, int selectID, bool noneStart, int index)
	{
	}

	[Token(Token = "0x6007846")]
	[Address(RVA = "0x1089EA0", Offset = "0x1089EA0", VA = "0x1089EA0")]
	public void BuildActiveSprite(int id)
	{
	}

	[Token(Token = "0x6007847")]
	[Address(RVA = "0x1089FD4", Offset = "0x1089FD4", VA = "0x1089FD4")]
	private void ResetTween()
	{
	}

	[Token(Token = "0x6007848")]
	[Address(RVA = "0x108A150", Offset = "0x108A150", VA = "0x108A150")]
	private void SetTween()
	{
	}

	[Token(Token = "0x6007849")]
	[Address(RVA = "0x1089AFC", Offset = "0x1089AFC", VA = "0x1089AFC")]
	private void BuildCategory()
	{
	}

	[Token(Token = "0x600784A")]
	[Address(RVA = "0x1089808", Offset = "0x1089808", VA = "0x1089808")]
	private void BuildSubCategory()
	{
	}

	[Token(Token = "0x600784B")]
	[Address(RVA = "0x108A57C", Offset = "0x108A57C", VA = "0x108A57C")]
	public void OnClickThisCategory()
	{
	}

	[Token(Token = "0x600784C")]
	[Address(RVA = "0x1089C9C", Offset = "0x1089C9C", VA = "0x1089C9C")]
	public void RefreshCategory()
	{
	}

	[Token(Token = "0x600784D")]
	[Address(RVA = "0x108A5D0", Offset = "0x108A5D0", VA = "0x108A5D0")]
	public void SetNotLink()
	{
	}

	[Token(Token = "0x600784E")]
	[Address(RVA = "0x108A7CC", Offset = "0x108A7CC", VA = "0x108A7CC")]
	public void SetSubLinkSprite(int id)
	{
	}

	[Token(Token = "0x600784F")]
	[Address(RVA = "0x108A6D0", Offset = "0x108A6D0", VA = "0x108A6D0")]
	public void SetMainLinkSprite(int groupId)
	{
	}

	[Token(Token = "0x6007850")]
	[Address(RVA = "0x108A8AC", Offset = "0x108A8AC", VA = "0x108A8AC")]
	public void SetGridHide()
	{
	}

	[Token(Token = "0x6007851")]
	[Address(RVA = "0x108A8DC", Offset = "0x108A8DC", VA = "0x108A8DC")]
	public void RefreshLink(int nID)
	{
	}

	[Token(Token = "0x6007852")]
	[Address(RVA = "0x108A8E4", Offset = "0x108A8E4", VA = "0x108A8E4")]
	public int GetHelpID()
	{
		return default(int);
	}

	[Token(Token = "0x6007853")]
	[Address(RVA = "0x108A908", Offset = "0x108A908", VA = "0x108A908")]
	public XUIHelpSubItem FindUIHelpSubItem(HelpLink helpLink)
	{
		return null;
	}

	[Token(Token = "0x6007854")]
	[Address(RVA = "0x108A990", Offset = "0x108A990", VA = "0x108A990")]
	private void _003CBuildCategory_003Em__502()
	{
	}
}
