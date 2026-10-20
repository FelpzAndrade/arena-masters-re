using System;
using CS;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F61")]
public class XUITitleItem : MonoBehaviour
{
	[Token(Token = "0x40050CA")]
	[FieldOffset(Offset = "0xC")]
	public GameObject goRoot;

	[Token(Token = "0x40050CB")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprIcon;

	[Token(Token = "0x40050CC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject sprSelect;

	[Token(Token = "0x40050CD")]
	[FieldOffset(Offset = "0x18")]
	public GameObject sprLock;

	[Token(Token = "0x40050CE")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject sprUnlock;

	[Token(Token = "0x40050CF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject sprCheck;

	[Token(Token = "0x40050D0")]
	[FieldOffset(Offset = "0x24")]
	public TitleInfo m_titleInfo;

	[Token(Token = "0x40050D1")]
	[FieldOffset(Offset = "0x28")]
	private Action<XUITitleItem> m_OnSelect;

	[Token(Token = "0x6007248")]
	[Address(RVA = "0x193824C", Offset = "0x193824C", VA = "0x193824C")]
	public XUITitleItem()
	{
	}

	[Token(Token = "0x6007249")]
	[Address(RVA = "0x1938254", Offset = "0x1938254", VA = "0x1938254")]
	public void ShowOnlyBG()
	{
	}

	[Token(Token = "0x600724A")]
	[Address(RVA = "0x1938290", Offset = "0x1938290", VA = "0x1938290")]
	public void Build(TitleInfo titleInfo, Action<XUITitleItem> onSelect, bool bOpened, bool bUnlockable, bool bSelected, bool bChecked)
	{
	}

	[Token(Token = "0x600724B")]
	[Address(RVA = "0x19388F4", Offset = "0x19388F4", VA = "0x19388F4")]
	public void Refresh(bool bOpened, bool bUnlockable, bool bSelected, bool bChecked)
	{
	}

	[Token(Token = "0x600724C")]
	[Address(RVA = "0x1938734", Offset = "0x1938734", VA = "0x1938734")]
	public void SetSelected(bool state)
	{
	}

	[Token(Token = "0x600724D")]
	[Address(RVA = "0x1938814", Offset = "0x1938814", VA = "0x1938814")]
	public void SetChecked(bool state)
	{
	}

	[Token(Token = "0x600724E")]
	[Address(RVA = "0x1938654", Offset = "0x1938654", VA = "0x1938654")]
	public void SetUnlockable(bool state)
	{
	}

	[Token(Token = "0x600724F")]
	[Address(RVA = "0x1938574", Offset = "0x1938574", VA = "0x1938574")]
	public void SetOpened(bool state)
	{
	}

	[Token(Token = "0x6007250")]
	[Address(RVA = "0x1938934", Offset = "0x1938934", VA = "0x1938934")]
	public void OnClick()
	{
	}
}
