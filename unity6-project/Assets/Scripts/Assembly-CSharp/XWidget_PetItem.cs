using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000FCA")]
public class XWidget_PetItem : MonoBehaviour
{
	[Token(Token = "0x40053F3")]
	[FieldOffset(Offset = "0xC")]
	public int charID;

	[Token(Token = "0x40053F4")]
	[FieldOffset(Offset = "0x10")]
	public UI2DSprite sprChar;

	[Token(Token = "0x40053F5")]
	[FieldOffset(Offset = "0x14")]
	public UIBasicSprite sprSel;

	[Token(Token = "0x40053F6")]
	[FieldOffset(Offset = "0x18")]
	public UIBasicSprite sprLock;

	[Token(Token = "0x40053F7")]
	[FieldOffset(Offset = "0x1C")]
	public UIBasicSprite sprDisable;

	[Token(Token = "0x40053F8")]
	[FieldOffset(Offset = "0x20")]
	public Action<int> onClick;

	[Token(Token = "0x40053F9")]
	[FieldOffset(Offset = "0x24")]
	private Action onRefresh;

	[Token(Token = "0x40053FA")]
	[FieldOffset(Offset = "0x28")]
	private bool m_isOpen;

	[Token(Token = "0x40053FB")]
	[FieldOffset(Offset = "0x2C")]
	private XModuleActor m_character;

	[Token(Token = "0x40053FC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel lblExp;

	[Token(Token = "0x40053FD")]
	[FieldOffset(Offset = "0x34")]
	public UIProgressBar prbExp;

	[Token(Token = "0x60075A7")]
	[Address(RVA = "0x1317C74", Offset = "0x1317C74", VA = "0x1317C74")]
	public XWidget_PetItem()
	{
	}

	[Token(Token = "0x60075A8")]
	[Address(RVA = "0x1317C7C", Offset = "0x1317C7C", VA = "0x1317C7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60075A9")]
	[Address(RVA = "0x1317CDC", Offset = "0x1317CDC", VA = "0x1317CDC")]
	public void Build(XModuleActor character, Sprite spr, bool seleceted, bool disable, Action<int> onClick, Action onRefresh)
	{
	}

	[Token(Token = "0x60075AA")]
	[Address(RVA = "0x1317DD4", Offset = "0x1317DD4", VA = "0x1317DD4")]
	private void SetSoulDust(XModuleActor character)
	{
	}

	[Token(Token = "0x60075AB")]
	[Address(RVA = "0x1318450", Offset = "0x1318450", VA = "0x1318450")]
	public void Refresh(XModuleActor character)
	{
	}

	[Token(Token = "0x60075AC")]
	[Address(RVA = "0x13182B0", Offset = "0x13182B0", VA = "0x13182B0")]
	private void SetOpenInfo(out bool changed)
	{
		changed = default;
	}

	[Token(Token = "0x60075AD")]
	[Address(RVA = "0x1317C8C", Offset = "0x1317C8C", VA = "0x1317C8C")]
	private void RefreshOpenInfo()
	{
	}

	[Token(Token = "0x60075AE")]
	[Address(RVA = "0x13182A8", Offset = "0x13182A8", VA = "0x13182A8")]
	public void SetOnClick(Action<int> onClick)
	{
	}

	[Token(Token = "0x60075AF")]
	[Address(RVA = "0x1318454", Offset = "0x1318454", VA = "0x1318454")]
	public void OnClick()
	{
	}

	[Token(Token = "0x60075B0")]
	[Address(RVA = "0x1318264", Offset = "0x1318264", VA = "0x1318264")]
	public void Select(bool val)
	{
	}
}
